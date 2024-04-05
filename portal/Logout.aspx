<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="portal.logout" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta http-equiv="Page-Exit" content="blendTrans(Duration=0)" />
	
	<link href="css/Login.css" rel="stylesheet" type="text/css" />

    <script src="js/metodos.js" type="text/javascript"></script>
	
    <title>ENTERPRISE | LOGOUT</title>
    
</head>
<body>
    <form id="form1" runat="server">
    
     <h1>Atenção: para acessar o sistema use seu novo nome de usuario e sua senha SIC</h1>
     <div id="_janela">
        <asp:Label ID="Label1" runat="server" Text="Logout" CssClass="caption"></asp:Label>
        <div class="box">
            <asp:Panel ID="Logout1" runat="server">
                <strong class="titulo">
                A sua sessão foi encerrada.
                <br /><br />
                Para voltar a usar o sistema, efetue o login novamente.</strong>
                <hr class="escondido"/>
                <div class="icone">
                    <asp:ImageButton ID="ImageButton1" runat="server" 
                    ImageUrl="~/imagens/128x128/alert.png"  />
                </div>
            
             <br />
            <asp:Button ID="Button1" runat="server" 
                Text="Login" CssClass="botaoLaranja" 
                PostBackUrl="~/Default.aspx" />
            </asp:Panel>
        </div>
     </div>
     
     <div id="_rodape">
              <p style="text-align:center;">
              <br /><br />
              <strong>
                  &nbsp;<asp:Image ID="Image4" runat="server" ImageUrl="~/css/img/icobr.gif"/>
                  &nbsp;ENTERPRISE® 2010
              </strong>  
              <br /><br />
              ©2010 MMSTEC SOLUÇÕES EM INFORMÁTICA LTDA 
              </p>
    </div>
    
    </form>
</body>
</html>
