using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Jacaton.BBDD
{
    internal class Conexion
    {
        private static readonly string url = "Server=145.14.151.1;" +
                    "Database=u812167471_Libreria_3;" +
                    "User ID=u812167471_Libreria_3;" +
                    "Port=3306;" +
                    "Password=Libreria_3;" +
                    "Convert Zero Datetime=True;";

        public static bool Acceder(string user, string pass)
        {
            string consulta = "SELECT * FROM vendedores WHERE usuario = ?user AND contraseña = ?pass";
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?user", user);
                comando.Parameters.AddWithValue("?pass", pass);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void ConsultarResumenVentas(Label label4, Label label5, Label label6)
        {
            MySqlConnection conn = new MySqlConnection(url);
            try
            {
                conn.Open();

                // Usando la consulta proporcionada
                string consulta = "SELECT COUNT(l.idLibro) AS LIBROS, " +
                        "SUM(l.stock) AS VOLUMEN, " +
                        "(SELECT COUNT(*) FROM ventas_online) + (SELECT COUNT(*) FROM ventas_tienda) AS TOTAL_VENTAS " +
                        "FROM libros l";

                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Actualizamos directamente los labels con los valores
                    label4.Text = reader.GetInt32("LIBROS").ToString();
                    label5.Text = reader.GetInt32("VOLUMEN").ToString();
                    label6.Text = reader.GetInt32("TOTAL_VENTAS").ToString();
                }
                else
                {
                    // No hay datos, establecer valores a cero
                    label4.Text = "0";
                    label5.Text = "0";
                    label6.Text = "0";
                }

                reader.Close();
                cmd.Dispose();
            }
            catch (MySqlException ex)
            {
                // Manejar la excepción
                Console.WriteLine("Error en la consulta: " + ex.Message);
                // O usar MessageBox para mostrar el error
                MessageBox.Show("Error en la consulta: " + ex.Message);

                // En caso de error, ponemos valores por defecto
                label4.Text = "0";
                label5.Text = "0";
                label6.Text = "0";
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable TablaTienda()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT \n" +
                "    a.nombre AS AUTOR, \n" +
                "    l.titulo AS TITULO, \n" +
                "    COUNT(vt.idVenta) AS VENTAS\n" +
                "FROM autores a\n" +
                "JOIN libros l ON a.idAutor = l.idAutor\n" +
                "JOIN ventas_tienda vt ON l.idLibro = vt.idLibro\n" +
                "GROUP BY a.nombre, l.titulo\n" +
                "ORDER BY VENTAS DESC\n" +
                "LIMIT 3;\n";

            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static DataTable TablaOnline()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT \n" +
                "    a.nombre AS AUTOR, \n" +
                "    l.titulo AS TITULO, \n" +
                "    COUNT(vo.idVenta) AS VENTAS\n" +
                "FROM autores a\n" +
                "JOIN libros l ON a.idAutor = l.idAutor\n" +
                "JOIN ventas_online vo ON l.idLibro = vo.idLibro\n" +
                "GROUP BY a.nombre, l.titulo\n" +
                "ORDER BY VENTAS DESC\n" +
                "LIMIT 3;\n";

            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static DataTable InformeUno()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT e.nombre AS EDITORIAL, COUNT(l.idLibro) AS LIBROS " +
                "FROM editoriales e " +
                "JOIN libros l ON e.idEditorial = l.idEditorial " +
                "GROUP BY e.idEditorial " +
                "ORDER BY LIBROS DESC " +
                "LIMIT 10;";

            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static DataTable InformeDos1()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT v.nombre AS VENDEDOR, SUM(vt.precio) AS FACTURACION " +
                "FROM vendedores v " +
                "JOIN ventas_tienda vt ON v.codVendedor = vt.codVendedor " +
                "JOIN estados e ON v.idEstado = e.idEstado " +
                "WHERE e.estado = 'Activo' " +
                "GROUP BY v.codVendedor " +
                "ORDER BY FACTURACION DESC;";

            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public static DataTable InformeDos2()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT p.nombre AS PLATAFORMA, SUM(vo.precio) AS FACTURACION " +
                "FROM plataformas p " +
                "JOIN ventas_online vo ON p.idPlataforma = vo.idPlataforma " +
                "GROUP BY p.idPlataforma " +
                "ORDER BY FACTURACION DESC;";

            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static DataTable InformeTres(int seccion, out int totalVolumenes)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("UBICACION", typeof(string));
            dt.Columns.Add("VOLUMENES", typeof(int));

            totalVolumenes = 0; // Inicializamos el contador

            string consulta = "SELECT u.ubicacion AS UBICACION, COUNT(l.idLibro) AS VOLUMENES " +
                    "FROM ubicacion u " +
                    "JOIN libros l ON u.ubicacion = l.codUbicacion " +
                    "WHERE u.ubicacion LIKE '" + seccion + "%' " +
                    "GROUP BY u.ubicacion " +
                    "ORDER BY u.ubicacion ASC;";

            MySqlConnection conn = new MySqlConnection(url);
            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ubicacion = reader.GetString("UBICACION");
                        int volumenes = reader.GetInt32("VOLUMENES");


                        totalVolumenes += volumenes;

                        dt.Rows.Add(ubicacion, volumenes);
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static DataTable InformeCuatro()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT le.ccaa AS 'COMUNIDAD AUTÓNOMA', COUNT(l.idlibro) AS LIBRO\n" +
                "FROM lugar_edicion le JOIN libros l\n" +
                "ON le.idLugar = l.idLugar\n" +
                "GROUP BY le.ccaa\n" +
                "ORDER BY LIBRO DESC\n" +
                "LIMIT 10;";

            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static DataTable InformeCinco()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT le.lugar AS CIUDAD, COUNT(l.idlibro) AS LIBRO\n" +
                "FROM lugar_edicion le JOIN libros l\n" +
                "ON le.idLugar = l.idLugar\n" +
                "GROUP BY le.lugar\n" +
                "ORDER BY LIBRO DESC\n" +
                "LIMIT 5;";

            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

    }
}
