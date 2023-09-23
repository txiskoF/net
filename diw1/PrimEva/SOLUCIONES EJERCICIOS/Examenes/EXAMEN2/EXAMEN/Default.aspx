<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
    .panel 
    {
        float:left;
    }
   .imagen
   {
       margin-top:10px;
       float:right;
       }
        .textos
        {
            
         position: absolute;
            left: 150px;
            
        }
           .sueldos
        {
            position: absolute;
            left: 250px;
            
        }
        .extras
        {
          
            position: absolute;
            left: 140px;
            
        }
        .extratextos
        {
            position:absolute;
            left:250px;
            right: 695px;
        }
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 371px">
        <asp:Panel ID="pnldatospersonales" runat="server" 
            GroupingText="Datos Personales" Width="783px">
          <asp:Image ID="imgpuesto" runat="server" 
                 CssClass ="imagen" Height="94px" 
                Width="100px"/>
            <asp:Label ID="Label2" runat="server" Text="Número Empleado: "></asp:Label>
            <asp:TextBox ID="txtnumeroE" runat="server" CssClass ="textos"></asp:TextBox>
        <br />
          <asp:Label ID="Label1" runat="server" Text="Nombre Empleado: "></asp:Label>
            <asp:TextBox ID="txtnombreE" runat="server" CssClass ="textos" 
              ></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Departamento: "></asp:Label>
            <asp:TextBox ID="txtdpto" runat="server" CssClass ="textos" AutoPostBack="True" 
               ></asp:TextBox>
        <br />
         <asp:Label ID="Label4" runat="server" Text="Situación: "></asp:Label><asp:TextBox ID="txtsituacion" runat="server" CssClass ="textos"></asp:TextBox>
        <br />
         <asp:Label ID="Label5" runat="server" Text="Teléfono: "></asp:Label><asp:TextBox ID="txttelefono" runat="server" CssClass ="textos"></asp:TextBox>
          
        <br /><br />
        <asp:ImageButton ID="imgbsueldo" runat="server" Height="94px" Width="172px" 
                 CssClass="imagen"  />
       <div>
        <asp:Panel ID="pnlpuesto" runat="server" CssClass ="panel" 
              GroupingText="Puesto de Trabajo">
               
              
            <asp:RadioButtonList ID="rdblpuesto" runat="server" AutoPostBack="True" 
               >
                <asp:ListItem>Programador</asp:ListItem>
                <asp:ListItem>Analista</asp:ListItem>
                <asp:ListItem>Jefe de Proyecto</asp:ListItem>
            </asp:RadioButtonList>
            </asp:Panel>
             <asp:Panel ID="pnlprogramador" runat="server" CssClass ="panel" 
              GroupingText="Puesto Programador">
            <asp:RadioButtonList ID="rdblprogramador" runat="server" AutoPostBack="True" 
                    >
                <asp:ListItem >Programador Junior</asp:ListItem>
                <asp:ListItem >Programador Junior-Senior</asp:ListItem>
                <asp:ListItem >Programador Senior</asp:ListItem>
            </asp:RadioButtonList>
            </asp:Panel>
           </div>
            <asp:Panel ID="pnlanalista" runat="server" CssClass ="panel" 
              GroupingText="Puesto Analista">
            <asp:RadioButtonList ID="rdblanalista" runat="server" AutoPostBack="True" 
                    >
                <asp:ListItem >Analista-Programador</asp:ListItem>
                <asp:ListItem >Analista Senior</asp:ListItem>
            </asp:RadioButtonList>
            <br />
        </asp:Panel>
        
       
    </asp:Panel>
       
    
            <br />
        <asp:Panel ID="pnlsueldos" runat="server"  GroupingText ="Sueldos de Empleados" 
            Height="158px" Width="781px">
        <asp:Panel ID="pnlretencion" runat="server"  GroupingText ="Retención" CssClass="panel"
                Width="104px">
            <asp:RadioButton ID="rdb17" runat="server" Text="17%" 
                
                 />
            <br />
            <asp:RadioButton ID="rdb19" runat="server" Text="19%"
              
                />
            <br />
            <asp:RadioButton ID="rdb21" runat="server" Text="21%" GroupName="retencion"
          />
            </asp:Panel>
           
            <asp:Label ID="Label7" runat="server" Text="Sueldo Base: " CssClass="textos"></asp:Label> <asp:TextBox ID="txtsueldobase" runat="server" CssClass="sueldos"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Retención: " CssClass="textos"></asp:Label> <asp:TextBox ID="txtretencion" runat="server" CssClass="sueldos"></asp:TextBox>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Sueldo Neto: " CssClass="textos"></asp:Label> <asp:TextBox ID="txtsueldoneto" runat="server" CssClass="sueldos"></asp:TextBox>
             
             <asp:Button ID="btnpesetas" runat="server" Text="PESETAS" CssClass="imagen" 
                Width="150" onclick="btnpesetas_Click" />
                <asp:Button ID="btneuros" runat="server" Text="EUROS" CssClass="imagen" 
                Width="150" onclick="btneuros_Click" />
             <br /><br />
             
             
             
           <div>
            <asp:CheckBoxList ID="chklextras" runat="server" CssClass="extras" 
                   AutoPostBack="True" onselectedindexchanged="chklextras_SelectedIndexChanged">
                <asp:ListItem>Horas Extras</asp:ListItem>
                <asp:ListItem>Guardias</asp:ListItem>
            </asp:CheckBoxList> </div>
             <asp:Button ID="btnreiniciar" runat="server" Text="Reiniciar" 
                CssClass="imagen" Width="300"/>
            <asp:TextBox ID="txthorasextras" runat="server"  Width ="50px" 
                CssClass="extratextos" 
                ontextchanged="txthorasextras_TextChanged"></asp:TextBox><br />
             <asp:TextBox ID="txtguardias" runat="server"  Width ="50px" 
                CssClass="extratextos" ></asp:TextBox><br />
            
             <br />
            
            
        </asp:Panel>
       
    
    </div>
    </form>
</body>
</html>
