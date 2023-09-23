<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PRESENTACION_GRID.aspx.cs" Inherits="EXAMENDOS.PRESENTACION_GRID" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body  bgcolor="#bbbb88">
    <form id="form1" runat="server">
    <div>
   <asp:GridView runat="server" ID="gvDatos" >
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <Columns>
        </Columns>


       



   </asp:GridView>
    </div>
    </form>
</body>
</html>

