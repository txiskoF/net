<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="Principal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="SCRIPTS/validacion.js"></script>
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <tr>
    <td><b>Nombre:</b></td><td>
        <asp:TextBox ID="txtNombre" runat="server" ValidationGroup="validapersonal"></asp:TextBox></td><td>
            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" 
                ErrorMessage="Debe introducir el campo Nombre" ControlToValidate="txtNombre" 
                ForeColor="Red">* </asp:RequiredFieldValidator></td>
    </tr>
    <tr>
    <td class="style1"><b>Edad:</b></td><td class="style1">
        <asp:TextBox ID="txtEdad" runat="server" ValidationGroup="validapersonal"></asp:TextBox></td><td class="style1">
            <asp:RequiredFieldValidator ID="rfvEdad" runat="server" 
                ErrorMessage="Debe introducir una edad" ControlToValidate="txtEdad" 
                ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="cvEdad" runat="server" 
                ErrorMessage="La edad debe ser superior a 18" ControlToValidate="txtEdad" 
                ForeColor="Red" Operator="GreaterThanEqual" ValueToCompare="18" Display="Dynamic" Type="Integer">*</asp:CompareValidator>
        </td>
    </tr>
    <tr>
    <td><b>Fecha Nacimiento:</b></td><td>
        <asp:TextBox ID="txtFechaNcto" runat="server" ValidationGroup="validapersonal"></asp:TextBox></td><td>
            <asp:CompareValidator ID="cvtipofecha" runat="server" 
                ErrorMessage="Debe introducir un formato fecha" 
                ControlToValidate="txtFechaNcto" ForeColor="Red" Operator="DataTypeCheck" 
                Type="Date">*</asp:CompareValidator>
            <asp:CompareValidator ID="cvfechancto" runat="server" 
                ErrorMessage="La fecha debe ser menor a la del día de hoy" 
                ControlToCompare="txtfechaActual" ControlToValidate="txtFechaNcto" 
                Display="Dynamic" ForeColor="Red" Operator="LessThan" ValueToCompare="29/11/2016">*</asp:CompareValidator>
        </td>
    </tr>
     <tr>
    <td><b>Correo:</b></td><td>
        <asp:TextBox ID="txtcorreo" runat="server" ValidationGroup="validamail"></asp:TextBox></td><td>
             <asp:RegularExpressionValidator ID="recorreo" runat="server" 
                 
                 ErrorMessage="La dirección introducida no cumple con la sintaxis correcta de cuentas de correo." 
                 ControlToValidate="txtcorreo" ForeColor="Red" 
                 ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
         </td>
         <tr>
    <td><b>Edad Mínima:</b></td><td>
        <asp:TextBox ID="txtEdadMinima" runat="server" ValidationGroup="validapersonal"></asp:TextBox></td><td>
                 <asp:RangeValidator ID="rvEdadminima" runat="server" 
                     ErrorMessage="Debe introducir una edad entre 18 y 65 años" ControlToValidate="txtEdadMinima" MaximumValue="65" MinimumValue="18" Type="Integer">*</asp:RangeValidator>
             </td>
    </tr>
    <tr>
    <td colspan="3">
        <asp:Button ID="btnAceptar" runat="server" Text="ACEPTAR" OnClick="btnAceptar_Click" ValidationGroup="validapersonal" />
        <asp:TextBox ID="txtfechaActual" runat="server">3/12/2018</asp:TextBox>
        <br />
        <asp:Label ID="lblresultados" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
    <td colspan="3">
        <asp:TextBox ID="txtnumero" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="cvnumeroPAR" runat="server" ControlToValidate="txtnumero" ErrorMessage="El numero que ha introducido no es PAR" EnableClientScript="False" ForeColor="Red" OnServerValidate="cvnumeroPAR_ServerValidate">*</asp:CustomValidator>
        <asp:Button ID="btnAceptar0" runat="server" Text="ACEPTAR" OnClick="btnAceptar_Click" ValidationGroup="validamail" />
        </td>
    </tr>
    </table>
    </div>
        <asp:ValidationSummary ID="vsresumen" runat="server" ShowMessageBox="True" ShowSummary="False" />
    </form>
</body>
</html>
