using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Portal
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Browser.IsBrowser("IE"))
            {
                PanelAviso.Visible = true;
            }
            else if (Request.Browser.IsBrowser("Gecko"))  // Firefox, Mozilla "Seamonkey" e compatíveis
            {
                PanelAviso.Visible = false;
            }
            else if (Request.Browser.IsBrowser("Netscape"))
            {
                PanelAviso.Visible = true;
            }
            else
            {
                PanelAviso.Visible = false;
            }
        }
        protected void PagerButtonClick(Object sender, EventArgs e)
        {
            string arg = ((LinkButton)sender).CommandArgument;
            switch (arg)
            {
                case "principal":
                    Response.Redirect(@"~/default.aspx");
                    break;

                case "arquivos":
                    Response.Redirect(@"~/listar.aspx");
                    break;

                case "creditos":
                    Response.Redirect(@"~/creditos.aspx");
                    break;


            }
        }
    }
}
