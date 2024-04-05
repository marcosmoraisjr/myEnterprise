using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;
using System.Net;
using System.Web.Security;

namespace portal.ZonaPrincipal.MenuSuporte.WebSite
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        private void LimpaCampos(ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = string.Empty;
                }
                LimpaCampos(ctrl.Controls);
            }
        }
        
        protected void EnviarEmail(String _remetente,String _destino, String _assunto, String _mensagem)
        {
            //crio objeto responsável pela mensagem de email
            MailMessage mensagem = new MailMessage();
            //rementente do email
            mensagem.From = new MailAddress(_remetente);
            //destinatario do email
            mensagem.To.Add(_destino);
            //se quiser enviar uma cópia oculta pra alguém, utilize a linha abaixo:
            mensagem.Bcc.Add("mmstec@gmail.com");
            //prioridade do email
            mensagem.Priority = MailPriority.Normal;
            //utilize true pra ativar html no conteúdo do email, ou false, para somente texto
            mensagem.IsBodyHtml = true;
            //Assunto do email
            mensagem.Subject = _assunto;
            //corpo do email 
            mensagem.Body = "MENSAGEM ENVIADA PELO SISTEMA ENTERPRISE<br /><br />Favor encaminhar a pessoa responsável.<br /><br />" + _mensagem;
            //prioridade do email
            mensagem.Priority = MailPriority.High;
            //codificação do assunto do email para que os caracteres acentuados serem reconhecidos.
            mensagem.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
            //codificação do corpo do email para que os caracteres acentuados serem reconhecidos.
            mensagem.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");

            //cria o objeto responsável pelo envio do email e envia email
            SmtpClient cliente = new SmtpClient("smtp.live.com", 25);
            cliente.Credentials = new NetworkCredential("mmstec@msn.com", "04796820");
            cliente.EnableSsl = true;
            cliente.Send(mensagem);

            //libera o objeto responsável pela mensagem de email
            mensagem.Dispose();
            //limpa todos os campos do form.
            LimpaCampos(this.Controls);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            MembershipUser u = Membership.GetUser();
            txtRemetenteNome.Text = u.UserName;
            txtRemetenteEmail.Text = u.Email;
            txtDestinatarioNome.Text = "Responsável";
            txtDestinatarioEmail.Text = "atendimento@barretoconstrucao.com.br";

            txtRemetenteNome.Enabled = false;
            txtRemetenteEmail.Enabled = false;
            txtDestinatarioNome.Enabled = false;
            txtDestinatarioEmail.Enabled = false;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarEmail(txtRemetenteEmail.Text, txtDestinatarioEmail.Text, "Solicitação - "+txtAssunto.Text, txtMensagem.Text);
            lblMensagem.Text = "<br /><h2>Mensagem enviada. <br />Aguarde contato.</h2>";
            Panel1.Visible = false;
            Panel2.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Response.Redirect(@"WebForm1.aspx");
        }

    }
}
