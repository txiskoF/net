using DAL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal
{
    public partial class Empleados : System.Web.UI.Page
    {
        DAL_Publisher DPublisher = new DAL_Publisher();
        DAL_Employee DEmployee = new DAL_Employee();
        DAL_Job Djob = new DAL_Job();

        //creo estas listas para usar cuando necesite
        List<Employee> listEmployees = new List<Employee>();
        List<Job> listJobs = new List<Job>();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                //llamo al metodo para cargar las editoriales en la ddl
                mostrarEditoriales();

        }

        private void mostrarEditoriales()
        {
            //en una lista guardo las editoriales llamo al metodo en DAO_Publishers
            List<Publisher> Publishers = DPublisher.getEditoriales();
            //recorro la lista
            foreach(Publisher publisher in Publishers)
            {
                //meto cada editorial en una linea de la ddl
                ListItem item = new ListItem(publisher.Pub_name, publisher.Pub_id);
                ddleditoriales.Items.Add(item);
            }
        }

        //de la ddl selecciono una 
        protected void ddleditoriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cojo el value y lo guardo 
            String idEditorialSeleccionada = ddleditoriales.SelectedValue;
            //llamo a calculartotalEmpelados  y paso el id de lo seleccionado
            int total = calcularTotalEmpleados(idEditorialSeleccionada);
            //pinto la cantidad
            lblEmpleados.Text = total.ToString();
            //llamo a rellenarListadoProfesiones
            rellenarListadoProfesiones();
        }

                private int calcularTotalEmpleados(String pub_id)
                {
                    //delcaro variable
                    int totalEmpleados = 0;
                    //recorro la lista
                    foreach (Employee employee in listEmployees)
                    {
                            //Llamo al metodo del DAO_Employee
                        int cantidad = DEmployee.cantidadEmployee(pub_id);
                        //actualizo
                        totalEmpleados += cantidad;
                    }
                    //obtengo el total
                    return totalEmpleados;
                }


                        private void rellenarListadoProfesiones()
                        {
                            List<String> job_desc = Djob.getJobDesc();

                            lstProfesiones.Text = "";
                            foreach (String job in job_desc)
                            {
                                ListItem liJob = new ListItem();
                                lstProfesiones.Items.Add(liJob);
                            }
                        }



        private void rellenarEmpleados(String pub_id)
        {
            List<String> emp_ids = DEmployee.getEmpIds(pub_id);
            foreach (String id in emp_ids)
            {
                Employee employee = DEmployee.getEmpId(id);
                ListItem liEmployee = new ListItem(employee.Emp_id, employee.Emp_id);
                lstEmpleados.Items.Add(liEmployee);
                listEmployees.Add(employee);
            }

        }

        

       

       


        protected void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

            


            
        }

        protected void lstProfesiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            String pub_id = ddleditoriales.SelectedValue;
            String job_lvl = lstProfesiones.SelectedValue;
            List<Employee> employees = DEmployee.getEmployess(Convert.ToInt32(job_lvl), pub_id);

            lstEmpleados.Items.Clear();
            foreach(Employee employee in employees)
            {
                ListItem item = new ListItem(employee.Nombre, employee.Apellido, employee.Job_lvl);
                lstEmpleados.Items.Add(item);
            }

         
        }

        private Job obtenerProfesion(string job_lvl)
        {
            Job job = Djob.getJobDesc(job_lvl);


    }
}