<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="SOLUCION_Ejercicio1.GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblClientes" runat="server" Text="Label"></asp:Label>
            <asp:DropDownList ID="ddlClientes" runat="server"></asp:DropDownList>
            <asp:Label ID="lblProductos" runat="server" Text="Label"></asp:Label>
            <asp:DropDownList ID="ddlProductos" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
                AutoGenerateColumns="false"  ShowHeader="true" ShowFooter="true">
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
                    <asp:TemplateField HeaderText="OrderID">
                        <ItemTemplate>
                            <asp:Label ID="LblOrderId" runat="server"  Text='<%# Eval("OrderID") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtOrderID" runat="server" Text='<%# Eval("OrderID") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtOrderIDFooter" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="EmployeeID">
                        <ItemTemplate>
                            <asp:Label ID="LblEmployeeID" runat="server"  Text='<%# Eval("EmployeeID") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtEmployeeID" runat="server" Text='<%# Eval("EmployeeID") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtEmployeeIDFooter" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="OrderDate">
                        <ItemTemplate>
                            <asp:Label ID="LblOrderDate" runat="server"  Text='<%# Eval("OrderDate") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtOrderDate" runat="server" Text='<%# Eval("OrderDate") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtOrderDateFooter" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="LblOrderDate" runat="server"  Text='<%# Eval("OrderDate") %>'></asp:Label>
                            <asp:ImageButton ID="imgSeleccionar" ImageUrl="~/Imagenes/edit.png" CommandName="edit" runat="server" />
                            <asp:ImageButton ID="imgEliminar" ImageUrl="~/Imagenes/eliminar.png" CommandName="delete" runat="server" />
                            </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtOrderDate" runat="server" Text='<%# Eval("OrderDate") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtOrderDateFooter" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>


            </asp:GridView>
        </div>
    </form>
</body>
</html>
