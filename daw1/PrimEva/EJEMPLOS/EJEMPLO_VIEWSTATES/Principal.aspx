<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="EJEMPLO_VIEWSTATES.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TxtNumero" runat="server"></asp:TextBox>
            <asp:Button ID="BtnIncremento" runat="server" Text="+1" OnClick="BtnIncremento_Click" />
            <asp:Button ID="BtnDecremento" runat="server" Text="-1" OnClick="BtnDecremento_Click" />
            <br />
            <br />
            <br />
  
            <br />
            <br />
        </div>
    </form>
</body>
</html>
