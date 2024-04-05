using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Globalization;
using portal.LIB;

namespace portal.ZonaPrincipal.MenuInstitucional.Documentos
{
    public partial class Upload : System.Web.UI.Page
    {
        protected System.Web.UI.HtmlControls.HtmlInputFile arquivo; //Declaração do controle para execução em servidor
        protected System.Web.UI.WebControls.Label lMensagem;
        protected System.Web.UI.WebControls.TextBox tbCaminho;
        protected System.Web.UI.WebControls.Button bEnviar;

        /// <summary>
        /// Marcos: remove acentos
        /// </summary>
        /// <param name="texto">String para retirar acentos</param>
        /// <returns>String do texto sem acentos</returns>
        private string RemoverAcentos(string texto)
        {
            string s = texto.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int k = 0; k < s.Length; k++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(s[k]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(s[k]);
                }
            }
            return sb.ToString();
        }

        private void Page_Load(object sender, System.EventArgs e)
        {
            // Atribuindo o caminho inicial para o upload do arquivo
            //if (!Page.IsPostBack)
            //    tbCaminho.Text = Server.MapPath("");

            if(!ValidarAcesso.Usuario("administrador"))
                Response.Redirect("./");
                
        }

        #region Web Form Designer generated code
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: This call is required by the ASP.NET Web Form Designer.
            //
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            this.Load += new System.EventHandler(this.Page_Load);
        }
        #endregion

        private void bEnviar_Click(object sender, System.EventArgs e)
        {
            try
            {
              //Informações do arquivo
              FileInfo vNomeArquivo = new FileInfo(arquivo.PostedFile.FileName);
              if (!File.Exists(arquivo.PostedFile.FileName))
              {
                  //Processo de upload
                  arquivo.PostedFile.SaveAs(Server.MapPath("") + "\\" + RemoverAcentos(vNomeArquivo.Name));
                  lMensagem.Text = "Arquivo enviado com sucesso.";
              }
              else
              {
                  lMensagem.Text = "Já existe um arquivo com esse nome!";
              }
            }
            catch (Exception ex)
            {
                lMensagem.Text = "Erro ao enviar o arquivo.<br />" + ex.Message;
            }
        }
    }
}
