using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.Odbc;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace WSReposteriaCRUDEnC
{
    /// <summary>
    /// Descripción breve de WSReposteriaCRUDEnC
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    

    
    public class WSReposteriaCRUDEnC : System.Web.Services.WebService
    {
        public string Get_ConnectionString()
        {
            var SQLServer_Connection_String = @"Data Source=LAPTOP-4CUK2A7H\SQLEXPRESS; Initial Catalog=Reposteria; User ID= sa; Password=aaa";
            return SQLServer_Connection_String;
        }

        [WebMethod]
        public string InsertProducto( String nombre, float precio, int cantidad, int idInsumo)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "INSERT INTO [dbo].[producto] ([nombre],[precio],[cantidad],[idInsumo]) VALUES ('" + nombre + "'," + precio + "," + cantidad + "," + idInsumo + ")";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Insercciòn de Producto completada";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        [WebMethod]
        public string updateProducto(int idproducto, String nombre, float precio, int cantidad, int idInsumo)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "UPDATE [dbo].[producto] SET [nombre] ='" + nombre + "' ,[precio] =" + precio + " ,[cantidad] = " + cantidad + ",[idInsumo] = " + idInsumo + " WHERE [idproducto] =" + idproducto + "";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Modificaciòn De producto completada";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            
        }

        [WebMethod]
        public string deleteProducto(int idproducto)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "DELETE FROM [dbo].[producto]" + "WHERE [idproducto] =" + idproducto + "";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Eliminaciòn De producto completada";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            
        }

        [WebMethod]
        public string InsertInsumo(String nombre, int cantidad, float monto)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "INSERT INTO [dbo].[insumo] ([nombre],[cantidad],[monto]) VALUES ('" + nombre + "'," + cantidad + "," + monto + ")";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Insercciòn de insumo completada";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        [WebMethod]
        public string updateInsumo(int idinsumo,String nombre, int cantidad, float monto)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "UPDATE [dbo].[insumo] SET [nombre] ='" + nombre + "' ,[cantidad] = " + cantidad + ",[monto] = " + monto + " WHERE [idinsumo] =" + idinsumo + "";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Modificaciòn De insumo completada";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            
        }

        [WebMethod]
        public string deleteInsumo(int idinsumo)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "DELETE FROM [dbo].[insumo]" + "WHERE [idinsumo] =" + idinsumo + "";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Eliminaciòn De insumo completada";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            
        }

        [WebMethod]
        public string InsertVenta(DateTime fecha, DateTime hora, String descripcion, float total, int idProducto)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "INSERT INTO [dbo].[venta] ([fecha],[hora],[descripcion],[total], [idProducto]) VALUES ('" + fecha.ToString("yyyy-MM-dd") + "','" + hora.ToString("hh\\:mm\\:ss") + "','" + descripcion + "'," + total + "," + idProducto + ")";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Venta registrada con Éxito";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        [WebMethod]
        public string updateVenta(DateTime fecha, DateTime hora, String descripcion, float total, int idProducto, int idventa)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "UPDATE [dbo].[venta] SET [fecha] ='" + fecha.ToString("yyyy-MM-dd") + "' ,[hora] = '" + hora.ToString("hh\\:mm\\:ss") + "' ,[descripcion] = '" + descripcion + "',[total] = " + total + ",[idProducto] = " + idProducto + " WHERE [idventa] =" + idventa + "";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Venta actualizada con éxito";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }

        [WebMethod]
        public string deleteVenta(int idventa)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "DELETE FROM [dbo].[venta]" + " WHERE [idventa] =" + idventa + "";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Venta eliminada con éxito";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }

        [WebMethod]
        public string insertEmpleado(string nombre, string paterno, string materno, string telefono, int idVenta)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "INSERT INTO [dbo].[empleado]([nombre],[paterno],[materno],[telefono],[idVenta])VALUES('" + nombre + "','" + paterno + "','" + materno + "','" + telefono + "', " + idVenta + ")";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Registro insertado con éxito";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }


        [WebMethod]
        public string updateEmpleado(int idEmpleado, string nombre, string paterno, string materno, string telefono, int idVenta)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "UPDATE [dbo].[empleado]SET [Nombre] = '" + nombre + "',[Paterno] = '" + paterno + "',[Materno] = '" + materno + "',[telefono] = '" + telefono + "',[idVenta] = " + idVenta + " WHERE [idEmpleado]=" + idEmpleado + "";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Registro modificado con éxito";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }


        [WebMethod]
        public string deleteEmpleado(int idEmpleado)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "DELETE FROM [dbo].[empleado] WHERE [idEmpleado]=" + idEmpleado + "";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Registro eliminado con éxito";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }

        [WebMethod]
        public string insertProveedores(string nombre, string tel, string loc, string calle, int cp)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "INSERT INTO [dbo].[provedor] ([nombre],[telefono],[localidad],[calle],[codigoPostal]) VALUES('" +nombre + "', '" + tel + "', '" + loc + "','" + calle + "'," + cp + ")";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Registro insertado con éxito";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }


        [WebMethod]
        public string updateProveedores(int id,string nombre, string tel, string loc, string calle, int cp)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "UPDATE [dbo].[provedor]SET [nombre] = '" + nombre + "',[telefono] = '" + tel + "',[localidad] = '" + loc + "',[calle] = '" + calle + "',[codigoPostal] = " + cp + " WHERE [idProveedor]=" + id + "";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Registro modificado con éxito";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }


        [WebMethod]
        public string deleteProveedores(int id)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                SqlConnection conexion = new SqlConnection(Get_ConnectionString());
                conexion.Open();
                sql = "DELETE FROM [dbo].[provedor] WHERE [idProveedor]=" + id + "";
                SqlCommand mycmd = new SqlCommand(sql, conexion);
                mycmd.ExecuteNonQuery();
                conexion.Close();
                return "Registro eliminado con éxito";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }



    }
}
