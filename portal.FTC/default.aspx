<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Portal._default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            
		        
	            <div id="colunacaixa">
	            
	    		    <div id="colunaesquerda">
	                <h5><strong>Favoritos:</strong></h5>
					            <h2>Selecione um site que deseja ter acesso e clique em "continuar".</h2>
					            <br /><br />
					            <p><asp:DropDownList ID="DropDownListFavoritos" runat="server" class="combobox"></asp:DropDownList></p>
                                <p><asp:Button ID="ButtonFavoritos" runat="server" Text="Continuar >>" 
                                        class="botaoLaranja" onclick="ButtonFavoritos_Click" /></p>
				    </div>
    				
				    <div id="colunacentro">
					      <h5><strong>Arquivos:</strong></h5>
					            <h2>Arquivos e documentos</h2>
					            <br /><br />
                                <p><asp:DropDownList ID="DropDownListArquivos" runat="server" class="combobox"></asp:DropDownList></p>
                                <p><asp:Button ID="ButtonArquivos" runat="server" Text="Continuar >>" 
                                        class="botaoAzul" onclick="ButtonArquivos_Click" /></p>
				    </div>
    				
				    <div id="colunadireita">
				          <h5><strong>Segurança:</strong></h5>
					                <h2>Atenção: Esta área é restrita</h2>
					                <br /><br />
					                <p>
					                    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Lembrar senha</asp:LinkButton>
                                        &nbsp;|
                                        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Primeiro acesso</asp:LinkButton>
                                    </p>
					                <p>
                                    <asp:Button ID="ButtonEntrar" runat="server" Text="Acessar >>" class="botaoVerde" PostBackUrl="~/login.aspx" />
                                    </p>
				    </div>
				    <div id="colunarodape">&nbsp;</div>
                </div>
                <div id="sombra">&nbsp;</div>

</asp:Content>
