<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resumenes.aspx.cs" Inherits="ExamenFinal.Resumenes" %>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resumenes.aspx.cs" Inherits="EXAMEN_BD_1_FINAL.Resumenes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<link rel="stylesheet" href="STYLES/estilo2.css"></link>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="auto-style5"><tr><td class="auto-style6" >
        <asp:Label ID="lblEditorial" runat="server" Text="Editorial:"  Font-Bold="True" ForeColor="#666633"></asp:Label>
       
        <asp:TextBox ID="txtEditorial" runat="server" Font-Bold="True" ForeColor="#666633" 
                style="margin-left: 0px" Width="133px"></asp:TextBox> 
        </td><td class="auto-style4">
       <asp:Label ID="lblProfesion" runat="server" Text="Profesión:"  Font-Bold="True" ForeColor="#666633"></asp:Label>
            
                  <asp:TextBox ID="txtProfesion" runat="server" Font-Bold="True" ForeColor="#666633" 
                style="margin-left: 0px" Width="98px"></asp:TextBox> 
       
       
            <asp:Button ID="btnMostrar" runat="server" Text="Mostrar Empleados" Font-Bold="True" ForeColor="#666633" Width="189px" />
       </td>
        </tr>
       <tr>
           <td class="auto-style6"></td>
            <td class="auto-style4" colspan="2">  
                <asp:Label ID="Label3" runat="server" Text="Min:"  Font-Bold="True" ForeColor="#666633"></asp:Label>
                <asp:textbox runat="server" ID="txtMin" Width="32px"></asp:textbox>
                <asp:Label ID="Label4" runat="server" Text="Max:"  Font-Bold="True" ForeColor="#666633"></asp:Label>
                <asp:textbox runat="server" ID="txtMax" Width="36px" Height="25px"></asp:textbox>  
                </td>

        </tr>
        <tr><td colspan="3">
            <asp:GridView ID="gvEmpleados" runat="server">
            </asp:GridView>
           </td>
           </tr>
           <tr><td colspan="3" class="auto-style3">
               &nbsp;</td></tr>
        
        </table>
    </div>
    </form>
</body>
</html>

