<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="portal.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<!--
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::                                                                      
SOLUÇÃO DESENVOLVIDA POR: 
- MARCOS MORAIS DE SOUSA
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
/--> 

<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" /> 
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" /> 
    <meta http-equiv="Cache-Control" content="no-cache" /> 
    <meta http-equiv="Expires" content="-1" /> 
	<meta http-equiv="Page-Exit" content="blendTrans(Duration=2)" />
	<link href="css/login.css" rel="stylesheet" type="text/css" />
    <title>Tudo em um só lugar | Enterprise</title>
    <script type="text/javascript">
        function desabilitar(object) {
            object.value = "Aguarde...";
            object.style.cursor = 'wait';
            object.disabled = false;
        }
    </script>
</head>
<body >
    <form id="form1" runat="server">
     
     <h1>Atenção: para acessar o sistema use seu novo nome de usuario e sua senha SIC</h1>
     
     <div id="_janela">
    
        <asp:Label ID="Label1" runat="server" Text="Login" CssClass="caption"></asp:Label>
        
        <div class="box">
        
            <strong class="titulo">
                Informe seu nome de usuário e <br />senha para acesso ao sistema.
            </strong>
            
            <hr class="escondido"/>
            
            <div class="icone">
                <asp:ImageButton ID="ImageButton1" runat="server" 
                    ImageUrl="~/imagens/128x128/lock.png"  />
            </div>

            <asp:Panel ID="Panel1" runat="server">
            <asp:Login ID="Login1" runat="server">
            <LayoutTemplate>
                <table border="0" cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                    <tr>
                        <td>
                            <table border="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Usuário:</asp:Label>
                                        <br />
                                        <asp:TextBox ID="UserName" runat="server" CssClass="shadyinput"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                            ControlToValidate="UserName" ErrorMessage="Nome de usuário é necessário." 
                                            ToolTip="Nome de usuário é necessário." ValidationGroup="Login1">*<br /> Nome de usuário é necessário</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Senha:</asp:Label>
                                        <br />
                                        <asp:TextBox ID="Password" runat="server" TextMode="Password" 
                                            CssClass="shadyinput"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                            ControlToValidate="Password" ErrorMessage="Senha é nescessária." 
                                            ToolTip="Senha é nescessária." ValidationGroup="Login1">* <br /> Senha é nescessária</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:LinkButton ID="LinkButton2" runat="server" 
                                            CommandArgument="usuarioNovo" 
                                            OnClick="PagerButtonClick">Novo usuário</asp:LinkButton>
                                            &nbsp;
                                        <asp:LinkButton ID="LinkButton1" runat="server" 
                                            CommandArgument="senhaLembrar" 
                                            OnClick="PagerButtonClick" Visible="False">Lembrar senha</asp:LinkButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" style="color:Red;">
                                        <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left">
                                        <asp:Button ID="LoginButton" runat="server" 
                                            onclientclick="desabilitar(this);" 
                                            UseSubmitBehavior="true"
                                            CommandName="Login" 
                                            Text="Entrar" 
                                            ValidationGroup="Login1" CssClass="botao" />
                                        <asp:Button ID="Button1" runat="server" 
                                            onclientclick="desabilitar(this);" 
                                            UseSubmitBehavior="true"
                                            Text="Cancelar" 
                                            CssClass="botao" 
                                            onclick="Button1_Click" />
                                        <asp:CheckBox ID="RememberMe" runat="server" Text="Lembrar da próxima vez." 
                                            Visible="False" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
        </asp:Login>
            </asp:Panel>
        
        </div>
    
         
    </div>
    
   <p style="text-align:center;">
      <br /><br />
      <strong>
          &nbsp;<asp:Image ID="Image1" runat="server" ImageUrl="~/css/img/icobr.gif"/>
          &nbsp;ENTERPRISE® 2010
      </strong>  
      <br /><br />
      ©2010 MMSTEC SOLUÇÕES EM INFORMÁTICA LTDA 
   </p>
    
    </form>
</body>
</html>
