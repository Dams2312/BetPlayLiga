using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LigaBetPlay.Equipos
{
    public class Equipo
    {
        public string Nombre { get; set; }

        public int PJ { get; set; }
        public int PG { get; set; }
        public int PE { get; set; }
        public int PP { get; set; }

        public int GF { get; set; }
        public int GC { get; set; }

        public int Puntos { get; set; }

        public int DiferenciaGol()
        {
            return GF - GC;
        }

        public Equipo(string nombre)
        {
            Nombre = nombre;
            PJ = 0;
            PG = 0;
            PE = 0;
            PP = 0;
            GF = 0;
            GC = 0;
            Puntos = 0;
        }
    }
}