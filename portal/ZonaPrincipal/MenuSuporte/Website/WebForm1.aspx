<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.ZonaPrincipal.MenuSuporte.WebSite.WebForm1" %>
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
    <h2>SOLICITAÇÃO DE ACESSO A WEBSITE</h2>
    
    <asp:Panel ID="Panel1" runat="server">
        <table width="100%">
            <tr valign="top">
                <td class="style1">
                    Nome do remetente:</td><td>
                    <asp:TextBox ID="txtRemetenteNome" runat="server" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr valign="top">
                <td>
                    Email do remetente:</td><td>
                    <asp:TextBox ID="txtRemetenteEmail" runat="server" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr valign="top">
                <td>
                    Nome do destinatário:</td><td>
                    <asp:TextBox ID="txtDestinatarioNome" runat="server" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr valign="top">
                <td>
                    Email do destinatário:</td><td>
                    <asp:TextBox ID="txtDestinatarioEmail" runat="server" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr valign="top">
                <td>
                    Nome do Website a ser liberado:</td><td>
                    <asp:TextBox ID="txtAssunto" runat="server"  Width="280px"></asp:TextBox>
                </td>
            </tr>
           <tr valign="top">
                <td >
                    Motivo da solicitação:</td><td>
                    <asp:TextBox ID="txtMensagem" runat="server" Width="480px" Height="69px" 
                        TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
              <tr valign="top">
                <td ></td>
                <td>
                    <br />
                    <asp:Button id="btnEnviar" runat="server" Text="Enviar"
                        onclientclick="desabilitar(this);" 
                        UseSubmitBehavior="False"
                        CssClass="botao100" OnClick="btnEnviar_Click" />    
                </td>
            </tr>
        </table>
        <br />
    </asp:Panel>
    
    <asp:Panel ID="Panel2" runat="server" Visible="false">
        <br />
        <br />
        <asp:Label id="lblMensagem" Text="" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Outra solicitação" CssClass="botao100" 
            onclick="Button1_Click" />
    </asp:Panel>
    
    <br /><br />
    </div>
    
</asp:Content>
