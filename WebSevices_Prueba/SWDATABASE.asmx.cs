using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WebSevices_Prueba
{
    /// <summary>
    /// Descripción breve de SWDATABASE
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWDATABASE : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataSet GetData()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-5J0B7RB\SQLEXPRESS; Initial Catalog=WEBSERVICE; Integrated Security=true;";
            SqlDataAdapter da=new SqlDataAdapter("SELECT * FROM Usuario",conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return(ds);
        }

        [WebMethod]
        public bool InsertData(string Nombre_Completo, string Usuario, string Correo_Electronico, string Numero_Celular, string Puesto)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                string sql="Insert into Usuario values('"+Nombre_Completo+"' , '"+Usuario+"' , '"+Correo_Electronico+"' , '"+Numero_Celular+"' , '"+Puesto+"')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int n=cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch(Exception)
            {
                return (false);
            }
        }
    }
}
