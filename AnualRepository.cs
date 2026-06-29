using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Socios_CamaraC
{
    internal class AnualRepository
    {
       /* public static void Crear(int anio)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var transaction = conn.BeginTransaction();
            Crear(conn, transaction, anio);
        }*/
        public static void Crear(
            SqliteConnection conn, SqliteTransaction transaction, int anio)
        {
            using var cmd = conn.CreateCommand();
            cmd.Transaction = transaction;

            cmd.CommandText = @"
                INSERT INTO ANUAL (Anio)
                VALUES (@Anio);";
            cmd.Parameters.AddWithValue("@Anio", anio);

            cmd.ExecuteNonQuery();
        }
        public static bool Existe(int anio)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var transaction = conn.BeginTransaction();
            return (Existe(conn, transaction, anio));
        }
        public static bool Existe(
            SqliteConnection conn, SqliteTransaction transaction, int anio)
        {
            using var cmd = conn.CreateCommand();
            cmd.Transaction = transaction;
            cmd.CommandText = @"
                SELECT 1
                FROM ANUAL
                WHERE Anio = @Anio
                LIMIT 1;";
            cmd.Parameters.AddWithValue("@Anio", anio);

            var respuesta = cmd.ExecuteScalar();
            return (respuesta != null);
        }
        public static List<Anual> Listar()
        {
            var listaAnual = new List<Anual>();
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT Anio
                FROM ANUAL
                ORDER BY Anio DESC;";
            using var respuesta = cmd.ExecuteReader();
            while (respuesta.Read())
            {
                var anual = new Anual(
                    respuesta.GetInt32(0)
                    );
                listaAnual.Add(anual);
            }
            return listaAnual;
        }
        public static void Borrar(int anio)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                DELETE FROM ANUAL
                WHERE Anio = @Anio;";
            cmd.Parameters.AddWithValue("@Anio", anio);

            cmd.ExecuteNonQuery();
        }


    }
}