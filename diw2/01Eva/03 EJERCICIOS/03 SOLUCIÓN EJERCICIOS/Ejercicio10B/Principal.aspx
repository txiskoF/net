<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Ejercicio10B.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <div>
     <asp:Panel ID="pnlBebida" runat="server" 
            
            style="z-index: 1; left: 9px; top: 26px; position: absolute; height: 191px; width: 286px" 
            GroupingText="Seleccione su bebida">
            <asp:RadioButtonList ID="rdbBebidas" runat="server" AutoPostBack="True" 
                onselectedindexchanged="rdbBebidas_SelectedIndexChanged">
                <asp:ListItem Value="Cafe">Cafe</asp:ListItem>
                <asp:ListItem Value="Te">Te</asp:ListItem>
                <asp:ListItem Value="Chocolate">Chocolate</asp:ListItem>
                <asp:ListItem Value="Infusión">Infusion</asp:ListItem>
                <asp:ListItem Value="Leche">Leche</asp:ListItem>
                <asp:ListItem Value="Caldo">Caldo</asp:ListItem>
            </asp:RadioButtonList>
          </asp:Panel>
          
          
    <asp:Panel ID="pnlAzucar" runat="server" 
        
            style="z-index: 1; left: 611px; top: 27px; position: absolute; height: 116px; width: 250px" 
            GroupingText="Detalles Azúcar" Visible="False">

        <asp:RadioButtonList ID="rdbAzucar" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rdbAzucar_SelectedIndexChanged" 
        >
            <asp:ListItem>Poco Azúcar</asp:ListItem>
            <asp:ListItem>Mucho Azúcar</asp:ListItem>
            <asp:ListItem>Sin Azúcar</asp:ListItem>
        </asp:RadioButtonList>


    </asp:Panel>



            <asp:Panel ID="pnlLeche" runat="server" 
                
            style="z-index: 1; left: 305px; top: 27px; position: absolute; height: 126px; width: 293px" 
            GroupingText="Detalles Bebida" Visible="False">
                <asp:RadioButtonList ID="rdbLeche" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="rdbLeche_SelectedIndexChanged">
                    <asp:ListItem>Solo</asp:ListItem>
                    <asp:ListItem Value="con poca leche">Min Leche</asp:ListItem>
                    <asp:ListItem Value="con mucha leche">Max Leche</asp:ListItem>
                </asp:RadioButtonList>
        </asp:Panel>
    
   

     </div>
    <asp:Button 
        ID="btnPrecio" runat="server" 
        
        style="z-index: 1; left: 13px; top: 264px; position: absolute; height: 26px" 
        Text="Precio" OnClick="btnPrecio_Click"  />
    <p>
        <asp:ImageButton ID="imgTaza" runat="server" ImageUrl="~/IMAGENES/tazacafe.jpg" 
            
            style="z-index: 1; left: 584px; top: 190px; position: absolute; height: 208px; width: 273px" OnClick="imgTaza_Click" 
            />
    </p>
    <asp:Panel ID="Panel1" runat="server" 
        
        style="z-index: 1; left: 266px; top: 234px; position: absolute; height: 34px; width: 311px">
        
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" 
        style="z-index: 1; left: 34px; top: 317px; position: absolute; height: 129px; width: 456px">
    </asp:Panel>
    </div>
    </form>
</body>
</html>
