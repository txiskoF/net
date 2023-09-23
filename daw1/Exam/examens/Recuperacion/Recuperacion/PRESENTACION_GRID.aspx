<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PRESENTACION_GRID.aspx.cs" Inherits="Recuperacion.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView runat="server" ID="gvDatos" AutoGenerateColumns="False">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
