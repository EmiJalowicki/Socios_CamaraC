using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;

namespace Socios_CamaraC
{
    internal class AnualSocioRepository
    {
        public static void Crear(
            int numSocio, int anio,
            DateTime periodoInicial, DateTime fechaRegistro,
            decimal importeTotal, decimal importePorCuota)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var transaction = conn.BeginTransaction();
            Crear(conn, transaction,
                numSocio, anio,
                periodoInicial, fechaRegistro,
                importeTotal, importePorCuota);
            transaction.Commit();
        }
        public static void Crear(
            SqliteConnection conn, SqliteTransaction transaction,
            int numSocio, int anio,
            DateTime periodoInicial, DateTime fechaRegistro,
            decimal importeTotal, decimal importePorCuota)
        {
            using var cmd = conn.CreateCommand();
            cmd.Transaction = transaction;

            cmd.CommandText = @"
                INSERT INTO ANUAL_SOCIO
                    (NumSocio, Anio, PeriodoInicio, FechaRegistro, 
                    ImporteTotal, ImportePorCuota)
                VALUES
                    (@NumSocio, @Anio, @PeriodoInicio, @FechaRegistro, 
                    @ImporteTotal, @ImportePorCuota);";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);
            cmd.Parameters.AddWithValue("@Anio", anio);
            cmd.Parameters.AddWithValue("@PeriodoInicio", 
                periodoInicial.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@FechaRegistro", 
                fechaRegistro.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@ImporteTotal", importeTotal);
            cmd.Parameters.AddWithValue("@ImportePorCuota", importePorCuota);

            cmd.ExecuteNonQuery();
        }
        public static bool Existe(int numSocio, int anio)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var transaction = conn.BeginTransaction();
            return (Existe(conn, transaction, numSocio, anio));
        }
        public static bool Existe(SqliteConnection conn, SqliteTransaction transaction,
            int numSocio, int anio)
        {
            using var cmd = conn.CreateCommand();
            cmd.Transaction = transaction;

            cmd.CommandText = @"
                SELECT 1
                FROM ANUAL_SOCIO
                WHERE NumSocio = @NumSocio
                    AND Anio = @Anio
                LIMIT 1;";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);
            cmd.Parameters.AddWithValue("@Anio", anio);

            var respuesta = cmd.ExecuteScalar();
            return (respuesta != null);
        }
        public static List<AnualSocio> ListarAnualSocio(int numSocio)
        {
            var listaAnualesSocio = new List<AnualSocio>();
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT
                    NumSocio, Anio, PeriodoInicio, FechaRegistro, 
                    ImporteTotal, ImportePorCuota
                FROM ANUAL_SOCIO
                WHERE NumSocio = @NumSocio
                ORDER BY Anio DESC;";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);

            var respuesta = cmd.ExecuteReader();
            while (respuesta.Read())
            {
                var anualSocio = Mapear(respuesta);
                listaAnualesSocio.Add(anualSocio);
            }
            return (listaAnualesSocio);
        }
        public static AnualSocio? ObtenerAnualSocio(int numSocio, int anio)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT
                    NumSocio, Anio, PeriodoInicio, FechaRegistro, 
                    ImporteTotal, ImportePorCuota
                FROM ANUAL_SOCIO
                WHERE NumSocio = @NumSocio
                    AND Anio = @Anio;";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);
            cmd.Parameters.AddWithValue("@Anio", anio);
            var respuesta = cmd.ExecuteReader();

            if (!respuesta.Read()) return null;

            return Mapear(respuesta);
        }
        public static void Borrar(int numSocio, int anio)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                DELETE FROM ANUAL_SOCIO
                WHERE NumSocio = @NumSocio
                    AND Anio = @Anio;";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);
            cmd.Parameters.AddWithValue("@Anio", anio);

            cmd.ExecuteNonQuery();
        }

        //Por utilidad:

        //Mapeo de AnualSocio
        private static AnualSocio Mapear(SqliteDataReader r)
        {
            return new AnualSocio(
                r.GetInt32(0),
                r.GetInt32(1),
                DateTime.Parse(r.GetString(2)),
                DateTime.Parse(r.GetString(3)),
                Convert.ToDecimal(r.GetDouble(4)),
                Convert.ToDecimal(r.GetDouble(5))
            );
        }
    }
}
