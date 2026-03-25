using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LigaBetPlay.Equipos;

namespace LigaBetPlay.LogicgTorneo
{
    public class SimularPartidos
    {
        public void JugarPartido(Equipo local, Equipo visitante)
        {
            Console.WriteLine("\nPARTIDO");

            Console.Write($"Goles de {local.Nombre}: ");
            int golesLocal = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Goles de {visitante.Nombre}: ");
            int golesVisitante = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nResultado:");
            Console.WriteLine($"{local.Nombre} {golesLocal} - {golesVisitante} {visitante.Nombre}");

            ActualizarEstadisticas(local, visitante, golesLocal, golesVisitante);
        }

        void ActualizarEstadisticas(Equipo a, Equipo b, int golesA, int golesB)
        {
            a.PJ++;
            b.PJ++;

            a.GF += golesA;
            a.GC += golesB;

            b.GF += golesB;
            b.GC += golesA;

            if (golesA > golesB)
            {
                a.PG++;
                b.PP++;
                a.Puntos += 3;
            }
            else if (golesA < golesB)
            {
                b.PG++;
                a.PP++;
                b.Puntos += 3;
            }
            else
            {
                a.PE++;
                b.PE++;
                a.Puntos += 1;
                b.Puntos += 1;
            }

        }
    }
}