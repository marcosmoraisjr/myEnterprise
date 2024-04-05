using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace portal.LIB
{
    public class EnderecoIP
    {
        /// <summary>
        /// Metodo estático para pegar o IP
        /// Quero que ele retorne o IP e o tipo ( se rede reservada, publica ou privada por exemplo )
        /// </summary>
        /// <param name="ShowIp()">mostra ip do usuário</param>
        /// <returns>string</returns>
        public static string getIP()
        {

            // Marcos: Conexão utilizando proxy
            string TerminalIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (TerminalIP == null)
            {
                TerminalIP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"]; //Marcos: Conexão sem utilizar proxy
            }

            if (TerminalIP.Substring(0, 2) == "10")
            {
                return TerminalIP;//10.0.0.0/8 Rede reservada 
            }
            else if (TerminalIP.Substring(0, 2) == "14")
            {
                return TerminalIP;//14.0.0.0/8 Rede Pública
            }
            else if (TerminalIP.Substring(0, 2) == "39")
            {
                return TerminalIP;//39.0.0.0/8 Rede Pública 
            }
            else if (TerminalIP.Substring(0, 3) == "127")
            {
                return TerminalIP + "(127.0.0.0/8 Rede Privada Localhost)";
            }
            else if (TerminalIP.Substring(0, 3) == "128")
            {
                return TerminalIP;//128.0.0.0/16 Reservado (IANA)  
            }
            else if (TerminalIP.Substring(0, 3) == "169")
            {
                return TerminalIP;//169.254.0.0/16 Zeroconf RFC 3927
            }
            else if (TerminalIP.Substring(0, 3) == "172")
            {
                return TerminalIP + "(172.16.0.0/12)Rede Privada RFC 1918)";
            }
            else if (TerminalIP.Substring(0, 3) == "191")
            {
                return TerminalIP;//191.255.0.0/16 Reservado (IANA) RFC 3330 
            }
            else if (TerminalIP.Substring(0, 3) == "192")
            {
                return TerminalIP;//192.0.0.0/24 Documentação RFC 3330
            }
            //else if (TerminalIP.Substring(0, 11) == "223.255.255")
            //{   
            //     
            //    return TerminalIP;//223.255.255.0/24 Reservado RFC 3330
            // }
            else if (TerminalIP.Substring(0, 3) == "224")
            {
                return TerminalIP; //224.0.0.0/4 Multicasts (antiga rede Classe D)
            }
            else if (TerminalIP.Substring(0, 3) == "240")
            {
                return TerminalIP; //240.0.0.0/4 Reservado (antiga rede Classe E) RFC 1700 
            }
            else if (TerminalIP == "255.255.255.255")
            {
                return TerminalIP;//255.255.255.255 Broadcast 
            }
            else
            {
                return "(" + TerminalIP + ")";
            }
        }
    }
}
