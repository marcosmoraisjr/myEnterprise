using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Globalization;
using System.IO;
using System.Text;

namespace Portal
{
    public partial class listar : System.Web.UI.Page
    {
        
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
        private string pasta = string.Empty;
        private string pastaatual = string.Empty;
        private string pastaanterior = string.Empty;
        public string path = string.Empty;
        protected DataTable loadFolder(GridView grid, String folder)
        {
            
            DirectoryInfo pasta = new DirectoryInfo(Server.MapPath(folder));
            DirectoryInfo[] subPastas = pasta.GetDirectories();
            FileInfo[] arquivos = pasta.GetFiles();
            DataTable dt = new DataTable();
            int TotalLinha = grid.Rows.Count;
            dt.Columns.Add("ID");
            dt.Columns.Add("Local");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Tamanho");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("Modificado");

            /*
            if (folder != "")
            {
                DataRow dr1 = dt.NewRow();
                dr1["ID"] = "D";
                dr1["Local"] = folder;
                dr1["Nome"] = "<< Voltar";
                dr1["Tamanho"] = "";
                dr1["Tipo"] = "";
                dr1["Modificado"] = "";
                switch (grid.PageCount)
                {
                    case 1:
                        break;
                    default:
                        if(grid.PageIndex != 1)
                            dt.Rows.Add(dr1);
                        break;
                }
            }
            */

            foreach (DirectoryInfo dir in subPastas)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = "D";
                dr["Local"] = folder + dir.Name;
                dr["Nome"] = dir.Name;
                dr["Tamanho"] = "-";
                dr["Tipo"] = "Diretório";
                dr["Modificado"] = dir.LastWriteTime.ToString("dd/MM/yyyy");
                dt.Rows.Add(dr);
            }
            foreach (FileInfo file in arquivos)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = "F";
                dr["Local"] = folder + file.Name;
                dr["Nome"] = file.Name;
                dr["Tamanho"] = Convert.ToString(file.Length / 1024) + " kb";
                dr["Tipo"] = file.Extension;
                dr["Modificado"] = file.LastWriteTime.ToString("dd/MM/yyyy");

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
            return dt;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Faz com que a session expire
            Response.Cache.SetExpires(DateTime.Now.Subtract(new TimeSpan(24, 0, 0)));
            //Desabilita a cache para a página
            Response.Cache.SetCacheability(HttpCacheability.NoCache);

            //verifica se é um submit para mesma página (PostBack)
            /*if (!IsPostBack)
            {
               GridView1.DataSource = loadFolder(GridView1, "arquivos");
               GridView1.DataBind();
            }
            */
            // MARCOS: 
            // Nesse caso específico, precisamos sempre carregar o gridview
            // Aponta a fonte para a fonte de dados
          
