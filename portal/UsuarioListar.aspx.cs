using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace portal
{
    public partial class UsuarioOnline : System.Web.UI.Page
    {

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
            
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Image img = (Image)e.Row.FindControl("image1");
                //switch (e.Row.Cells[0].Text.ToLower()) 
                switch(user.IsOnline)
                {
                    case true:
                        img.ImageUrl = @"~/imagens/mini-icoverde.png";
                        img.Visible = true;
                        break;
                }
            }


            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lbl = (Label)e.Row.FindControl("LabelIP");
                lbl.Text = Request.UserHostAddress.ToString();
            }

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
                        e.Row.Cells[2].Text += s +"<br />";
                    }
                    /*Array.ForEach(userRoles, delegate(string s)
                    {
                        e.Row.Cells[2].Text += s+"<br />";
                    });*/
                    //e.Row.Cells[2].Text = userRoles[0];
                }
            }
           
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
             if (!Page.IsPostBack)
                  GetUsers();
        }
    }
}
