<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Validacion.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="SCRIPTS/Validacion.js"></script>
    <style type="text/css">
        .auto-style3 {
            width: 1233px;
        }
        .auto-style4 {
            width: 74px;
        }
        .auto-style5 {
            width: 168px;
        }
        .auto-style8 {
            width: 611px;
        }
        .auto-style9 {
            width: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style3">
                <tr><td class="auto-style4">DNI:</td><td class="auto-style5">
                    <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox></td><td class="auto-style8">
                        <asp:RequiredFieldValidator ID="rfvDNI" runat="server" ErrorMessage="Debes introducir tu DNI" ControlToValidate="txtDNI" ValidationGroup="correos">*</asp:RequiredFieldValidator></td><td class="auto-style9">
                        <asp:RegularExpressionValidator ID="reDNI" runat="server" ControlToValidate="txtDNI" ErrorMessage="Debes introducir 8 dígitos y una letra Mayúscula" ValidationExpression="\d{8}[\-\s]?[A-Za-z]" ValidationGroup="correos">*</asp:RegularExpressionValidator>
                    </td></tr>
                  <tr><td class="auto-style4">Nombre:</td><td class="auto-style5">
                      <asp:TextBox ID="TxtNombre" runat="server" OnTextChanged="TxtNombre_TextChanged"></asp:TextBox> </td><td class="auto-style8">
                          <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="Debes introducir tu Nombre" ControlToValidate="TxtNombre" ValidationGroup="correos">*</asp:RequiredFieldValidator></td><td class="auto-style9">&nbsp;</td></tr>
                  <tr><td class="auto-style4">Edad:</td><td class="auto-style5">
                      <asp:TextBox ID="TxtEdad" runat="server"></asp:TextBox></td><td class="auto-style8">
                          <asp:CompareValidator ID="cvEdad" runat="server" ErrorMessage="Tu edad debe ser superior a 18 años" ControlToValidate="TxtEdad" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="18">*</asp:CompareValidator></td><td class="auto-style9"></td></tr>
                  <tr><td class="auto-style4">Fecha de Contrato:</td><td class="auto-style5">
                      <asp:TextBox ID="TxtFContrato" runat="server"></asp:TextBox></td><td class="auto-style8">
                          <asp:CompareValidator ID="cvFecha" runat="server" ErrorMessage="La fecha de contrato debe ser inferior al día actual" ControlToValidate="TxtFContrato" Operator="GreaterThan" Type="Date" ValueToCompare="22/11/2019">*</asp:CompareValidator></td><td class="auto-style9"></td></tr>
                  <tr><td class="auto-style4">Salario:</td><td class="auto-style5">
                      <asp:TextBox ID="TxtSalario" runat="server"></asp:TextBox></td><td class="auto-style8">
                          <asp:RangeValidator ID="rvSalario" runat="server" ErrorMessage="Debes introducir un salario entre 1600 y 4000" ControlToValidate="TxtSalario" MaximumValue="4000" MinimumValue="1600" Type="Integer">*</asp:RangeValidator></td><td class="auto-style9">
                          &nbsp;</td></tr>
                <tr><td class="auto-style4">Correo:</td><td class="auto-style5">
                    <asp:TextBox ID="TxtCorreo" runat="server"></asp:TextBox></td><td class="auto-style8">
                    <asp:RegularExpressionValidator ID="reCorreo" runat="server" ErrorMessage="Debes introducir un correo electrónico válido" ControlToValidate="TxtCorreo" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="correos" Display="Dynamic"></asp:RegularExpressionValidator>
                        <asp:CustomValidator ID="cvCorreo" runat="server" ErrorMessage="Tiene que ser un correo perteneciente al colegio" ControlToValidate="TxtCorreo" Display="Dynamic" OnServerValidate="cvCorreo_ServerValidate" ValidationGroup="correos" ClientValidationFunction="validarCorreo"></asp:CustomValidator>

                                                                                  </td>

                    <td class="auto-style9">
                          
                      </td>
                </tr>
                <tr><td colspan="4">
                    <asp:Button ID="BtnEnviarDatos" runat="server" Text="Enviar Formulario" OnClick="BtnEnviarDatos_Click" />
                    <asp:Button ID="BtnValidaCorreo" runat="server" OnClick="BtnValidaCorreo_Click" Text="VALIDA SOLO CORREO" />
                    <asp:Button ID="btnGrupoValidacion" runat="server" Text="Valida GRUPO (dni,nombre,correo)" ValidationGroup="correos" />
                    </td></tr>
            </table>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="correos" />
    </form>
</body>
</html>
