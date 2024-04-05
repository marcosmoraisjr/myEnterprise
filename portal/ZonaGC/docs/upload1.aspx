<%@ Page language="c#" Codebehind="upload1.aspx.cs" AutoEventWireup="false" Inherits="ExemplosCSharp.Upload.upload" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Upload</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server" enctype="multipart/form-data">
			<P><FONT size="5"><STRONG>Upload de arquivos</STRONG></FONT></P>
			<P>Selecione o arquivo:
				<BR>
				<INPUT type="file" id="arquivo" size="50" runat="server"><BR>
				Indique o caminho onde o arquivo deverá ser armazenado:<BR>
				<asp:TextBox id="tbCaminho" runat="server" Columns="50"></asp:TextBox><BR>
				<BR>
				<asp:Button id="bEnviar" runat="server" Text="Enviar"></asp:Button></P>
			<P>
				<asp:Label id="lMensagem" runat="server"></asp:Label></P>
			<P><STRONG>OBS:</STRONG>
				<BR>
				- O <STRONG>encType</STRONG> do &lt;form&gt; foi alterado para: <STRONG>multipart/form-data<BR>
				</STRONG>- Foi atribuída propriedade <STRONG>runat="server"</STRONG> para o 
				&lt;input type="file"&gt;</P>
			<P><EM>By:<BR>
					Eduardo Henrique Rizo<BR>
				</EM><A href="mailto:ehrizo@hotmail.com"><EM>ehrizo@hotmail.com</EM></A></P>
		</form>
	</body>
</HTML>
