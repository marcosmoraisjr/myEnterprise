using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net.NetworkInformation;

namespace portal.LIB
{
    public class VerificarURL
    {
        private bool Ping(string _host)
        {
            System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            System.Net.NetworkInformation.PingReply pr;
            pr = p.Send(_host.Trim());
            if (pr.Status == System.Net.NetworkInformation.IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Ping2(string _host)
        {
            bool retorno = false;
            PingReply reply = null;
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            Ping p = new Ping();
            for (int n = 1; n < 255 && (reply == null || reply.Status != IPStatus.Success); n++)
            {
                options.Ttl = n;
                reply = p.Send(_host, 1000, new byte[1], options);
                if (reply.Address != null)
                {
                    // Console.WriteLine(n.ToString() + " : " + reply.Address.ToString());
                    retorno = true;
                }
                else
                {
                    // Console.WriteLine(n.ToString() + " : <null>");
                    retorno = false;
                }
            }
            return retorno;
        }
    }
}
