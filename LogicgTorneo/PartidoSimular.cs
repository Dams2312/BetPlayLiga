using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LigaBetPlay.LogicgTorneo;
using LigaBetPlay.Equipos;

namespace LigaBetPlay.LogicgTorneo
{
    public class PartidoSimular
    {
        Torneo torneo = new Torneo();
        SimularPartidos simulador = new SimularPartidos();


        public void SimularPartido()
        {
            if (torneo.Equipos.Count < 2)
            {
                Console.WriteLine("Debes registrar al menos 2 equipos");
                return;
            }

            torneo.ListarEquipos();

            Console.Write("Seleccione equipo local #: ");
            int localIndex = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Seleccione equipo visitante #: ");
            int visitanteIndex = int.Parse(Console.ReadLine()) - 1;



            Equipo local = torneo.BuscarEquipoPorIndice(localIndex);
            Equipo visitante = torneo.BuscarEquipoPorIndice(visitanteIndex);

            simulador.JugarPartido(local, visitante);
        }
    }
};