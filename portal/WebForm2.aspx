<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="portal.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <script src="js/metodos.js" type="text/javascript"></script>
    <script type="text/javascript">
        function desabilitar(object) {
            window.status = "Aguarde...";
            document.body.style.cursor = 'wait';
            object.value = "Aguarde...";
            object.style.cursor = 'wait';
            object.disabled = true;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Button ID="ButtonProdutos" runat="server" AccessKey="4" 
        CssClass="" 
        onclientclick="desabilitar(this);" 
        UseSubmitBehavior="False"
        PostBackUrl="~/" 
        Text="Principal - teste1" 
        ToolTip="Atalho: ALT+4" />
        
        
        <asp:Button ID="Button2" runat="server" AccessKey="4" 
        CssClass="" onkeydown="desabilitar(this);" 
        PostBackUrl="~/" 
        Text="Principal - teste2" 
        ToolTip="Atalho: ALT+4" />
        
    </div>
    </form>
</body>
</html>
