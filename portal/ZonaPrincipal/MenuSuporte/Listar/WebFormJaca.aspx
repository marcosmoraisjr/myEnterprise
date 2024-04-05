<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebFormJaca.aspx.cs" Inherits="portal.ZonaPrincipal.MenuSuporte.Listar.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>LISTA DE SOLICITAÇÕES EM ABERTO</h2>
    
    <asp:Button ID="Button1" runat="server" CssClass="botao100" 
        onclick="Button1_Click" Text="Excluir marcados" Enabled="False" />
    <asp:Button ID="Button2" runat="server" CssClass="botao100" 
        onclick="Button2_Click" Text="Novo" />
    <asp:Button ID="Button3" runat="server" CssClass="botao100" 
        onclick="Button3_Click" Text="Pesquisa" />
    
    <br />
    <br />
    <br />

    <asp:GridView ID="GridView1" runat="server" CssClass="GridViewStyle" >
        <Columns>
            
            <asp:TemplateField HeaderText="xxx">
                <HeaderTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" 
                        oncheckedchanged="CheckBox1_CheckedChanged" 
                        ToolTip="Marcar todos registros" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox2" runat="server" 
                    ToolTip="Marcar este registro"/>
                </ItemTemplate>
            </asp:TemplateField>  
                   
            <asp:TemplateField HeaderText="Ver">
                 <ItemTemplate>
                     <asp:ImageButton ID="ImageButton1" runat="server" ToolTip="Detalhar este registro"
                         ImageUrl="~/imagens/mini-mais.gif" />
                </ItemTemplate>
            </asp:TemplateField> 
            <asp:TemplateField HeaderText="Apagar">
                 <ItemTemplate>
                     <asp:ImageButton ID="ImageButton2" runat="server" ToolTip="Apagar este registro"
                         ImageUrl="~/imagens/mini-deletar.png" onclick="ImageButton2_Click" />
                </ItemTemplate>
            </asp:TemplateField> 
            <asp:TemplateField HeaderText="Alterar">
                 <ItemTemplate>
                     <asp:ImageButton ID="ImageButton3" runat="server" ToolTip="Alterar este registro"
                         ImageUrl="~/imagens/mini-selecionar.png" />
                </ItemTemplate>
            </asp:TemplateField> 
        </Columns>
   
    </asp:GridView>
    
    <asp:LinkButton ID="lnkAnterior" runat="server" ToolTip="Anterior" OnClick="lnkAnterior_Click">Anterior</asp:LinkButton>
    <asp:LinkButton ID="lnkProximo" runat="server" ToolTip="Próximo" OnClick="lnkProximo_Click">Próximo</asp:LinkButton>
    
    <br />
    <br />
    
</asp:Content>
