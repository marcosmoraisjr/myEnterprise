<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.ZonaGC.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="_paginaContent" >
    
        <h2>Gestão do Conhecimento</h2>
        <table border="0" cellpadding="0" cellspacing="0" width="100%">

        <tr>
        <td align="center"><asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="~/imagens/128x128/audio.png" PostBackUrl="~/ZonaGC/audio/" /></td>
        <td align="center"><asp:ImageButton ID="ImageButton2" runat="server" 
                ImageUrl="~/imagens/128x128/documentos.png" PostBackUrl="~/ZonaGC/docs/" /></td>
        <td align="center"><asp:ImageButton ID="ImageButton3" runat="server" 
                ImageUrl="~/imagens/128x128/video.png" PostBackUrl="~/ZonaGC/video/" /></td>
        <td align="center"><asp:ImageButton ID="ImageButton4" runat="server" 
                ImageUrl="~/imagens/128x128/curso.png" PostBackUrl="~/ZonaGC/cursos/" /></td>
        </tr>

        <tr>
        <td align="center">Audio</td>
        <td align="center">Documentos</td>
        <td align="center">Videos</td>
        <td align="center">Cursos</td>
        </tr>

        </table>
        <hr />
        Esta seção disponibiliza alguns documentos, treinamentos, audio e videos procurando assim, melhorar suas qualificações.<br />
        Caso, você tenha alguma sugestão, entre em contato por email. 
        <br /><br />Bom proveito!
        
    </div>

</asp:Content>
