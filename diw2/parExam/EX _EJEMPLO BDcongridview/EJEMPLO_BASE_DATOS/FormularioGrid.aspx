<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioGrid.aspx.cs" Inherits="EJEMPLO_BASE_DATOS.FormularioGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 62px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvEditores" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
                
                 OnSelectedIndexChanged="gvEditores_SelectedIndexChanged" DataKeyNames="Pub_Id"
                >
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
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="ImgSeleccionar" ImageUrl="~/IMG/edit.png" runat="server" Width="20" Height="20" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:GridView ID="gvLibros" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" 
                 <%--Esto para mostrar  HeaderStyle-BackColor y footer--%>
                AutoGenerateColumns="false" ShowHeader="true" ShowFooter="true"
                <%--generareventos--%>
                OnRowUpdated=""
                OnRowCommand="gvLibros_RowCommand"
                  <%--generareventos--%>
                OnRowEditing="gvLibros_RowEditing"
                 <%--generareventos--%>
                 OnRowCancelingEdit="gvLibros_RowCancelingEdit"
                 <%--generareventos--%>
                 OnRowUpdating="gvLibros_RowUpdating"
                 <%--generareventos--%>
                 OnRowDeleting="gvLibros_RowDeleting"
                <%--para permitir paginar y el tamño de paginado--%>
                 AllowPaging="true" PageSize="10" OnPageIndexChanging="gvLibros_PageIndexChanging"
                <%--para permitir ordenar--%>
                 AllowSorting="true" OnSorting="gvLibros_Sorting" 
                        <%--indicar camp identificativo CLAVE--%>
                 DataKeyNames="Title_Id" CssClass="auto-style1" Height="236px" Width="743px"
                >
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
            <%--Introducir una serie de estas por cada columna--%>
                <Columns>
                    
                    <asp:TemplateField HeaderText="Title_Id" SortExpression="Title_Id">
                    <%--para ver datos--%>
                        <ItemTemplate>
                            <asp:Label ID="LblTitle_Id" runat="server" Text='<%# Eval("Title_Id") %>'></asp:Label>
                        </ItemTemplate>
                   <%--para editar--%>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtTitle_ID" runat="server" Text='<%# Eval("Title_Id") %>'></asp:TextBox>
                        </EditItemTemplate>
                    <%--para poder insertar un nuevo registro--%>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtFooterTitle_ID" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                                            <%--sortexpresion para poder ordenar--%>
                     <asp:TemplateField HeaderText="Title" SortExpression="Title">
                        <ItemTemplate>
                            <asp:Label ID="LblTitle" runat="server" Text='<%# Eval("Title") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtTitle" runat="server" Text='<%# Eval("Title") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtFooterTitle" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    
                     <asp:TemplateField HeaderText="Type" SortExpression="Type">
                        <ItemTemplate>
                            <asp:Label ID="LblType" runat="server" Text='<%# Eval("Type") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtType" runat="server" Text='<%# Eval("Type") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtFooterType" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                   
                     <asp:TemplateField HeaderText="Pub_Id" SortExpression="Pub_Id">
                        <ItemTemplate>
                            <asp:Label ID="LblPub_Id" runat="server" Text='<%# Eval("Pub_Id") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtPub_ID" runat="server" Text='<%# Eval("Pub_Id") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtFooterPub_ID" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                        
                     <asp:TemplateField HeaderText="Price" SortExpression="Price">
                        <ItemTemplate>
                            <asp:Label ID="LblPrice" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtPrice" runat="server" Text='<%# Eval("Price") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtFooterPrice" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                     
                     <asp:TemplateField HeaderText="Pubdate" SortExpression="Pubdate">
                        <ItemTemplate>
                            <asp:Label ID="LblPubdate" runat="server" Text='<%# Eval("Pubdate") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtPubdate" runat="server" Text='<%# Eval("Pubdate") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtFooterPubdate" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
               <%-- esto para los iconos de editar o borrar--%>
                            <asp:ImageButton ID="imgEditar" ImageUrl="~/IMG/edit.png" CommandName="edit" runat="server" width="20" Height="20"/>
                            <asp:ImageButton ID="imgEliminar" ImageUrl="~/IMG/eliminar.png" CommandName="delete" runat="server" width="20" Height="20"/>
                        </ItemTemplate>
                  <%--para salvar o cancelar cuadno edite--%>
                        <EditItemTemplate>
                            <asp:ImageButton ID="ImgSalvar" ImageUrl="~/IMG/Guardar.png" CommandName="update" runat="server"  width="20" Height="20" />
                            <asp:ImageButton ID="ImgCancelar" ImageUrl="~/IMG/Cancelar.png" CommandName="cancel" runat="server"  width="20" Height="20" />
                        </EditItemTemplate>
                 <%-- para añadir un nuevo libro--%>
                        <FooterTemplate>
                            <asp:ImageButton ID="ImgAñadir" ImageUrl="~/IMG/Nueva.png" CommandName="addnew" runat="server"  width="20" Height="20" />
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
