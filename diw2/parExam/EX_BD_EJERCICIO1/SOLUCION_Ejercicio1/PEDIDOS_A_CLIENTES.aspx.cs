using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDADES;
using NEGOCIO;

namespace SOLUCION_Ejercicio1
{
    public partial class PEDIDOS_A_CLIENTES : System.Web.UI.Page
    {
        DAL_Cliente ncliente = new DAL_Cliente();
        DAL_Empleado nEmpleado = new DAL_Empleado();
        DAL_Producto nProducto = new DAL_Producto();
        DAL_Pedido nPedido = new DAL_Pedido();
        DAL_Lineas_Pedidos nLineas_Pedido = new DAL_Lineas_Pedidos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Cliente> LClientes = ncliente.mostrarClientes();
                List<Empleado> LEmpleados = nEmpleado.mostrarEmpleados();
                List<Producto> LProductos = nProducto.mostrarProductos();

                foreach (var item in LClientes)
                {
                    ddlClientes.Items.Add(new ListItem(item.IdCliente + "-" + item.NombreCiente, item.IdCliente));
                }
                foreach (var item in LEmpleados)
                {
                    ddlEmpleados.Items.Add(new ListItem(item.IdEmpleado + "-" + item.NombreEmpleado + " " + item.ApellidoEmpleado, item.IdEmpleado));
                }
                foreach (var item in LProductos)
                {
                    ddlproductos.Items.Add(new ListItem(item.IdProducto + "-" + item.Descripcion, item.IdProducto.ToString()));
                }

            }
        }

        protected void btnGenerarPedido_Click(object sender, EventArgs e)
        {
            if (ddlClientes.SelectedIndex != -1 && ddlEmpleados.SelectedIndex != -1)
            {
                nPedido.insertarPedido(new Pedido(ddlClientes.SelectedValue, Convert.ToInt32(ddlEmpleados.SelectedValue)));
                lblOrdenID.Text = nPedido.mostrarNPedido().ToString();

            }
        }

        protected void ddlproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiar();
            Producto p = nProducto.mostrarDatosProducto(Convert.ToInt32(ddlproductos.SelectedValue));
            txtprecio.Text = p.Precio.ToString();
            txtustock.Text = p.UnidadesEnStock.ToString();
            txtupedido.Text = p.UnidadesEnPedido.ToString();
            txtOPrecio.Text = p.Precio.ToString();
            txtOProducto.Text = p.Descripcion;
        }


        protected void limpiar()
        {
            txtOCantidad.Text = String.Empty;
            txtODescuento.Text = String.Empty;
            LblRegistro.Visible = false;
        }

        protected void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtOProducto.Text != "" && txtprecio.Text != "" && txtOCantidad.Text != "" && lblOrdenID.Text!="")
            {
                if (Convert.ToInt16(txtOCantidad.Text) <= Convert.ToInt16(txtustock.Text))
                {
                    txtODescuento.Text = (Convert.ToInt16(txtOCantidad.Text) > 20 ? "0,15" : "0,05");
                    try
                    {
                        nLineas_Pedido.insertarLineaPedido(new Linea_Pedido(Convert.ToInt32(lblOrdenID.Text), Convert.ToInt32(ddlproductos.SelectedValue)
                      , Convert.ToDecimal(txtOPrecio.Text), Convert.ToInt16(txtOCantidad.Text), Convert.ToSingle(txtODescuento.Text)));
                        ViewState["cantidad"] = txtOCantidad.Text;
                        LblRegistro.Text = "El producto ha sido añadido al pedido";
                        txtustock.Text = (Convert.ToInt16(txtustock.Text) - Convert.ToInt16(txtOCantidad.Text)).ToString();
                        nLineas_Pedido.actualizarStock(Convert.ToInt16(txtustock.Text), Convert.ToInt32(ddlproductos.SelectedValue));
                    }
                    catch (Exception)
                    {
                        int cantidadtotal = Convert.ToInt32(ViewState["cantidad"]) + Convert.ToInt32(txtOCantidad.Text);
                        txtODescuento.Text = (cantidadtotal > 20 ? "0,15" : "0,05");
                        nLineas_Pedido.actualizarLineaPedido(Convert.ToInt32(lblOrdenID.Text), Convert.ToInt32(ddlproductos.SelectedValue)
                      , Convert.ToInt16(cantidadtotal), Convert.ToSingle(txtODescuento.Text));
                        LblRegistro.Text = "El producto ha sido modificado en el pedido";
                        txtustock.Text = (Convert.ToInt16(txtustock.Text) - Convert.ToInt16(txtOCantidad.Text)).ToString();
                        nLineas_Pedido.actualizarStock(Convert.ToInt16(txtustock.Text), Convert.ToInt32(ddlproductos.SelectedValue));
                    }
                  
                }
            else
            {
                txtOCantidad.Text = "";
                txtOCantidad.Focus();
            }
            }
        }

        protected void btnBorrarPedido_Click(object sender, EventArgs e)
        {
            Server.Transfer("EliminarPedidos.aspx");
            //Response.Redirect("EliminarPedidos.aspx");
        }
    }
}

 