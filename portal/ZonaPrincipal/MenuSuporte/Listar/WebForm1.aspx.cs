using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;
using portal.LIB;
using System.Text;
using System.Net.NetworkInformation;

namespace portal.ZonaPrincipal.MenuSuporte.Listar
{
    public enum TipoOperacao
    {
        toTotal, toPendente, toAndamento, toConcluido
    };

    public partial class WebForm1 : System.Web.UI.Page
    {

        double graficoTotal, graficoPendente, graficoAndamento, graficoConcluido;
        
        int pageSize = 20;
        int totalRegistros;
        int totalPages;
        int currentPage = 1;

        public void NextButton_OnClick(object sender, EventArgs args)
        {
            currentPage = Convert.ToInt32(CurrentPageLabel.Text);
            currentPage++;
            GetSolicitacoes();
        }
        public void PreviousButton_OnClick(object sender, EventArgs args)
        {
            currentPage = Convert.ToInt32(CurrentPageLabel.Text);
            currentPage--;
            GetSolicitacoes();
        }

        private string sSortDirection = "ASC";
        private string sSortExpression = "SOLICITACAO_INCLUSAO";
        private string sSortFiltro = "SOLICITACAO_SITUACAO=1";
        private string GetSortDirection(string column)
        {
            // By default, set the sort direction to ascending.
            string sortDirection = "ASC";

            // Retrieve the last column that was sorted.
            string sortExpression = ViewState["SortExpression"] as string;

            if (sortExpression != null)
            {
                // Check if the same column is being sorted.
                // Otherwise, the default value can be returned.
                if (sortExpression == column)
                {
                    string lastDirection = ViewState["SortDirection"] as string;
                    if ((lastDirection != null) && (lastDirection == "ASC"))
                    {
                        sortDirection = "DESC";
                    }
                }
            }

            // Save new values in ViewState.
            ViewState["SortDirection"] = sortDirection;
            ViewState["SortExpression"] = column;

            return sortDirection;
        }

