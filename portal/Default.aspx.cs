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
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Text;

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

        private void ObterAniversariantesDoMesDia(String _mes, String _dia)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.Append(" SELECT  PESSOAS.PESSOA_NOME, PESSOAS.PESSOA_EMAIL, PESSOAS.PESSOA_NASCIMENTO, PESSOAS_FISICA.PESSOA_FISICA_ADMISSAO,  ");
                query.Append(" PESSOAS_FISICA.PESSOA_FISICA_FUNCIONARIO_ATIVO ");
                query.Append(" FROM    PESSOAS INNER JOIN ");
                query.Append(" PESSOAS_FISICA ON PESSOAS.PESSOA_ID = PESSOAS_FISICA.PESSOA_ID ");
                query.Append(" WHERE   (MONTH(PESSOAS.PESSOA_NASCIMENTO) = '" + _mes + "') AND (DAY(PESSOAS.PESSOA_NASCIMENTO) = '" + _dia + "') AND (PESSOAS_FISICA.PESSOA_FISICA_FUNCIONARIO_ATIVO = 0) ORDER BY DAY(PESSOAS.PESSOA_NASCIMENTO)");

                portal.BLL.FUNCIONARIOS funcionario = new portal.BLL.FUNCIONARIOS();
                GridView1.DataSource = funcionario.FindQueryDataSet(query.ToString());
                GridView1.DataBind();
                Int32 numRegistros = GridView1.Rows.Count;
                if (numRegistros > 1)
                {
                    LabelParabens.Text = String.Format("Parabéns aos {0} aniversariantes de hoje:", numRegistros.ToString());
                }
                else
                {
                    LabelParabens.Text = String.Format("Parabéns ao aniversariante de hoje:");
                }
                if (numRegistros <= 0)
                {
                    PanelAniversariantes.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<div class='error'>ERRO NA EXECUÇÃO: " + ex.Message + "</div>");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "PRINCIPAL";
            Master.TituloPage = this.Title;
            ObterAniversariantesDoMesDia(DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString());
            
            if (!string.IsNullOrEmpty(Request.QueryString["dst"]))
            {
                string s = Request.QueryString["dst"];
                Regex regularExpression = new Regex(@"^((?:\?[a-zA-Z0-9_]+\=[a-zA-Z0-9_]+)?(?:\&[a-zA-Z0-9_]+\=[a-zA-Z0-9_]+)*)$");
                if (regularExpression.IsMatch(s))
                {
                    Server.Transfer(Request.QueryString["dst"]);
                }
            }
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

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

    }
}
