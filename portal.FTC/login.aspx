<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Portal.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<!--
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::                                                                      
SOLUÇÃO DESENVOLVIDA POR: 
- MARCOS MORAIS DE SOUSA
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
/--> 

<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta http-equiv="Page-Exit" content="blendTrans(Duration=0)" />
	<style type="text/css" media="screen">@import url("css/estilo.css");</style>
    <title>Tudo em um só lugar | Centro Virtual de Arquivos</title>
</head>

<body>
    <form id="form1" runat="server">
    <div id="_login">
        <div class="box">
        <asp:TextBox ID="TextBox1" class="shadyinput" runat="server"></asp:TextBox>
        <br /><br /><br />
        <asp:TextBox ID="TextBox2" class="shadyinput" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button  ID="Button1" class="botao" runat="server" Text="Entrar" 
                onclick="Button1_Click" />
        <asp:Button  ID="Button2" class="botao" runat="server" Text="Sair" PostBackUrl="~/default.aspx" />
        </div>
    </div>
    </form>
</body>
</html>