        private void montaGrafico()
        {
            var graf1 = new StringBuilder();
            var query1 = new StringBuilder();
            var query2 = new StringBuilder();
            var query3 = new StringBuilder();
            var query4 = new StringBuilder();
            var dsTotal = new DataSet();
            var dsPendente = new DataSet();
            var dsAndamento = new DataSet();
            var dsConcluido = new DataSet();

            BLL.SOLICITACOES solicitacoes = new BLL.SOLICITACOES();
            
            query1.Append(" SELECT    COUNT(*) AS EXP1 ");
            query1.Append(" FROM      SOLICITACOES "); //TODOS

            query2.Append(" SELECT    COUNT(*) AS EXP1");
            query2.Append(" FROM      SOLICITACOES ");
            query2.Append(" WHERE     (SOLICITACAO_SITUACAO=0)"); //PENDENTE

            query3.Append(" SELECT    COUNT(*) AS EXP1 ");
            query3.Append(" FROM      SOLICITACOES ");
            query3.Append(" WHERE     (SOLICITACAO_SITUACAO=1)"); //CONCLUIDO

            query4.Append(" SELECT    COUNT(*) AS EXP1 ");
            query4.Append(" FROM      SOLICITACOES ");
            query4.Append(" WHERE     (SOLICITACAO_SITUACAO=2)"); //ANDAMENTO

            dsTotal = solicitacoes.FindQueryDataSet(query1.ToString());
            dsPendente = solicitacoes.FindQueryDataSet(query2.ToString());
            dsConcluido = solicitacoes.FindQueryDataSet(query3.ToString());
            dsAndamento = solicitacoes.FindQueryDataSet(query4.ToString());
            
            graficoTotal = Convert.ToDouble(dsTotal.Tables[0].Rows[0]["EXP1"]);
            graficoPendente = Convert.ToDouble(dsPendente.Tables[0].Rows[0]["EXP1"]);
            graficoConcluido = Convert.ToDouble(dsConcluido.Tables[0].Rows[0]["EXP1"]);
            graficoAndamento = Convert.ToDouble(dsAndamento.Tables[0].Rows[0]["EXP1"]);
            
                //dica: http://code.google.com/intl/pt-BR/apis/chart/docs/chart_wizard.html
                Label2.Text = string.Format("<img src='http://chart.apis.google.com/chart?chf=bg,s,F1F1F1&chs=300x150&cht=p&chd=t:{0},{1},{2}&chco=FF9900|3399CC|AA0033&chp=0.628&chl=Pendente ({0})|Andamento ({1})|Concluido ({2})&chtt=Situacao+dos+Atendimentos'' width='300' height='150' alt='' />", graficoPendente, graficoAndamento, graficoConcluido);
                Label3.Text = string.Format("<img src='http://chart.apis.google.com/chart?chf=bg,s,F1F1F1&chxl=0:|Pessimo|Bom|Excelente&chxp=0,0,50,100&chxs=0,676767,9,0,l,676767&chxt=y&chs=250x150&cht=gm&chd=t:{0}&chl= {1}%&chtt=Processos Pendentes(nao atendidos)' width='250' height='150' alt='' />", Convert.ToInt32(100 - ((graficoPendente / graficoTotal) * 100)), Convert.ToInt32((graficoPendente / graficoTotal) * 100));
                Label4.Text = string.Format("<img src='http://chart.apis.google.com/chart?chf=bg,s,F1F1F1&chxl=0:|Pessimo|Bom|Excelente&chxp=0,0,50,100&chxs=0,676767,9,0,l,676767&chxt=y&chs=250x150&cht=gm&chd=t:{0}&chl= {1}%&chtt=Processos Pendentes(em andamento)' width='250' height='150' alt='' />", Convert.ToInt32(100 - ((graficoAndamento / graficoTotal) * 100)), Convert.ToInt32((graficoAndamento / graficoTotal) * 100));
                Label5.Text = string.Format("<img src='http://chart.apis.google.com/chart?chf=bg,s,F1F1F1&chxl=0:|Pessimo|Bom|Excelente&chxp=0,0,50,100&chxs=0,676767,9,0,l,676767&chxt=y&chs=250x150&cht=gm&chd=t:{0}&chl= {0}%&chtt=Processos Concluidos' width='250' height='150' alt='' />", Convert.ToInt32((graficoConcluido / graficoTotal) * 100));
                //Label2.Text = string.Format("<img src='http://chart.apis.google.com/chart?chf=bg,s,F1F1F1&chs=425x165&cht=pc&chco=FF9900|3399CC|AA0033&chd=e:f7OoeG&chdl={0} Pendencias|{1} Concluindo|{2} Concluidos &chp=0&chl=Pendente|Andamento|Concluido&chtt=Situacao+dos+Atendimentos' />", graficoPendente, graficoAndamento, graficoConcluido);          
                //Label3.Text = string.Format("<img src='http://chart.apis.google.com/chart?chf=bg,s,F1F1F1&chxl=0:|Pessimo|Bom|Excelente&chxp=0,100,50,0&chxt=y&chs=325x185&cht=gm&chco=FF9900|3399CC|AA0033&chd=e:Ee&chdl={0}&chl=Pendente&chma=0,0,5&chtt=Analise+de+Desempenho' width='325' height='185' alt='Analise+de+Desempenho' />", graficoPendente);
                //Label4.Text = string.Format("<img src='http://chart.apis.google.com/chart?chf=bg,s,F1F1F1&chxl=0:|Pessimo|Bom|Excelente&chxp=0,100,50,0&chxt=y&chs=405x205&cht=gm&chco=FF9900|3399CC|AA0033&chd=s:E&chl=Pendente&chma=0,0,5&chtt=Analise de Desempenho' width='405' height='205' alt='Analise de Desempenho' />", graficoPendente, graficoAndamento, graficoConcluido);
        }
        
