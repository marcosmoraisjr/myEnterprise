<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="portal.MenuFerramentas.BuscaCEP.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
        <br />
        <asp:LinkButton ID="LinkButton28" runat="server" onclick="opcao_Click" CommandArgument="cep">Pesquisar por CEP</asp:LinkButton>
        &nbsp;|  
        <asp:LinkButton ID="LinkButton29" runat="server" onclick="opcao_Click" CommandArgument="logradouro">Pesquisar por Logradouro e Cidade</asp:LinkButton>
        <br />
        <br />
        Logradouro:<br />
        <asp:TextBox ID="TextBoxLogradouro" runat="server"></asp:TextBox><br />
        Cidade:<br />
        <asp:TextBox ID="TextBoxCidade" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button runat="server" ID="ButtonConsulta" Text="Consultar" onclick="ButtonConsulta_Click" /> 
        <hr />
        <asp:Label ID="Label1" runat="server" Text="Resultado" Visible="false"></asp:Label>
</asp:Content>
