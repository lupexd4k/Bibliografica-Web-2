using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Class
{
    public class ClsInformeTecnico
    {
        public int Mes;
        public int Anio;

        public ClsInformeTecnico()
        {
            this.Mes = 0;
            this.Anio = 0;
        }

        public ClsInformeTecnico(int aMes, int aAnio)
        {
            this.Mes = aMes;
            this.Anio = aAnio;
        }
    }
}