            pasta = @"arquivos" + Request.QueryString["pasta"] +"/";
            Label1.Text = string.Format("Você esta em {0}", pasta.ToUpper());
            GridView1.DataSource = loadFolder(GridView1, pasta);
            GridView1.DataBind();
            ShowStats();
            if (GridView1.PageCount <= 1)
            {
                PanelPaginacao.Visible = false;
            }
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = int.Parse((string)e.CommandArgument);
                pastaanterior = @"/" + pastaatual;
                pastaatual = @"" + pastaatual + GridView1.Rows[index].Cells[3].Text;
                if (GridView1.Rows[index].Cells[1].Text == "D")
                {
                    if (Request.QueryString["pasta"] != string.Empty)
                    {
                        pastaatual = @""+Request.QueryString["pasta"] +"/" +pastaatual;
                    }
                    Response.Redirect(@"listar.aspx?pasta=" + pastaatual);
                }
                else
                {
                    path += GridView1.Rows[index].Cells[2].Text;
                    Response.Redirect(path);
                }
            }
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //Marcos: oculta colunas especificas
            if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header || e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[1].Visible = false;
                e.Row.Cells[2].Visible = false;
            }

            if ((e.Row.RowType != DataControlRowType.Footer) && (e.Row.RowType != DataControlRowType.Header) && (e.Row.RowType != DataControlRowType.Pager))
            {
                e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='#FFCC66';this.style.color='#990000';");
                if (e.Row.RowState == DataControlRowState.Normal)
                {
                    e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#F7F7F7';this.style.color='Black';");
                }
                else if (e.Row.RowState == DataControlRowState.Alternate)
                {
                    e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#CCCCCC';this.style.color='Black';");
                }
            }

            //Marcos: oculta linhas especificas
            /*if (e.Row.RowType == DataControlRowType.DataRow )
            {
                string _item = ((DataRowView)e.Row.DataItem)["Nome"].ToString();
                switch (_item.ToString().ToLower())
                {
                    case ("index.html"):
                    case ("index.htm"):
                    case ("default.aspx"):
                    case ("default.asp"):
                    case ("listar.aspx"):
                    case ("thumbs.db"):
                        e.Row.Cells[3].ForeColor = System.Drawing.Color.Red;
                        e.Row.Cells[3].Font.Bold = true;
                        break;
                }
            }*/

            // remover acentos
            //HttpUtility.UrlEncode("Pêssego pássaro canção", Encoding.GetEncoding(28597)).Replace("+", " ");
            //

            /*if (e.Row.RowType == DataControlRowType.DataRow )
            {
                string ITE_ID = ((DataRowView)e.Row.DataItem)["Nome"].ToString();
                if (ITE_ID.ToString().Equals("antonioluis"))
                {
                    e.Row.Cells[1].ForeColor = System.Drawing.Color.Red;
                    e.Row.Cells[1].Font.Bold = true;
                }
            }*/
            //MARCOS: Efeito zebrado ao grid colorindo linhas alternadamente
            /*
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.RowIndex % 2 == 0)
                {
                    e.CellStyle.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    e.CellStyle.BackColor = Color.White;
                }
            }
            */
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //MARCOS: configura nova página paginando
            //paginaAtual = GridView1.PageIndex;
            GridView1.PageIndex = e.NewPageIndex;
            if (pasta.Length < 1)
            {
                pasta = "arquivos";
            }
            GridView1.DataSource = loadFolder(GridView1, pasta);
            GridView1.DataBind();
            ShowStats();
            
        }
        protected void PagerButtonClick(Object sender, EventArgs e)
        {
                string arg = ((LinkButton)sender).CommandArgument;
                switch (arg)
                {
                    case "next":
                        if (GridView1.PageIndex < (GridView1.PageCount - 1)) GridView1.PageIndex += 1;
                        break;

                    case "prev":
                        if (GridView1.PageIndex > 0) GridView1.PageIndex -= 1;
                        break;

                    case "last":
                        GridView1.PageIndex = (GridView1.PageCount - 1);
                        break;

                    case "zero":
                        if (GridView1.PageIndex >= 0) GridView1.PageIndex = 0;
                        break;
                }
            GridView1.DataSource = loadFolder(GridView1, pasta);
            GridView1.DataBind();
            ShowStats();
        }
        protected void ShowStats()
        {
            lblCurrentIndex.Text = "" +  (GridView1.PageIndex+1) + "";
            lblPageCount.Text = "" + GridView1.PageCount + "";
        }
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            /*UploadStatusLabel.Text = string.Empty;
            if (FileUpload1.HasFile)
            {
                try
                {
                    FileUpload1.SaveAs(@"c:\mmstec\portalftc\arquivos\" + pasta + FileUpload1.FileName);
                    UploadStatusLabel.Text = string.Format("Arquivo enviado: {0} | {1} kb - Tipo {2} ", FileUpload1.PostedFile.FileName, FileUpload1.PostedFile.ContentLength, FileUpload1.PostedFile.ContentType);

                }
                catch (Exception ex)
                {
                    UploadStatusLabel.Text = "ERRO: " + ex.Message.ToString();
                }
            }
            else
            {
                UploadStatusLabel.Text = "Você deve escolher um arquivo para o upload.";
            }*/

            // Before attempting to save the file, verify
            // that the FileUpload control contains a file.
            if (FileUpload1.HasFile)
                // Call a helper method routine to save the file.
                SaveFile(FileUpload1.PostedFile);
            else
                // Notify the user that a file was not uploaded.
                UploadStatusLabel.Text = "Você não especificou um arquivo para enviar.";
        }
        protected void SaveFile(HttpPostedFile file)
        {
            // Specify the path to save the uploaded file to.
            string savePath = string.Format(@"c:\mmstec\portalftc\{0}\", pasta);

            // Get the name of the file to upload.
            string fileName = FileUpload1.FileName;

            // Create the path and file name to check for duplicates.
            string pathToCheck = savePath + fileName;

            // Create a temporary file name to use for checking duplicates.
            string tempfileName = "";

            // Check to see if a file already exists with the
            // same name as the file to upload.        
            if (System.IO.File.Exists(pathToCheck))
            {
                int counter = 2;
                while (System.IO.File.Exists(pathToCheck))
                {
                    // if a file with this name already exists,
                    // prefix the filename with a number.
                    tempfileName = counter.ToString() + fileName;
                    pathToCheck = savePath + tempfileName;
                    counter++;
                }

                fileName = tempfileName;

                // Notify the user that the file name was changed.
                UploadStatusLabel.Text = "Um arquivo com o mesmo nome já existe." +
                                         "<br />Seu arquivo foi salvo como " + fileName;
            }
            else
            {
                // Notify the user that the file was saved successfully.
                UploadStatusLabel.Text = "Seu arquivo foi enviado com sucesso para " + pasta;
            }

            // Append the name of the file to upload to the path.
            savePath += fileName;

            // Call the SaveAs method to save the uploaded
            // file to the specified directory.
            FileUpload1.SaveAs(savePath);
            savePath = string.Empty;
        }

    }
}
