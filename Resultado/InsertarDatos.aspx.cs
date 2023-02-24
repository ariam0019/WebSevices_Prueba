using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Resultado;

namespace Resultado
{
    public partial class InsertarDatos : System.Web.UI.Page
    {
        WEB_SERVICE.SWDATABASESoapClient WS = new WEB_SERVICE.SWDATABASESoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Nombre_Completo, Usuario, Correo_Electronico, Numero_Celular, Puesto;
            Nombre_Completo = Txtnombre.Text;
            Usuario = Txtusuario.Text;
            Correo_Electronico = TxtCorreo.Text;
            Numero_Celular = TxtNumero.Text;
            Puesto = TxtPuesto.Text;
            /*if(WS.InsertarDatos()(Nombre_Completo, Usuario, Correo_Electronico, Numero_Celular, Puesto))
            {
                Response.Write("<script>window.alert('Error al Ingresar Usuario')</script>");
            }
            else
            {
                Response.Write("<script>window.alert('Persona Ingresada Correctamente')</script>");
            }*/
        }
    }
}