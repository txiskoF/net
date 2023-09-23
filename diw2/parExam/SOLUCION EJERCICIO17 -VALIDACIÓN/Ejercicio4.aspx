<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4.aspx.cs" Inherits="EjercicioValidacion.Ejercicio4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="SCRIPTS/js.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        
         <tr>
            <td><b>Marca:</b></td>
            <td >
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Marca Coche</asp:ListItem>
                    <asp:ListItem>Renault</asp:ListItem>
                    <asp:ListItem>Ford</asp:ListItem>
                    <asp:ListItem>Mercedes</asp:ListItem>
                    <asp:ListItem>Seat</asp:ListItem>
                </asp:DropDownList>
            </td>
             <td colspan="3">
                    <asp:RequiredFieldValidator ID="rdvMarca" runat="server" ErrorMessage="Debe seleccionar la MARCA" ControlToValidate="DropDownList1" Display="Dynamic" InitialValue="Marca Coche"></asp:RequiredFieldValidator>
            </td>
       
        </tr>
         <tr>
            <td><b>Tipo:</b></td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>gasolina</asp:ListItem>
                    <asp:ListItem>diesel</asp:ListItem>
                </asp:RadioButtonList>
            </td>
           <td colspan="3">
                    &nbsp;</td>
        </tr>
        <tr>
            <td ><b>Total Km:</b></td>
            <td colspan="4">
                <asp:TextBox ID="txtKm" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="cvKm" runat="server" ControlToValidate="txtKm" ErrorMessage="EL número de km debe ser una cifra numérica" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
            </td>
          
        </tr>
        <tr>
            <td><b>Fecha Fabrica:</b></td>
            <td>
                <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
            </td>
            
            <td colspan="3">
                <asp:CompareValidator ID="cvFecha" runat="server" ControlToValidate="txtFecha" ErrorMessage="EL dato introducido no es una fecha o es posterior a la fecha actual" Operator="LessThanEqual" Type="Date" ValueToCompare="10/12/2020"></asp:CompareValidator>
            </td>
            
        </tr>
        <tr>
            <td><b>Número de Matícula:</b></td>
            <td colspan="4">
                <asp:TextBox ID="txtMatricula" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="rematricula" runat="server" ControlToValidate="txtMatricula" Display="Dynamic" ErrorMessage="La matrícula no sigue el patrón correcto" ValidationExpression="\d{4}\ [A-Z]{3}"></asp:RegularExpressionValidator>
            </td>
                        
        </tr>
        <tr>
            <td colspan="5">
                <asp:Button ID="btnAceptar" runat="server" Text="ACEPTAR" OnClick="btnAceptar_Click" /></td>
           
                        
        </tr>

    </table>
    </div>
    </form>
</body>
</html>
