<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="BIOTEK.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="lblUsuario" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblContraseña" runat="server" Text="Contraseña: " ></asp:Label>
            <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="txtIngresar" runat="server" Text="Ingresar" OnClick="txtIngresar_Click" />
            <asp:Button ID="txtRegistar" runat="server" Text="Registrarse" OnClick="txtRegistar_Click" />
            
            
        </div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:Panel ID="pnlRanking" runat="server">
                <asp:GridView ID="GridRanking" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" 
                    AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

                    <Columns>
                        <asp:TemplateField HeaderText="Id Usuario" SortExpression="idUsuario">
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%# Eval("idUsuario") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="TxtFooterTitleId" runat="server"></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Fecha" SortExpression="fecha">
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%# Eval("fecha") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="TxtFooterTitleId" runat="server"></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Puntuación" SortExpression="puntuacion">
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%# Eval("puntuacion") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="TxtFooterTitleId" runat="server"></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>
                    </Columns>

                </asp:GridView>

            </asp:Panel>
    </form>
</body>
</html>
