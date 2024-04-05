using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;


namespace portal.LIB
{
    public class ValidarAcesso
    {
        private ValidarAcesso()
        {
        }

        //Marcos: rotina que garante acesso apenas a usuarios autorizados
        public static Boolean Usuario(String role)
        {
            MembershipUser user = Membership.GetUser();
            String[] userRoles = Roles.GetRolesForUser(user.UserName);
            foreach (String s in userRoles)
            {
                if (s.ToLower() == role.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
