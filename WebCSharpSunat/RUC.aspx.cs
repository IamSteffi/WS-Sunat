using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCSharpSunat
{
    public partial class RUC : System.Web.UI.Page
    {
        private static ServiceReference1.WebService1SoapClient servicio = new ServiceReference1.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buscartxt_TextChanged(object sender, EventArgs e)
        {
            gvRUC.DataSource = servicio.Buscar(Buscartxt.Text).Tables[0];
            gvRUC.DataBind();
        }
    }
}