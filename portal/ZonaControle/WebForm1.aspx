<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.WebForm1" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="_paginaContent">
    <h2>PAINEL DE CONTROLE</h2>    
        <asp:Button ID="Button1" runat="server" Text="Favoritos"        CssClass="botao100" PostBackUrl="~/ZonaControle/Favoritos/" />
        <asp:Button ID="Button2" runat="server" Text="Sistemas"         CssClass="botao100" PostBackUrl="~/ZonaControle/Sistemas/" />
        <asp:Button ID="Button3" runat="server" Text="Downloads"        CssClass="botao100" PostBackUrl="~/ZonaControle/Downloads/" />
        <asp:Button ID="Button7" runat="server" Text="Auditoria"        CssClass="botao100" PostBackUrl="~/ZonaControle/Auditoria/" Enabled="false" />
        <asp:Button ID="Button4" runat="server" Text="Usuários"         CssClass="botao100" PostBackUrl="~/ZonaControle/Usuarios/" />
        <br /><br /><br />
    </div>
    
</asp:Content>
