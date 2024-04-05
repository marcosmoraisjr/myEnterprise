/* Upload de arquivos
 * by: Eduardo Henrique Rizo
 *     ehrizo@hotmail.com
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO; //Inclusão do namespace para tratamento de arquivos

namespace ExemplosCSharp.Upload
{
	/// <summary>
	/// Summary description for upload.
	/// </summary>
	public class upload : System.Web.UI.Page
	{
		protected System.Web.UI.HtmlControls.HtmlInputFile arquivo; //Declaração do controle para execução em servidor
		protected System.Web.UI.WebControls.Label lMensagem;
		protected System.Web.UI.WebControls.TextBox tbCaminho;
		protected System.Web.UI.WebControls.Button bEnviar;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			//Atribuindo o caminho inicial para o upload do arquivo
			if (!Page.IsPostBack)
				tbCaminho.Text = Server.MapPath("");
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
				//Processo de upload
				arquivo.PostedFile.SaveAs(tbCaminho.Text + "\\" + vNomeArquivo.Name);
				lMensagem.Text = "Arquivo enviado com sucesso.";
			}
			catch(Exception ex)
			{
				lMensagem.Text = "Erro ao enviar o arquivo.<br>" + ex.Message;
			}
		}
	}
}
