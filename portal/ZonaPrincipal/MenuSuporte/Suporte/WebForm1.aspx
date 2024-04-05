<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.ZonaPrincipal.MenuSuporte.Suporte.WebForm1" %>
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
    <h2>SOLICITAÇÃO DE SUPORTE</h2>
        
    <asp:Image ID="Image1" runat="server" 
            ImageUrl="~/imagerotator/imagemCapaSuporte.png" Width="66%" />
    
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
                    Nome da máquina com problema:</td><td>
                    <asp:TextBox ID="txtAssunto" runat="server"  Width="280px"></asp:TextBox>
                </td>
            </tr>
           <tr valign="top">
                <td >
                    Descrição do problema:</td><td>
                    <asp:TextBox ID="txtMensagem" runat="server" Width="480px" Height="69px" 
                        TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
              <tr valign="top">
                <td ></td>
                <td>
                    <br />
                    <asp:Button id="btnEnviar" runat="server" Text="Enviar" CssClass="botao100" OnClick="btnEnviar_Click" />    
                    <asp:Button id="btnCancelar" runat="server" Text="Cancelar" CssClass="botao100"  PostBackUrl="~/" />    
                </td>
            </tr>
        </table>
        <br />
    </asp:Panel>
    
    <asp:Panel ID="Panel2" runat="server" Visible="false">
        <br />
        <br />
        <asp:Label id="lblMensagem" Text="" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Fazer outra solicitação" CssClass="botao150" 
            onclick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Listar solicitações" CssClass="botao150" PostBackUrl="../listar" />
    </asp:Panel>
    
    <br /><br />
    </div>
</asp:Content>
