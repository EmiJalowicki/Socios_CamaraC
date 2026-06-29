using System;
using System.Collections.Generic;
using System.Text;

namespace Socios_CamaraC
{
    internal class CategoriaRepository
    {
        public static Categoria? ObtenerPorId(int idCategoria)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT IdCategoria, Descripcion, ImporteBase
                FROM CATEGORIA
                WHERE IdCategoria = @IdCategoria;";
            cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);

            using var respuesta = cmd.ExecuteReader();
            if (!respuesta.Read())
            {
                return null;
            }
            return new Categoria
            {
                IdCategoria = respuesta.GetInt32(0),
                Descripcion = respuesta.GetString(1),
                ImporteBase = Convert.ToDecimal(respuesta.GetDouble(2))
            };
        }

        public static List<Categoria> Listar()
        {
            var listaCategoria = new List<Categoria>();
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT IdCategoria, Descripcion, ImporteBase
                FROM CATEGORIA
                ORDER BY IdCategoria;";
            using var respuesta = cmd.ExecuteReader();
            while (respuesta.Read())
            {
                listaCategoria.Add(new Categoria
                {
                    IdCategoria = respuesta.GetInt32(0),
                    Descripcion = respuesta.GetString(1)
                });
            }
            return listaCategoria;
        }
        public static bool Existe(int idCategoria)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT 1
                FROM CATEGORIA
                WHERE IdCategoria = @IdCategoria;";
            cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
            using var respuesta = cmd.ExecuteReader();
            return respuesta.Read();
        }
        public static void ActualizarImporteBase(int idCategoria, decimal importe)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                UPDATE CATEGORIA
                SET ImporteBase = @ImporteBase
                WHERE IdCategoria = @CategoriaId;";
            cmd.Parameters.AddWithValue("@ImporteBase", importe);
            cmd.Parameters.AddWithValue("@CategoriaId", idCategoria);
            cmd.ExecuteNonQuery();
        }

    }
}