        private void GetSolicitacoes()
        {
            switch (RadioButtonList2.SelectedItem.Value)
            {
                case "0":
                    sSortFiltro = "SOLICITACAO_SITUACAO=0 OR SOLICITACAO_SITUACAO=2"; //PENDENTE
                    break;
                case "1":
                    sSortFiltro = "SOLICITACAO_SITUACAO=1"; //CONLUIDO
                    break;
                case "2":
                    sSortFiltro = "SOLICITACAO_SITUACAO=2"; //EM ANDAMENTO
                    break;
                case "3":
                    sSortFiltro = "SOLICITACAO_SITUACAO<3"; //TODAS AS SITUAÇÕES
                    break;
            }
            
            BLL.SOLICITACOES solicitacoes = new BLL.SOLICITACOES();

            GridView1.DataSource = solicitacoes.FindByWhere(sSortFiltro, sSortExpression, sSortDirection);
            GridView1.DataBind();

            totalRegistros = GridView1.Rows.Count;
            totalPages = ((totalRegistros - 1) / pageSize) + 1;

            if (currentPage > totalPages)
            {
                currentPage = totalPages;
                GetSolicitacoes();
                return;
            }

            //RadioButtonList2.SelectedItem.Text += String.Format(" ({0})", GridView1.Rows.Count);
            Label1.Text = String.Format("{1}: {0} |&nbsp;", GridView1.Rows.Count, RadioButtonList2.SelectedItem.Text);

            CurrentPageLabel.Text = currentPage.ToString();
            TotalPagesLabel.Text = totalPages.ToString();

            if (currentPage == totalPages)
                NextButton.Visible = false;
            else
                NextButton.Visible = true;

            if (currentPage == 1)
                PreviousButton.Visible = false;
            else
                PreviousButton.Visible = true;

            if (totalRegistros <= 0)
                NavigationPanel.Visible = false;
            else
                NavigationPanel.Visible = true;
        }
   
