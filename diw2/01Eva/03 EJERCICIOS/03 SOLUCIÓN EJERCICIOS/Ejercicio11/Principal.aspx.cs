using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio11
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btncalcular_Click1(object sender, EventArgs e)
        {
            txtdescripcion.Text = "La descripcion del ordenador es: ";
            lblprecio.Text = "Precio: ";
            double precio = 0;
            if (rdblcajas.SelectedIndex != -1 && rdblhd.SelectedIndex != -1 &&
                rdblmicros.SelectedIndex != -1 && rdblplacas.SelectedIndex != -1 &&
                rdblram.SelectedIndex != -1 && rdbltg.SelectedIndex != -1)
            {
                txtdescripcion.Text += "\n " + rdblcajas.SelectedItem.Text
                                    + "\n" + rdblhd.SelectedItem.Text
                                    + "\n" + rdblmicros.SelectedItem.Text
                                    + "\n" + rdblplacas.SelectedItem.Text
                                    + "\n" + rdblram.SelectedItem.Text
                                    + "\n" + rdbltg.SelectedItem.Text;

                foreach (ListItem item in chklopcional.Items)
                {
                    if (item.Selected)
                    {
                        txtdescripcion.Text += "\n " + item.Text;
                        precio += Convert.ToDouble(item.Value);
                    }
                }

                lblprecio.Text = "Precio: " + (precio +
                      Convert.ToDouble(rdblcajas.SelectedValue)
                    + Convert.ToDouble(rdblhd.SelectedValue)
                       + Convert.ToDouble(rdblmicros.SelectedValue)
                          + Convert.ToDouble(rdblplacas.SelectedValue)
                             + Convert.ToDouble(rdblram.SelectedValue)
                                + Convert.ToDouble(rdbltg.SelectedValue)).ToString("c");
            }


        }

        protected void btnReinicio_Click(object sender, EventArgs e)
        {
            rdblcajas.ClearSelection();
            rdblhd.ClearSelection();
            rdblmicros.ClearSelection();
            rdblplacas.ClearSelection();
            rdblram.ClearSelection();
            rdbltg.ClearSelection();
            chklopcional.ClearSelection();
            txtdescripcion.Text = "La descripcion del ordenador es: ";
            lblprecio.Text = "Precio: ";

        }
    }
}