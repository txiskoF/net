<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PRINCIPAL.aspx.cs" Inherits="PRINCIPAL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gvEditores" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" 
            OnSelectedIndexChanged="gvEditores_SelectedIndexChanged"
             DataKeyNames="pub_Id"
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
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="ImgSeleccionar" ImageUrl="~/imagenes/edit.png" 
                            CommandName="Select" runat="server" Width="20px" height="20px"/>

                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
    </div>
        <asp:GridView ID="gvLibros" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
            <%--Esto para mostrar  HeaderStyle-BackColor y footer--%>
            AutoGenerateColumns="false" ShowHeader="true" ShowFooter="true"
             OnRowEditing="gvLibros_RowEditing"
             OnRowCancelingEdit="gvLibros_RowCancelingEdit"
             OnRowUpdating="gvLibros_RowUpdating"
             OnRowDeleting="gvLibros_RowDeleting"
             OnRowCommand="gvLibros_RowCommand"
             DataKeyNames="Title_Id"
             AllowPaging="true"  PageSize="7" OnPageIndexChanging="gvLibros_PageIndexChanging"
             AllowSorting="true" OnSorting="gvLibros_Sorting" OnSelectedIndexChanged="gvLibros_SelectedIndexChanged"
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
                <asp:TemplateField HeaderText="title_Id" SortExpression="Title_Id">
                    <%--para ver datos--%>
                    <ItemTemplate>
                        <asp:Label  runat="server" Text='<%# Eval("Title_ID") %>'></asp:Label>
                    </ItemTemplate>
                   <%--para editar--%>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtTitle_Id" runat="server" Text='<%# Eval("Title_ID") %>'></asp:TextBox>
                    
                    </EditItemTemplate>
                    <%--para poder insertar un nuevo registro--%>
                    <FooterTemplate>
                        <asp:TextBox ID="txtTitle_IDFooter" runat="server"></asp:TextBox>
                    </FooterTemplate>
             </asp:TemplateField >

                 <asp:TemplateField HeaderText="title" SortExpression="Title">
                    <ItemTemplate>
                        <asp:Label  runat="server" Text='<%# Eval("Title") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtTitle" runat="server" Text='<%# Eval("Title") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtTitleFooter" runat="server"></asp:TextBox>
                    </FooterTemplate>
 </asp:TemplateField>

                 <asp:TemplateField HeaderText="type" SortExpression="Type">
                    <ItemTemplate>
                        <asp:Label  runat="server" Text='<%# Eval("Type") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtType" runat="server" Text='<%# Eval("Type") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtTypeFooter" runat="server"></asp:TextBox>
                    </FooterTemplate>

                      </asp:TemplateField>
                 <asp:TemplateField HeaderText="Price" SortExpression="Price">
                    <ItemTemplate>
                        <asp:Label  runat="server" Text='<%# Eval("price") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtPrice" runat="server" Text='<%# Eval("Price") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtPriceFooter" runat="server"></asp:TextBox>
                    </FooterTemplate>
                      </asp:TemplateField>
                     <asp:TemplateField HeaderText="Pub_Id" SortExpression="Pub_Id">
                          <ItemTemplate>
                        <asp:Label  runat="server" Text='<%# Eval("Pub_ID") %>'></asp:Label>
                    </ItemTemplate>
                    
                    <FooterTemplate>
                        <asp:TextBox ID="txtPub_IDFooter" runat="server"></asp:TextBox>
                    </FooterTemplate>
                          </asp:TemplateField>
                 <asp:TemplateField HeaderText="Pubdate" SortExpression="Pubdate">
                    <ItemTemplate>
                        <asp:Label  runat="server" Text='<%# Eval("Pubdate") %>'></asp:Label>
                    </ItemTemplate>
                    
                    <FooterTemplate>
                        <asp:TextBox ID="txtPubdateFooter" runat="server"></asp:TextBox>
                    </FooterTemplate>
                      </asp:TemplateField>
               <%-- esto para los iconos de editar o borrar--%>
              <asp:TemplateField>
                  <ItemTemplate>
                      <asp:ImageButton ID="imgEditar" ImageUrl="~/imagenes/edit.png" CommandName="edit" runat="server" Width="20px" Height="20px" />
                      <asp:ImageButton ID="ImgBorrar" ImageUrl="~/imagenes/eliminar.png" CommandName="delete" runat="server" Width="20px" Height="20px"/>
                  </ItemTemplate>
                  <%--para salvar o cancelar cuadno edite--%>
                  <EditItemTemplate>
                      <asp:ImageButton ID="ImgSalvar" ImageUrl="~/imagenes/Guardar.png" CommandName="update"  runat="server" Width="20px" Height="20px"/>
                      <asp:ImageButton ID="ImgCancelar" ImageUrl="~/imagenes/Cancelar.png" runat="server" CommandName="cancel" Width="20px" Height="20px"/>
                  </EditItemTemplate>
                 <%-- para añadir un nuevo libro--%>
                  <FooterTemplate>
                      <asp:ImageButton ID="ImgNuevo" ImageUrl="~/imagenes/Nueva.png" runat="server"  CommandName="addnew" Width="20px" Height="20px"/>
                  </FooterTemplate>


              </asp:TemplateField>

            </Columns>

        </asp:GridView>
    </form>
</body>
</html>
