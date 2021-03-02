using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Class
{
    public class ClsRevistaCientifica
    {
        public string Nombre;
        public string AnioPub;
        public string Frecuencia;
        public string RangoPagina;
        public string Anio;
        ClsRevistaCientifica()
        {
            this.Nombre = "";
            this.AnioPub = "";
            this.Frecuencia = "";
            this.RangoPagina = "";
            this.Anio = "";
        }

        ClsRevistaCientifica(string aNombre, string aAnioPub, string aFrecuencia, string
            aRangoPagina, string aAnio)
        {
            this.Nombre = aNombre;
            this.Anio = aAnioPub;
            this.Frecuencia = aFrecuencia;
            this.RangoPagina = aRangoPagina;
            this.Anio = aAnio;
        }
    }
}
