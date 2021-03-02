using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Class
{
    public class ClsCentro
    {
        public string Descripcion;

        public ClsCentro()
        {
            this.Descripcion = "";
        }

        public ClsCentro(string aDescripcion)
        {
            this.Descripcion = aDescripcion;
        }
    }
}
