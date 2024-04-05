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
using System.Diagnostics;

namespace Portal
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //O código para chamar o Internet Explorer em C# é o seguinte:
            // Create a .NET "proxy" class to manage the COM class
            //SHDocVw.InternetExplorer IE = new SHDocVw.InternetExplorer();
            // Show
            //IE.Visible = true;
            // This is the form of optional parameters
            //object Dummy = System.Type.Missing;
            // Call a method
            //IE.Navigate("http://www.goolgle.com.br", ref Dummy, ref Dummy, ref Dummy, ref Dummy);
            
            //string app = @"%windir%\explorer.exe";
            string app = @"explorer.exe";
            string param = "ftp://189.104.11.133";
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(app, param);
            Response.Redirect("~/default.aspx");

        }
    }
}
