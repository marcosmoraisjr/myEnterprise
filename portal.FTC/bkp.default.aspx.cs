using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace Intranet
{
    public partial class _Default : System.Web.UI.Page
    {

        public DataTable loadFolder(DropDownList gv_arquivos, String folder)
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
                dr1["Caminho"] = "../";
                dr1["Nome"] = "PROFESSORES";
                dr1["Tamanho"] = "";
                dr1["Tipo"] = "";
                dr1["Modificado"] = "";
                dt.Rows.Add(dr1);
            }

            foreach (DirectoryInfo dir in subPastas)
            {
                DataRow dr = dt.NewRow();
                dr["Caminho"] = "/" + dir.Name;
                dr["Nome"] = dir.Name;
                dr["Tamanho"] = "-";
                dr["Tipo"] = "Diretório";
                dr["Modificado"] = dir.LastWriteTime.ToString("dd/MM/yyyy");
                dt.Rows.Add(dr);
            }
            /*int linha = 0;
            foreach (FileInfo file in arquivos)
            {
                linha++;
                DataRow dr = dt.NewRow();
                dr["Nome"] = file.Name;
                dr["Tamanho"] = Convert.ToString(file.Length / 1024) + " kb";
                dr["Tipo"] = file.Extension;
                dr["Modificado"] = file.LastWriteTime.ToString("dd/MM/yyyy");
                dr["Ação"] = linha.ToString();
                dt.Rows.Add(dr);
            }

            //gv_arquivos.DataSource = dt;
            //gv_arquivos.DataBind();
            */
            return dt;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListArquivos.DataSource = loadFolder(DropDownListArquivos, Server.MapPath("./arquivos")); ;
                DropDownListArquivos.DataTextField = "Nome";
                DropDownListArquivos.DataValueField = "Nome";
                DropDownListArquivos.DataBind();
            }
        }
    }
}
