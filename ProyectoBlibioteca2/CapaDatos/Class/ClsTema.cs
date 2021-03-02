using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Class
{
    public class ClsTema
    {
        public string Nombre;
        public string Descripcion;

        public ClsTema()
        {
            this.Nombre = "";
            this.Descripcion = "";
        }

        public ClsTema(string aNombre, string aDescripcion)
        {
            this.Nombre = aNombre;
            this.Descripcion = aDescripcion;
        }
    }
}
