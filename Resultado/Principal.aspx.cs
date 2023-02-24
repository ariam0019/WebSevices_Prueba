using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Resultado
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WEB_SERVICE.SWDATABASESoapClient WS = new WEB_SERVICE.SWDATABASESoapClient();
            DataSet ds = WS.GetData();
            GridView1.DataSource=ds.Tables[0];
            GridView1.DataBind();
        }

        protected void Btn_Insertar_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertarDatos.aspx");
        }

        protected void Btn_Eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}