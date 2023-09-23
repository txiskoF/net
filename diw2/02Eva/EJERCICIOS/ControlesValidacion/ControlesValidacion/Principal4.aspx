<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal4.aspx.cs" Inherits="ControlesValidacion.Principal4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
                    <asp:RequiredFieldValidator ID="rfvMarca" runat="server" ErrorMessage="Selecciones una marca" InitialValue="Marca Coche"></asp:RequiredFieldValidator>
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
                <asp:CompareValidator ID="cvKm" runat="server" ErrorMessage="Debe ser numerico" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
            </td>
          
        </tr>
        <tr>
            <td><b>Fecha Fabrica:</b></td>
            <td>
                <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
            </td>
            
            <td colspan="3">
                <asp:CompareValidator ID="cvFecha" runat="server" ControlToValidate="txtFecha" Display="Dynamic" ErrorMessage="La fecha debe ser anterior a la actual" Operator="LessThanEqual" Type="Date" ValueToCompare="07/12/2020"></asp:CompareValidator>
            </td>
            
        </tr>
        <tr>
            <td><b>Número de Matícula:</b></td>
            <td colspan="4">
                <asp:TextBox ID="txtMatricula" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtMatricula" ErrorMessage="La matricula debe ser de formato  0000-AAA" ValidationExpression="\d{4}|\s[A-Z]{3}"></asp:RegularExpressionValidator>
            </td>
                        
        </tr>
        <tr>
            <td colspan="5">
                <asp:Button ID="btnAceptar" runat="server" Text="ACEPTAR" OnClick="btnAceptar_Click" /></td>
           
                        
        </tr>

    </table>
    </div>
    </form>
</body></html>
