<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.ZonaPrincipal.MenuInformacao.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div id="_paginaContent" >
    
    <h2>Informações e notícias de última hora</h2>
    <table border="0" cellpadding="0" cellspacing="0" width="100%">

    <tr>
    <td align="center"><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imagens/128x128/aniversario.png" Enabled="false" /></td>
    <td align="center"><asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/imagens/128x128/mundo.png" 
        PostBackUrl="Mundo/WebForm1.aspx?dst=mundo" /></td>
    <td align="center"><asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/imagens/128x128/esporte.png" 
        PostBackUrl="Mundo/WebForm1.aspx?dst=esportes"/></td>
    <td align="center"><asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/imagens/128x128/economia.png" 
        PostBackUrl="Mundo/WebForm1.aspx?dst=economia" /></td>
    </tr>

    <tr>
        <td align="center">Aniversariantes</td>
        <td align="center">Mundo</td>
        <td align="center">Esporte</td>
        <td align="center">Econômia</td>
    </tr>

    <tr>
    <td align="center"><asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/imagens/128x128/tecnologia.png" 
        PostBackUrl="Mundo/WebForm1.aspx?dst=tecnologia" /></td>
    <td align="center"><asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/imagens/128x128/curso.png" 
        PostBackUrl="Mundo/WebForm1.aspx?dst=concurso" /></td>
    <td align="center"></td>
    <td align="center"></td>
    
    </tr>
    
    <tr>
        <td align="center">Tecnologia</td>
        <td align="center">Concursos</td>
        <td align="center"></td>
        <td align="center"></td>
    </tr>
    </table>
  
</div>

</asp:Content>
