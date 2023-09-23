using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio13_SOLUCION
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //BÚSQUEDA CON MÉTODO FINDBYTEXT (sin comparar mayúsculas y minúsculas)

            //ListItem lielemento = lstelementos.Items.FindByText(txtelemento.Text);
            //if (lielemento == null)
            //{
            //    lstelementos.Items.Add(txtelemento.Text);
            //}

            //txtelemento.Text = "";
            //txtelemento.Focus();


            //BÚSQUEDA CON MÉTODO IndexOf(sin comparar mayúsculas y minúsculas)

            //ListItem li = new ListItem(txtelemento.Text);

            //int posicion = lstelementos.Items.IndexOf(li);
            //if (posicion == -1)
            //{
            //    lstelementos.Items.Add(txtelemento.Text);
            //}

            //txtelemento.Text = "";
            //txtelemento.Focus();

            //BÚSQUEDA MANUAL
            bool encontrado = false;
            foreach (ListItem item in lstelementos.Items)
            {
                if (item.Text.ToLower() == txtelemento.Text.ToLower())
                {
                    encontrado = true;

                }

            }
            if (!encontrado)
            {
                lstelementos.Items.Add(txtelemento.Text);
            }


            txtelemento.Text = "";
            txtelemento.Focus();


        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            EliminarElementos(lstelementos, lstpapelera);
        }

        private void EliminarElementos(ListBox listaO,ListBox listaD)
        {

            for (int i = 0; i < listaO.Items.Count; i++)
            {
                if( (listaD.ID=="lstpapelera" && listaD.Items.Count<5) || listaD.ID=="lstelementos")
                {
                    if (listaO.Items[i].Selected)
                    {
                        listaD.Items.Add(listaO.Items[i].Text);
                        listaO.Items.RemoveAt(i);
                        i--;
                    }
                }
               
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            EliminarElementos(lstpapelera, lstelementos);
        }

        protected void btnVaciar_Click(object sender, EventArgs e)
        {
            lstpapelera.Items.Clear();
        }

        protected void btnborrar_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lstpapelera.Items.Count)
            {
                if (lstpapelera.Items[i].Selected)
                {
                    lstpapelera.Items.RemoveAt(i);
                    //Aqui no se incrementa porque al borrar el elemento tengo que volver a mirar
                    //la misma posición en la siguiente vuelta del bucle. El elemento siguiente
                    //se recoloca al hacer un borrado.
                }
                else
                {
                    i++;
                }
            }
        }
    }
}