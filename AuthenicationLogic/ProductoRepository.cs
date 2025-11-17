#region Using
using CommonEntities.DTO;
using CommonEntities.Entidades;
using CommonEntities.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks; 
#endregion

namespace AuthenicationLogic
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly string _connectionString;

        public ProductoRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("SqlServer") 
                ?? throw new ArgumentNullException("Connection string 'SqlServer' not found.");
        }

        public async Task<bool> ActualizarProducto(int id, AgregarProductoDto productoActualizado)
        {
            var connection = new SqlConnection(_connectionString);
            const string sql = @"
                UPDATE Productos
                SET Nombre=@Nombre, Precio=@Precio, Stock=@Stock
                WHERE Id=@Id;";
            try
            {
                connection.Open();
                using var cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@Nombre", SqlDbType.NVarChar, 100){ Value = productoActualizado.Nombre },
                    new SqlParameter("@Precio", SqlDbType.Decimal){ Precision=10, Scale=2, Value = productoActualizado.Precio },
                    new SqlParameter("@Stock", SqlDbType.Int){ Value = productoActualizado.Stock },
                    new SqlParameter("@Id", SqlDbType.Int){ Value = id }
                });

                var rows = await cmd.ExecuteNonQueryAsync();
                return rows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar producto.", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public async Task<bool> BorrarProducto(int id)
        {
            var connection = new SqlConnection(_connectionString);
            const string sql = @"DELETE FROM Productos WHERE Id=@Id;";
            try
            {
                connection.Open();
                using var cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });

                var rows = await cmd.ExecuteNonQueryAsync();
                return rows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar producto.", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public async Task<int> CrearProducto(AgregarProductoDto nuevoProducto)
        {
            var connection = new SqlConnection(_connectionString);
            const string sql = @"
                                INSERT INTO Productos (Nombre, Precio, Stock)
                                VALUES (@Nombre, @Precio, @Stock);
                                SELECT CAST(SCOPE_IDENTITY() AS INT);";
            try
            {
                connection.Open();
                using var cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@Nombre", SqlDbType.NVarChar, 100){ Value = nuevoProducto.Nombre },
                    new SqlParameter("@Precio", SqlDbType.Decimal){ Precision=10, Scale=2, Value = nuevoProducto.Precio },
                    new SqlParameter("@Stock", SqlDbType.Int){ Value = nuevoProducto.Stock }
                });

                var id = (int)await cmd.ExecuteScalarAsync();
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear producto.", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public async Task<IEnumerable<Producto>> GetAllProductosAsync()
        {
            List<Producto> productos = [];
            string query = "SELECT Id, Nombre, Precio, Stock FROM Productos";
            var connection = new SqlConnection(_connectionString);
            try
            {
                connection.Open();
                using var command = new SqlCommand(query, connection);
                using var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var prod = new Producto
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        Stock = Convert.ToInt32(reader["Stock"])
                    };
                    productos.Add(prod);
                }
                return productos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los productos.", ex);
            }
            finally
            {
                if(connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public async Task<Producto> GetProductoPorId(int id)
        {
            var connection = new SqlConnection(_connectionString);
            try
            {
                connection.Open();
                const string sql = @"SELECT Id, Nombre, Precio, Stock FROM Productos WHERE Id = @Id;";
                using var command = new SqlCommand(sql, connection);
                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });

                using var reader = await command.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    return new Producto
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        Stock = Convert.ToInt32(reader["Stock"])
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el producto {id}.", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            return null;
        }
    }
}
