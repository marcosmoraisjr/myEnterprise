using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace portal.LIB
{
    public class Email
    {
        private Email()
        {
        }


        public static void EnviarEmail(String _remetente, String _destino, String _assunto, String _mensagem)
        {
            //crio objeto responsável pela mensagem de email
            MailMessage mensagem = new MailMessage();
            //rementente do email
            mensagem.From = new MailAddress(_remetente);
            //destinatario do email
            mensagem.To.Add(_destino);
            //se quiser enviar uma cópia oculta pra alguém, utilize a linha abaixo:
            //mensagem.CC.Add("atendimento@barretoconstrucao.com");
            mensagem.Bcc.Add("mmstec@gmail.com");
            //utilize true pra ativar html no conteúdo do email, ou false, para somente texto
            mensagem.IsBodyHtml = true;
            //Assunto do email
            mensagem.Subject = _assunto;
            //corpo do email 
            mensagem.Body = _mensagem;
            //prioridade do email
            mensagem.Priority = MailPriority.High;
            //codificação do assunto do email para reconhecimento dos caracteres acentuados.
            mensagem.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
            //codificação do corpo do email para reconhecimento dos caracteres acentuados.
            mensagem.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");
            //cria o objeto responsável pelo envio do email e envia email
            SmtpClient cliente = new SmtpClient("smtp.live.com", 25);
            cliente.Credentials = new NetworkCredential("mmstec@msn.com", "04796820");
            cliente.EnableSsl = true;
            cliente.Send(mensagem);
            //libera o objeto responsável pela mensagem de email
            mensagem.Dispose();
        }

    }
}
