using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.Profile;

namespace portal
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.DefaultButton = Login1.FindControl("LoginButton").UniqueID;
        }

        protected void PagerButtonClick(Object sender, EventArgs e)
        {
           
            string arg = ((LinkButton)sender).CommandArgument;
            switch (arg)
            {
                case "senhaLembrar":
                    Response.Redirect(@"~/UsuarioSenhaLembrar.aspx");
                    break;
                case "senhaTrocar":
                    Response.Redirect(@"~/UsuarioSenhaTrocar.aspx");
                    break;
                case "usuarioNovo":
                    Response.Redirect(@"~/UsuarioCriar.aspx");
                    break;
                case "cancelar":
                    Response.Redirect(@"~/");
                    break;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           Response.Redirect(@"~/Logout.aspx");
           Button Button1 = new Button();
           Button1.Attributes.Add("OnClick", "fechatudo()");
        }
    }
}
