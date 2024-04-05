using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text; 
using System.Web.UI;
using System.Web.Security;
using System.Collections;

namespace portal.LIB
{
    /// <summary> 
    /// Shows a client-side JavaScript alert in the browser. 
    /// </summary> 
    public class MessageBox
    {
        protected static Hashtable handlerPages = new Hashtable();

        private MessageBox()
        {
        }

        /// <summary> 
        /// Mostra um alerta de JavaScript do lado do cliente no navegador. 
        /// </summary> 
        /// <param name="message">A mensagem que aparece no alerta.</param> 
        public static void Show(string message)
        {
            // Limpa a mensagem para autorizar aspas simples
            string cleanMessage = message.Replace("'", "\'");
            string script = "<script type='text/javascript'>alert('" + cleanMessage + "');</script>";

            // Obtém a página web execução
            Page page = HttpContext.Current.CurrentHandler as Page;

            // Verifica se o manipulador é uma página e que o script não é allready na página 
            if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
            {
                page.ClientScript.RegisterClientScriptBlock(typeof(MessageBox), "alert", script);
            }
        }

        /// <summary> 
        /// Mostra um alerta de JavaScript do lado do cliente no navegador. 
        /// </summary> 
        /// <param name="message">A mensagem que aparece no alerta.</param> 
        public static void Mostra(string Message)
        {
            if (!(handlerPages.Contains(HttpContext.Current.Handler)))
            {
                Page currentPage = (Page)HttpContext.Current.Handler;
                if (!((currentPage == null)))
                {
                    Queue messageQueue = new Queue();
                    messageQueue.Enqueue(Message);
                    handlerPages.Add(HttpContext.Current.Handler, messageQueue);
                    currentPage.Unload += new EventHandler(CurrentPageUnload);
                }
            }
            else
            {
                Queue queue = ((Queue)(handlerPages[HttpContext.Current.Handler]));
                queue.Enqueue(Message);
            }
        }
        private static void CurrentPageUnload(object sender, EventArgs e)
        {
            Queue queue = ((Queue)(handlerPages[HttpContext.Current.Handler]));
            if (queue != null)
            {
                StringBuilder builder = new StringBuilder();
                int iMsgCount = queue.Count;
                builder.Append("<script language='javascript'>");
                string sMsg;
                while ((iMsgCount > 0))
                {
                    iMsgCount = iMsgCount - 1;
                    sMsg = System.Convert.ToString(queue.Dequeue());
                    sMsg = sMsg.Replace("\"", "'");
                    builder.Append("alert( \"" + sMsg + "\" );");
                }
                builder.Append("</script>");
                handlerPages.Remove(HttpContext.Current.Handler);
                HttpContext.Current.Response.Write(builder.ToString());
            }
        }
    }
}