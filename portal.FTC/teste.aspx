<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="teste.aspx.cs" Inherits="Portal.teste" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
        <div class="roundedcornr_box_755818">
           <div class="roundedcornr_top_755818"><div></div></div>
              <div class="roundedcornr_content_755818">
                 Lorem ipsum dolor sit amet, consectetur 
                 adipisicing elit, sed do eiusmod tempor incididunt 
                 ut labore et dolore magna aliqua. Ut enim ad minim 
                 veniam, quis nostrud exercitation ullamco laboris 
                 nisi ut aliquip ex ea commodo consequat. Duis aute 
                 irure dolor in reprehenderit in voluptate velit esse 
                 cillum dolore eu fugiat nulla pariatur. Excepteur 
                 sint occaecat cupidatat non proident, sunt in culpa 
                 qui officia deserunt mollit anim id est laborum.
              </div>
           <div class="roundedcornr_bottom_755818"><div></div></div>
        </div>
        <br />
        
        <div id="colunacaixa">
            
            <div id="colunaesquerda">
                <h5><strong>Favoritos:</strong></h5>
                <h2>Selecione um site que deseja ter acesso e clique em "continuar".</h2>
                <br /><br />
                <p><asp:DropDownList ID="DropDownList1" runat="server" class="combobox"></asp:DropDownList></p>
                <p><asp:Button ID="Button1" runat="server" Text="Continuar >>" class="botaoLaranja" /></p>
            </div>
            
            <div id="colunacentro">
                <h5><strong>Favoritos:</strong></h5>
                <h2>Selecione um site que deseja ter acesso e clique em "continuar".</h2>
                <br /><br />
                <p><asp:DropDownList ID="DropDownList2" runat="server" class="combobox"></asp:DropDownList></p>
                <p><asp:Button ID="Button2" runat="server" Text="Continuar >>" class="botaoAzul" /></p>
            </div>
            
           <div id="colunadireita">
                <h5><strong>Favoritos:</strong></h5>
                <h2>Selecione um site que deseja ter acesso e clique em "continuar".</h2>
                <br /><br />
                <p><asp:DropDownList ID="DropDownList3" runat="server" class="combobox"></asp:DropDownList></p>
                <p><asp:Button ID="Button3" runat="server" Text="Continuar >>" class="botaoVerde" /></p>
            </div>
            <div id="colunarodape">&nbsp;</div>
        </div>
        <div id="sombra">&nbsp;</div>
        
          
</asp:Content>