        protected void Page_Load(object sender, EventArgs e)
        {
            montaGrafico();
            //Verifica se usuario atual tem acesso
            if(!ValidarAcesso.Usuario("usuario"))
                Response.Redirect(@"~/AcessoRestrito.aspx?msg=tecnico");

            //Limita registros por página
            GridView1.PageSize = pageSize;

            //Chamando na primeira vez em que a página é carregada
            if (!IsPostBack)
            {
                GetSolicitacoes();
            }
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            Response.Redirect(@"WebForm1.aspx");
        }
        protected void btnConcluir_Click(object sender, EventArgs e)
        {
            if (btnConcluir.Text != "Gravar")
            {
                txtSituacao.Visible = false;
                RadioButtonList1.Visible = true;
                PanelConclusao.Visible = true;
                txtConclusao.ReadOnly = false;
                txtDataConclusao.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                RadioButtonList1.Items[1].Selected = true;
                this.btnAndamento.Visible = false;
                this.btnConcluir.Visible = true;
                this.btnConcluir.Text = "Gravar";
            }
            else if (txtConclusao.Text.Length > 0)
            {
                try
                {
                    TAB.SOLICITACOES campo = new TAB.SOLICITACOES();
                    BLL.SOLICITACOES cmd = new BLL.SOLICITACOES();

                    DataSet ds = new DataSet();
                    ds = cmd.FindBy_SOLICITACAO_ID(Convert.ToInt32(LabelCodigo.Text));
                    
                    campo.SOLICITACAO_ID = Convert.ToInt32(LabelCodigo.Text);
                    campo.SOLICITACAO_REMETENTE_NOME = ds.Tables[0].Rows[0]["SOLICITACAO_REMETENTE_NOME"].ToString();
                    campo.SOLICITACAO_REMETENTE_EMAIL = ds.Tables[0].Rows[0]["SOLICITACAO_REMETENTE_EMAIL"].ToString();
                    campo.SOLICITACAO_ASSUNTO = ds.Tables[0].Rows[0]["SOLICITACAO_ASSUNTO"].ToString();
                    campo.SOLICITACAO_DESCRICAO = ds.Tables[0].Rows[0]["SOLICITACAO_DESCRICAO"].ToString();
                    campo.SOLICITACAO_INCLUSAO = Convert.ToDateTime(ds.Tables[0].Rows[0]["SOLICITACAO_INCLUSAO"]);
                    campo.SOLICITACAO_SITUACAO = 1;

                    MembershipUser u = Membership.GetUser();
                    campo.SOLICITACAO_DESTINATARIO_EMAIL = u.Email; //ds.Tables[0].Rows[0]["SOLICITACAO_DESTINATARIO_EMAIL"].ToString();
                    campo.SOLICITACAO_CONCLUSAO = DateTime.Now;// Convert.ToDateTime("01/01/1900 00:00:00");
                    campo.SOLICITACAO_OBSERVACAO = txtConclusao.Text;

                    cmd.Update(campo, " SOLICITACAO_ID = " + campo.SOLICITACAO_ID.ToString() + " ");
                    
                    Panel1.Visible = false;
                    Panel2.Visible = true;
                    Response.Redirect(@"../listar/");
                }
                catch (Exception ex)
                {
                    LIB.MessageBox.Show("Falha no sistema: Impossível modificar o registro. " + ex.ToString());
                }

            }
            else
            {
                LIB.MessageBox.Show("É obrigatório informar a solução encontrada.");
            }
        }
        protected void btnAndamento_Click(object sender, EventArgs e)
        {
            RadioButtonList1.Visible = false;
            if (btnAndamento.Text != "Gravar")
            {
                txtSituacao.Visible = false;
                RadioButtonList1.Visible = true;
                PanelConclusao.Visible = true;
                txtConclusao.ReadOnly = false;
                txtDataConclusao.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                RadioButtonList1.Items[1].Selected = true;
                RadioButtonList2.Items[2].Selected = true;
                this.btnConcluir.Visible = false;
                this.btnAndamento.Visible = true;
                this.btnAndamento.Text = "Gravar";
            }
            else if (txtConclusao.Text.Length > 0)
            {
                try
                {
                    TAB.SOLICITACOES campo = new TAB.SOLICITACOES();
                    BLL.SOLICITACOES cmd = new BLL.SOLICITACOES();

                    DataSet ds = new DataSet();
                    ds = cmd.FindBy_SOLICITACAO_ID(Convert.ToInt32(LabelCodigo.Text));

                    campo.SOLICITACAO_ID = Convert.ToInt32(LabelCodigo.Text);
                    campo.SOLICITACAO_REMETENTE_NOME = ds.Tables[0].Rows[0]["SOLICITACAO_REMETENTE_NOME"].ToString();
                    campo.SOLICITACAO_REMETENTE_EMAIL = ds.Tables[0].Rows[0]["SOLICITACAO_REMETENTE_EMAIL"].ToString();
                    campo.SOLICITACAO_ASSUNTO = ds.Tables[0].Rows[0]["SOLICITACAO_ASSUNTO"].ToString();
                    campo.SOLICITACAO_DESCRICAO = ds.Tables[0].Rows[0]["SOLICITACAO_DESCRICAO"].ToString();
                    campo.SOLICITACAO_INCLUSAO = Convert.ToDateTime(ds.Tables[0].Rows[0]["SOLICITACAO_INCLUSAO"]);
                    campo.SOLICITACAO_SITUACAO = 2; //em andamento
                    MembershipUser u = Membership.GetUser();
                    campo.SOLICITACAO_DESTINATARIO_EMAIL = u.Email; //ds.Tables[0].Rows[0]["SOLICITACAO_DESTINATARIO_EMAIL"].ToString();
                    campo.SOLICITACAO_CONCLUSAO = DateTime.Now;
                    campo.SOLICITACAO_OBSERVACAO = ds.Tables[0].Rows[0]["SOLICITACAO_OBSERVACAO"].ToString() + txtConclusao.Text;

                    cmd.Update(campo, " SOLICITACAO_ID = " + campo.SOLICITACAO_ID.ToString() + " ");

                    Panel1.Visible = false;
                    Panel2.Visible = true;
                    Response.Redirect(@"../listar/");
                }
                catch (Exception ex)
                {
                    LIB.MessageBox.Show("Falha no sistema: Impossível modificar o registro. " + ex.ToString());
                }
            }
            else
            {
                LIB.MessageBox.Show("É obrigatório informar um texto para a situação em andamento.");
            }
        }
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            //criando o objeto do Cliente
            TAB.SOLICITACOES SOL = new TAB.SOLICITACOES();
            BLL.SOLICITACOES cmd = new BLL.SOLICITACOES();

