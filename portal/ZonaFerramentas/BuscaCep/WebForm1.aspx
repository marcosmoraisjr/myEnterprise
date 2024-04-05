<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.MenuCEP.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="_paginaContent">
    <h2>PESQUISAR</h2>
    
        <table><tr>
            <td>
            
            Pesquisar por CEP:<br />
            <asp:TextBox runat="server" ID="TextBoxCep" onkypress="formataCEP(this,event);" 
                    MaxLength="8"></asp:TextBox>
            
            <br /><br />
            <asp:Button runat="server" ID="ButtonConsulta" Text="Pesquisar CEP »" 
                onclick="ButtonConsulta_Click" CssClass="botao" /> 
            
            </td>   
            
            <td>
            Pesquisar por Logradouro e Cidade:<br />
            <asp:TextBox runat="server" ID="TextBoxLogradouro" ></asp:TextBox>
            <asp:TextBox runat="server" ID="TextBoxCidade" ></asp:TextBox>
            
            <br /><br />
            <asp:Button runat="server" ID="ButtonConsulta2" Text="Pesquisar LOGRADOURO e CIDADE »" 
               CssClass="botao" onclick="ButtonConsulta2_Click" /> 
            </td>
        </tr></table>
       
        <br /><br />
        <asp:GridView ID="GridView1" runat="server" CssClass="GridViewStyle" AutoGenerateColumns="false"
            Caption="Resultado">
            
            <Columns>
                <asp:BoundField DataField="RETORNO" DataFormatString="{0:c}" 
                    HeaderText="RETORNO" />
                <asp:BoundField DataField="TIPO_LOGRADOURO" DataFormatString="{0:c}" 
                    HeaderText="TIPO" />
                <asp:BoundField DataField="LOGRADOURO" DataFormatString="{0:c}" 
                    HeaderText="LOGRADOURO" />
                <asp:BoundField DataField="BAIRRO" DataFormatString="{0:c}" 
                    HeaderText="BAIRRO" />
                <asp:BoundField DataField="UF_SIGLA" DataFormatString="{0:c}" 
                    HeaderText="UF" />
                <asp:BoundField DataField="CIDADE" DataFormatString="{0:c}" 
                    HeaderText="CIDADE" />
                <asp:BoundField DataField="CEP" DataFormatString="{0:c}" 
                    HeaderText="CEP" />
                <asp:BoundField DataField="CODIGO_IBGE" DataFormatString="{0:c}" 
                    HeaderText="IBGE" />
                <asp:BoundField DataField="ORIGEM" DataFormatString="{0:c}" 
                    HeaderText="ORIGEM" />
            </Columns>
          
        </asp:GridView>
        
        <asp:GridView ID="GridView2" runat="server" CssClass="GridViewStyle" Caption="Resultado">
        </asp:GridView>
        
        <p>
            <hr />
            <strong>Esta área esta reservada para teste. Favor não usar.</strong>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="getCepLocal" CssClass="botao"
                onclick="Button1_Click" />
                
            <asp:Button ID="Button4" runat="server" Text="getCepLivre " CssClass="botao"
                onclick="Button4_Click" />
            
            <asp:Button ID="Button5" runat="server" Text="getCepRepublicaVirtual " CssClass="botao"
                onclick="Button5_Click" />
                
            <asp:Button ID="Button3" runat="server" Text="getWsCep " CssClass="botao"
                onclick="Button3_Click" />
            
            <br />
            <hr class="escondido"/>
            <br />
            
            <asp:Label ID="Label1" runat="server" Text="" Visible="true" ></asp:Label>
        </p>
        </div>
</asp:Content>
