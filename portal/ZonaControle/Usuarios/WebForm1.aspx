<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.ZonaControle.Usuarios.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>ENTERPRISE | PAINEL DE CONTROLE | USUÁRIOS</title>
    <link href="../../css/Principal.css" rel="stylesheet" type="text/css" />
    <link href="../../css/GridView.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="Div1">
        <h2>PAINEL DE CONTROLE DOS USUÁRIOS</h2>   
        <asp:LoginName ID="LoginName1" runat="server" FormatString="Usuário logado: {0}" />
        &nbsp;|
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/">Principal</asp:LinkButton>
        &nbsp;|
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
        
        <br />
        <hr />
        <br />
        <asp:Table ID="Table1" runat="server" Height="100%" Width="100%" >
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <b>Lista de Usuários:</b><br />
                    <asp:ListBox ID="ListBox1" runat="server" Width="200px" AutoPostBack="True"></asp:ListBox>
                       

                       <br />
                    <asp:Button ID="ButtonExcluirUsuario" runat="server" onclick="ButtonExcluirUsuario_Click" 
                        Text="Excluir usuário" CssClass="botao300" />
                    

                    <br />
                    <br />
                    <br />
                    <br />
                    <b>Lista de Funções:</b><br />
                    <asp:ListBox ID="ListBox2" runat="server" Width="200px"></asp:ListBox>
                    

                    <br />
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="Adicionar função ao usuário selecionado" CssClass="botao300" />
                    

                    <br />
                    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                        Text="Remover função do usuário selecionado" CssClass="botao300" />
                    

                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <b>Criar nova função:</b><br />
                    <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                       

                    <br />
                    <asp:Button ID="RoleAdicionar" runat="server" 
                        onclick="RoleAdicionar_Click" 
                        Text="Adicionar " CssClass="botao300" />
                    <br />
                    <asp:Button ID="RoleRemover" runat="server" 
                        onclick="RoleRemover_Click" 
                        Text="Remover" CssClass="botao300" />

                    <br />
                    <br />
                    <br />
                    <br />
                    <b>Funções do usuário selecionado:</b><br />
                    <asp:ListBox ID="ListBox3" runat="server" Width="200px"></asp:ListBox>
                       

                       <br />
                    <asp:Button ID="ButtonFuncoesDoUsuario" runat="server" onclick="ButtonFuncoesDoUsuario_Click" 
                        Text="Continuar &gt;&gt;" CssClass="botao300" />
                    

                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                
</asp:TableCell>
                <asp:TableCell runat="server">
                    <h3>Lista de Usuários</h3>
                    
                    Numero de Usuários Online: <asp:Label id="UsersOnlineLabel" runat="Server" />
                    &nbsp; &nbsp; &nbsp; &nbsp;
                    Legenda:&nbsp;
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/imagens/16x16/true.png" /> On-Line
                    &nbsp;
                    <asp:Image ID="Image3" runat="server" ImageUrl="~/imagens/16x16/false.png"/> Off-Line
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
            EmptyDataText="Não existe registros para visualização." 
            AllowSorting="True"
            AutoGenerateColumns="False" 
            PageSize="20" 
            CssClass="GridViewStyle" 
            onrowdatabound="UserGrid_RowDataBound" >
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
                
            </Columns>
        </asp:GridView>
                

                <br /><br />
                Funções Disponíveis
                <asp:CheckBoxList ID="CheckBoxListRoles" runat="server">
                </asp:CheckBoxList>
                
</asp:TableCell></asp:TableRow></asp:Table><br />
        
    </div>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
        CssClass="GridViewStyle1" ForeColor="#333333" GridLines="None"><RowStyle 
            BackColor="#EFF3FB" /><FooterStyle BackColor="#507CD1" Font-Bold="True" 
            ForeColor="White" /><PagerStyle BackColor="#2461BF" ForeColor="White" 
            HorizontalAlign="Center" /><SelectedRowStyle BackColor="#D1DDF1" 
            Font-Bold="True" ForeColor="#333333" /><HeaderStyle BackColor="#507CD1" 
            Font-Bold="True" ForeColor="White" /><EditRowStyle BackColor="#2461BF" /><AlternatingRowStyle 
            BackColor="White" /></asp:GridView></form>
</body>
</html>
