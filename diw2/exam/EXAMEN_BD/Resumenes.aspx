<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resumenes.aspx.cs" Inherits="EXAMEN_BD.Resumenes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Resúmenes</title>
<link rel="stylesheet" href="STYLES/estilo2.css"/>
    <style type="text/css">
        .auto-style7 {
            width: 295px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   
        <div style="margin-left:8cm;margin-top:4cm;margin-right:3cm;padding-left:2cm;padding-top:1cm;"; class="auto-style9" >
    
  
    <table class="auto-style5">
         <tr style="background-color:#0275d8;color:#ffffff;"><td colspan="3"><h1> Resúmenes</h1></td></tr>
        <tr><td class="auto-style7" >
        
        <asp:Label ID="lblEditorial" runat="server" Text="Editorial:"  Font-Bold="True"  ></asp:Label>
       
        <asp:TextBox ID="txtEditorial" runat="server" Font-Bold="True" 
                style="margin-left: 0px" Width="133px"  ></asp:TextBox> 
        </td><td class="auto-style4">
       <asp:Label ID="lblProfesion" runat="server" Text="Profesión:"  Font-Bold="True" ></asp:Label>
            
                  <asp:TextBox ID="txtProfesion" runat="server" Font-Bold="True" 
                style="margin-left: 0px" Width="98px" ></asp:TextBox> 
       
       
            <asp:Button ID="btnMostrar" runat="server" Text="Mostrar Empleados" Font-Bold="True"  Width="297px"  BackColor="#0275d8" ForeColor="#ffffff" />
       </td>
        </tr>
       <tr>
           <td class="auto-style7"></td>
            <td class="auto-style4" colspan="2">  
                <asp:Label ID="Label3" runat="server" Text="Min:"  Font-Bold="True"  ></asp:Label>
                <asp:textbox runat="server" ID="txtMin" Width="32px"></asp:textbox>
                <asp:Label ID="Label4" runat="server" Text="Max:"  Font-Bold="True"  ></asp:Label>
                <asp:textbox runat="server" ID="txtMax" Width="36px" Height="25px" ></asp:textbox>  
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

