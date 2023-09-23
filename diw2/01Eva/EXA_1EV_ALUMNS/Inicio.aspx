<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="EXAMEN_1.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="ESTILOS/estilo.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server" >
        <header>
        <div class="navbar navbar-inverse navbar-static-top">
                <div class="container">
                <h1>Tasas Demográficas - Pais Vasco</h1>
                 </div>
         </div>
        </header>
        <div class="jumbotron">
            <div class="container">
                  <div class="row">
                <div class="col-lg-2">
                    <H3>Provincias</H3>
                    <asp:RadioButtonList ID="RdbProvincias" runat="server">
                        <asp:ListItem>Bizkaia</asp:ListItem>
                        <asp:ListItem>Gipuzkoa</asp:ListItem>
                        <asp:ListItem>Araba</asp:ListItem>
                    </asp:RadioButtonList>
                       
                </div>
                 <asp:Panel ID="PnlBizkaia" runat="server" Visible="False">
                       <h3>Bizkaia</h3>
                        <asp:ImageButton ID="ImgBtnBilbao" runat="server" Height="120px" Width="200px" />
                        <asp:ImageButton ID="ImgBtnGetxo" runat="server" Height="120px" Width="200px" />
                        <asp:ImageButton ID="ImgBtnPortugalete" runat="server" Height="120px" Width="200px" />
                       
                 </asp:Panel>
                      <asp:Panel ID="PnlGipuzkoa" runat="server" Visible="False">
                       <h3>Gipuzkoa</h3>
                        <asp:ImageButton ID="ImgBtnDonosti" runat="server" Height="120px" Width="200px"  />
                        <asp:ImageButton ID="ImgHondarribia" runat="server" Height="120px" Width="200px" />
                        <asp:ImageButton ID="ImgBtnZarautz" runat="server" Height="120px" Width="200px" />
                       
                 </asp:Panel>
                      <asp:Panel ID="PnlAraba" runat="server" Visible="False">
                       <h3>Araba</h3>
                        <asp:ImageButton ID="ImgBtnGasteiz" runat="server" Height="120px" Width="200px"  />
                        <asp:ImageButton ID="ImgBtnAmurrio" runat="server" Height="120px" Width="200px" />
                        <asp:ImageButton ID="ImgBtnArtziniega" runat="server" Height="120px" Width="200px" />
                      
                 </asp:Panel>
                    </div>
            
                </div>
        </div>
   
        <div class="container">
            <div class="row">
                <div class="col-lg-3">
                    <h3>Nueva Población</h3>
                    <asp:TextBox ID="TxtNombrePoblacion" CssClass="form-control" placeholder="Nombre Población" width="200" runat="server"></asp:TextBox>
                     <asp:TextBox ID="TxtPoblacion" CssClass="form-control" placeholder="Población" width="200" runat="server"></asp:TextBox>
                     <asp:TextBox ID="TxtKm2" CssClass="form-control" placeholder="Kilometros2" width="200" runat="server"></asp:TextBox>          
                     <asp:TextBox ID="TxtNacimientos" CssClass="form-control" placeholder="Nº Nacimientos" width="200" runat="server"></asp:TextBox>
                     <asp:TextBox ID="TxtDefunciones" CssClass="form-control" placeholder="Nº Defunciones" width="200" runat="server"></asp:TextBox>
                     <asp:TextBox ID="TxtMujeres" CssClass="form-control" placeholder="Nº Mujeres 15-49 años" width="200" runat="server"></asp:TextBox>
                     <asp:ImageButton ID="ImgBtnAgregarPoblacion" runat="server" Height="50px" ImageUrl="~/IMAGENES/agregar.jpg" Width="50px"  />
            
            </div>
                 <div class="col-lg-3">
                     <h3>Tasas Demográficas</h3>
                     <asp:CheckBoxList ID="ChklTasas" runat="server" >
                         <asp:ListItem>Tasa General de Natalidad</asp:ListItem>
                         <asp:ListItem>Tasa General de Defunción</asp:ListItem>
                         <asp:ListItem>Tasa General de Fecundidad</asp:ListItem>
                         <asp:ListItem>Densidad de Población</asp:ListItem>
                     </asp:CheckBoxList>
                </div>
                 <div class="col-lg-3">
                     <h3>
                         <asp:Label ID="LblPoblacion" runat="server" Text=""></asp:Label> &nbsp;    </h3>
                       <asp:TextBox  ReadOnly="true" ID="TxtTasaNacimiento" runat="server"></asp:TextBox>                 
                    <asp:TextBox  ReadOnly="true" ID="TxtTasaDefuncion" runat="server"></asp:TextBox>
                    <asp:TextBox  ReadOnly="true" ID="TxtTasaFecundidad" runat="server"></asp:TextBox>
                    <asp:TextBox  ReadOnly="true" ID="TxtDensidadPoblacion" runat="server"></asp:TextBox>
                </div>
                 <div class="col-lg-3">
                     <h3>Informe General</h3>
                      <asp:Label ID="LblInforme" runat="server" Text="" Width="300" Height="250" BorderColor="Gray" BorderWidth="1px"></asp:Label>
                </div>




            </div>   
             </div>   
               
          

               
                  
                   

            
            
               
        
    </form>
</body>
</html>
