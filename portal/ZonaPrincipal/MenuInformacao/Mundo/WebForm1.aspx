<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.MenuNoticias.Mundo.WebForm1" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       
        <div id="_paginaContent" >
    
        <h2><asp:Label ID="LabelTitulo" runat="server" Text="Label"></asp:Label></h2>
    
        <asp:GridView 
            ID="GridView1" runat="server" 
            CssClass="GridViewStyle"
            AllowPaging="True" 
            AllowSorting="True"
            AutoGenerateColumns="False" 
            GridLines="None"
            EnableSortingAndPagingCallbacks="True"
            Width="100%" 
            onpageindexchanging="GridView1_PageIndexChanging" 
            PageSize="5" 
            onrowcreated="GridView1_RowCreated" >
            
            <Columns>
                <asp:BoundField 
                    DataField="pubDate" 
                    HeaderText="Data" 
                    DataFormatString="{0:dd-MM-yyyy}" />
                
                <asp:BoundField 
                    DataField="title" 
                    HeaderText="Notícia" 
                    visible="false" />
                
                <asp:BoundField 
                    DataField="link" 
                    HeaderText="Fonte" 
                    visible="false"/>
                
                <asp:HyperLinkField 
                    DataNavigateUrlFields="link" 
                    DataTextField="title" 
                    HeaderText="Notícia" />
            </Columns>
            
        </asp:GridView>
        
        <table class="GridViewStyle" width="100%"><tr><th>
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
        </th></tr></table>
    </div>
</asp:Content>
