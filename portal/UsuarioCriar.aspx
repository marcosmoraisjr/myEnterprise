<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuarioCriar.aspx.cs" Inherits="portal.CriarUsuario" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta http-equiv="Page-Exit" content="blendTrans(Duration=2)" />
	<link href="css/criarusuario.css" rel="stylesheet" type="text/css" />
    <title>Tudo em um só lugar | ENTERPRISE </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" 
            CssClass="criarusuario" 
            CancelDestinationPageUrl="~/Login.aspx" DisplayCancelButton="True" 
            FinishDestinationPageUrl="~/" Height="330px" Width="450px" 
            ContinueDestinationPageUrl="~/Default.aspx">
            <FinishCompleteButtonStyle CssClass="botao" />
            <StepNextButtonStyle CssClass="botao" />
            <CreateUserButtonStyle CssClass="botaoright" />
            <CancelButtonStyle CssClass="botaoleft" />
            <WizardSteps>
                <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                </asp:CreateUserWizardStep>
                <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                    <ContentTemplate>
                        <table border="0" style="font-size:100%;height:330px;width:450px;">
                            <tr>
                                <td align="center" colspan="2">
                                    Complete</td>
                            </tr>
                            <tr>
                                <td>
                                    Your account has been successfully created.</td>
                            </tr>
                            <tr>
                                <td align="right" colspan="2">
                                    <asp:Button ID="ContinueButton" runat="server" CausesValidation="False" 
                                        CommandName="Continue" Text="Continue" ValidationGroup="CreateUserWizard1" 
                                        PostBackUrl="~/Logout.aspx" />
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:CompleteWizardStep>
            </WizardSteps>
        </asp:CreateUserWizard>
    </div>
    </form>
</body>
</html>
