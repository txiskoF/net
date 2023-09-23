<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="Principal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="SCRIPTS/Js6.js"></script>
    <script type='text/javascript'
src='http://www.bing.com/api/maps/mapcontrol?callback=GetMap&key=AgYuBE0uerBUG
Dd98UgIiVxXNpETDk9ws2POifvs_Dps4aw7eCHAkJ9wSGM-tTQU' async defer></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       
    
     

       
    
        <asp:Button ID="btnIdaVuelta" runat="server" OnClick="btnIdaVuelta_Click" style="z-index: 1; left: 657px; top: 654px; position: absolute" Text="Ida y Vuelta" />
        <asp:TextBox ID="txteuros" runat="server" style="z-index: 1; left: 470px; top: 628px; position: absolute" AutoPostBack="True" OnTextChanged="txteuros_TextChanged" ></asp:TextBox>
    
       
    
     

       
    
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 377px; top: 589px; position: absolute; height: 24px" Text="Km."></asp:Label>
        <asp:Label ID="LblLatitud" runat="server" Text="43.260285" style="z-index: 1; left: 866px; top: 240px; position: absolute"></asp:Label>
        <asp:Label ID="LblLongitud" runat="server" Text="-2.919633" style="z-index: 1; left: 871px; top: 260px; position: absolute; width: 84px"></asp:Label>
    
       
    
     

       
    
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 807px; top: 240px; position: absolute" Text="Latitud"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 807px; top: 260px; position: absolute; height: 18px" Text="Longitud"></asp:Label>
    
       
    
     

       
    
    </div>
   
 <div style="float:right; height: 19px; width: 1px;">
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 378px; top: 623px; position: absolute" Text="€/Km."></asp:Label>
        <asp:Label ID="lblTotal" runat="server" style="z-index: 1; left: 379px; top: 661px; position: absolute; height: 19px" Text="Total"></asp:Label>
        <asp:ImageButton ID="imgbtndonosti" runat="server" height="100px" 
            ImageUrl="~/IMÁGENES/Donosti-Logo.png" onCommand="mostrar" 
            CommandName="0" CommandArgument="IMÁGENES/donosti.jfif"
            style="z-index: 1; left: 21px; top: 45px; position: absolute; bottom: 437px;" width="160px" 
            />

        
        <asp:Label ID="lblCiudad" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="XX-Large" style="z-index: 1; left: 370px; top: 72px; position: absolute" Text="Bilbao"></asp:Label>

        
        <asp:ImageButton ID="imgbtngasteiz" runat="server" height="100px" 
            ImageUrl="~/IMÁGENES/Gasteiz-Logo.png" onCommand="mostrar" 
            CommandName="1" CommandArgument="IMÁGENES/Gasteiz.jfif"
            style="z-index: 1; left: 19px; top: 142px; position: absolute" width="160px" 
            />

        <asp:ImageButton ID="imgbtnlogroño" runat="server" height="100px" 
            ImageUrl="~/IMÁGENES/Logroño-Logo.png" onCommand="mostrar" 
            CommandName="2" CommandArgument="IMÁGENES/Logroño.jfif"
            style="z-index: 1; left: 19px; top: 262px; position: absolute" width="160px" 
            />

        <asp:ImageButton ID="imgbtnsantander" runat="server" height="100px" 
            ImageUrl="~/IMÁGENES/Santander-logo.jfif" onCommand="mostrar" 
            CommandName="3" CommandArgument="IMÁGENES/Santander.jfif"
            style="z-index: 1; left: 31px; top: 379px; position: absolute" width="160px" 
            />

     <asp:ImageButton ID="imgbtnmadrid" runat="server" height="100px" 
            ImageUrl="~/IMÁGENES/Madrid-Logo.png" onCommand="mostrar" 
            CommandName="4" CommandArgument="IMÁGENES/Madrid.jfif"
            style="z-index: 1; left: 35px; top: 504px; position: absolute" width="160px" 
            />
     <asp:ImageButton ID="imgbtnbarcelona" runat="server" height="100px" 
            ImageUrl="~/IMÁGENES/Barcelona-Logo.png" onCommand="mostrar" 
            CommandName="5" CommandArgument="IMÁGENES/barcelona.jpg"
            style="z-index: 1; left: 37px; top: 643px; position: absolute" width="160px" 
            />

     <div id="myMap" style="width:320px;height:189px; position:absolute;top:159px; left:439px" ></div>
   
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 377px; top: 589px; position: absolute; height: 24px" Text="Km."></asp:Label>
    <asp:Image ID="imgCiudad" runat="server" 
            
            
            style="z-index: 1; left: 442px; top: 370px; position: absolute; height: 186px; width: 319px;" />
   
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 377px; top: 589px; position: absolute; height: 24px" Text="Km."></asp:Label>
    </div>
   
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 377px; top: 589px; position: absolute; height: 24px" Text="Km."></asp:Label>
        <asp:TextBox ID="txtkm" runat="server" style="z-index: 1; left: 467px; top: 595px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnIda" runat="server" OnClick="btnIda_Click" style="z-index: 1; left: 655px; top: 612px; position: absolute; width: 31px" Text="Ida" />
   
    </form>
</body>
</html>
