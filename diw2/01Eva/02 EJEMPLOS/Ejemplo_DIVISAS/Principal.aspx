<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Ejemplo_DIVISAS.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblMoneda" runat="server" Text="Monedas"></asp:Label>
            <asp:TextBox ID="TxtMonedas" runat="server"></asp:TextBox>
            <asp:Label ID="LblCambio" runat="server" Text=""></asp:Label><br/>
            <asp:Button ID="BtnDolarUSA" runat="server" Text="DOLAR USA" OnClick="BtnDolarUSA_Click" /><br/>
            <asp:Button ID="BtnDolarCAN" runat="server" Text="DOLAR CAN" OnClick="BtnDolarCAN_Click" /><br/>
            <asp:Button ID="BtnDolarAUS" runat="server" Text="DOLAR AUS" OnClick="BtnDolarAUS_Click" /><br/>
            <asp:Button ID="BtnPesoARG" runat="server" Text="PESO ARG" OnClick="BtnPesoARG_Click" /><br/>
        </div>
    </form>
</body>
</html>
