using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace portal.ZonaControle.Usuarios
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        void Roles_DataBind()
        {
            ListBox2.DataSource = Roles.GetAllRoles();
            ListBox2.DataBind();
        }
        
        int pageSize = 20;
        int totalUsers;
        int totalPages;
        int currentPage = 1;

        private void GetUsers()
        {
            UsersOnlineLabel.Text = Membership.GetNumberOfUsersOnline().ToString();

            UserGrid.DataSource = Membership.GetAllUsers(currentPage - 1, pageSize, out totalUsers);
            
            
            totalPages = ((totalUsers - 1) / pageSize) + 1;

            // Ensure that we do not navigate past the last page of users.

            if (currentPage > totalPages)
            {
                currentPage = totalPages;
                GetUsers();
                return;
            }

            UserGrid.DataBind();
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

            if (totalUsers <= 0)
                NavigationPanel.Visible = false;
            else
                NavigationPanel.Visible = true;
        }
        
        public void NextButton_OnClick(object sender, EventArgs args)
        {
            currentPage = Convert.ToInt32(CurrentPageLabel.Text);
            currentPage++;
            GetUsers();
        }
        public void PreviousButton_OnClick(object sender, EventArgs args)
        {
            currentPage = Convert.ToInt32(CurrentPageLabel.Text);
            currentPage--;
            GetUsers();
        }

        protected void UserGrid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
           string userName = e.Row.Cells[1].Text;
           MembershipUser user = Membership.GetUser(userName);        

           /*if (e.Row.RowType == DataControlRowType.DataRow)
           {
               Image img = (Image)e.Row.FindControl("image1");
               //switch (e.Row.Cells[0].Text.ToLower()) 
               switch (user.IsOnline)
               {
                   case true:
                       img.ImageUrl = @"~/imagens/mini-icoverde.png";
                       img.Visible = true;
                       break;
               }
           }*/

           if (e.Row.RowType == DataControlRowType.DataRow)
           {
               String[] userRoles = Roles.GetRolesForUser(user.UserName);
               if (userRoles.Length == 0)
               {
                   e.Row.Cells[2].Text = "Indefinido";
               }
               else
               {
                   foreach (String s in userRoles)
                   {
                       e.Row.Cells[2].Text += s + "<br />";
                   }
               }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                ListBox1.DataSource = Membership.GetAllUsers();
                ListBox1.DataBind();
                Roles_DataBind();
                GetUsers();

                //lista funções disponíveis
                CheckBoxListRoles.DataSource = Roles.GetAllRoles();
                //CheckBoxListRoles.DataTextField = "TipoVenda";
                //CheckBoxListRoles.DataValueField = "controle";
                CheckBoxListRoles.RepeatDirection = RepeatDirection.Horizontal;
                CheckBoxListRoles.RepeatColumns = 4;
                CheckBoxListRoles.DataBind();
            }
        }
        protected void RoleAdicionar_Click(object sender, EventArgs e)
        {
            Roles.CreateRole(TextBox1.Text);
            Roles_DataBind();
        }
        protected void RoleRemover_Click(object sender, EventArgs e)
        {
            Roles.CreateRole(TextBox1.Text);
            Roles_DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Roles.AddUserToRole(ListBox1.SelectedItem.Text, ListBox2.SelectedItem.Text);
            ListBox3.DataSource = Roles.GetRolesForUser(ListBox1.SelectedItem.Text);
            ListBox3.DataBind();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Roles.RemoveUserFromRole(ListBox1.SelectedItem.Text, ListBox2.SelectedItem.Text);
            ListBox3.DataSource = Roles.GetRolesForUser(ListBox1.SelectedItem.Text);
            ListBox3.DataBind();
        }
        protected void ButtonExcluirUsuario_Click(object sender, EventArgs e)
        {
            Membership.DeleteUser(ListBox1.SelectedItem.Text);
            ListBox1.DataSource = Membership.GetAllUsers();
            ListBox1.DataBind();
        }
        protected void ButtonFuncoesDoUsuario_Click(object sender, EventArgs e)
        {
            ListBox3.DataSource = Roles.GetRolesForUser(ListBox1.SelectedItem.Text);
            ListBox3.DataBind();
            Label1.Text = "";
            String[] lista = Roles.GetRolesForUser(ListBox1.SelectedItem.Text);
            for (int i = 0; i < lista.Count(); i++)
            {
                Label1.Text += "<br />" + lista[i].ToString().ToUpper();
            }

        }
    }
}
