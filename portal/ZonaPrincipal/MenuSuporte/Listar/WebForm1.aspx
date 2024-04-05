<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.ZonaPrincipal.MenuSuporte.Listar.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <style type="text/css">
        .style1
        {
            width: 200px;
        }
    </style>
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="_paginaContent">
        <h3>LISTA DE SOLICITAÇÕES</h3>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" 
                RepeatDirection="Horizontal" AutoPostBack="True" 
                onselectedindexchanged="Button1_Click1">
                             <asp:ListItem Value="0" Selected="True" >Pendente</asp:ListItem >
                             <asp:ListItem Value="1">Concluído</asp:ListItem>
                             <asp:ListItem Value="2">Andamento</asp:ListItem>
                             <asp:ListItem Value="3">Soma Geral</asp:ListItem>
        </asp:RadioButtonList>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" 
                Text="atualizar" Visible="False" />
        
        <hr class="escondido" />
        <asp:Panel ID="Panel1" runat="server" Visible="false">
            <table width="100%">
                 <tr valign="top">
                    <td class="style1">
                        Código:</td><td>
                        <asp:Label ID="LabelCodigo" runat="server" Text="000000" ></asp:Label>
                    </td>
                </tr>
                <tr valign="top">
                    <td class="style1">
                        Solicitante:</td><td>
                        <asp:TextBox ID="txtRemetenteNome" runat="server" Width="280px" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr valign="top">
                    <td>
                        Email do solicitante:</td><td>
                        <asp:TextBox ID="txtRemetenteEmail" runat="server" Width="280px" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr valign="top">
                    <td>
                        Nome do técnico:</td><td>
                        <asp:TextBox ID="txtDestinatarioNome" runat="server" Width="280px" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr valign="top">
                    <td>
                        Email do técnico:</td><td>
                        <asp:TextBox ID="txtDestinatarioEmail" runat="server" Width="280px" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr valign="top">
                    <td>
                        Nome da máquina com problema:</td><td>
                        <asp:TextBox ID="txtAssunto" runat="server"  Width="280px" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
               <tr valign="top">
                    <td >
                        </td><td>
                        <strong>Descrição do problema:</strong><br />
                        <asp:TextBox ID="txtMensagem" runat="server" Width="480px" Height="69px" TextMode="MultiLine" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>

                <tr valign="top">
                    <td >
                        Data de inclusão:</td><td>
                        <asp:TextBox ID="txtInclusao" runat="server" Width="120px" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>

               <asp:Panel ID="PanelConclusao" runat="server" Visible="false"> 
               <tr valign="top">
                    <td >
                        </td><td>
                        <strong>Solução encontrada:</strong><br />
                        <asp:TextBox ID="txtConclusao" runat="server" Width="480px" Height="69px" TextMode="MultiLine" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
               <tr valign="top">
                    <td >
                        Data de solução:</td><td>
                        <asp:TextBox ID="txtDataConclusao" runat="server" Width="120px" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                 </asp:Panel>   
                 
                 <!--  <tr valign="top">
                    <td >
                        Situação:</td><td>
                        <asp:TextBox ID="txtSituacao" runat="server" Width="100px" ReadOnly="true"></asp:TextBox>
                       <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Visible="false">
                                 <asp:ListItem Value="True" >Pendente</asp:ListItem>
                                 <asp:ListItem Value="False">Concluído</asp:ListItem>
                       </asp:RadioButtonList> 
                    </td>
                  </tr>
                  -->
                  <tr valign="top">
                    <td ></td>
                    <td>
                        <br />
                        <asp:Button id="btnSalvar" runat="server" Text="Gravar" CssClass="botao100" visible="false" />
                        <asp:Button id="btnCancelar" runat="server" Text="Cancelar" CssClass="botao100" 
                            onclick="btnCancelar_Click" />    
                        <asp:Button id="btnConcluir" runat="server" Text="Concluído" CssClass="botao100" 
                            onclick="btnConcluir_Click" />
                        <asp:Button ID="btnAndamento" runat="server" CssClass="botao100" 
                            Text="Andamento" onclick="btnAndamento_Click" />
                    </td>
                </tr>
            </table>
            <br />
        </asp:Panel>
       
        <asp:Panel ID="Panel2" runat="server" Visible="true">
           
           
          <center>
           
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            
          </center>
           
           <asp:Panel id="NavigationPanel" Visible="true" runat="server">
                <table border="0" cellpadding="3" cellspacing="3" >
                <tr>
                   <td style="width:60">
                    <asp:Label ID="Label1" runat="server" Text="Registros"></asp:Label>
                   </td>
                   <td style="width:100;text-align:right">Página <asp:Label id="CurrentPageLabel" runat="server" />
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
            <asp:Label ID="LabelClassificacao" runat="server" Text=""></asp:Label>
                    
            <asp:GridView ID="GridView1" runat="server" 
                CellPadding="2" 
                CellSpacing="1" 
                AutoGenerateColumns="False" 
                CssClass="GridViewStyle"
                EmptyDataText="Não existe registros para visualização." 
                AllowSorting="True" 
                Width="930px" 
                onrowcreated="GridView1_RowCreated" 
                onsorting="GridView1_Sorting" 
                onrowcommand="GridView1_RowCommand" 
                onrowdatabound="GridView1_RowDataBound" >
                
            <Columns>
                
                <asp:TemplateField HeaderText="xxx" Visible="false">
                    <HeaderTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" 
                            AutoPostBack="True" 
                            oncheckedchanged="CheckBox1_CheckedChanged" 
                            ToolTip="Marcar todos registros" />
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox2" runat="server" 
                            ToolTip="Marcar este registro"/>
                    </ItemTemplate>
                </asp:TemplateField>
                  
                <asp:TemplateField HeaderText="">
                     <ItemTemplate>
                         <asp:ImageButton ID="ImageButton1" runat="server" 
                             ToolTip="Visualizar este registro"
                             ImageUrl="~/imagens/mini-detalhar.png" 
                             CommandName="visualizar"
                             CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                    </ItemTemplate>
                </asp:TemplateField> 
                
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                         <asp:ImageButton ID="ImageButton2" runat="server" 
                             ToolTip="Apagar este registro"
                             ImageUrl="~/imagens/mini-apagar.png" 
                             CommandName="apagar"
                             CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                    </ItemTemplate>
                </asp:TemplateField> 
                
                <asp:TemplateField HeaderText="" Visible="false">
                     <ItemTemplate>
                         <asp:ImageButton ID="ImageButton3" runat="server"
                             ToolTip="Alterar este registro"
                             ImageUrl="~/imagens/mini-alterar.png" 
                             CommandName="modificar"
                             CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                    </ItemTemplate>
                </asp:TemplateField> 

                <asp:ImageField DataImageUrlField="SOLICITACAO_SITUACAO" 
                    HeaderText="" 
                    DataImageUrlFormatString="~/imagens/16x16/{0}.png">
                </asp:ImageField>
                
                
                <asp:BoundField DataField="SOLICITACAO_ID" HeaderText="CODIGO" ReadOnly="True" 
                    SortExpression="SOLICITACAO_ID" Visible="true" /> 
                <asp:BoundField DataField="SOLICITACAO_REMETENTE_NOME" HeaderText="SOLICITANTE"
                    SortExpression="SOLICITACAO_REMETENTE_NOME" />
                <asp:BoundField DataField="SOLICITACAO_REMETENTE_EMAIL" HeaderText="SOLICITANTE EMAIL"
                    SortExpression="SOLICITACAO_REMETENTE_EMAIL" Visible="False" />
                <asp:BoundField DataField="SOLICITACAO_ASSUNTO" HeaderText="ASSUNTO"
                    SortExpression="SOLICITACAO_ASSUNTO" />
                <asp:BoundField DataField="SOLICITACAO_DESCRICAO" HeaderText="DESCRICAO"
                    SortExpression="SOLICITACAO_DESCRICAO" Visible="False" />
                <asp:BoundField DataField="SOLICITACAO_DESTINATARIO_EMAIL" HeaderText="TÉCNICO ATENDENTE"
                    SortExpression="SOLICITACAO_DESTINATARIO_EMAIL" />
                <asp:BoundField DataField="SOLICITACAO_INCLUSAO" HeaderText="DATA INÍCIO"
                    SortExpression="SOLICITACAO_INCLUSAO" DataFormatString="{0:dd/MM/yyyy hh:mm:ss}" />
                <asp:BoundField DataField="SOLICITACAO_CONCLUSAO" HeaderText="DATA ÚLTIMO ATENDIMENTO²"
                    SortExpression="SOLICITACAO_CONCLUSAO" DataFormatString="{0:dd/MM/yyyy hh:mm:ss}" />
                <asp:BoundField DataField="SOLICITACAO_SITUACAO" HeaderText="SOLICITACAO_SITUACAO" Visible="false"
                    SortExpression="SOLICITACAO_SITUACAO" />
                    
                <asp:TemplateField HeaderText="DIAS DECORRIDOS¹" Visible="true">
                 <ItemTemplate>
                     <asp:Label ID="LabelPendenciaDias" runat="server" Text=""></asp:Label>
                </ItemTemplate>
                </asp:TemplateField> 
                
                <asp:TemplateField HeaderText="Informação">
                    <ItemTemplate>
                        <asp:Label ID="info" runat="server" Text='<%# Eval("SOLICITACAO_DESCRICAO") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>
            
        </asp:GridView>
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
             ConnectionString="<%$ ConnectionStrings:ROTA %>"
             ProviderName="<%$ ConnectionStrings:ROTA.ProviderName %>"
             SelectCommand="SELECT [SOLICITACAO_ID], [SOLICITACAO_CODIGO], [SOLICITACAO_REMETENTE_NOME], [SOLICITACAO_REMETENTE_EMAIL], [SOLICITACAO_ASSUNTO], [SOLICITACAO_DESCRICAO], [SOLICITACAO_INCLUSAO], [SOLICITACAO_SITUACAO],[SOLICITACAO_DESTINATARIO_EMAIL] FROM [SOLICITACOES]"
             UpdateCommand="UPDATE [SOLICITACOES] SET [SOLICITACAO_SITUACAO] = @SOLICITACAO_SITUACAO WHERE [SOLICITACAO_ID] = @SOLICITACAO_ID" 
             DeleteCommand="DELETE FROM [SOLICITACOES] WHERE [SOLICITACAO_ID] = @SOLICITACAO_ID">
             <DeleteParameters>
                    <asp:Parameter Name="SOLICITACAO_ID" Type="Int32" />
             </DeleteParameters>
             <UpdateParameters>
                    <asp:Parameter Name="SOLICITACAO_ID" Type="Int32" />
                    <asp:Parameter Name="SOLICITACAO_CODIGO" Type="String" />
                    <asp:Parameter Name="SOLICITACAO_REMETENTE_NOME" Type="String" />
                    <asp:Parameter Name="SOLICITACAO_REMETENTE_EMAIL" Type="String" />
                    <asp:Parameter Name="SOLICITACAO_ASSUNTO" Type="String" />
                    <asp:Parameter Name="SOLICITACAO_DESCRICAO" Type="String" />
                    <asp:Parameter Name="SOLICITACAO_INCLUSAO" Type="DateTime" />
                    <asp:Parameter Name="SOLICITACAO_DESTINATARIO_EMAIL" Type="String" />
                    <asp:Parameter Name="SOLICITACAO_SITUACAO" Type="Boolean" />
             </UpdateParameters>
        </asp:SqlDataSource>

            <hr class="escondido" />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/imagens/16x16/0.png" />&nbsp;Processo Pendente (Não atendido)&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image2" runat="server" ImageUrl="~/imagens/16x16/2.png" />&nbsp;Processo Pendente (Em andamento)&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image3" runat="server" ImageUrl="~/imagens/16x16/1.png" />&nbsp;Processo Concluído
            
        </asp:Panel>
       
        <small style="color:Blue;"><br />Nota¹: Os valores númericos listados na coluna de "DIAS DECORRIDOS PARA CONCLUSÃO DO ATENDIMENTO" se refere a "dias" completos.</small>
        <small style="color:Blue;"><br />Nota²: O período entre um chamado e o primeiro atendimento não deve ultrapassar 01 dia completo.</small>
    </div>
</asp:Content>
