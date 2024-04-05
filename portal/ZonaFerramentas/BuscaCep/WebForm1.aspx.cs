using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Collections;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Net;
using System.Xml.Linq;
using System.IO;
using System.Web.Services;
using System.Web.UI.MobileControls;
using portal.LIB;
using System.Text.RegularExpressions;

namespace portal.MenuCEP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = string.Empty;
            GridView1.Visible = false;
            GridView2.Visible = false;
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
            string numero = @"^\d+$";
            if (TextBoxCep.Text.Length == 8)
            {
                if (Regex.Match(TextBoxCep.Text, numero).Success)
                {
                    GridView1.DataSource = CepService.getCEP(TextBoxCep.Text);
                    GridView1.DataBind();
                    GridView1.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Por favor, informe um CEP válido. Exemplo: 45200000");
            }
        }

        //teste: procura na web. Retorno void
        protected void Button1_Click(object sender, EventArgs e)
        {
            LIB.Endereco endereco = new LIB.Endereco();
            endereco = LIB.CepService.getCepLocal(TextBoxCep.Text);

            Label1.Text += "<b>RESULTADO: </b> " + endereco.Retorno + "<br /><br />";
            Label1.Text += "<b>TIPO DE LOGRADOURO: </b> " + endereco.Tipo_logradouro + "<br /><br />";
            Label1.Text += "<b>LOGRADOURO: </b> " + endereco.Logradouro + "<br /><br />";
            Label1.Text += "<b>BAIRRO: </b> " + endereco.Bairro + "<br /><br />";
            Label1.Text += "<b>CIDADE: </b> " + endereco.Cidade + "<br /><br />";
            Label1.Text += "<b>UF: </b> " + endereco.Uf_sigla + "<br /><br />";
            Label1.Text += "<b>IBGE: </b> " + endereco.Codigo_ibge + "<br /><br />";
            Label1.Text += "<b>Fonte: </b> " + endereco.Origem + "<br /><br />";
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            LIB.Endereco endereco = new LIB.Endereco();
            endereco = LIB.CepService.getCepWs(TextBoxCep.Text);
            

            Label1.Text += "<b>RESULTADO: </b> " + endereco.Retorno + "<br /><br />";
            Label1.Text += "<b>TIPO DE LOGRADOURO: </b> " + endereco.Tipo_logradouro + "<br /><br />";
            Label1.Text += "<b>LOGRADOURO: </b> " + endereco.Logradouro + "<br /><br />";
            Label1.Text += "<b>BAIRRO: </b> " + endereco.Bairro + "<br /><br />";
            Label1.Text += "<b>CIDADE: </b> " + endereco.Cidade + "<br /><br />";
            Label1.Text += "<b>UF: </b> " + endereco.Uf_sigla + "<br /><br />";
            Label1.Text += "<b>IBGE: </b> " + endereco.Codigo_ibge + "<br /><br />";
            Label1.Text += "<b>Fonte: </b> " + endereco.Origem + "<br /><br />";
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            LIB.Endereco endereco = new LIB.Endereco();
            if (TextBoxCep.Text.Length > 0)
            {
                endereco = LIB.CepService.getCepLivre(TextBoxCep.Text);
            }
            else
            {
                endereco = LIB.CepService.getCepLivre(TextBoxLogradouro.Text, TextBoxCidade.Text);
            }
            
            Label1.Text += "<b>RESULTADO: </b> " + endereco.Retorno + "<br /><br />";
            Label1.Text += "<b>TIPO DE LOGRADOURO: </b> " + endereco.Tipo_logradouro + "<br /><br />";
            Label1.Text += "<b>LOGRADOURO: </b> " + endereco.Logradouro + "<br /><br />";
            Label1.Text += "<b>BAIRRO: </b> " + endereco.Bairro + "<br /><br />";
            Label1.Text += "<b>CIDADE: </b> " + endereco.Cidade + "<br /><br />";
            Label1.Text += "<b>UF: </b> " + endereco.Uf_sigla + "<br /><br />";
            Label1.Text += "<b>CEP: </b> " + endereco.Cep + "<br /><br />";
            Label1.Text += "<b>IBGE: </b> " + endereco.Codigo_ibge + "<br /><br />";
            Label1.Text += "<b>Fonte: </b> " + endereco.Origem + "<br /><br />";
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            LIB.Endereco endereco = new LIB.Endereco();
            endereco = LIB.CepService.getCepRepublicaVirtual(TextBoxCep.Text);

            Label1.Text += "<b>RESULTADO: </b> " + endereco.Retorno + "<br /><br />";
            Label1.Text += "<b>TIPO DE LOGRADOURO: </b> " + endereco.Tipo_logradouro + "<br /><br />";
            Label1.Text += "<b>LOGRADOURO: </b> " + endereco.Logradouro + "<br /><br />";
            Label1.Text += "<b>BAIRRO: </b> " + endereco.Bairro + "<br /><br />";
            Label1.Text += "<b>CIDADE: </b> " + endereco.Cidade + "<br /><br />";
            Label1.Text += "<b>UF: </b> " + endereco.Uf_sigla + "<br /><br />";
            Label1.Text += "<b>IBGE: </b> " + endereco.Codigo_ibge + "<br /><br />";
            Label1.Text += "<b>Fonte: </b> " + endereco.Origem + "<br /><br />";
        }

        protected void ButtonConsulta2_Click(object sender, EventArgs e)
        {
            if (TextBoxLogradouro.Text.Length > 0 && TextBoxCidade.Text.Length>0)
            {
                GridView2.DataSource = CepService.getCEP(TextBoxLogradouro.Text, TextBoxCidade.Text);
                GridView2.DataBind();
                GridView2.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, informe o logradouro e a cidade para obter um CEP.");
            }

           
        }
    }
}
