<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.ZonaPrincipal.MenuEmail.SendSMS.WebForm1" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 200px;
            height: 22px;
        }
        .style2
        {
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="_paginaContent">
    <h2>ENVIO DE MENSAGEM PARA CELULAR (SMS)</h2>
    <br /><br />
    
   <asp:Panel ID="Panel1" runat="server">
        <table width="100%">
            <tr valign="top">
                <td class="style1">
                    Nome do remetente:</td><td class="style2">
                    <asp:TextBox ID="txtRemetenteNome" runat="server" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr valign="top">
                <td>
                    Celular do remetente:</td><td>
                    <asp:TextBox ID="txtRemetenteCelular" runat="server" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr valign="top">
                <td class="style2">
                    Nome do destinatário:</td><td class="style2">
                    <asp:TextBox ID="txtDestinatarioNome" runat="server" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr valign="top">
                <td>
                    Celular do destinatário:</td><td>
                    <asp:TextBox ID="txtDestinatarioCelular" runat="server" Width="280px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr valign="top">
                <td>
                    Assunto:<br />
                   (máximo de 20 caracteres)</td><td>
                    <asp:TextBox ID="txtAssunto" runat="server"  Width="280px" MaxLength="20"></asp:TextBox>
                </td>
            </tr>
           <tr valign="top">
                <td >
                    Mensagem :<br />
                   (máximo de 140 caracteres)</td><td>
                    <asp:TextBox ID="txtMensagem" runat="server" Width="480px" Height="69px" 
                        TextMode="MultiLine" MaxLength="130"></asp:TextBox>
                </td>
            </tr>
              <tr valign="top">
                <td ></td>
                <td>
                    <br />
                    <asp:Button id="ButtonEnviarSMS" runat="server" Text="Enviar" 
                        CssClass="botao100" OnClick="ButtonEnviarSMS_Click" />    
                    <asp:Button ID="Button3" runat="server" Text="Menu Principal" CssClass="botao100" PostBackUrl='~/' />   
                </td>
            </tr>
        </table>
        <br />
    </asp:Panel>
    
    
    </div>    
</asp:Content>
