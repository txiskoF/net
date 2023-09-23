using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJEMPLO_LISTAS
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblTexto.Text = "Posicion del elemento seleccionado:" + rdbLista.SelectedIndex + "<BR/>";
            LblTexto.Text += "El elemento seleccionado es:" + rdbLista.SelectedItem.Text + "<BR/>";
            LblTexto.Text += "El valor del elemento seleccionado es:" + rdbLista.SelectedItem.Value + "<BR/>";
            LblTexto.Text += "El valor del elemento seleccionado es:" + rdbLista.SelectedValue + "<BR/>";
            LblTexto.Text += "El número de elementos de la lista es:" + rdbLista.Items.Count;

            rdbLista.SelectedIndex = -1;
            rdbLista.ClearSelection();
        }

        protected void btnAñadir_Click(object sender, EventArgs e)
        {
            rdbLista.Items.Add("Cuatro");

            ListItem linuevo = new ListItem("Cinco", "5");
            rdbLista.Items.Add(linuevo);

            string[] textos = new string[3] { "Seis", "Siete", "Ocho" };
            string[] valores = new string[3] { "6", "7", "8" };

            ListItem[] lielementos = new ListItem[3];

            for (int i = 0; i < textos.Length; i++)
            {
                lielementos[i] = new ListItem(textos[i], valores[i]);
            }

            rdbLista.Items.AddRange(lielementos);

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            rdbLista.Items.Insert(0, "Cero");
            rdbLista.Items.Insert(rdbLista.Items.Count-1, "Final");

            if (rdbLista.SelectedIndex!=-1)
            {
                rdbLista.Items.Insert(rdbLista.SelectedIndex, "Nuevo");
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            rdbLista.Items.RemoveAt(0);
            rdbLista.Items.RemoveAt(rdbLista.Items.Count - 1);
            if (rdbLista.SelectedIndex != -1)
            {
                rdbLista.Items.RemoveAt(rdbLista.SelectedIndex);
            }

            rdbLista.Items.Remove(rdbLista.Items[0]);
            rdbLista.Items.Remove(rdbLista.Items[rdbLista.Items.Count - 1]);

            if (rdbLista.SelectedItem != null)
            {
                rdbLista.Items.Remove(rdbLista.SelectedItem);
            }

            rdbLista.Items.Clear();
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            ListItem libuscar = new ListItem("Cinco", "5");
            bool encontrado=rdbLista.Items.Contains(libuscar);
            LblTexto.Text = "Elemento enocntrado: " + encontrado;

            if (rdbLista.Items.Contains(libuscar))
            {
                LblTexto.Text = "Elemento encontrado";

            }
            else
            {
                LblTexto.Text = "Elemento NO encontrado";
            }



            ListItem li = rdbLista.Items.FindByText("Seis");

            if (li != null)
            {
                LblTexto.Text = "ListItem ENCONTRADO: " + li.Text + "-" + li.Value;
            }

            //ListItem liB = rdbLista.Items.FindByValue("8");

            //if (liB != null)
            //{
            //    LblTexto.Text = "ListItem ENCONTRADO: " + liB.Text + "-" + liB.Value;
            //}

            int posicion = rdbLista.Items.IndexOf(libuscar);

            if (posicion != -1)
            {
                LblTexto.Text = "Posicion elemento:" + posicion + "<BR/>";
                LblTexto.Text += "Elemento: " + rdbLista.Items[posicion].Text
                    + "-" + rdbLista.Items[posicion].Value;
            }


        }

        protected void BtnSMultiple_Click(object sender, EventArgs e)
        {
            LblTexto.Text = "Elementos Seleccionados: <BR/>"; 
            foreach (ListItem item in ChkHobbies.Items)
            {
                if (item.Selected)
                {
                    LblTexto.Text += item.Text + "-" + item.Value + "<BR/>";
                }
            }
        }

        protected void BtnBMULTPLE_Click(object sender, EventArgs e)
        {
            //foreach (ListItem item in ChkHobbies.Items)
            //{
            //    if (item.Selected)
            //    {
            //        ChkHobbies.Items.Remove(item);
            //    }
            //}

            for (int i = 0; i < ChkHobbies.Items.Count; i++)
            {
                if (ChkHobbies.Items[i].Selected)
                {
                    ChkHobbies.Items.RemoveAt(i);
                    i--;
                }
            }

            for (int i = ChkHobbies.Items.Count-1; i>=0 ; i--)
            {
                if (ChkHobbies.Items[i].Selected)
                {
                    ChkHobbies.Items.RemoveAt(i);
                }
            }

        }
    }
}