<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="Portal.listar" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
        <!-- INICIO AREA GRID -->
        <div class="grid">
        
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            
            <asp:GridView ID="GridView1" runat="server" CssClass="tabulardata"
                onpageindexchanging="GridView1_PageIndexChanging" 
                onrowdatabound="GridView1_RowDataBound" ShowFooter="True" 
                AllowPaging="True" BackColor="White" BorderColor="#999999" 
                BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" 
                GridLines="Vertical" onrowcommand="GridView1_RowCommand" Width="890px" 
                PageSize="5">
                <Columns>
                    <asp:ButtonField ButtonType="Image" CommandName="Select" Text="Button" ImageUrl="~/imagens/mini-ok.gif" />
                </Columns>
                <HeaderStyle BackColor="Red" Font-Bold="True" ForeColor="White" />
                <FooterStyle BackColor="#CCCCCC" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#FFCC66" ForeColor="#990000" Font-Bold="True" />
                <AlternatingRowStyle BackColor="#CCCCCC" ForeColor="Black" /> 
            </asp:GridView>
            <asp:Panel ID="PanelPaginacao" runat="server">
            <asp:LinkButton id="btnFirst" runat="server"  
            Text="Primeira"  
            CommandArgument="zero"  
            ForeColor="Black"  
            Font-Name="verdana" Font-size="8pt"  
            OnClick="PagerButtonClick"  
            />  
                &nbsp;|&nbsp;  
            <asp:LinkButton id="btnPrev" runat="server"  
            Text="Anterior"  
            CommandArgument="prev"  
            ForeColor="Black"  
            Font-Name="verdana" Font-size="8pt"  
            OnClick="PagerButtonClick"  
            />  
    
                &nbsp;|&nbsp;  
            <asp:Label id="lblCurrentIndex" Font-Name="verdana" Font-size="8pt" runat="server" />  
                &nbsp;de&nbsp;  
            <asp:Label id="lblPageCount" Font-Name="verdana" Font-size="8pt" runat="server" />  
                |&nbsp;  
            
            <asp:LinkButton id="btnNext" runat="server"  
            Text="Próxima"  
            CommandArgument="next"  
            ForeColor="Black"  
            Font-Name="verdana" Font-size="8pt"  
            OnClick="PagerButtonClick"  
            />  
                &nbsp;|&nbsp;  
            <asp:LinkButton id="btnLast" runat="server"  
            Text="Última"  
            CommandArgument="last"  
            ForeColor="Black"  
            Font-Name="verdana" Font-size="8pt"  
            OnClick="PagerButtonClick"  
            />  
            </asp:Panel>
            
            <hr class="escondido" />
            <h5><strong>Envio de arquivos:</strong></h5>
            <h4>Selecione a pasta de destino acima. Depois selecione o arquivo que deseja enviar 
                e clique em &quot;enviar&quot;.</h4>
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" Width="100%"  />
            <p>
            <asp:Button ID="btnSalvar" runat="server" Text="Enviar" onclick="btnSalvar_Click" CssClass="botaoVerde" />
            <br />
            <asp:Label ID="UploadStatusLabel" runat="server" Text=""></asp:Label>
            </p>

            <div id="tooltip">
                Atenção: O sistema não permite as situações abaixo listadas:
                <ul>
                <li>arquivos com extensões do tipo: .php, .asp, .aspx, .db não são permitidos.</li>
                <li>arquivos acentuados ou compostos de caracteres especiais (#,$,%,&amp;, etc)</li>
                </ul>
            </div> 
            <hr class="escondido" />
        </div>
        <!-- FIM AREA GRID -->
	
</asp:Content>
