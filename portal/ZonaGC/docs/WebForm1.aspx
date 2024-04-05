<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.ZonaGC.docs.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript" language="javascript">
    function download(arquivo) {
        window.location = arquivo;
        return false;
    }
    </script>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="_paginaContent">
        <h2>Documentos <div class="direita">
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="upload.aspx">Enviar arquivo</asp:LinkButton>
            </div></h2>
        <asp:GridView ID="GridView1" runat="server" CssClass="GridViewStyle" EmptyDataText="Não existe registros para visualização." 
            AllowPaging="True" 
            AllowSorting="True" 
            Width="930px" onrowdatabound="GridView1_RowDataBound" 
            onrowcreated="GridView1_RowCreated">
        </asp:GridView>
    </div>
    
</asp:Content>
