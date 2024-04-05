using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Web.Security;
using System.Text;
using portal.LIB;

namespace portal.ZonaPrincipal.MenuEmail.SendMail
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MembershipUser u = Membership.GetUser();
            txtRemetenteNome.Text = u.UserName;
            txtRemetenteEmail.Text = u.Email;
            txtRemetenteNome.Enabled = false;
            txtRemetenteEmail.Enabled = false;

            if (CheckBox1.Checked)
            {
                if (DropDownList1.SelectedValue.Equals(""))
                {
                    txtDestinatarioEmail.Visible = false;
                    DropDownList1.Visible = true;
                    DropDownList1.DataSource = Membership.GetAllUsers();
                    DropDownList1.DataBind();
                }
                else
                {
                    txtDestinatarioEmail.Visible = false;
                    DropDownList1.Visible = true;
                    //DropDownList1.DataSource = Membership.GetAllUsers();
                    DropDownList1.DataBind();
                }
            }
            else
            {
                //txtDestinatarioNome.Text ="";
                //txtDestinatarioEmail.Text = "";
                txtDestinatarioEmail.Visible = true;
                DropDownList1.Visible = false;
            }
                

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userName = DropDownList1.SelectedItem.Text;
            MembershipUser user = Membership.GetUser(userName);

            if (!DropDownList1.SelectedValue.Equals(""))
            {
                txtDestinatarioNome.Text = user.UserName;
                txtDestinatarioEmail.Text = user.Email;
                txtDestinatarioEmail.Visible = true;
                DropDownList1.Visible = false;
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

            try
            {
                StringBuilder mensagem = new StringBuilder();
                mensagem.Append("MENSAGEM ENVIADA PELO SISTEMA ENTERPRISE<br /><hr /><br />");
                mensagem.Append(txtMensagem.Text + " <br /><hr /><br />");
                LIB.Email.EnviarEmail(txtRemetenteEmail.Text.Trim(), txtDestinatarioEmail.Text.Trim(), txtAssunto.Text.Trim(), mensagem.ToString());
                LIB.LimparCampos.Iniciar(this.Controls);
                lblMensagem.Text = "<br /><h2>Mensagem enviada. <br />Aguarde contato.</h2>";
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
            catch
            {
                MessageBox.Show("O envio do email não foi possível.");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Response.Redirect(@"WebForm1.aspx");
        }

   
    }
}
