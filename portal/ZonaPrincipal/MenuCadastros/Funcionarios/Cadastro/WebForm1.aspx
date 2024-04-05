<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.MenuFuncionarios.Ficha.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1" 
        EmptyDataText="There are no data records to display.">
        <Columns>
            <asp:BoundField DataField="funcionarioNome" HeaderText="funcionarioNome" 
                SortExpression="funcionarioNome" />
            <asp:BoundField DataField="funcionarioEndereco" HeaderText="funcionarioEndereco" 
                SortExpression="funcionarioEndereco" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ROTA %>" 
        ProviderName="<%$ ConnectionStrings:ROTA.ProviderName %>" 
        SelectCommand="SELECT [funcionarioNome] FROM [FUNCIONARIOS]">
    </asp:SqlDataSource>
    
</asp:Content>