            //adicionando os atributos
            SOL.SOLICITACAO_REMETENTE_EMAIL = "";

            //chamando a camada de Persistência para salvar os dados no banco
            if (cmd.InsertId(SOL)==0)
            {
                LIB.MessageBox.Show("Solicitação salva com sucesso!");
                GetSolicitacoes();
            }
            else
            {
                LIB.MessageBox.Show("Erro ao salvar Cliente. Favor tentar novamente.");
            }
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
           

        }
        protected void Button2_Click(object sender, EventArgs e)
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
                // FormasPagamentoBusiness.Excluir(FormasPagamento);

                // totalSaida = totalSaida + Decimal.Parse(row.Cells[5].Text.ToString());
                // totalEntrada = totalEntrada + Decimal.Parse(row.Cells[4].Text.ToString());
            }

            //Adicionando o método Listar contido no objeto empresaBusiness ao DataSOurce do GridView
            //gvFormasPagamento.DataSource = FormasPagamentoBusiness.Listar();

            //Preenchendo o GridView com a Lista retornada através do método Listar.
            //gvFormasPagamento.DataBind();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
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

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ImageButton addButton = (ImageButton)e.Row.Cells[1].Controls[1];
                addButton.CommandArgument = e.Row.RowIndex.ToString();
            }

        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //Marcos: apenas tecnicos podem visualizar os botões de ação
            if (!ValidarAcesso.Usuario("tecnico"))
            {
                if (e.Row.RowType == DataControlRowType.Header)
                {
                    e.Row.Cells[0].Visible = false;
                    e.Row.Cells[1].Visible = false;
                    e.Row.Cells[2].Visible = false;
                }
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    e.Row.Cells[0].Visible = false;
                    e.Row.Cells[1].Visible = false;
                    e.Row.Cells[2].Visible = false;
                }
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string nome = e.Row.Cells[10].Text;
                int pos = nome.IndexOf("@");
                //A partir do índice 5
                int pos2 = nome.IndexOf("@", pos);
                nome = nome.Substring(0, pos2);
                e.Row.Cells[10].Text = nome;

                //DateTime inicio = Convert.ToDateTime("01/09/2010 05:57:15");
                DateTime inicio = new DateTime();
                DateTime fim = new DateTime();
                TimeSpan diff;

                if (e.Row.Cells[11].Text != "" )
                    inicio = Convert.ToDateTime(e.Row.Cells[11].Text);
                else
                    inicio = DateTime.Now;

                if (Convert.ToDateTime(e.Row.Cells[12].Text) > Convert.ToDateTime(e.Row.Cells[11].Text))
                    if (e.Row.Cells[13].Text == "1")
                        fim = Convert.ToDateTime(e.Row.Cells[12].Text);
                    else
                        fim =DateTime.Now; 
                else
                {
                    fim = DateTime.Now;
                    e.Row.Cells[12].Text = "";
                }
                
                // Usando Subtract para calcular diferença de datas
                diff = fim.Subtract(inicio);
                ((Label)e.Row.FindControl("LabelPendenciaDias")).Text = String.Format("{0} dias.", diff.Days);
            }

            /*
            if (e.Row.RowType == DataControlRowType.DataRow)
                ((ImageButton)e.Row.FindControl("ImageButton1")).CommandArgument = e.Row.Cells[3].Text;

            if (e.Row.RowType == DataControlRowType.DataRow)
                ((ImageButton)e.Row.FindControl("ImageButton2")).CommandArgument = e.Row.Cells[3].Text;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Image img = (Image)e.Row.FindControl("image1");
                Boolean situcao = Convert.ToBoolean(e.Row.Cells[3].Text);
                switch (situcao) 
                {
                    case true:
                        img.ImageUrl = @"~/imagens/16x16/button-red.png";
                        img.Visible = true;
                        break;
                    case false:
                        img.ImageUrl = @"~/imagens/16x16/button-green.png";
                        img.Visible = true;
                        break;
                }
            }*/
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            

            //visualizar///////////////////////////////////////////////////////////////////////////////
            if (e.CommandName == "visualizar")
            {
                
                if (!ValidarAcesso.Usuario("_visualizar"))
                    MessageBox.Mostra("Você não tem permissão de " + e.CommandName);
                else
                {
                    int linha = Convert.ToInt32(e.CommandArgument);
                    GridViewRow row = GridView1.Rows[linha];
                    int id = Convert.ToInt32(GridView1.Rows[linha].Cells[5].Text);
                    TAB.SOLICITACOES tab = new TAB.SOLICITACOES();
                    BLL.SOLICITACOES bll = new BLL.SOLICITACOES();

                    DataSet ds = new DataSet();
                    ds = bll.FindBy_SOLICITACAO_ID(id);

                    if (ds != null)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            LabelCodigo.Text = GridView1.Rows[linha].Cells[5].Text;
                            txtRemetenteNome.Text = GridView1.Rows[linha].Cells[6].Text;
                            txtRemetenteEmail.Text = ds.Tables[0].Rows[0]["SOLICITACAO_REMETENTE_EMAIL"].ToString();
                            txtDestinatarioNome.Text = ds.Tables[0].Rows[0]["SOLICITACAO_DESTINATARIO_EMAIL"].ToString();
                            txtDestinatarioEmail.Text = ds.Tables[0].Rows[0]["SOLICITACAO_DESTINATARIO_EMAIL"].ToString();
                            txtAssunto.Text = ds.Tables[0].Rows[0]["SOLICITACAO_ASSUNTO"].ToString();
                            txtMensagem.Text = ds.Tables[0].Rows[0]["SOLICITACAO_DESCRICAO"].ToString();
                            txtInclusao.Text = ds.Tables[0].Rows[0]["SOLICITACAO_INCLUSAO"].ToString();

                            int situacao = Convert.ToInt32(ds.Tables[0].Rows[0]["SOLICITACAO_SITUACAO"]);
                            switch (situacao)
                            {
                                case 0:
                                    PanelConclusao.Visible = false;
                                    txtSituacao.Text = string.Format("Pendente em {0}<br />",DateTime.Now);
                                    btnConcluir.Visible = true;
                                    btnAndamento.Visible = true;
                                    break;
                                case 1:
                                    PanelConclusao.Visible = true;
                                    txtDataConclusao.Text = ds.Tables[0].Rows[0]["SOLICITACAO_CONCLUSAO"].ToString();
                                    txtConclusao.Text = ds.Tables[0].Rows[0]["SOLICITACAO_OBSERVACAO"].ToString();
                                    txtSituacao.Text = string.Format("Concluído em {0}<br />",DateTime.Now);
                                    btnConcluir.Visible = false;
                                    btnAndamento.Visible = false;
                                    break;
                                case 2:
                                    PanelConclusao.Visible = true;
                                    txtDataConclusao.Text = ds.Tables[0].Rows[0]["SOLICITACAO_CONCLUSAO"].ToString();
                                    txtConclusao.Text = ds.Tables[0].Rows[0]["SOLICITACAO_OBSERVACAO"].ToString();
                                    txtSituacao.Text = string.Format("Andamento em {0}<br />", DateTime.Now);
                                    btnConcluir.Visible = true;
                                    btnAndamento.Visible = true;
                                    break;
                            }

                            Panel1.Visible = true;
                            Panel2.Visible = false;
                            btnCancelar.Text = "Voltar";
                        }
                    }
                }
            }
            //apagar///////////////////////////////////////////////////////////////
            if (e.CommandName == "apagar")
            {
                if (!ValidarAcesso.Usuario("_apagar"))
                    MessageBox.Mostra("Você não tem permissão de " + e.CommandName);
                else
                {
                    int linha = Convert.ToInt32(e.CommandArgument);
                    GridViewRow row = GridView1.Rows[linha];
                    int id = Convert.ToInt32(GridView1.Rows[linha].Cells[5].Text);
                    TAB.SOLICITACOES tab = new TAB.SOLICITACOES();
                    BLL.SOLICITACOES bll = new BLL.SOLICITACOES();
                    bll.Delete("solicitacao_id=" + id);
                    GetSolicitacoes();

                    // pede confirmação
                    /*StringBuilder myScript = new StringBuilder("");
                    myScript.Append("<script type='text/javascript' language='javascript'>");
                    myScript.Append("var result = window.confirm('O registro " + id.ToString() + " será eliminado definitivamente. Continuar?');");
                    myScript.Append("__doPostBack('Confirmacao', result);");
                    myScript.Append("</script>");
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "msg", myScript.ToString(), false);
                    string eventTarget = (this.Request["__EVENTTARGET"] == null) ? string.Empty : this.Request["__EVENTTARGET"];
                    string eventArgument = (this.Request["__EVENTARGUMENT"] == null) ? string.Empty : this.Request["__EVENTARGUMENT"];

                    if (eventTarget == "Confirmacao")
                    {
                        if (eventArgument == "true")
                        {
                            try
                            {
                                bll.Delete("solicitacao_id=" + id);
                            }
                            catch
                            {
                                MessageBox.Show("Erro ao excluir registro. Favor tentar novamente.");
                            }
                            GetSolicitacoes();
                        }
                    }*/
                }
            }

            
            //modificar////////////////////////////////////////////////////////////
            if (e.CommandName == "modificar")
            {
                MessageBox.Show("Opção em desenvolvimento. Aguarde novas versões.");
            }

        }
        protected void GridView1_PageIndexChanging(Object sender, GridViewPageEventArgs e)
        {
            GetSolicitacoes();   
            GridView1.PageIndex = e.NewPageIndex;
            //GridView1.DataBind();
        }
        protected void GridView1_Sorting(Object sender, GridViewSortEventArgs e)
        {
           sSortDirection = GetSortDirection(e.SortExpression);
           sSortExpression = e.SortExpression;

           string colunaClassificacao = string.Empty;
           switch(sSortExpression)
           {
               case "SOLICITACAO_ID":
                   colunaClassificacao=GridView1.Columns[5].ToString();
                   break;
               case "SOLICITACAO_REMETENTE_NOME":
                   colunaClassificacao=GridView1.Columns[6].ToString();
                   break;
               case "SOLICITACAO_ASSUNTO":
                   colunaClassificacao=GridView1.Columns[8].ToString();
                   break;
               case "SOLICITACAO_DESTINATARIO_EMAIL":
                   colunaClassificacao=GridView1.Columns[10].ToString();
                   break;
               case "SOLICITACAO_INCLUSAO":
                   colunaClassificacao=GridView1.Columns[11].ToString();
                   break;
               case "SOLICITACAO_CONCLUSAO":
                   colunaClassificacao=GridView1.Columns[12].ToString();
                   break;
               default:
                   colunaClassificacao = sSortExpression;
                   break;
           }

            string colunaDirecao = string.Empty;
            switch(sSortDirection){
              case "ASC":
                 colunaDirecao = "crescente";
                 break;
              case "DESC":
                 colunaDirecao = "decrescente";
                 break;
             default:
                 colunaDirecao = sSortDirection;
                 break;
            }
            
            GetSolicitacoes();
            LabelClassificacao.Text = "Registros ordenados por <strong>" + colunaClassificacao.ToLower() + "</strong> em ordem <strong>" + colunaDirecao + "</strong> .<hr class='escondido' />";
        }
        
        protected void Button1_Click1(object sender, EventArgs e)
        {
            GetSolicitacoes();
        }
         
     
     }
}
