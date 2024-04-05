using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace portal.ZonaPrincipal.MenuSuporte.Listar
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Propriedade da página atual, colocada no viewstate
        public int PaginaAtual 
        {
            get
            {
                object o = this.ViewState["PaginaAtual"];
                if (o == null || (int)o < 0)
                {
                    return 0;
                }
                else
                {
                    return (int)o;
                }
            }
            set
            {
                this.ViewState["PaginaAtual"] = value;
            }
        }

        protected void lnkProximo_Click(object sender, EventArgs e)
        {
            PaginaAtual++;
            GetData();
        }
        protected void lnkAnterior_Click(object sender, EventArgs e)
        {
            PaginaAtual--;
            GetData();
        }
        protected void lnkConsultaNova_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }

        public void GetData()
        {
            StringBuilder query = new StringBuilder();
            query.Append(" SELECT * FROM [SOLICITACOES]");

            BLL.SOLICITACOES obj = new BLL.SOLICITACOES();
            DataSet ds = new DataSet();
            ds = obj.FindQueryDataSet(query.ToString());

            PagedDataSource Pgs = new PagedDataSource();
            Pgs.AllowPaging = true;
            Pgs.DataSource = ds.Tables[0].DefaultView;

            Pgs.PageSize = 10; //Número de registros por página
            if (PaginaAtual >= Pgs.PageCount)
            {
                PaginaAtual--;
            }
            else if (PaginaAtual < 0)
            {
                PaginaAtual++;
            }
            else
            {
                Pgs.CurrentPageIndex = PaginaAtual;
                GridView1.DataSource = Pgs;
                GridView1.DataBind();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox ch = (CheckBox)row.FindControl("CheckBox2");
                if (ch != null)
                {
                    ch.Checked = (sender as CheckBox).Checked;
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int str = 0;
            foreach (GridViewRow row in GridView1.Rows)
            {
                str = 0;
                CheckBox ch = (CheckBox)row.FindControl("CheckBox2");
                if (ch != null)
                {
                    if (ch.Checked)
                        str = int.Parse(row.Cells[1].Text.ToString());
                }

                // GridView1.ID = str;
                //cmd.Delete(registro, "solicitacao_id");

                //   totalSaida = totalSaida + Decimal.Parse(row.Cells[5].Text.ToString());
                //   totalEntrada = totalEntrada + Decimal.Parse(row.Cells[4].Text.ToString());
            }

            //Adicionando o método Listar contido no objeto empresaBusiness ao DataSOurce do GridView
            //gvFormasPagamento.DataSource = FormasPagamentoBusiness.Listar();

            //Preenchendo o GridView com a Lista retornada através do método Listar.
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            //BLL.SOLICITACOES cmd = new BLL.SOLICITACOES();
            //cmd.Delete("solicitacao_id=10");
        }

     }
}
