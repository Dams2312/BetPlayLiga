using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LigaBetPlay.PermanenciData;

using LigaBetPlay.Equipos;



namespace LigaBetPlay.LogicgTorneo
{
    public class Torneo
    {
        public List<Equipo> Equipos = new List<Equipo>();
        public ReadWriteJson readWriteJson = new ReadWriteJson();

        public void RegistrarEquipo()
        {
            Console.Write("Nombre del equipo: ");
            bool validInput = false;
            while(!validInput)
            {
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {   
                    var equipos = readWriteJson.LeerEquipos();
                    equipos.Add(new Equipo(input));
                    readWriteJson.GuardarEquipos(equipos);
                    validInput = true;
                    Console.WriteLine("Equipo registrado correctamente\n");
                    Equipos.Add(new Equipo(input));
                }
                else
                {
                    Console.WriteLine("El nombre del equipo no puede estar vacío. Por favor, ingrese un nombre válido.");
                    Console.Write("Nombre del equipo: ");
                }
            }
        }

        public void ListarEquipos()
        {
            Console.WriteLine("\nEquipos registrados:");
            var equipos = readWriteJson.LeerEquipos();
            for (int i = 0; i < equipos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {equipos[i].Nombre}");
            }

        }

        public Equipo BuscarEquipoPorIndice(int indice)
        {
                var equipos = readWriteJson.LeerEquipos();
                if (indice < 0 || indice >= equipos.Count)
                    throw new ArgumentOutOfRangeException(nameof(indice), "Índice de equipo fuera de rango");
            return equipos[indice];
        }
    }
}