<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UsuarioListar.aspx.cs" Inherits="portal.UsuarioOnline" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="_paginaContent">
    <h2>Lista de Usuários</h2>

        Numero de Usuários Online: <asp:Label id="UsersOnlineLabel" runat="Server" />
        &nbsp; &nbsp; &nbsp; &nbsp;
        Legenda:&nbsp;
        <asp:Image ID="Image2" runat="server" ImageUrl="imagens/16x16/true.png" /> On-Line
        &nbsp;
        <asp:Image ID="Image3" runat="server" ImageUrl="imagens/16x16/false.png"/> Off-Line
        <br />
        <asp:Panel id="NavigationPanel" Visible="false" runat="server">
            <table border="0" cellpadding="3" cellspacing="3" >
            <tr>
                <td style="width:100">Página <asp:Label id="CurrentPageLabel" runat="server" />
                    de <asp:Label id="TotalPagesLabel" runat="server" />
                </td>
                <td>.&nbsp;</td>
                <td style="width:60">&nbsp;<asp:LinkButton id="PreviousButton" Text="< Voltar"
                                OnClick="PreviousButton_OnClick" runat="server" />
                </td>
                <td style="width:60"><asp:LinkButton id="NextButton" Text="Avançar >"
                                OnClick="NextButton_OnClick" runat="server" />
                </td>
            </tr>
            </table>
        </asp:Panel>
        
        <hr class ="escondido"/>
        
        <asp:GridView ID="UserGrid" runat="server" 
            CellPadding="2" 
            CellSpacing="1" 
            AllowSorting="True"
            AutoGenerateColumns="False" PageSize="20" CssClass="GridViewStyle" 
            onrowdatabound="UserGrid_RowDataBound">
            <Columns>
            
            <asp:ImageField DataImageUrlField="ISONLINE" 
                        HeaderText="" 
                        DataImageUrlFormatString="~/imagens/16x16/{0}.png">
                        </asp:ImageField>
                        
            <asp:BoundField 
                        DataField="USERNAME" 
                        HeaderText="USUÁRIO" />
            
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Perfil"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                        
            <asp:BoundField 
                        DataField="CREATIONDATE" 
                        HeaderText="Data de Criação" 
                        DataFormatString="{0:dd/MM/yyyy}" />
                        
            <asp:BoundField 
                        DataField="LASTLOCKOUTDATE" 
                        HeaderText="Data do último bloqueio" 
                        DataFormatString="{0:dd/MM/yyyy}" />
                        
            <asp:BoundField 
                        DataField="LASTLOGINDATE" 
                        HeaderText="Data do último login" 
                        DataFormatString="{0:dd/MM/yyyy}" />
                        
            <asp:BoundField 
                        DataField="LASTACTIVITYDATE" 
                        HeaderText="Data da última atividade" 
                        DataFormatString="{0:dd/MM/yyyy}" />
                        
            <asp:BoundField 
                        DataField="LASTPASSWORDCHANGEDDATE" 
                        HeaderText="Última mudança de senha" 
                        DataFormatString="{0:dd/MM/yyyy}" />
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server"  ImageUrl="~/imagens/mini-icobranco.png" />
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Registro na Rede">
                
                    <ItemTemplate>
                        <asp:Label ID="LabelIP" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>
        </asp:GridView>
        
 </div>
 
</asp:Content>
