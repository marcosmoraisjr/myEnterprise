using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using portal.WSDL;
using System.IO;
using System.Net;
using System.Text;
using portal.LIB;

namespace portal.ZonaPrincipal.MenuEmail.SendSMS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void ButtonEnviarSMS_Click(object sender, EventArgs e)
        {
                //apenas administradores podem enviar SMS
                if (!ValidarAcesso.Usuario("administrador"))
                    Response.Redirect(@"~/AcessoRestrito.aspx?msg=tecnico");

                //fonte: http://www.human.com.br/
                WSDL.SendSmsRequest request = new WSDL.SendSmsRequest();
                request.account = "mmstec";
                request.code = "PiFAMbv1sA";
                request.msg =  string.Format(" {0} {1}",txtAssunto.Text,txtMensagem.Text);
                request.mobile = "55" + txtDestinatarioCelular.Text;
                request.from = "557381023484";
            
                /* USO PARA APLICAÇÕES DESKTOP*/
                //Sms_BindingImplClient sms = new Sms_BindingImplClient();
                //String respose = sms.sendSms(request);

                /* USO PARA APLICAÇÕES WEB*/
                String respose = string.Empty;
                string verifica = request.msg ;
                //respose = GetPage("http://system.human.com.br/GatewayIntegration/msgSms.do", "dispatch=send&account=controle.gw&code=0sOtU3F4q5&msg=teste&to=557381023484");     
                respose = GetPage("http://system.human.com.br/GatewayIntegration/msgSms.do", "dispatch=send&account=" + request.account + "&code=" + request.code + "&msg=" + request.msg + "&to=" + request.mobile + "");
                if (verifica.Length >=140)
                {
                    MessageBox.Show("Total caracteres digitados: " + verifica.Length.ToString() + ". O número máximo de caracteres é 140.");
                }
                else
                {

                    String returnCode = respose.Substring(0, 3);
                    switch (returnCode)
                    {
                        case "000":
                            MessageBox.Show("Mensagem enviada com Sucesso");
                            txtRemetenteNome.Text = string.Empty;
                            txtRemetenteCelular.Text = string.Empty;
                            txtDestinatarioNome.Text = string.Empty;
                            txtDestinatarioCelular.Text = string.Empty;
                            txtAssunto.Text = string.Empty;
                            txtMensagem.Text = string.Empty;
                            break;
                        case "010":
                            MessageBox.Show("Erro de Autenticação");
                            break;
                        case "011":
                            MessageBox.Show("Corpo da mensagem inválido");
                            break;
                        case "012":
                            MessageBox.Show("Corpo da mensagem excedeu o limite. Os campos 'destinatario' e 'Descricao' devem ter juntos no máximo 142 caracteres");
                            break;
                        case "013":
                            MessageBox.Show("Numero de destinatario esta incorreto ou invalido. O numero deve conter o codigo do pais e codigo de area do numero. Apenas digitos sao aceitos");
                            break;
                        case "014":
                            MessageBox.Show("Numero do destinatário está incorreto");
                            break;
                        case "015":
                            MessageBox.Show("A data de agendamento esta mal formatada. O formato correto deve ser: 'dd/MM/aaaa hh:mm:ss'");
                            break;
                        case "016":
                            MessageBox.Show("ID informado ultrapassou o limite de 20 caracteres.");
                            break;
                        case "080":
                            MessageBox.Show("Ja foi enviada uma mensagem de sua conta com o mesmo identificador.");
                            break;
                        case "990":
                            MessageBox.Show("Erro de Autenticação");
                            break;
                        case "999":
                            MessageBox.Show("Erro desconhecido. Contrate nosso suporte");
                            break;
                        // Aqui podem ser adicionados outros casos conforme descritos na Documentação de Integração
                        default:
                            MessageBox.Show("Mensagem não foi enviada. Motivo: " + respose);
                            break;
                    }
                }
        }

        private static String GetPage(String url, String query)
        {
            // Declarações necessárias 
            Stream requestStream = null;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                WebRequest request = WebRequest.Create(url);
                request.Method = WebRequestMethods.Http.Post;

                // Neste ponto, você está setando a propriedade ContentType da página 
                // para urlencoded para que o comando POST seja enviado corretamente 
                request.ContentType = "application/x-www-form-urlencoded";

                StringBuilder urlEncoded = new StringBuilder();

                // Separando cada parâmetro 
                Char[] reserved = { '?', '=', '&' };

                // alocando o bytebuffer 
                byte[] byteBuffer = null;

                // caso a URL seja preenchida 
                if (query != null)
                {
                    int i = 0, j;
                    // percorre cada caractere da url atraz das palavras reservadas para separação 
                    // dos parâmetros 
                    while (i < query.Length)
                    {
                        j = query.IndexOfAny(reserved, i);
                        if (j == -1)
                        {
                            urlEncoded.Append(query.Substring(i, query.Length - i));
                            break;
                        }
                        urlEncoded.Append(query.Substring(i, j - i));
                        urlEncoded.Append(query.Substring(j, 1));
                        i = j + 1;
                    }
                    // codificando em UTF8 (evita que sejam mostrados códigos malucos em caracteres especiais 
                    byteBuffer = Encoding.UTF8.GetBytes(urlEncoded.ToString());

                    request.ContentLength = byteBuffer.Length;
                    requestStream = request.GetRequestStream();
                    requestStream.Write(byteBuffer, 0, byteBuffer.Length);
                    requestStream.Close();
                }
                else
                {
                    request.ContentLength = 0;
                }

                // Dados recebidos 
                response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();

                // Codifica os caracteres especiais para que possam ser exibidos corretamente 
                System.Text.Encoding encoding = System.Text.Encoding.Default;

                // Preenche o reader 
                reader = new StreamReader(responseStream, encoding);

                Char[] charBuffer = new Char[256];
                int count = reader.Read(charBuffer, 0, charBuffer.Length);

                String Dados = "";

                // Lê cada byte para preencher meu string
                while (count > 0)
                {
                    Dados += new String(charBuffer, 0, count);
                    count = reader.Read(charBuffer, 0, charBuffer.Length);
                }

                return Dados;

            }
            catch (Exception e)
            {
                // Ocorreu algum erro 
                return ("Erro: " + e.Message);
            } // END: catch 

            finally
            {
                // Fecha tudo 
                if (requestStream != null) requestStream.Close();
                if (response != null) response.Close();
                if (reader != null) reader.Close();
            } // END: finally
        }
    }
}
