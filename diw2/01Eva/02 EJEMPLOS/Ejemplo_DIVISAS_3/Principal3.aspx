<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal3.aspx.cs" Inherits="Ejemplo_DIVISAS_3.Principal3" %>

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
            <asp:Button ID="BtnDolarUSA" runat="server" Text="DOLAR USA" OnCommand="Calcular" CommandArgument="1,35" CommandName="Dolares Americanos" /><br/>
            <asp:Button ID="BtnDolarCAN" runat="server" Text="DOLAR CAN" OnCommand="Calcular" CommandArgument="1,39" CommandName="Dolares Canadienses" /><br/>
            <asp:Button ID="BtnDolarAUS" runat="server" Text="DOLAR AUS" OnCommand="Calcular" CommandArgument="1,43" CommandName="Dolares Australianos" /><br/>
            <asp:Button ID="BtnPesoARG" runat="server" Text="PESO ARG" OnCommand="Calcular" CommandArgument="7,78" CommandName="Pesos Argentinos" /><br/>
        </div>
    </form>
</body>
</html>
