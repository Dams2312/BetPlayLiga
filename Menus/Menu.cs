using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LigaBetPlay.LogicgTorneo;
using LigaBetPlay.Menus;
using LigaBetPlay.PermanenciData;


namespace LigaBetPlay.Menus
{
    public class Menu
    {
        Torneo torneo = new Torneo();
        PartidoSimular partidoSimular = new PartidoSimular();
        Consultas consultas = new Consultas();

        SubMenus subMenus = new SubMenus();

        ReadWriteJson readWriteJson = new ReadWriteJson();

        public void Iniciar()
        {
            bool opciones = true;

            while (opciones)
            {
                Console.WriteLine("\n--- LIGA BETPLAY ---");
                Console.WriteLine("1. Registrar equipo");
                Console.WriteLine("2. Listar equipos");
                Console.WriteLine("3. Simular partido");
                Console.WriteLine("4. Tabla posiciones");
                Console.WriteLine("5. Estadisticas");
                Console.WriteLine("6. Salir");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            torneo.RegistrarEquipo();
                            break;

                        case 2:
                            torneo.ListarEquipos();
                            break;

                        case 3:
                            partidoSimular.SimularPartido();
                            break;

                        case 4:
                            var equipos = readWriteJson.LeerEquipos();
                            consultas.MostrarTabla(equipos);
                            break;

                        case 5:
                            subMenus.SubmenuConsultas();
                            break;
                        case 6:
                            Console.WriteLine("Saliendo del programa...");
                            opciones = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, ingrese un número del 1 al 6.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número del 1 al 6.");
                }
                
            }
        }
    }
}