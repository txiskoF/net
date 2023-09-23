using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDADES;
using NEGOCIO;



public partial class CONECTADO : System.Web.UI.Page
{

    N_Empleados pempleado = new N_Empleados();
    N_Clientes pcliente = new N_Clientes();
    N_Productos pproducto = new N_Productos();
    N_ORDER porder = new N_ORDER();
    N_ORDERDETAILS porderdetail = new N_ORDERDETAILS();
    protected void Page_Load(object sender, EventArgs e)
    {
        //al arrancar muestro
        if (!IsPostBack)
        {
            //la lista de empleados
            List<Empleados> lemp = pempleado.mostrarEmpleados();
            foreach (Empleados emp in lemp)
            {
                ListItem li = new ListItem(emp.IdEmpleado + "-" + emp.NombreEmpleado, emp.IdEmpleado.ToString());
                ddlEmpleados.Items.Add(li);
            }
            //la lista de clientes
            List<Clientes> lcli = pcliente.mostrarClientes();
            foreach (Clientes cli in lcli)
            {
                ListItem li = new ListItem(cli.IdCliente + "-" + cli.NombreCliente, cli.IdCliente.ToString());
                ddlClientes.Items.Add(li);
            }
            //la lista de productos
            List<Productos> lpro = pproducto.mostrarProductos();
            foreach (Productos pro in lpro)
            {
                ListItem li = new ListItem(pro.IdProducto + "-" + pro.Descripcion, pro.IdProducto.ToString());
                ddlproductos.Items.Add(li);
            }
        }

    }

    protected void btnGenerarPedido_Click(object sender, EventArgs e)
    {
        if (ddlEmpleados.SelectedIndex!=-1 && ddlClientes.SelectedIndex!=-1)
        {
            //selecciono el valor de listaempleados   el valor de listalcientes
            ORDER or = new ORDER(ddlEmpleados.SelectedValue, ddlClientes.SelectedValue);
            //genero una nueva orden de venta y la pongo es su etiquea
            porder.insertarOrder(or);
            int numeroOrden=porder.mostrarOrden();
            lblOrdenID.Text = numeroOrden.ToString();

        }
    }

    //el producto que esta seleecionado de la lista deproductos
    protected void ddlproductos_SelectedIndexChanged(object sender, EventArgs e)
    {
        //de la lista de productos el seleccionado
        Productos pro=pproducto.mostrarProducto(ddlproductos.SelectedValue);
        //pongo el valor en cada cuadro
        txtprecio.Text = pro.Precio.ToString();
        txtupedido.Text = pro.Unidadesenpedido.ToString();
        txtustock.Text = pro.Unidadesenstock.ToString();
        txtOProducto.Text = pro.Descripcion;
        txtOPrecio.Text= pro.Precio.ToString();

    }

    //del boton añadr al pedido
    protected void btnAñadir_Click(object sender, EventArgs e)
    {
        //del valor que tienes los cuadros de texto
        if (lblOrdenID.Text!= "" && txtOProducto.Text!="" &&
            txtOPrecio.Text!="" && txtOCantidad.Text!="")
        {
            //cojo los valores de cada cuadro texto
            int cantidad = Convert.ToInt32(txtOCantidad.Text);
            int stock = int.Parse(txtustock.Text);
            //si la cantidad es menor del stock
            if (cantidad < stock)
            {
                //pongo el descuetno si es mas de 20 o si no
                txtODescuento.Text = (cantidad > 20 ? "0,15" : "0,05");
                //creo una orderdetail
                ORDERDETAILS or = new ORDERDETAILS();
                //guardo los valores
                or.OrderID = Int32.Parse(lblOrdenID.Text);
                or.ProductID = Int32.Parse(ddlproductos.SelectedValue);
                or.Unitprice = Decimal.Parse(txtprecio.Text);
                or.Quantity = Int16.Parse(txtOCantidad.Text);
                or.Discount = Double.Parse(txtODescuento.Text);
                try
                {
                    //inserto la ordendepedido realizada
                    porderdetail.insertarOrderDetail(or);
                }
                catch (Exception)
                {
                    cantidad=porderdetail.mostrarCantidad(or);
                    double descuento = (cantidad + or.Quantity > 20 ? 0.15 : 0.05);
                    or.Quantity = Convert.ToInt16(cantidad + or.Quantity);
                    or.Discount = descuento;
                    porderdetail.actualizarLineaPedido(or);
                }
              
                pproducto.actualizarProducto(ddlproductos.SelectedValue, cantidad);
            }
            else
            {
                //si la cantidad esta vacia pongo el Foco en ese txtcuadro
                txtOCantidad.Text = String.Empty;
                txtOCantidad.Focus();
            }
        }
       
    }

    protected void btnBorrarPedido_Click(object sender, EventArgs e)
    {
        Server.Transfer("Desconectado.aspx");
    }

    protected void btnFinalizar_Click(object sender, EventArgs e)
    {
        lblOrdenID.Text = String.Empty;
        foreach (Control c in Form.Controls)
        {
            if (c is TextBox)
            {
                TextBox txt=(TextBox)c;
                txt.Text = String.Empty;
            }
            else { 
          
            if (c is DropDownList)
            {
                DropDownList ddl = (DropDownList)c;
                ddl.SelectedIndex = -1;

            }
                }
           

        }
    }
}
