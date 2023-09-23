using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using ACCESO_DATOS;

namespace NEGOCIO
{

    public class DAL_Editores
    {
        DAO_Editores ado_editor = new DAO_Editores();

        public List<Editor> getEditores()
        {
            return ado_editor.getEditores();
        }
    }
}
