<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="portal.MenuFuncionarios.MenuAniversariantes.WebForm1" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <table width="100%" class="GridViewStyle1">
            <tr> 
			    <td>
			        <h2><asp:Label ID="LabelTitulo" runat="server" Text="Aniversariantes"></asp:Label></h2>
			        <br />
			    </td>
			</tr>
			<tr class="header">
			    <th>
                    <asp:LinkButton ID="LinkButton1"    runat="server" CommandArgument="01"  onclick="Mes_Click">Jan</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2"    runat="server" CommandArgument="02"  onclick="Mes_Click">Fev</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton3"    runat="server" CommandArgument="03"  onclick="Mes_Click">Mar</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton4"    runat="server" CommandArgument="04"  onclick="Mes_Click">Abr</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton5"    runat="server" CommandArgument="05"  onclick="Mes_Click">Mai</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton6"    runat="server" CommandArgument="06"  onclick="Mes_Click">Jun</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton7"    runat="server" CommandArgument="07"  onclick="Mes_Click">Jul</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton8"    runat="server" CommandArgument="08"  onclick="Mes_Click">Ago</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton9"    runat="server" CommandArgument="09"  onclick="Mes_Click">Set</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton10"   runat="server" CommandArgument="10"  onclick="Mes_Click">Out</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton11"   runat="server" CommandArgument="11"  onclick="Mes_Click">Nov</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton12"   runat="server" CommandArgument="12"  onclick="Mes_Click">Dez</asp:LinkButton>
                    &nbsp;|&nbsp;
                    <asp:LinkButton ID="LinkButton13"   runat="server" CommandArgument="hoje"  onclick="Mes_Click">Hoje</asp:LinkButton>
			    </th>
			</tr>
        </table>
        
        <asp:GridView ID="GridView1" runat="server"
            CssClass="GridViewStyle" 
            AllowPaging="True" 
            AllowSorting="True"
            AutoGenerateColumns="False" 
            GridLines="None"
            EnableSortingAndPagingCallbacks="True"
            Width="100%" 
            PageSize="5" onpageindexchanging="GridView1_PageIndexChanging" 
            onrowcreated="GridView1_RowCreated" 
            EmptyDataText="Nenhum registro encontrado." >
               
               <Columns>
                <asp:BoundField 
                    DataField="funcionarioNome" 
                    HeaderText="Nome" />
              
                <asp:BoundField 
                    DataField="funcionarioEMail" 
                    HeaderText="Email" >
                      
                   <ItemStyle Width="300px" />
                   </asp:BoundField>
                      
                <asp:BoundField 
                    DataField="funcionarioNascimento" 
                    HeaderText="Nascimento" 
                    DataFormatString="{0:dd/MM}" >
                
                   <ItemStyle Width="100px" />
                   </asp:BoundField>
                
                <asp:BoundField 
                    DataField="funcionarioAdmissao" 
                    HeaderText="Admissao" 
                    DataFormatString="{0:dd/MM/yyyy}" >
                   <ItemStyle Width="100px" />
                   </asp:BoundField>
            </Columns>

        </asp:GridView>
      
      <table class="GridViewStyle" width="100%">
        <tr>
            <th>
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
            </th>
        </tr>
      </table>
      
</asp:Content>
