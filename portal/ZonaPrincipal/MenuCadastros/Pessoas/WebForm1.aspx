<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.ZonaPrincipal.MenuCadastros.Pessoas.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <style type="text/css">
        .style1
        {
            width: 200px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
  <div id="_paginaContent">
     <h2>CADASTRO DE PESSOA</h2>
     <table width="100%">
            <tr valign="top">
                <td class="style1">
                    ID:</td><td>
                    <asp:TextBox ID="txtID" runat="server" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr valign="top">
                <td class="style1">
                    CODIGO:</td><td>
                    <asp:TextBox ID="txtCODIGO" runat="server" Width="280px"></asp:TextBox>
                </td>
            </tr>
      </table>
  </div>
  
</asp:Content>
