<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="PRESENTACION_GRID.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvEditores" runat="server" CellPadding="4" ForeColor="#333333" 
                GridLines="None" OnSelectedIndexChanged="gvEditores_SelectedIndexChanged"
                 DataKeyNames="Pub_Id">
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
                            <asp:ImageButton  ImageUrl="~/imagenes/edit.png" 
                                CommandName="Select" runat="server" Height="20" Width="20"/>
            
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:GridView ID="gvLibros" runat="server" CellPadding="4" 
                ForeColor="#333333" GridLines="None" 
                AutoGenerateColumns="false" ShowHeader="true" ShowFooter="true"
                 OnRowEditing="gvLibros_RowEditing"
                 OnRowCancelingEdit="gvLibros_RowCancelingEdit"
                OnRowDeleting="gvLibros_RowDeleting" 
                 OnRowUpdating="gvLibros_RowUpdating"
                 OnRowCommand="gvLibros_RowCommand"
                 DataKeyNames="Title_Id"
                AllowPaging="true" PageSize="7" OnPageIndexChanging="gvLibros_PageIndexChanging" 
                 AllowSorting="true" OnSorting="gvLibros_Sorting"
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
                    <asp:TemplateField HeaderText="Title_ID" SortExpression="Title_ID">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%# Eval("title_ID") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtTitleId" runat="server" Text='<%# Eval("title_ID") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtFooterTitleId" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Title" SortExpression="Title">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%# Eval("title") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtTitle" runat="server" Text='<%# Eval("title") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtFooterTitle" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Type" SortExpression="Type">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%# Eval("type") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtType" runat="server" Text='<%# Eval("type") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtFooterType" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Price" SortExpression="Price">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%# Eval("Price") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtPrice" runat="server" Text='<%# Eval("Price") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtFooterPrice" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Pub_ID" SortExpression="Pub_ID">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%# Eval("Pub_ID") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtPubId" runat="server" Text='<%# Eval("Pub_ID") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtFooterPubId" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Pubdate" SortExpression="Pubdate">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%# Eval("pubdate") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TxtPubdate" runat="server" Text='<%# Eval("pubdate") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TxtFooterPubdate" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                      <asp:TemplateField >
                        <ItemTemplate>
                            <asp:ImageButton  runat="server" ImageUrl="~/imagenes/edit.png" Height="20" Width="20" 
                                CommandName="Edit" />
                            <asp:ImageButton  runat="server"  ImageUrl="~/imagenes/eliminar.png" Height="20" Width="20" 
                                CommandName="delete" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:ImageButton  runat="server" ImageUrl="~/imagenes/Guardar.png" Height="20" Width="20" 
                                CommandName="update" />
                            <asp:ImageButton runat="server" ImageUrl="~/imagenes/Cancelar.png" Height="20" Width="20" 
                                CommandName="cancel" />
                        </EditItemTemplate>
                        <FooterTemplate>
                             <asp:ImageButton  runat="server" ImageUrl="~/imagenes/Nueva.png" Height="20" Width="20" 
                                CommandName="addnew" />
                        </FooterTemplate>
                    </asp:TemplateField>



                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
