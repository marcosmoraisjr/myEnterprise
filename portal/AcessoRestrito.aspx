<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcessoRestrito.aspx.cs" Inherits="portal.AcessoRestrito" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta http-equiv="Page-Exit" content="blendTrans(Duration=0)" />
	
	<link href="css/Login.css" rel="stylesheet" type="text/css" />

    <script src="js/metodos.js" type="text/javascript"></script>
	
    <title>ENTERPRISE | RETRIÇÃO DE ACESSO</title>
    
</head>
<body>
    <form id="form1" runat="server">
    
     <h1>Você 
         <asp:Label ID="Label2" runat="server" Text="não não tem permissão para a sessão requisitada, "></asp:Label>
          portanto não pode visualizar esta página</h1>
     <div id="_janela">
        <asp:Label ID="Label1" runat="server" Text="Acesso Restrito" CssClass="caption"></asp:Label>
        <div class="box">
            <asp:Panel ID="Logout1" runat="server">
                <strong class="titulo">
                Você 
                <asp:Label ID="LabelPerfilRestrito" runat="server" Text="não não tem permissão para a sessão requisitada, "></asp:Label>
                portanto não pode visualizar esta página. <br /><br />
          
                Em caso de dúvidas, entre em contato com o administrador do sistema
                <br /><br />
                Para voltar a usar o sistema, clique em continuar.</strong>
                <hr class="escondido"/>
                <div class="icone">
                    <asp:ImageButton ID="ImageButton1" runat="server" 
                    ImageUrl="~/imagens/128x128/alert.png"  />
                </div>
            
             <br />
            <asp:Button ID="Button1" runat="server" 
                Text="Continuar" CssClass="botaoVerde" 
                PostBackUrl="~/" />
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
