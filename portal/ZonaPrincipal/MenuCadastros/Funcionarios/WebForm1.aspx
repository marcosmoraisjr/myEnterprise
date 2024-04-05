<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.MenuFuncionarios.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" 
        Text="Listar" CssClass="botao" 
        PostBackUrl="~/MenuFuncionarios/Lista/WebForm1.aspx" />
    <asp:Button ID="Button2" runat="server" 
        Text="Cadastrar" CssClass="botao" 
        PostBackUrl="~/MenuFuncionarios/Cadastro/WebForm1.aspx" />
    <asp:Button ID="Button3" runat="server" 
        Text="Aniversariantes" CssClass="botao" 
        PostBackUrl="~/MenuFuncionarios/Aniversariantes/WebForm1.aspx" />
</asp:Content>
