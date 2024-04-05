using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Profile;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Collections.Specialized;
using portal.BLL;
using System.Text;
using portal.LIB;

namespace Portal
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {

        //MARCOS: 
        //Trabalhando com propriedades, funções e atributos da Master Page.
        //COLOQUE NA PAGINA FILHO: <%@ MasterType VirtualPath="~/MasterPage.master" %>
        //COLOQUE NO LOAD DA PAGINA FILHO: Master.TituloPage = "ENTERPRISE | BARRETO MAT DE CONSTRUÇÃO";
        private String Titulo;
        public String TituloPage
        {
            get { return Titulo; }
            set { Titulo = value; }
        }


        //CAPTURAR O NOME DO OBETO .NET DE MODO QUE POSSIBILITE TRABALHAR COM JAVASCRIPT
        public void RenderJSArrayWithCliendIds(params Control[] wc)
        {
            if (wc.Length > 0)
            {
                StringBuilder arrClientIDValue = new StringBuilder();
                StringBuilder arrServerIDValue = new StringBuilder();

                // Get a ClientScriptManager reference from the Page class.
                ClientScriptManager cs = Page.ClientScript;

                // Now loop through the controls and build the client and server id's
                for (int i = 0; i < wc.Length; i++)
                {
                    arrClientIDValue.Append("\"" + wc[i].ClientID + "\",");
                    arrServerIDValue.Append("\"" + wc[i].ID + "\",");
                }
                // Register the array of client and server id to the client
                cs.RegisterArrayDeclaration("MyClientID", arrClientIDValue.ToString().Remove(arrClientIDValue.ToString().Length - 1, 1));
                cs.RegisterArrayDeclaration("MyServerID", arrServerIDValue.ToString().Remove(arrServerIDValue.ToString().Length - 1, 1));
                // Now register the method GetClientId, used to get the client id of tthe control
                cs.RegisterStartupScript(this.Page.GetType(), "key", "\nfunction GetClientId(serverId)\n{\nfor(i=0; i<MyServerID.length; i++)\n{\nif ( MyServerID[i] == serverId )\n{\nreturn MyClientID[i];\nbreak;\n}\n}\n}", true);
            }
        }

        private DataTable LoadFolder(DropDownList gv_arquivos, String folder)
        {
          
            gridProfiles.DataSource = ProfileManager.GetAllProfiles(ProfileAuthenticationOption.Anonymous);
            gridProfiles.DataBind();

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
                dr["Caminho"] = "listar.aspx?pasta=/" + dir.Name;
                dr["Nome"] = dir.Name;
                dr["Tamanho"] = "-";
                dr["Tipo"] = "Diretório";
                dr["Modificado"] = dir.LastWriteTime.ToString("dd/MM/yyyy");
                dt.Rows.Add(dr);
            }
            return dt;

        }
        
        //MARCOS: MenuTab
        protected void MenuTab_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "tab1":
                    MultiView1.ActiveViewIndex = 0;
                    break;
                case "tab2":
                    MultiView1.ActiveViewIndex = 1;
                    break;
                //case "tab3":
                //    MultiView1.ActiveViewIndex = 2;
                //    break;
            }
        }

        //MARCOS: Menu
        protected void Menu_Click(Object sender, EventArgs e)
        {
            string arg =  ((LinkButton)sender).CommandArgument;
            switch (arg)
            {
                case "principal":
                    Response.Redirect(@"~/");
                    break;
                
                case "empresa":
                    Response.Redirect(@"~/ZonaPrincipal/MenuInstitucional/empresa/");
                    break;
                case "missao":
                    Response.Redirect(@"~/ZonaPrincipal/MenuInstitucional/missao/");
                    break;
                case "visao":
                    Response.Redirect(@"~/ZonaPrincipal/MenuInstitucional/visao/");
                    break;
               case "documento":
                    Response.Redirect(@"~/ZonaPrincipal/MenuInstitucional/documentos/");
                    break;

                case "mundo":
                    Response.Redirect(@"~/ZonaPrincipal/MenuInformacao/Mundo/WebForm1.aspx?dst=mundo");
                    break;
                case "esporte":
                    Response.Redirect(@"~/ZonaPrincipal/MenuInformacao/Mundo/WebForm1.aspx?dst=esporte");
                    break;
                case "economia":
                    Response.Redirect(@"~/ZonaPrincipal/MenuInformacao/Mundo/WebForm1.aspx?dst=economia");
                    break;
                case "tecnologia":
                    Response.Redirect(@"~/ZonaPrincipal/MenuInformacao/Mundo/WebForm1.aspx?dst=tecnologia");
                    break;
                case "concurso":
                    Response.Redirect(@"~/ZonaPrincipal/MenuInformacao/Mundo/WebForm1.aspx?dst=concurso");
                    break;

                case "solicitarSuporte":
                    Response.Redirect(@"~/ZonaPrincipal/MenuSuporte/Suporte/");
                    break;
                case "solicitarWebsite":
                    Response.Redirect(@"~/ZonaPrincipal/MenuSuporte/WebSite/");
                    break;
                case "solicitarOutra":
                    Response.Redirect(@"~/ZonaPrincipal/MenuSuporte/Outra/");
                    break;
                case "solicitarLista":
                    Response.Redirect(@"~/ZonaPrincipal/MenuSuporte/Listar/");
                    break;

                case "enviaremail":
                    Response.Redirect(@"~/ZonaPrincipal/MenuEmail/SendMail/");
                    break;
                case "enviarsms":
                    Response.Redirect(@"~/ZonaPrincipal/MenuEmail/SendSMS/");
                    break;
                case "batepapo":
                    Response.Redirect(@"http://partnerpage.google.com/barretoconstrucao.com.br");
                    break;
                case "painel":
                    Response.Redirect(@"~/ZonaControle/");
                    break;
                
                case "relatorios":
                    Response.Redirect(@"~/ZonaRelatorios/");
                    break;

                case "ferramentas":
                    Response.Redirect(@"~/ZonFerramentas/");
                    break;
                case "buscarcep":
                    Response.Redirect(@"~/ZonaFerramentas/BuscaCEP/");
                    break;

                case "trocarusuario":
                    Response.Redirect("~/logout.aspx");
                    break;
                }
        }

        //MARCOS: opções do conteudo
        protected void ButtonSistemas_Click(object sender, EventArgs e)
        {
            Response.Redirect(DropDownListSistemas.SelectedValue);
        }
        protected void ButtonFavoritos_Click(object sender, EventArgs e)
        {
            Response.Redirect(DropDownListFavoritos.SelectedValue);
        }
        protected void ButtonDownloads_Click(object sender, EventArgs e)
        {
            Response.Redirect(DropDownListDownloads.SelectedValue);
        }
        
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }

        //MARCOS: identifica o navegador usado
        protected void verificaBrowser()
        {
            if (Request.Browser.IsBrowser("IE"))
            {
                PanelAviso.Visible = true;
            }
            else if (Request.Browser.IsBrowser("Gecko"))  // Firefox, Mozilla "Seamonkey" e compatíveis
            {
                PanelAviso.Visible = false;
            }
            else if (Request.Browser.IsBrowser("Netscape"))
            {
                PanelAviso.Visible = true;
            }
            else
            {
                PanelAviso.Visible = false;
            }
        }

        //MARCOS: carregando a página
        protected void Page_Load(object sender, EventArgs e)
        {

            MembershipUser user = Membership.GetUser();
            string[] userRoles = Roles.GetRolesForUser(user.UserName);
            if (userRoles.Length == 0)
            {
                Response.Redirect(@"~/logout.aspx");
            }

            //MARCOS: identifica o TABMENU selecionado
            MenuTab.Items[MultiView1.ActiveViewIndex].Selected = true;
            //MARCOS: identifica o navegador usado
            verificaBrowser();
            //MARCOS: chama relogio javascript
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "xx", "mostradata()", true);
            if (!IsPostBack)
            {
                try
                {
                    portal.BLL.FAVORITOS favoritos = new FAVORITOS();
                    //MARCOS: lê o banco e pega os registros da tabela favoritos para popular o dropdownlist
                    
                    if (!ValidarAcesso.Usuario("usuario"))
                        DropDownListDownloads.DataSource = favoritos.FindAll("FAVORITO_DESCRICAO");
                    else
                        DropDownListFavoritos.DataSource = favoritos.FindByWhere("FAVORITO_ATIVO='1'", "FAVORITO_DESCRICAO");

                    DropDownListFavoritos.DataTextField = "FAVORITO_DESCRICAO";
                    DropDownListFavoritos.DataValueField = "FAVORITO_LINK";
                    DropDownListFavoritos.DataBind();
                }
                catch
                {
                }

                try
                {
                    //MARCOS: lê o banco e pega os registros da tabela favoritos para popular o dropdownlist
                    portal.BLL.SISTEMAS sistemas = new SISTEMAS();
                    
                    if (!ValidarAcesso.Usuario("usuario"))
                        DropDownListDownloads.DataSource = sistemas.FindAll("SISTEMA_DESCRICAO");
                     else
                        DropDownListSistemas.DataSource = sistemas.FindByWhere("SISTEMA_ATIVO='1'", "SISTEMA_DESCRICAO");
                    
                    DropDownListSistemas.DataTextField = "SISTEMA_DESCRICAO";
                    DropDownListSistemas.DataValueField = "SISTEMA_LINK";
                    DropDownListSistemas.DataBind();
                }
                catch
                {
                }

                try
                {
                    //MARCOS: lê o diretório de arquivos e popula o dropdownlist
                    portal.BLL.DOWNLOADS downloads = new DOWNLOADS();
                    
                    if (!ValidarAcesso.Usuario("usuario"))
                        DropDownListDownloads.DataSource = downloads.FindAll("DOWNLOAD_DESCRICAO");
                    else
                        DropDownListDownloads.DataSource = downloads.FindByWhere("DOWNLOAD_ATIVO='1'", "DOWNLOAD_DESCRICAO");
                    
                    DropDownListDownloads.DataTextField = "DOWNLOAD_DESCRICAO";
                    DropDownListDownloads.DataValueField = "DOWNLOAD_LINK";
                    DropDownListDownloads.DataBind();
                }
                catch
                {
                }

                try
                {
                    portal.BLL.EMPRESAS empresa = new portal.BLL.EMPRESAS();
                    DataSet ds                  = new DataSet();
                    ds                          = empresa.FindAll("EMPRESA_NOME_FANTASIA");

                    Label _LabelData            = (Label)LoginView1.FindControl("LabelData");
                    _LabelData.Text             = String.Format("Hojé é {0} Hrs.", DateTime.Now.ToLongDateString()+" - "+ DateTime.Now.ToString("hh:mm"));

                    Label _LabelUsuEmpresa      = (Label)LoginView2.FindControl("LabelUsuEmpresa");
                    Label _LabelUsoLoginNome    = (Label)LoginView2.FindControl("LabelUsoLoginNome");
                    Label _LabelUsuAcesso       = (Label)LoginView2.FindControl("LabelUsuAcesso");
                    Label _LabelUsuIP           = (Label)LoginView2.FindControl("LabelUsoIP");
                    LinkButton _LinkButtonUsuOnlineTotal = (LinkButton)LoginView2.FindControl("LinkButtonUsuOnlineTotal");

                    _LabelUsuEmpresa.Text = String.Format("<small style='color:Black;'>{0}</small>", ds.Tables[0].Rows[0]["EMPRESA_NOME_FANTASIA"].ToString());
                    _LabelUsoLoginNome.Text = String.Format("<br />Seu nome de usuário:<br><small style='color:Blue;'> {0}</small>", Membership.GetUser().ToString().ToUpper());
                    _LabelUsuIP.Text = String.Format("Seu registro na rede:<br> <small style='color:Blue;'>{0}</small>", Request.UserHostAddress);
                    _LabelUsuAcesso.Text = String.Format("Seu último acesso:<br> <small style='color:Blue;'>{0}</small>", Membership.GetUser().LastLoginDate.ToString("dddd - dd/MM/yyyy hh:mm:ss").ToUpper());
                    
                    int totalUsuarios = Membership.GetNumberOfUsersOnline();
                    if (totalUsuarios > 1)
                        _LinkButtonUsuOnlineTotal.Text = String.Format("<small style='color:Black;'>Atualmente existem <strong>{0}</strong> usuários no sistema</small><br />", totalUsuarios.ToString().ToUpper());
                    else
                        _LinkButtonUsuOnlineTotal.Text = String.Format("<small style='color:Black;'>Atualmente existe <strong>{0}</strong> usuário no sistema</small><br />", totalUsuarios.ToString().ToUpper());
                }
                catch
                {
                    
                }
                
            }
        }
 
    }
}
