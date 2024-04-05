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
using portal.BLL;
using System.Text;

namespace portal.MenuFuncionarios.MenuAniversariantes
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Mes_Click(Object sender, EventArgs e)
        {
            String mes = ((LinkButton)sender).CommandArgument;
            switch(mes)
            {
                case "01":
                    LabelTitulo.Text = "Aniversariantes de Janeiro";
                    break;
                case "02":
                    LabelTitulo.Text = "Aniversariantes de Fevereiro";
                    break;
                case "03":
                    LabelTitulo.Text = "Aniversariantes de Março";
                    break;
                case "04":
                    LabelTitulo.Text = "Aniversariantes de Abril";
                    break;
                case "05":
                    LabelTitulo.Text = "Aniversariantes de Maio";
                    break;
                case "06":
                    LabelTitulo.Text = "Aniversariantes de Junho";
                    break;
                case "07":
                    LabelTitulo.Text = "Aniversariantes de Julho";
                    break;
                case "08":
                    LabelTitulo.Text = "Aniversariantes de Agosto";
                    break;
                case "09":
                    LabelTitulo.Text = "Aniversariantes de Setembro";
                    break;
                case "10":
                    LabelTitulo.Text = "Aniversariantes de Outubro";
                    break;
                case "11":
                    LabelTitulo.Text = "Aniversariantes de Novembro";
                    break;
                case "12":
                    LabelTitulo.Text = "Aniversariantes de Dezembro";
                    break;
                case "hoje":
                    LabelTitulo.Text = "Aniversariantes de Hoje";
                    
                    break;
            }
            if (mes == "hoje")
            {
                ObterAniversariantesDoMesDia(DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString());
            }
            else
            {
                ObterAniversariantesDoMes(mes);
            }
           
        }
        private void ObterAniversariantesDoMes(String _mes)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.Append(" SELECT  PESSOAS.PESSOA_NOME, PESSOAS.PESSOA_EMAIL, PESSOAS.PESSOA_NASCIMENTO, PESSOAS_FISICA.PESSOA_FISICA_ADMISSAO,  ");
                query.Append(" PESSOAS_FISICA.PESSOA_FISICA_FUNCIONARIO_ATIVO ");
                query.Append(" FROM    PESSOAS INNER JOIN ");
                query.Append(" PESSOAS_FISICA ON PESSOAS.PESSOA_ID = PESSOAS_FISICA.PESSOA_ID ");
                query.Append(" WHERE   (MONTH(PESSOAS.PESSOA_NASCIMENTO) = '" + _mes + "') AND (PESSOAS_FISICA.PESSOA_FISICA_FUNCIONARIO_ATIVO = 0) ");


                BLL.FUNCIONARIOS funcionario = new BLL.FUNCIONARIOS();
                GridView1.DataSource = funcionario.FindQueryDataSet(query.ToString());
                GridView1.DataBind();
                Int32 numRegistros = GridView1.Rows.Count;
                if(numRegistros<=0)
                    Label1.Text = "<div class='info'>Não existe aniversariantes em "+_mes+" </div>";
            }
            catch (Exception ex)
            {
                GridView1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "<div class='error'>ERRO NA EXECUÇÃO: " + ex.Message + "</div>";
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
                query.Append(" WHERE   (MONTH(PESSOAS.PESSOA_NASCIMENTO) = '" + _mes + "') AND (DAY(PESSOAS.PESSOA_NASCIMENTO) = '" + _dia + "') AND (PESSOAS_FISICA.PESSOA_FISICA_FUNCIONARIO_ATIVO = 0) ");

                /*query.Append(" SELECT ");
                query.Append(" funcionarioNome,funcionarioEmail,funcionarioCargo,funcionarioNascimento,funcionarioAdmissao  ");
                query.Append(" FROM  FUNCIONARIOS  ");
                query.Append(" WHERE funcionarioInativo=0 AND ((MONTH(funcionarioNascimento) = '" + _mes + "')) AND ((DAY(funcionarioNascimento) = '" + _dia + "'))");
                query.Append(" ORDER BY DAY(funcionarioNascimento)");
                 */

                BLL.FUNCIONARIOS funcionario = new BLL.FUNCIONARIOS();
                GridView1.DataSource = funcionario.FindQueryDataSet(query.ToString());
                GridView1.DataBind();
                Int32 numRegistros = GridView1.Rows.Count;
                if (numRegistros <= 0)
                    Label1.Text = "<div class='info'>Não existe aniversariantes em "+_dia+"/"+_mes+" </div>";
   
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
            if (!IsPostBack)
            {
                ObterAniversariantesDoMes(DateTime.Now.ToString("MM"));
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
