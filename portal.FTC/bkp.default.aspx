<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bkp.default.aspx.cs" Inherits="Intranet._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<!--
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::                                                                      
SOLUÇÃO DESENVOLVIDA POR: 
- MARCOS MORAIS DE SOUSA
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
/--> 

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta http-equiv="Page-Exit" content="blendTrans(Duration=0)" />
	<style type="text/css" media="screen">@import url("css/estilo.css");</style>
    <title>Tudo em um só lugar | Centro Virtual de Arquivos</title>
</head>

<body>
    <br /><br /><br />
    <form id="form1" runat="server">
        <div id="pagina">
        
            <!--BORDAS INICIO--> 
            <div id="_borda" class="bordaE"><!--x--></div> 
            <div id="_borda" class="bordaD"><!--x--></div> 
            <!--BORDAS FIM--> 
            
            <!--TOPO INICIO-->
	        <div id="_topo" class="topo">
		        <div class="logo">
				    <img src="imagens/logoFTC.png" title="" alt="" />
		        </div> 
		        <div class="titulo">
			        CENTRO VIRTUAL DE ARQUIVOS
		        </div> 
	        </div>
	        <!--TOPO FIM-->
	        
            
            <!-- TITULO BANNER INICIO -->
            <div id="_banner">    
			    <script type="text/javascript" src="imagerotator/swfobject.js"></script>
					    <script type="text/javascript">
						    var s1 = new SWFObject('imagerotator/imagerotator.swf','rotator','930','300','1');
						    s1.addParam('allowfullscreen','false');
						    s1.addParam('allowscriptaccess','always');
						    s1.addParam('wmode','opaque');
						    /* s1.addVariable('logo','imagerotator/logo_mmstec.jpg');*/
						    s1.addVariable('transition','flash');  // (default, random e randomly)  ou (fade, bgfade, blocks, bubbles, circles, flash, fluids, lines ou slowfade)
						    s1.addVariable('file','imagerotator/imagemCapa.xml');
						    s1.addVariable('width','930');
						    s1.addVariable('height','300');
						    s1.addVariable('rotatetime','60');
						    s1.addVariable('linkfromdisplay','true');
						    s1.addVariable('shownavigation','true');
						    s1.addVariable('imagerotator/expressinstall.swf');
						    s1.write("_banner");
					    </script>
            </div>
            <!-- TITULO BANNER FIM -->
                
            <!--CONTEUDO INICIO-->
		    <div id="_conteudo">

		        <div class="coluna">
				<div id="Div1">
	            <h5><strong>Favoritos:</strong></h5>
					        <h2>Selecione um site que deseja ter acesso e clique em "continuar".</h2>
					        <br /><br />
                            <form name="formSistemas" method="post" >
					        <p>
							        <select class="combobox" name="comboboxSistemas" size="1px" >
                                         <option>FTC de A a Z</option> 
								         <option value="http://portal.ftc.br/index.php">Portal FTC</option> 
								         <option value="http://webmail.ftc.br/imp/login.php?Horde=04ui95c8k73f261csaiholbif7">Email FTC</option> 
 								         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=750&Itemid=839" >Avaliação Institucional</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=503&Itemid=490" >Biblioteca</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=301&Itemid=219" >Bolsas, Descontos e Financiamento </option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=64&Itemid=509" >Central de Atendimento ao Aluno</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_wrapper&Itemid=691" >Circulador</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_frontpage&Itemid=861" >Cursos</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_poll&Itemid=523" >Enquetes</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=120&Itemid=468" >Escritório de projetos</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_frontpage&Itemid=259" >Esporte</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=317&Itemid=230" >Estrutura Organizacional</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_jcalpro&Itemid=862" >Eventos</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=668&Itemid=816" >Extensão</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_frontpage&Itemid=542" >FTC Digital</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=blogcategory&id=238&Itemid=845" >FTC Verde</option> 
                                         <option value="http://www.fundacaoftc.org.br">Fundação FTC</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=320&Itemid=240" >Guia do Aluno</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=332&Itemid=258" >Guia do Professor</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_frontpage&Itemid=1" >Início</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=65&Itemid=44" >Institucional</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=87&Itemid=59" >Mestrado em Bioenergia</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=category&sectionid=1&id=2&Itemid=485" >Notícias</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=70&Itemid=46" >Ouvidoria</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=509&Itemid=506" >Perguntas Frequentes</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=6&Itemid=30" >Pesquisa</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=94&Itemid=67" >Pós-graduação</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_frontpage&Itemid=696" >Processo Seletivo</option> 
                                         <option value="http://dialogos.ftc.br" >Revista Diálogos & Ciência</option> 
                                         <option value="http://portal.ftc.br/index.php?option=com_content&task=view&id=233&Itemid=810" >Vantagem Amiga</option> 

							        </select>
							        <br />
							        <input type="button" class="botaoLaranja" onclick="location = ''+document.formSistemas.comboboxSistemas.options[document.formSistemas.comboboxSistemas.selectedIndex].value;" value=" Continuar >> " />
					        </p>
					        </form>
				</div>
				
				<!-- <div id="Div2">
	            <h5><strong>Favoritos:</strong></h5>
					        <h2>Selecione um site que deseja ter acesso e clique em "continuar".</h2>
					        <br /><br />
					        <form name="formLinks" method="post">
					        <p>
							        <select class="combobox" name="comboboxLinks" size="1">
								        <option>FTC EXEMPLOS</option> 
								        <option value="http://www.spc.com.br/">1 - SPC</option> 
								        <option value="http://www.serasa.com.br">2 - SERASA</option> 
								        <option value="http://www.bb.com.br">3 - Banco do Brasil</option> 
								        <option value="http://www.caixa.com.br">4 - Caixa Econômica Federal</option> 
								        <option value="http://www.bancodonordeste.com.br">5 - Banco do Nordeste</option> 
								        <option value="http://www.bradesco.com.br">6 - Bradesco</option> 
							        </select>
							        <br />
							        <input type="button" class="botaoAzul" onclick="location = ''+document.formLinks.comboboxLinks.options[document.formLinks.comboboxLinks.selectedIndex].value;" value=" Continuar >> " />
					        </p>
					        </form>	
				</div>
				-->
				
				<div id="Div2">
				  <h5><strong>Arquivos:</strong></h5>
					        <h2>Arquivos e documentos</h2>
					        <br /><br />
					        <form name="formArquivos" method="post" >
					        <p>
							        <select class="combobox" name="comboboxArquivos" size="1" >
								        <option>FTC PROFESSORES</option> 
								        <option value="arquivos/agnaldovolpe/">Agnaldo Volpe</option> 
								        <option value="arquivos/antonioluis/">Antonio Luis</option> /-->
								        <option value="arquivos/lucianopestana">Luciano Pestana</option> 
								        <option value="arquivos/">Todos os cursos</option> 
							        </select>
							        <br />
							        <input type="button" class="botaoVerde" onclick="location = ''+document.formArquivos.comboboxArquivos.options[document.formArquivos.comboboxArquivos.selectedIndex].value;" value=" Continuar >> " />
					        </p>
					        </form>
				</div>
				
				<div id="Div3">
				  <h5><strong>Arquivos:</strong></h5>
					        <h2>Arquivos e documentos</h2>
					        <br /><br />
                            <p>
                            <asp:DropDownList ID="DropDownListArquivos" runat="server" class="combobox">
                            </asp:DropDownList>
                            <br />
                            <asp:Button ID="ButtonArquivos" runat="server" Text="Continuar >>" class="botaoAzul" />
                            </p>
				</div>
				
		        </div> 
		    </div>
            <!--CONTEUDO FIM-->
            
            <!--RODAPE INICIO-->
            <div id="_rodape">
                Se desejar uma solução semelhantes a esta, entre em contato. 73.8102.3484
            </div>
            <!--RODAPE FIM-->

        </div>
    </form>
</body>

</html>
