using Microsoft.Data.Sqlite;
using Socios_CamaraC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;

public static class Backup
{
    public static void ExportarTabla(string nombreTabla, string carpetaFecha)
    {
        using var conn = ConexionBD.AbrirConexion();
        using var cmd = conn.CreateCommand();

        cmd.CommandText = $"SELECT * FROM {nombreTabla};";
        using var reader = cmd.ExecuteReader();

        string rutaArchivo = Path.Combine(
            carpetaFecha,
            $"{nombreTabla}.sql");

        using var writer = new StreamWriter(rutaArchivo, false);

        // Obtener columnas dinámicamente
        var columnas = new List<string>();
        for (int i = 0; i < reader.FieldCount; i++)
            columnas.Add(reader.GetName(i));

        string columnasTexto = string.Join(", ", columnas);

        while (reader.Read())
        {
            var valores = new List<string>();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.IsDBNull(i))
                {
                    valores.Add("NULL");
                    continue;
                }

                object valor = reader.GetValue(i);

                switch (valor)
                {
                    case string s:
                        valores.Add($"'{EscaparTexto(s)}'");
                        break;

                    case DateTime dt:
                        valores.Add($"'{dt:yyyy-MM-dd HH:mm:ss}'");
                        break;

                    case bool b:
                        valores.Add(b ? "1" : "0");
                        break;

                    case double or float or decimal:
                        valores.Add(Convert.ToString(valor, CultureInfo.InvariantCulture));
                        break;

                    default:
                        valores.Add(valor.ToString());
                        break;
                }
            }

            string valoresTexto = string.Join(", ", valores);

            writer.WriteLine(
                $"INSERT INTO {nombreTabla} ({columnasTexto}) VALUES ({valoresTexto});");
        }
    }
    private static string EscaparTexto(string texto)
    {
        return texto.Replace("'", "''");
    }
    //Restablecer.sql
    public static void GenerarRestablecerSql(string carpetaFecha)
    {
        if (!Directory.Exists(carpetaFecha))
            Directory.CreateDirectory(carpetaFecha);

        string rutaArchivo = Path.Combine(carpetaFecha, "Restablecer.sql");

        using var writer = new StreamWriter(rutaArchivo, false);

        writer.WriteLine("-- Restablecer base de datos");
        writer.WriteLine("PRAGMA foreign_keys = OFF;");
        writer.WriteLine("BEGIN TRANSACTION;");

        // Lista de archivos .sql en orden correcto según FK
        string[] archivosOrdenados = new[]
        {
        "ANUAL.sql",
        "SOCIO.sql",
        "CUOTA.sql",
        "CUOTA_SOCIO.sql",
        "ANUAL_SOCIO.sql"
    };

        foreach (var archivo in archivosOrdenados)
        {
            string rutaArchivoTabla = Path.Combine(carpetaFecha, archivo);
            if (File.Exists(rutaArchivoTabla))
            {
                writer.WriteLine($"\n-- Insertando datos desde {archivo}");
                string[] lineas = File.ReadAllLines(rutaArchivoTabla);
                foreach (var linea in lineas)
                {
                    writer.WriteLine(linea);
                }
            }
        }

        writer.WriteLine("COMMIT;");
        writer.WriteLine("PRAGMA foreign_keys = ON;");
    }
    //BORRAR DATOS [PELIGRO!]
    public static void BorrarDatosEnTablas()
    {
        using var conn = ConexionBD.AbrirConexion();
        using var cmd = conn.CreateCommand();

        cmd.CommandText = @"
        PRAGMA foreign_keys = OFF;
        BEGIN TRANSACTION;

        DELETE FROM CUOTA_SOCIO;
        DELETE FROM ANUAL_SOCIO;
        DELETE FROM CUOTA;
        DELETE FROM SOCIO;
        DELETE FROM ANUAL;

        COMMIT;
        PRAGMA foreign_keys = ON;
    ";

        cmd.ExecuteNonQuery();
    }
    //Restablecer a partir de Restaurar.sql
    public static void EjecutarUltimoRestablecer()
    {
        string baseDir = AppDomain.CurrentDomain.BaseDirectory;
        string carpetaBackup = Path.Combine(baseDir, "Backup");

        if (!Directory.Exists(carpetaBackup))
            throw new Exception("No existe la carpeta Backup.");

        var directorios = new DirectoryInfo(carpetaBackup)
            .GetDirectories()
            .OrderByDescending(d => d.Name)
            .ToList();

        if (directorios.Count == 0)
            throw new Exception("No hay backups disponibles.");

        string carpetaMasReciente = directorios.First().FullName;
        string rutaRestablecer = Path.Combine(carpetaMasReciente, "Restablecer.sql");

        if (!File.Exists(rutaRestablecer))
            throw new Exception("No se encontró Restablecer.sql en el último backup.");

        string scriptSql = File.ReadAllText(rutaRestablecer);

        using var conn = ConexionBD.AbrirConexion();
        using var cmd = conn.CreateCommand();

        cmd.CommandText = scriptSql;
        cmd.ExecuteNonQuery();

        // Verificar integridad
        cmd.CommandText = "PRAGMA integrity_check;";
        var resultado = cmd.ExecuteScalar()?.ToString();

        if (resultado != "ok")
            throw new Exception("La base restaurada tiene problemas de integridad.");
    }

    //Carpeta BACKUP
    public static string CrearCarpetaBackup()
    {
        string baseDir = AppDomain.CurrentDomain.BaseDirectory;

        string carpetaBackup = Path.Combine(baseDir, "Backup");
        if (!Directory.Exists(carpetaBackup))
            Directory.CreateDirectory(carpetaBackup);

        string carpetaFecha = Path.Combine(
            carpetaBackup,
            DateTime.Now.ToString("yy-MM-dd_HH-mm-ss"));

        if (!Directory.Exists(carpetaFecha))
            Directory.CreateDirectory(carpetaFecha);

        return carpetaFecha;
    }
    public static void AbrirCarpetaBackup()
    {
        // Obtener la ruta de la carpeta Backup
        string carpetaBackup = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backup");

        // Verificar si la carpeta existe
        if (Directory.Exists(carpetaBackup))
        {
            // Abrir la carpeta en el explorador de archivos
            Process.Start("explorer.exe", carpetaBackup);
        }
        else
        {
            // Si la carpeta no existe, puedes lanzar un mensaje o crearla
            MessageBox.Show("La carpeta de respaldo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}
