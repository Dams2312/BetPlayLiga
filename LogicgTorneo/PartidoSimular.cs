using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LigaBetPlay.LogicgTorneo;
using LigaBetPlay.Equipos;
using LigaBetPlay.PermanenciData;

namespace LigaBetPlay.LogicgTorneo
{
    public class PartidoSimular
    {
        Torneo torneo = new Torneo();
        SimularPartidos simulador = new SimularPartidos();

        ReadWriteJson readWriteJson = new ReadWriteJson();

        public void SimularPartido()
        {
            var equipos = readWriteJson.LeerEquipos();
            if (equipos.Count < 2)
            {
                Console.WriteLine("Debes registrar al menos 2 equipos");
                return;
            }

            torneo.ListarEquipos();

            Console.Write("Seleccione equipo local #: ");
            if (int.TryParse(Console.ReadLine(), out int localIndex))
            {
                localIndex--; 
            }
            else
            {
                Console.WriteLine("Número inválido");
                return;
            }

            Console.Write("Seleccione equipo visitante #: ");
            if (int.TryParse(Console.ReadLine(), out int visitanteIndex))
            {
                visitanteIndex--; 
            }
            else
            {
                Console.WriteLine("Número inválido");
                return;
            }

            if (localIndex < 0 || localIndex >= equipos.Count || visitanteIndex < 0 || visitanteIndex >= equipos.Count)
            {
                Console.WriteLine("Índice de equipo fuera de rango");
                return;
            }

            if (localIndex == visitanteIndex)
            {
                Console.WriteLine("No puedes seleccionar el mismo equipo");
                return;
            }


            Equipo local = equipos[localIndex];
            Equipo visitante = equipos[visitanteIndex];

            simulador.JugarPartido(local, visitante);

            readWriteJson.GuardarEquipos(equipos);
            Console.WriteLine("Partido simulado y estadísticas actualizadas correctamente.");
        }
    }
};