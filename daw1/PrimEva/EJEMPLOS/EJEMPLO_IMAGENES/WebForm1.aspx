﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EJEMPLO_IMAGENES.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="ImgCiudad" runat="server" AlternateText="Imagen de Barcelona" Height="310px" ImageUrl="~/IMAGENES/Barcelona.jpg" Width="347px" />
            <asp:ImageButton ID="ImgbtnCiudad" runat="server" />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Button" />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Variables" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Matrices" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
