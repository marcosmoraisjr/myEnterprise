using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace portal
{
    public partial class AcessoRestrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string msg = HttpContext.Current.Request.QueryString["msg"];
            LabelPerfilRestrito.Text = msg;

            //FormsAuthentication.SignOut();
            //Response.Redirect("~/");
        }
    }
}
