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



    }
}
