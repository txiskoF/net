<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario3.aspx.cs" Inherits="BIOTEK.Formulario3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="PanelBotones" runat="server">
            <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" />

        </asp:Panel>
        <asp:Panel ID="Panel1" runat="server">
            <p>BIOTEK</p>
            <p>Colegio Zabalburu</p>
            
        </asp:Panel>
        <div>

            <asp:Panel ID="Panel2" runat="server" Width="600px" Height ="500px">
            </asp:Panel>
        </div>
    </form>
</body>
</html>
