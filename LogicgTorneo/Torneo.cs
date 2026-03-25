using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LigaBetPlay.Equipos;

namespace LigaBetPlay.LogicgTorneo
{
    public class Torneo
    {
        public List<Equipo> Equipos = new List<Equipo>();

        public void RegistrarEquipo()
        {
            Console.Write("Nombre del equipo: ");
            string nombre = Console.ReadLine();

            Equipos.Add(new Equipo(nombre));

            Console.WriteLine("Equipo registrado correctamente\n");
        }

        public void ListarEquipos()
        {
            Console.WriteLine("\nEquipos registrados:");

            for (int i = 0; i < Equipos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Equipos[i].Nombre}");
            }

            Console.WriteLine();
        }

        public Equipo BuscarEquipoPorIndice(int indice)
        {
            return Equipos[indice];
        }
    }
}