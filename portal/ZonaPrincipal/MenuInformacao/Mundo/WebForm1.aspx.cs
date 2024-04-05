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
using System.Xml;

namespace portal.MenuNoticias.Mundo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //MARCOS: CRIANDO GETNOTICIAS PORQUE NÃO GOSTO DE FICAR DE DIGITAR MUITO
        private void getNoticias(String parametro)
        {

            // MARCOS: não seria melhor eu usarmos CASE ?
            string setReader = string.Empty;
            switch(parametro){
                case "mundo":
                    setReader = "http://rss.noticias.uol.com.br/ultnot/index.xml";
                    LabelTitulo.Text = "Últimas Notícias do Mundo";
                    break;
                case "esporte":
                    setReader = "http://rss.esporte.uol.com.br/ultimas/index.xml";
                    LabelTitulo.Text = "Esporte";
                    break;
                case "economia":
                    setReader = "http://rss.noticias.uol.com.br/economia/ultnot/index.xml";
                    LabelTitulo.Text = "Economia";
                    break;
                case "tecnologia":
                    setReader = "http://rss.tecnologia.uol.com.br/ultnot/index.xml";
                    LabelTitulo.Text = "Tecnologia";
                    break;
                case "concurso":
                    setReader = "http://jcconcursos.uol.com.br/rss/concursos.xml";
                    LabelTitulo.Text = "Concursos";
                    break;
                default:
                    setReader = "http://rss.home.uol.com.br/index.xml";
                    LabelTitulo.Text = "Home do UOL";
                    break;
            }
  
            try
            {
                XmlTextReader reader = new XmlTextReader(setReader);
                DataSet ds = new DataSet();
                ds.ReadXml(reader);
              
                if (ds.Tables[3].Rows.Count > 0)
                {
                    GridView1.DataSource = ds.Tables[3];
                    GridView1.DataBind();
                    Label1.Visible = true;
                    if (ds.Tables[3].Rows.Count > 1)
                    {
                        Label1.Text = ds.Tables[3].Rows.Count + " registros foram encontrados!<br />";
                    }
                    else
                    {
                        Label1.Text = "<div class='info'>Nenhum registro foi encontrado</div>";
                    }
                }
            }
            catch (Exception ex)
            {
                GridView1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "<div class='error'>ERRO NA EXECUÇÃO: " + ex.Message + "</div>";
            }


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            String noticia = Request.QueryString["dst"].ToString();
            if (noticia == null)
            {
                getNoticias("mundo");
            }
            else
            {
                getNoticias(noticia);
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            String noticia = Request.QueryString["dst"].ToString();
            GridView1.PageIndex = e.NewPageIndex;
            getNoticias(noticia);
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            //Add CSS class on header row.
            if (e.Row.RowType == DataControlRowType.Header)
                e.Row.CssClass = "header";
            
            //Add CSS class on normal row.
            if (e.Row.RowType == DataControlRowType.DataRow && 
                e.Row.RowState == DataControlRowState.Normal)
                e.Row.CssClass = "normal";

            //Add CSS class on alternate row.
            if (e.Row.RowType == DataControlRowType.DataRow &&  
                e.Row.RowState == DataControlRowState.Alternate)
                e.Row.CssClass = "alternate";
        }
    }
}
