<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="404.aspx.cs" Inherits="portal.msg._04" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>MMSTEC - Acesso negado | Erro Deny</title>
    <style type="text/css">
        *
        {
            margin: 0;
            padding: 0;
        }
        html, body
        {
            width: 100%;
            height: 100%;
            margin: 0px;
            padding: 0px;
            background-color: #990000;
        }
        #caixa
        {
            position:absolute;
            left:50%;
            top:50%;
            margin-left:-389px;
            margin-top:-276px;
            display: table;
        }
        .texto
        {
            position: absolute;
            left: 37px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: 22px;
            color: #FFFFFF;
            top: 378px;
            letter-spacing: -1px;
            text-align: justify;
            width: 630px;
        }
        .botaoVerde
        {
            width: 130px;
            height: 30px;
            line-height: 10px;
            background-color: #009900;
            font-family: tahoma;
            font-size: 11px;
            color: #FFFFFF;
            border-color: #00CC00;
            font-weight: bold;
            cursor: hand;
        }

    </style>
    <script language="javascript" type="text/javascript">
    // <!CDATA[
            function Button1_onclick() {
                location.href = "../login.aspx";      
            }
    // ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">

        <div id="caixa">
                    <div class="texto">
                        <div align="center" style="margin-top:20px; color:Black">
                            <strong>
                                Olá,
                                <asp:LoginName ID="LoginName1" runat="server" />.
                                &nbsp;A opção requisitada está em desenvolvimento. 
                                <br />Por favor, aguarde próximas versões.
                            </strong>
                            <br />
                            <br />
                            <input id="Button1" type="button" value="Trocar Usuário" onclick="return Button1_onclick()" class="botaoVerde" />
                         </div>
                    </div>
                    <img src="/portal/msg/images/404.png" alt="Erro 404" width="778" height="573" border="0" usemap="#" />
                    <map name="MMSTEC" id="MMSTEC">
                      <area shape="rect" coords="193,45,567,163" href="/" target="_self" alt="MMSTEC| clique aqui para voltar" />
                    </map>
          </div>
     </form>
</body>
</html>

