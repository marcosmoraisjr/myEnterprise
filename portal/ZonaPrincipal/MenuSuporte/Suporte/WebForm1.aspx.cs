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
using portal.BLL;
using portal.TAB;
using portal.LIB;

namespace portal.ZonaPrincipal.MenuSuporte.Suporte
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            

            MembershipUser u = Membership.GetUser();
            txtRemetenteNome.Text = u.UserName;
            txtRemetenteEmail.Text = u.Email;
            txtDestinatarioNome.Text = "Jeferson Santos";
            txtDestinatarioEmail.Text = "jefersonsantos@barretoconstrucao.com.br";

            txtRemetenteNome.ReadOnly = true;
            txtRemetenteEmail.ReadOnly = true;
            txtDestinatarioNome.ReadOnly = false;
            txtDestinatarioEmail.ReadOnly = false;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            
            try
            {
                StringBuilder mensagem = new StringBuilder();
                mensagem.Append("MENSAGEM ENVIADA PELO SISTEMA ENTERPRISE<br /><hr /><br />");
                mensagem.Append( txtMensagem.Text + " <br /><hr /><br />");
                mensagem.Append( "IMPORTANTE: APÓS ATENDIMENTO, INFORMAR AO SISTEMA QUE O CHAMADO ESTA CONCLUÍDO.");
                mensagem.Append( "<br /><br />");
                mensagem.Append( "Você pode acessar de qualquer lugar pelo link: http://mfbjequie.ddns.com.br:8082");
                LIB.Email.EnviarEmail(txtRemetenteEmail.Text, txtDestinatarioEmail.Text, "SOLICITAÇÃO SUPORTE TÉCNICO - "+txtAssunto.Text, mensagem.ToString());
            }
            catch
            {
                MessageBox.Show("Problemas no envio de mensagem por email.");
            }

            try
            {
                BLL.SOLICITACOES obj = new BLL.SOLICITACOES();
                TAB.SOLICITACOES reg = new TAB.SOLICITACOES();
                reg.SOLICITACAO_REMETENTE_NOME = this.txtRemetenteNome.Text.ToString();
                reg.SOLICITACAO_REMETENTE_EMAIL = this.txtRemetenteEmail.Text;
                reg.SOLICITACAO_ASSUNTO = "Solicitação Suporte Técnico - " + txtAssunto.Text;
                reg.SOLICITACAO_DESCRICAO = this.txtMensagem.Text;
                reg.SOLICITACAO_INCLUSAO = DateTime.Now;
                reg.SOLICITACAO_SITUACAO = 0; //0-PENDENTE | 1-CONCLUIDO
                reg.SOLICITACAO_DESTINATARIO_EMAIL = this.txtDestinatarioEmail.Text;
                reg.SOLICITACAO_CONCLUSAO = DateTime.Now;
                reg.SOLICITACAO_OBSERVACAO = "Pedente";
                obj.Insert(reg);
                LimparCampos.Iniciar(this.Controls);
                Response.Redirect("../listar/");
            }
            catch
            {
                MessageBox.Show("Problemas na inclusão dos registros no banco de dados.");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Response.Redirect(@"../suporte/");
        }


    }
}
