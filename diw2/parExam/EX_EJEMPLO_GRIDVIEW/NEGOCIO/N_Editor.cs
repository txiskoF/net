using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDADES;

namespace NEGOCIO
{
  
    public class N_Editor
    {
        D_Editor neditor = new D_Editor();
        public List<Editor> getEditor()
        {
            return neditor.getEditor();
        }
    }
}
