using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio10B
{
    public partial class Principal : System.Web.UI.Page
    {
        byte[] precios = new byte[] { 50, 50, 50, 50, 40, 40 };
        byte[] monedas = new byte[] { 200, 100, 50, 20, 10, 5, 2, 1 };
        string[] imagenmoneda = new string[] { "Imagenes/2.png", "Imagenes/1.gif", "Imagenes/50c.png", "Imagenes/20c.gif", "Imagenes/10.gif", "Imagenes/5c.png", "Imagenes/2c.png", "Imagenes/1c.jpg" };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnlLeche.Visible = false;
                pnlAzucar.Visible = false;
                btnPrecio.Visible = false;
                Panel1.Visible = false;
                imgTaza.Visible = false;
                ViewState["creadas"] = false;
                //ViewState["precio"] = 0;
            }

            bool monedascreadas = Convert.ToBoolean(ViewState["creadas"]);
            if (monedascreadas)
            {
                crearmonedas();
            }


        }

        protected void rdbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Iniciar();
            if (rdbBebidas.SelectedIndex == 0 || rdbBebidas.SelectedIndex == 1 || rdbBebidas.SelectedIndex == 3)
            {
                pnlLeche.Visible = true;
                btnPrecio.Visible = false;
                pnlAzucar.Visible = false;
                rdbAzucar.ClearSelection();
                rdbLeche.ClearSelection();

            }
            else
            {
                pnlLeche.Visible = false;
                pnlAzucar.Visible = false;
                btnPrecio.Text = rdbBebidas.SelectedValue + " " + precios[rdbBebidas.SelectedIndex] + "cts.";
                btnPrecio.Visible = true;
                crearmonedas();
                ViewState["creadas"] = true;
                ViewState["pvp"] = precios[rdbBebidas.SelectedIndex];
            }
        }

        protected void rdbLeche_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlAzucar.Visible = true;
        }

        protected void rdbAzucar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPrecio.Text = rdbBebidas.SelectedItem.Value + " " + rdbLeche.SelectedValue + " " + rdbAzucar.SelectedValue + " " + precios[rdbBebidas.SelectedIndex] + "cts.";
            btnPrecio.Visible = true;
            crearmonedas();
            ViewState["creadas"] = true;
            ViewState["pvp"] = precios[rdbBebidas.SelectedIndex];
        }

        protected void crearmonedas()
        {
            ImageButton[] ImgMonedas = new ImageButton[8];

            for (int i = 0; i < monedas.Length; i++)
            {
                ImgMonedas[i] = new ImageButton();
                ImgMonedas[i].ImageUrl = imagenmoneda[i];
                ImgMonedas[i].CommandArgument = monedas[i].ToString();
                ImgMonedas[i].Width = 50;
                ImgMonedas[i].Height = 50;
                ImgMonedas[i].Command += SumarEntradaDinero;
                Panel1.Controls.Add(ImgMonedas[i]);

            }
            Panel1.Visible = true;


        }

        private void SumarEntradaDinero(object sender, CommandEventArgs e)
        {
            Label LblPrecio = new Label();
            short precio = Convert.ToInt16(ViewState["precio"]);
            short nuevoprecio = Convert.ToInt16(e.CommandArgument);
            precio += nuevoprecio;
            ViewState["precio"] = precio;
            LblPrecio.Text = precio.ToString();
            Panel1.Controls.Add(LblPrecio);


        }

        protected void btnPrecio_Click(object sender, EventArgs e)
        {
            short acumulado = Convert.ToInt16(ViewState["precio"]);
            short pvp = Convert.ToInt16(ViewState["pvp"]);
            if (acumulado == pvp)
            {
                Panel1.Controls.Clear();
                imgTaza.Visible = true;
            }
            else if (acumulado > pvp)
            {
                Panel1.Controls.Clear();
                imgTaza.Visible = true;
                int[] moncambios = new int[8];
                int cambio = acumulado - pvp;
                for (int i = 0; i < monedas.Length; i++)
                {
                    moncambios[i] = cambio / monedas[i];
                    cambio = cambio % monedas[i];
                }

                for (int i = 0; i < moncambios.Length; i++)
                {
                    for (int j = 0; j < moncambios[i]; j++)
                    {
                        Image txanpon = new Image();
                        txanpon.ImageUrl = imagenmoneda[i];
                        txanpon.Width = 50;
                        txanpon.Height = 50;
                        Panel1.Controls.Add(txanpon);
                    }
                }

            }

        }

        protected void imgTaza_Click(object sender, ImageClickEventArgs e)
        {
            Iniciar();
            rdbBebidas.ClearSelection();
        }

        private void Iniciar()
        {
            Panel1.Controls.Clear();
            Panel1.Visible = false;
            ViewState["creadas"] = false;
            ViewState["precio"] = 0;
            btnPrecio.Text = "";
            btnPrecio.Visible = false;

            pnlLeche.Visible = false;
            pnlAzucar.Visible = false;
            imgTaza.Visible = false;
        }
    }
}