using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace portal.MenuFerramentas.BuscaCEP
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //MARCOS: pesquisando de acordo a preferencia do usuário.
        protected void opcao_Click(Object sender, EventArgs e)
        {
            string arg = ((LinkButton)sender).CommandArgument;
            switch (arg)
            {
                case "cep":
                    Response.Redirect(@"WebForm1.aspx");
                    break;
                case "logradouro":
                    Response.Redirect(@"WebForm2.aspx");
                    break;
            }
        }

        protected void ButtonConsulta_Click(object sender, EventArgs e)
        {
            String logradouro = TextBoxLogradouro.Text;
            String cidade = TextBoxCidade.Text;

            String filename = @"http://www.buscarcep.com.br/?logradouro=" + logradouro + "&cidade=" + cidade + "&formato=xml";

            XmlTextReader reader = new XmlTextReader(filename);
            string strTempName, strTempValue;
            reader.MoveToContent();
            Label1.Text = string.Empty;
            Label1.Visible = true;
            do
            {
                strTempName = reader.Name;
                if (reader.NodeType == XmlNodeType.Element)
                {
                    reader.Read();
                    strTempValue = reader.Value;
                    switch (strTempName)
                    {
                        case "tipo_logradouro":
                            Label1.Text += "<b>Tipo de Logradouro: </b> " + strTempValue + "<br /><br />";
                            break;
                        case "logradouro":
                            Label1.Text += "<b>Logradouro: </b> " + strTempValue + "<br /><br />";
                            break;
                        case "bairro":
                            Label1.Text += "<b>Bairro: </b> " + strTempValue + "<br /><br />";
                            break;
                        case "cidade":
                            Label1.Text += "<b>Cidade: </b> " + strTempValue + "<br /><br />";
                            break;
                        case "uf":
                            Label1.Text += "<b>UF: </b> " + strTempValue + "<br /><br />";
                            /*switch (strTempValue)
                                {
                                    case "AC":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "AL":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "AP":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "AM":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "BA":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "CE":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "DF":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "ES":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "GO":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "MA":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "MT":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "MS":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "MG":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "PA":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "PB":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "PR":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "PE":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "PI":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "RJ":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "RN":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "RS":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "RO":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "RR":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "SC":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "SP":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "SE":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                    case "TO":
                                        Response.Write("<b>UF: </b>" + strTempValue + "<br>");
                                        break;
                                }
                            */
                            break;
                        case "resultado":
                            if (strTempValue == "1")
                            {
                                //cep ok
                            }
                            else
                            {
                                if (strTempValue == "-1")
                                {
                                    ClientScript.RegisterStartupScript(this.GetType(), "erro", "<script>alert('Cep não encontrado');</script>");
                                }
                                else if (strTempValue == "-2")
                                {
                                    ClientScript.RegisterStartupScript(this.GetType(), "erro", "<script>alert('Formato de CEP inválido');</script>");
                                }
                                else if (strTempValue == "-3")
                                {
                                    ClientScript.RegisterStartupScript(this.GetType(), "erro", "<script>alert('Busca de CEP congestionada. \n Aguarde alguns segundos e tente novamente.');</script>");
                                }
                                else
                                {
                                    ClientScript.RegisterStartupScript(this.GetType(), "erro", "<script>alert('Erro na busca de CEP.');</script>");
                                }
                            }
                            break;
                    }
                }
            } while (reader.Read());
        }
    }
}
