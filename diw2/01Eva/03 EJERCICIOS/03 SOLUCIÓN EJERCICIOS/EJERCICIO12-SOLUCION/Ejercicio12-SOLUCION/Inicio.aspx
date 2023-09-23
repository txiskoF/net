<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Ejercicio12_SOLUCION.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:RadioButtonList ID="rdblBases" runat="server" AutoPostBack="True" 
            
            RepeatDirection="Horizontal" OnSelectedIndexChanged="rdblBases_SelectedIndexChanged">
            <asp:ListItem Value="2">Binario</asp:ListItem>
            <asp:ListItem Value="8">Octal</asp:ListItem>
            <asp:ListItem Value="10" Selected="True">Decimal</asp:ListItem>
            <asp:ListItem Value="16">Hexadecimal</asp:ListItem>
        </asp:RadioButtonList>
        <asp:TextBox ID="txtresultado" runat="server" ReadOnly="True">0.</asp:TextBox>
    <table>
        <asp:PlaceHolder ID="pnldecimal" runat="server">
    <tr>
    <td><asp:Button ID="btn7" runat="server" Text="7" onclick="escribir"/></td>
    <td><asp:Button ID="btn8" runat="server" Text="8" onclick="escribir" /></td>
    <td><asp:Button ID="btn9" runat="server" Text="9" onclick="escribir"/></td>
    </tr>
     <tr>
    <td><asp:Button ID="btn4" runat="server" Text="4" onclick="escribir" /></td>
    <td><asp:Button ID="btn5" runat="server" Text="5" onclick="escribir"/></td>
    <td><asp:Button ID="btn6" runat="server" Text="6" onclick="escribir" /></td>
    </tr>
     <tr>
    <td><asp:Button ID="btn1" runat="server" Text="1" onclick="escribir"/></td>
    <td><asp:Button ID="btn2" runat="server" Text="2" onclick="escribir" /></td>
    <td><asp:Button ID="btn3" runat="server" Text="3" onclick="escribir" /></td>
    </tr>
    </asp:PlaceHolder>
       <tr>
    <td></td>
    <td><asp:Button ID="btn0" runat="server" Text="0" onclick="escribir" /></td>
    <td><asp:Button ID="btnClear" runat="server" Text="C" OnClick="btnClear_Click"   /></td>
    </tr>
    </table>
    <table>
        <asp:PlaceHolder ID="pnlhexadecimal" runat="server" >
    <tr>
    <td><asp:Button ID="btnA" runat="server" Text="A" onclick="escribir" /></td>
     <td><asp:Button ID="btnB" runat="server" Text="B" onclick="escribir"/></td>
      <td><asp:Button ID="btnC" runat="server" Text="C" onclick="escribir"/></td>
       <td><asp:Button ID="btnD" runat="server" Text="D" onclick="escribir"/></td>
        <td><asp:Button ID="btnE" runat="server" Text="E" onclick="escribir"/></td>
         <td><asp:Button ID="btnF" runat="server" Text="F" onclick="escribir"/></td>
    </tr>
      </asp:PlaceHolder>
    </table>
    </div>
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" Width="174px">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:ListBox>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </form>
</body>
</html>
