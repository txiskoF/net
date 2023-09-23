using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal : System.Web.UI.Page
{
    public object RdblNumeros { get; private set; }



    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Propiedades SelectedIndex (Posiscion elemento seleccionado)
        //Propiedades SelectedItem ( Elemento seleccionado - ListItem)
        //Propiedades SelectedValue( Valor del elemento seleccionado)
        LblEtiqueta.Text = "La posicion del eelmento seleccionado es: " + RdbLNumeros.SelectedIndex;
        LblEtiqueta.Text += " <BR/> El elemento seleccionado es: " + RdbLNumeros.SelectedItem.Text;
        LblEtiqueta.Text += " <BR/> El elemento seleccionado es: " + RdbLNumeros.SelectedItem.Value;
        LblEtiqueta.Text += " <BR/> El elemento seleccionado es: " + RdbLNumeros.SelectedValue;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        //Mostrar el número de elementos de la lista
        LblEtiqueta.Text = "El número de elementos de mi lista es: " + RdbLNumeros.Items.Count.ToString();

        //Seleccionar el primer elemento de la lista
        RdbLNumeros.SelectedIndex = 0;

        //Seleccionar el último elemento de la lista
        RdbLNumeros.SelectedIndex = RdbLNumeros.Items.Count - 1;

        //Deseleccionar la lista (Borrar las selecciones) 1ª FORMA 
        RdbLNumeros.SelectedIndex = -1;
        //Borrar las selecciones 2ª FORMA
        RdbLNumeros.ClearSelection();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Añadir elementos a la lista


        //Añadir (al final siempre) Un elemento con el mismo Text y Value
        RdbLNumeros.Items.Add("Cuatro");

        //Añadir un elemento a la lista con diferente text y Value
        ListItem LiNuevo = new ListItem("Cinco", "5");
        RdbLNumeros.Items.Add(LiNuevo);


        /**************Añadir varios elementos a la lista ****/

        string[] textos = new string[3] { "Seis", "Siete", "Ocho" };
        string[] valores = new string[3] { "6", "7", "8" };

        ListItem[] ListaElementos = new ListItem[3];

        for (int i = 0; i < textos.Length; i++)
        {
            ListaElementos[i] = new ListItem();
            ListaElementos[i].Text = textos[i];
            ListaElementos[i].Value = valores[i];
        }

        RdbLNumeros.Items.AddRange(ListaElementos);
        /**********************************************************/
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        //Insertar un elemento en la posición 0
        RdbLNumeros.Items.Insert(0, "Cero");

        //Insertar un ListItem en la posición 0 (elemento con distinto texto y value)
        ListItem LiNuevo = new ListItem("CERO-B", "0");
        RdbLNumeros.Items.Insert(0, LiNuevo);

        //Insertar un elemento antes del último elemento
        RdbLNumeros.Items.Insert(RdbLNumeros.Items.Count - 1, "Cero");
        //Insertar un elemento en la posición seleccionada
        if (RdbLNumeros.SelectedIndex != -1)
        {
            RdbLNumeros.Items.Insert(RdbLNumeros.SelectedIndex, "Diez");
        }



    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        //Borrar un elemento de la lista pasándole la posción que ocupa

        //Borra el elemento que está en la posición 0
        RdbLNumeros.Items.RemoveAt(0);
        //Borra el elemento que está en la última posición 
        RdbLNumeros.Items.RemoveAt(RdbLNumeros.Items.Count - 1);

        //Borra el elemento de la posición seleccionada 
        if (RdbLNumeros.SelectedIndex != -1)
        {
            RdbLNumeros.Items.RemoveAt(RdbLNumeros.SelectedIndex);
        }


        //Método para Borrar un ListItem. Borra por elemento.

        //Borrar el elemento 0 - Primer elemento de la lista
        RdbLNumeros.Items.Remove(RdbLNumeros.Items[0]);

        //Borra el último elemento de la lista
        RdbLNumeros.Items.Remove(RdbLNumeros.Items[RdbLNumeros.Items.Count - 1]);

        //Borra el elemento seleccionado 
        RdbLNumeros.Items.Remove(RdbLNumeros.SelectedItem);



        //Borrar todos los elementos de la lista
        RdbLNumeros.Items.Clear();

    }



    protected void Button4_Click(object sender, EventArgs e)
    {
        //Buscar elementos en una lista

        //Contains- Si encuentra el elemento (pasa un Listitem) devuelve true si no false.
        ListItem LiNuevo = new ListItem("Ocho", "8");
        bool encontrado = RdbLNumeros.Items.Contains(LiNuevo);
        LblEtiqueta.Text = "Elemento encontrado: " + encontrado;


        //FindByText: Busca por Texto (string) un elemento en la lista. Si lo encuentra devuelve todo el elemento (ListItem).
        // Si no lo encuentra devuelve un null.
        ListItem li = RdbLNumeros.Items.FindByText("Cinco");
        if (li != null)
        {
            LblEtiqueta.Text = "Elemento seleccionado: " + li.Text + "-Valor-" + li.Value;
        }

        //FindByValue: Busca por Value (string) un elemento en la lista. Si lo encuentra devuelve todo el elemento (ListItem).
        // Si no lo encuentra devuelve un null.
        ListItem li2 = RdbLNumeros.Items.FindByValue("6");
        if (li2 != null)
        {
            LblEtiqueta.Text = "Elemento seleccionado: " + li2.Text + "-Valor-" + li2.Value;
        }

        //IndexOf:Busca un elemento (ListItem) en la lista. Si lo encuentra devuelvela posición del elemento (int).
        // Si no lo encuentra devuelve un -1.
        int posicion = RdbLNumeros.Items.IndexOf(LiNuevo);
        if (posicion != -1)
        {
            LblEtiqueta.Text = "Elemento seleccionado: " + RdbLNumeros.Items[posicion].Text + "-Valor-" + RdbLNumeros.Items[posicion].Value;
        }
    }

    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //CUIDADO: En CheckBNoxList el SelectedIndex,SelectedItem y SelectedValue solo devuelven los valores del 
        //Primer elemento seleccionado en la lista de casillas de verificación.
        //LblEtiqueta.Text = ChkLLetras.SelectedItem.Text;

        //Mostrar todos los elementos seleccionados en una Lista de casillas de verificación

        LblEtiqueta.Text = String.Empty;
        foreach (ListItem item in ChkLLetras.Items)
        {
            if (item.Selected)
            {
                LblEtiqueta.Text += item.Text + "<BR/>";
            }
        }


    }






    protected void Button7_Click(object sender, EventArgs e)
    {
        //Borrar todos los elementos seleccionados en una lista de casillas de verificación

        /************¡¡¡¡¡¡CUIDADO: Con foreach no se puede eliminar elementos. No permite modificar las colecciones que se recorren!!!!!!!******/
        //foreach (ListItem item in ChkLLetras.Items)
        //{
        //    if (item.Selected)
        //    {
        //        ChkLLetras.Items.Remove(item);
        //    }
        //}
        /************************************************************************************************************************************/

        //Eliminar los elementos con un for en creciente.
        //Acordaos de decrementar el contador del for, cuando borra un elemento porque los elementos de una lista siempre se recolocan.
        //Si no lo hacemos nos saltaríamos posiciones

        for (int i = 0; i < ChkLLetras.Items.Count; i++)
        {
            if (ChkLLetras.Items[i].Selected)
            {

                ChkLLetras.Items.RemoveAt(i);
                i--;
            }

            //Eliminar los elementos con un for en decreciente.
            //No hace falta tocar la variable del for porque al ir en decreciente aunque se borren los elementos
            //siempre pasas a la posición anterior que es la que toca tratar.
            for (int j = ChkLLetras.Items.Count - 1; j >= 0; j--)
            {
                if (ChkLLetras.Items[j].Selected)
                {
                    ChkLLetras.Items.RemoveAt(j);
                }
            }
        }
    }
}



