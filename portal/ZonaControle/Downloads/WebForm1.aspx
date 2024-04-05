<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.MenuSuporte.WebForm1" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="_paginaContent">
    <h2>PAINEL DE CONTROLE DOWNLOADS</h2> 
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="GridViewStyle"
        DataKeyNames="DOWNLOAD_ID" DataSourceID="SqlDataSource1" 
        EmptyDataText="There are no data records to display.">
        <Columns>
            <asp:BoundField DataField="DOWNLOAD_LINK" HeaderText="DOWNLOAD" 
                SortExpression="DOWNLOAD_LINK" />
            <asp:BoundField DataField="DOWNLOAD_INCLUSAO" HeaderText="INCLUSAO" 
                SortExpression="DOWNLOAD_INCLUSAO" />
            <asp:BoundField DataField="DOWNLOAD_DESCRICAO" HeaderText="DESCRICAO" 
                SortExpression="DOWNLOAD_DESCRICAO" />
            <asp:CheckBoxField DataField="DOWNLOAD_ATIVO" HeaderText="ATIVO" 
                SortExpression="DOWNLOAD_ATIVO" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ROTA %>" 
        DeleteCommand="DELETE FROM [DOWNLOADS] WHERE [DOWNLOAD_ID] = @DOWNLOAD_ID" 
        InsertCommand="INSERT INTO [DOWNLOADS] ([DOWNLOAD_LINK], [DOWNLOAD_INCLUSAO], [DOWNLOAD_DESCRICAO], [DOWNLOAD_ATIVO]) VALUES (@DOWNLOAD_LINK, @DOWNLOAD_INCLUSAO, @DOWNLOAD_DESCRICAO, @DOWNLOAD_ATIVO)" 
        ProviderName="<%$ ConnectionStrings:ROTA.ProviderName %>" 
        SelectCommand="SELECT [DOWNLOAD_ID], [DOWNLOAD_LINK], [DOWNLOAD_INCLUSAO], [DOWNLOAD_DESCRICAO], [DOWNLOAD_ATIVO] FROM [DOWNLOADS]" 
        UpdateCommand="UPDATE [DOWNLOADS] SET [DOWNLOAD_LINK] = @DOWNLOAD_LINK, [DOWNLOAD_INCLUSAO] = @DOWNLOAD_INCLUSAO, [DOWNLOAD_DESCRICAO] = @DOWNLOAD_DESCRICAO, [DOWNLOAD_ATIVO] = @DOWNLOAD_ATIVO WHERE [DOWNLOAD_ID] = @DOWNLOAD_ID">
        <DeleteParameters>
            <asp:Parameter Name="DOWNLOAD_ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="DOWNLOAD_LINK" Type="String" />
            <asp:Parameter Name="DOWNLOAD_INCLUSAO" Type="DateTime" />
            <asp:Parameter Name="DOWNLOAD_DESCRICAO" Type="String" />
            <asp:Parameter Name="DOWNLOAD_ATIVO" Type="Boolean" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="DOWNLOAD_LINK" Type="String" />
            <asp:Parameter Name="DOWNLOAD_INCLUSAO" Type="DateTime" />
            <asp:Parameter Name="DOWNLOAD_DESCRICAO" Type="String" />
            <asp:Parameter Name="DOWNLOAD_ATIVO" Type="Boolean" />
            <asp:Parameter Name="DOWNLOAD_ID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    

    </div>
    
    
</asp:Content>
