<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Portal._default" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/MasterPage.master"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            
                <!--/ TITULO BANNER INICIO /-->
                <div id="_banner">
                    <script type="text/javascript" src="imagerotator/swfobject.js"></script>
                    <script type="text/javascript">
                        var s1 = new SWFObject('imagerotator/imagerotator.swf', 'rotator', '930', '300', '9','#F1F1F1');
                        s1.addParam('allowfullscreen','false');
                        s1.addParam('allowscriptaccess','always');
                        s1.addParam('wmode','opaque');
                        /* s1.addVariable('logo','imagerotator/logo_mmstec.jpg');*/
                        s1.addVariable('transition','random');  // (default, random e randomly)  ou (fade, bgfade, blocks, bubbles, circles, flash, fluids, lines ou slowfade)
                        s1.addVariable('file','imagerotator/imagemCapa.xml');
                        s1.addVariable('width','930');
                        s1.addVariable('height','300');
                        s1.addVariable('rotatetime','180');
                        s1.addVariable('linkfromdisplay','true');
                        s1.addVariable('shownavigation','true');
                        s1.addVariable('imagerotator/expressinstall.swf');
                        s1.write("_banner");
                    </script>

                
                </div>
               <div class="sombra">&nbsp;</div>
                <!--/ TITULO BANNER FIM /-->
                
          
          <!--
             <div class="roundedcornr_box_710912">
               <div class="roundedcornr_top_710912"><div></div></div>
                  <div class="roundedcornr_content_710912">
                     <p>Lorem ipsum dolor sit amet, consectetur 
                     adipisicing elit, sed do eiusmod tempor incididunt 
                     ut labore et dolore magna aliqua. Ut enim ad minim 
                     veniam, quis nostrud exercitation ullamco laboris 
                     nisi ut aliquip ex ea commodo consequat. Duis aute 
                     irure dolor in reprehenderit in voluptate velit esse 
                     cillum dolore eu fugiat nulla pariatur. Excepteur 
                     sint occaecat cupidatat non proident, sunt in culpa 
                     qui officia deserunt mollit anim id est laborum.</p>
                  </div>
               <div class="roundedcornr_bottom_710912"><div></div></div>
            </div>
          -->
          <!--/ ANIVERSARIANTES INICIO /-->
          <asp:Panel ID="PanelAniversariantes" runat="server">
          <div class="roundedBox">
                        
                        <strong>
                            <asp:Label ID="LabelParabens" runat="server" Text="Label"></asp:Label>
                        </strong>
                        
                        <br /><br />
                        
                        <asp:GridView ID="GridView1" runat="server"
                        CssClass="GridViewStyle" 
                        AllowPaging="True" 
                        AllowSorting="True"
                        AutoGenerateColumns="False" 
                        GridLines="None"
                        EnableSortingAndPagingCallbacks="True"
                        Width="100%" 
                        PageSize="3" onpageindexchanging="GridView1_PageIndexChanging" 
                        onrowcreated="GridView1_RowCreated" >
                        
                        <Columns>
                        <asp:BoundField 
                            DataField="funcionarioNome" 
                            HeaderText="Nome"  
                            DataFormatString="{0:C}" >
                            <ItemStyle Width="100%" />
                            </asp:BoundField>
                       <asp:BoundField 
                            DataField="funcionarioCargo" 
                            HeaderText="Cargo"  
                            DataFormatString="{0:C}" >
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
                        <EmptyDataTemplate>
                        Não existe aniversariantes na data de hoje.
                        </EmptyDataTemplate>
                        </asp:GridView>
                        <div class="sombra">&nbsp;</div>
            </div>
            </asp:Panel>
           <!--/ ANIVERSARIANTES FIM /-->
 
</asp:Content>
