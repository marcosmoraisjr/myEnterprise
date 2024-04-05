<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="portal.ZonaPrincipal.MenuInstitucional.Documentos.Upload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="_paginaContent">

    <h2>Upload de arquivos</h2>
	    <p>
	        Selecione o arquivo a ser enviado:
		    <br />
		    <input type="file" id="arquivo" size="50" runat="server"><br />
		    
		    <asp:Button id="bEnviar" runat="server" Text="Enviar"></asp:Button>
		</p>
	    
	    <p>
		    <asp:Label id="lMensagem" runat="server"></asp:Label>
		</p>
        <asp:Button ID="Button1" runat="server" Text="Listar Arquivos" PostBackUrl="./" />
    </div>
</asp:Content>
