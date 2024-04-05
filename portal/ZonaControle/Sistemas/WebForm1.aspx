<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.MenuSistemas.WebForm1" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div id="_paginaContent">
    <h2>PAINEL DE CONTROLE SISTEMAS</h2> 
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CssClass="GridViewStyle"
        AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="SISTEMA_ID" 
        DataSourceID="SqlDataSource1" 
        EmptyDataText="There are no data records to display.">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                ShowSelectButton="True" />
            <asp:BoundField DataField="SISTEMA_LINK" HeaderText="SISTEMA" 
                SortExpression="SISTEMA_LINK" />
            <asp:BoundField DataField="SISTEMA_INCLUSAO" HeaderText="INCLUSAO" 
                SortExpression="SISTEMA_INCLUSAO" />
            <asp:BoundField DataField="SISTEMA_DESCRICAO" HeaderText="DESCRICAO" 
                SortExpression="SISTEMA_DESCRICAO" />
            <asp:CheckBoxField DataField="SISTEMA_ATIVO" HeaderText="ATIVO" 
                SortExpression="SISTEMA_ATIVO" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ROTA %>" 
        DeleteCommand="DELETE FROM [SISTEMAS] WHERE [SISTEMA_ID] = @SISTEMA_ID" 
        InsertCommand="INSERT INTO [SISTEMAS] ([SISTEMA_LINK], [SISTEMA_INCLUSAO], [SISTEMA_DESCRICAO], [SISTEMA_ATIVO]) VALUES (@SISTEMA_LINK, @SISTEMA_INCLUSAO, @SISTEMA_DESCRICAO, @SISTEMA_ATIVO)" 
        ProviderName="<%$ ConnectionStrings:ROTA.ProviderName %>" 
        SelectCommand="SELECT [SISTEMA_ID], [SISTEMA_LINK], [SISTEMA_INCLUSAO], [SISTEMA_DESCRICAO], [SISTEMA_ATIVO] FROM [SISTEMAS]" 
        UpdateCommand="UPDATE [SISTEMAS] SET [SISTEMA_LINK] = @SISTEMA_LINK, [SISTEMA_INCLUSAO] = @SISTEMA_INCLUSAO, [SISTEMA_DESCRICAO] = @SISTEMA_DESCRICAO, [SISTEMA_ATIVO] = @SISTEMA_ATIVO WHERE [SISTEMA_ID] = @SISTEMA_ID">
        <DeleteParameters>
            <asp:Parameter Name="SISTEMA_ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="SISTEMA_LINK" Type="String" />
            <asp:Parameter Name="SISTEMA_INCLUSAO" Type="DateTime" />
            <asp:Parameter Name="SISTEMA_DESCRICAO" Type="String" />
            <asp:Parameter Name="SISTEMA_ATIVO" Type="Boolean" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="SISTEMA_LINK" Type="String" />
            <asp:Parameter Name="SISTEMA_INCLUSAO" Type="DateTime" />
            <asp:Parameter Name="SISTEMA_DESCRICAO" Type="String" />
            <asp:Parameter Name="SISTEMA_ATIVO" Type="Boolean" />
            <asp:Parameter Name="SISTEMA_ID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    
    <br />
    </div>

</asp:Content>
