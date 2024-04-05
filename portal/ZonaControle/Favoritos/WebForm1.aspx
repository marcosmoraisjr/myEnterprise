<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.MenuFavoritos.WebForm1" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
 <div id="_paginaContent">
    <h2>PAINEL DE CONTROLE FAVORITOS</h2> 
    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" CssClass="GridViewStyle"
        AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="FAVORITO_ID" 
        DataSourceID="SqlDataSource2" 
        EmptyDataText="There are no data records to display.">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                ShowSelectButton="True" />
            <asp:BoundField DataField="FAVORITO_LINK" HeaderText="FAVORITO" 
                SortExpression="FAVORITO_LINK" />
            <asp:BoundField DataField="FAVORITO_INCLUSAO" HeaderText="INCLUSAO" 
                SortExpression="FAVORITO_INCLUSAO" />
            <asp:BoundField DataField="FAVORITO_DESCRICAO" HeaderText="DESCRICAO" 
                SortExpression="FAVORITO_DESCRICAO" />
            <asp:CheckBoxField DataField="FAVORITO_ATIVO" HeaderText="ATIVO" 
                SortExpression="FAVORITO_ATIVO" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ROTA %>" 
        DeleteCommand="DELETE FROM [FAVORITOS] WHERE [FAVORITO_ID] = @FAVORITO_ID" 
        InsertCommand="INSERT INTO [FAVORITOS] ([FAVORITO_LINK], [FAVORITO_INCLUSAO], [FAVORITO_DESCRICAO], [FAVORITO_ATIVO]) VALUES (@FAVORITO_LINK, @FAVORITO_INCLUSAO, @FAVORITO_DESCRICAO, @FAVORITO_ATIVO)" 
        ProviderName="<%$ ConnectionStrings:ROTA.ProviderName %>" 
        SelectCommand="SELECT [FAVORITO_ID], [FAVORITO_LINK], [FAVORITO_INCLUSAO], [FAVORITO_DESCRICAO], [FAVORITO_ATIVO] FROM [FAVORITOS]" 
        UpdateCommand="UPDATE [FAVORITOS] SET [FAVORITO_LINK] = @FAVORITO_LINK, [FAVORITO_INCLUSAO] = @FAVORITO_INCLUSAO, [FAVORITO_DESCRICAO] = @FAVORITO_DESCRICAO, [FAVORITO_ATIVO] = @FAVORITO_ATIVO WHERE [FAVORITO_ID] = @FAVORITO_ID">
        <DeleteParameters>
            <asp:Parameter Name="FAVORITO_ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="FAVORITO_LINK" Type="String" />
            <asp:Parameter Name="FAVORITO_INCLUSAO" Type="DateTime" />
            <asp:Parameter Name="FAVORITO_DESCRICAO" Type="String" />
            <asp:Parameter Name="FAVORITO_ATIVO" Type="Boolean" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="FAVORITO_LINK" Type="String" />
            <asp:Parameter Name="FAVORITO_INCLUSAO" Type="DateTime" />
            <asp:Parameter Name="FAVORITO_DESCRICAO" Type="String" />
            <asp:Parameter Name="FAVORITO_ATIVO" Type="Boolean" />
            <asp:Parameter Name="FAVORITO_ID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    </div>
    
</asp:Content>
