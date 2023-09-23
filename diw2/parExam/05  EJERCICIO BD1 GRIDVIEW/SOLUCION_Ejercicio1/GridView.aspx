<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="SOLUCION_Ejercicio1.GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblClientes" runat="server" Text="Label"></asp:Label>
            <asp:DropDownList ID="ddlClientes" runat="server"></asp:DropDownList>
            <asp:Label ID="lblProductos" runat="server" Text="Label"></asp:Label>
            <asp:DropDownList ID="ddlProductos" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:GridView ID="gvPedidos" runat="server" OnSelectedIndexChanged="gvPedidos_SelectedIndexChanged" >


            </asp:GridView>
        </div>
    </form>
</body>
</html>
