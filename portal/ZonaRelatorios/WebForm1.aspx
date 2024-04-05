<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.ZonaRelatorios.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="_paginaContent" >
    
    <h2>Relatórios adcionais</h2>
    <table border="0" cellpadding="0" cellspacing="0" width="100%">

    <tr>
    <td align="center"><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="sic.png" /></td>
    <td align="center"><asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="compufour.png" /></td>
    <td align="center"><asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="smallsoft.png" /></td>
    <td align="center"><asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="prosoft.png" /></td>
    </tr>

    <tr>
    <td align="center">SIC</td>
    <td align="center">COMPUFOUR</td>
    <td align="center">SMALLSOFT</td>
    <td align="center">PROSOFT</td>
    </tr>

    </table>
    <hr />
    Esta seção disponibiliza alguns relatórios que não existem em seus sistemas de origem.<br />
    Caso, você tenha alguma sugestão, entre em contato por email.
</div>
</asp:Content>
