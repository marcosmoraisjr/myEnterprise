using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Globalization;
using System.Text;
using System.Runtime.InteropServices;
using portal.LIB;

namespace portal.ZonaPrincipal.MenuInstitucional.Documentos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        /// <summary>
        /// Marcos: remove acentos
        /// </summary>
        /// <param name="texto">String para retirar acentos</param>
        /// <returns>String do texto sem acentos</returns>
        public string tira_acentos(string texto)
        {
            string ComAcentos = "'!@#$%¨&*()-?:{}][ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç ";
            string SemAcentos = "__________________AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc_";
            for (int i = 0; i < ComAcentos.Length; i++)
                texto = texto.Replace(ComAcentos[i].ToString(), SemAcentos[i].ToString()).Trim();
            return texto;
        }

        /// <summary>
        /// Marcos: Retirar todos os acentos do texto informado
        /// </summary> 
        /// <param name="texto">String para retirar acentos</param>
        /// <returns>String do texto sem acentos</returns>
        public string TirarAcentos(string texto)
        {
            string textor = "";

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i].ToString() == "ã") textor += "a";
                else if (texto[i].ToString() == "á") textor += "a";
                else if (texto[i].ToString() == "à") textor += "a";
                else if (texto[i].ToString() == "â") textor += "a";
                else if (texto[i].ToString() == "ä") textor += "a";
                else if (texto[i].ToString() == "é") textor += "e";
                else if (texto[i].ToString() == "è") textor += "e";
                else if (texto[i].ToString() == "ê") textor += "e";
                else if (texto[i].ToString() == "ë") textor += "e";
                else if (texto[i].ToString() == "í") textor += "i";
                else if (texto[i].ToString() == "ì") textor += "i";
                else if (texto[i].ToString() == "ï") textor += "i";
                else if (texto[i].ToString() == "õ") textor += "o";
                else if (texto[i].ToString() == "ó") textor += "o";
                else if (texto[i].ToString() == "ò") textor += "o";
                else if (texto[i].ToString() == "ö") textor += "o";
                else if (texto[i].ToString() == "ú") textor += "u";
                else if (texto[i].ToString() == "ù") textor += "u";
                else if (texto[i].ToString() == "ü") textor += "u";
                else if (texto[i].ToString() == "ç") textor += "c";
                else if (texto[i].ToString() == "Ã") textor += "A";
                else if (texto[i].ToString() == "Á") textor += "A";
                else if (texto[i].ToString() == "À") textor += "A";
                else if (texto[i].ToString() == "Â") textor += "A";
                else if (texto[i].ToString() == "Ä") textor += "A";
                else if (texto[i].ToString() == "É") textor += "E";
                else if (texto[i].ToString() == "È") textor += "E";
                else if (texto[i].ToString() == "Ê") textor += "E";
                else if (texto[i].ToString() == "Ë") textor += "E";
                else if (texto[i].ToString() == "Í") textor += "I";
                else if (texto[i].ToString() == "Ì") textor += "I";
                else if (texto[i].ToString() == "Ï") textor += "I";
                else if (texto[i].ToString() == "Õ") textor += "O";
                else if (texto[i].ToString() == "Ó") textor += "O";
                else if (texto[i].ToString() == "Ò") textor += "O";
                else if (texto[i].ToString() == "Ö") textor += "O";
                else if (texto[i].ToString() == "Ú") textor += "U";
                else if (texto[i].ToString() == "Ù") textor += "U";
                else if (texto[i].ToString() == "Ü") textor += "U";
                else if (texto[i].ToString() == "Ç") textor += "C";
                else textor += texto[i];
            }
            return textor;
        }

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

        /// <summary>
        /// Marcos: download
        /// </summary>
        public static void Download(string fName)
        {
            FileInfo fInfo = new FileInfo(fName);
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.ContentType = "application/octet-stream";
            HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=\"" + fInfo.Name + "\"");
            HttpContext.Current.Response.AddHeader("Content-Length", fInfo.Length.ToString());
            HttpContext.Current.Response.WriteFile(fInfo.FullName);
            HttpContext.Current.Response.Flush();
            HttpContext.Current.Response.Close();
            fInfo = null;
        }

        private string pasta = string.Empty;
        private string pastaatual = string.Empty;
        private string pastaanterior = string.Empty;
        public string path = string.Empty;
        protected void ListarArquivos(GridView grid, String folder)
        {
            DirectoryInfo pasta = new DirectoryInfo(Server.MapPath(folder));
            DirectoryInfo[] subPastas = pasta.GetDirectories();
            FileInfo[] arquivos = pasta.GetFiles();
            Int32 TotalLinha = grid.Rows.Count;
            
            DataTable dt = new DataTable();
            // dt.Columns.Add("imagem", typeof(String));
            // dt.Columns.Add("Local");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Tamanho");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("Modificado");
            
            dt.Columns.Add("Ação");

            foreach (DirectoryInfo dir in subPastas)
            {
                DataRow dr = dt.NewRow();
                //dr["imagem"] = "~/imagens/mini-pasta.gif";
                //dr["Local"] = folder;
                dr["Nome"] = dir.Name;
                dr["Tamanho"] = "-";
                dr["Tipo"] = "Pasta";
                dr["Modificado"] = dir.LastWriteTime.ToString("dd/MM/yyyy");
                dr["Ação"] = "";
                dt.Rows.Add(dr);
            }
            foreach (FileInfo file in arquivos)
            {
                DataRow dr = dt.NewRow();
                //dr["imagem"] = "~/imagens/mini-baixar.gif";
                //dr["Local"] = folder;
                dr["Nome"] = file.Name;
                dr["Tamanho"] = Convert.ToString(file.Length / 1024) + " kb";
                dr["Tipo"] = file.Extension;
                dr["Modificado"] = file.LastWriteTime.ToString("dd/MM/yyyy");
                dr["Ação"] = "";
                
                //Marcos: oculta arquivos que não devem ser exibidos
                switch (file.Extension)
                {
                    case ".db":
                    case ".php":
                    case ".asp":
                    case ".aspx":
                    case ".htm":
                    case ".html":
                        break;
                    default:
                        dt.Rows.Add(dr);
                        break;
                }

            }
            grid.DataSource = dt;
            grid.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
            ListarArquivos(GridView1, @"."); 
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
         {
           if (e.Row.RowType == DataControlRowType.DataRow)
             {
                 int iGraph = e.Row.Cells.Count - 1;
                 ImageButton img1 = new ImageButton();
                 ImageButton img2 = new ImageButton();
                 
                 img1.ImageUrl = "~/imagens/mini-detalhar.png";
                 img1.CommandName = "baixar";
                 img1.CommandArgument = e.Row.Cells[0].Text;
                 img1.PostBackUrl = img1.CommandArgument;
                 img1.ToolTip = img1.CommandArgument;
                 img1.Attributes.Add("onclick", "javascript: return download('" + img1.CommandArgument + "')");
                 e.Row.Cells[iGraph].Controls.Add(img1);

                 if (ValidarAcesso.Usuario("administrador"))
                 {
                     img2.ImageUrl = "~/imagens/mini-deletar.png";
                     img2.Attributes.Add("onclick", "javascript: alert('Opção em desenvolvimento. Aguarde novas versões.');");
                     e.Row.Cells[iGraph].Controls.Add(img2);
                 }
             }
         }
        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            //Marcos: zebrando o grid
            if (e.Row.RowType == DataControlRowType.Header)
                e.Row.CssClass = "header";

            if (e.Row.RowType == DataControlRowType.DataRow &&
                e.Row.RowState == DataControlRowState.Normal)
                e.Row.CssClass = "normal";

            if (e.Row.RowType == DataControlRowType.DataRow &&
                e.Row.RowState == DataControlRowState.Alternate)
                e.Row.CssClass = "alternate";
        }

     
    }
}
