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
using System.IO;

namespace Portal
{
    public partial class _default : System.Web.UI.Page
    {
        /// <summary>
        /// ASP.NET JavaScript message box class
        /// </summary>
        public static class MessageBox
        {
            public static void ShowMessage(string MessageText, Page MyPage)
            {
                MyPage.ClientScript.RegisterStartupScript(MyPage.GetType(),
                    "MessageBox", "alert('" + MessageText.Replace("'", "\'") + "');", true);
            }
        }

        private DataTable loadFolder(DropDownList gv_arquivos, String folder)
        {
            DirectoryInfo pasta = new DirectoryInfo(folder);
            DirectoryInfo[] subPastas = pasta.GetDirectories();
            FileInfo[] arquivos = pasta.GetFiles();

            DataTable dt = new DataTable();

            dt.Columns.Add("Caminho");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Tamanho");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("Modificado");

            if (folder != "")
            {
                DataRow dr1 = dt.NewRow();
                dr1["Caminho"] = "listar.aspx";
                dr1["Nome"] = "PROFESSORES";
                dr1["Tamanho"] = "";
                dr1["Tipo"] = "";
                dr1["Modificado"] = "";
                dt.Rows.Add(dr1);
            }

            foreach (DirectoryInfo dir in subPastas)
            {
                DataRow dr = dt.NewRow();
                dr["Caminho"] = "listar.aspx?pasta=/"+dir.Name;
                dr["Nome"] = dir.Name;
                dr["Tamanho"] = "-";
                dr["Tipo"] = "Diretório";
                dr["Modificado"] = dir.LastWriteTime.ToString("dd/MM/yyyy");
                dt.Rows.Add(dr);
            }
            return dt;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Marcos: lê o banco e pega os registros da tabela favoritos para popular o dropdownlist
                //DropDownListFavoritos.DataSource = portal.DAL.dados.retornarQueryDataTable("select * from favoritos");
                DropDownListFavoritos.DataTextField = "favoritosNome";
                DropDownListFavoritos.DataValueField = "favoritosURL";
                DropDownListFavoritos.DataBind();

                //Marcos: lê o diretório de arquivos e popula o dropdownlist
                DropDownListArquivos.DataSource = loadFolder(DropDownListArquivos, Server.MapPath("./arquivos")); ;
                DropDownListArquivos.DataTextField = "Nome";
                DropDownListArquivos.DataValueField = "Caminho";
                DropDownListArquivos.DataBind();
            }
        }

        protected void ButtonArquivos_Click(object sender, EventArgs e)
        {
            Response.Redirect(DropDownListArquivos.SelectedValue);
        }

        protected void ButtonFavoritos_Click(object sender, EventArgs e)
        {
            Response.Redirect(DropDownListFavoritos.SelectedValue);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }
    }
}
