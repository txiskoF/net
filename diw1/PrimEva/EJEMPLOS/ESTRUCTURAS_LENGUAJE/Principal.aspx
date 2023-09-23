<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="ESTRUCTURAS_LENGUAJE.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnIF" runat="server" OnClick="BtnIF_Click" Text="IF" />
            <asp:Button ID="BtnSwitch" runat="server" OnClick="BtnSwitch_Click" Text="SWITCH" />
            <br />
            <br />
            <asp:Button ID="BtnFOR" runat="server" Text="FOR" OnClick="BtnFOR_Click" />
            <asp:Button ID="BtnForeach" runat="server" Text="FOREACH" OnClick="BtnForeach_Click" />
            <br />
            <br />
            <asp:TextBox ID="TxtPalabra" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LblSentencia" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="BtnWhile" runat="server" Text="WHILE" OnClick="BtnWhile_Click"  />
            <asp:Button ID="BtnDoWhile" runat="server" Text="DO WHILE" OnClick="BtnDoWhile_Click"  />
            <br />
            <br />
            <asp:Label ID="LblNumeros" runat="server"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
