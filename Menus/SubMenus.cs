using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LigaBetPlay.LogicgTorneo;
using LigaBetPlay.Equipos;
using LigaBetPlay.PermanenciData;

namespace LigaBetPlay.Menus
{
    public class SubMenus
    {
        Consultas consultas = new Consultas();
        Torneo torneo = new Torneo();
        
        ReadWriteJson readWriteJson = new ReadWriteJson();
        public void SubmenuConsultas()
        {
            int opcion = 0;

            var equipos = readWriteJson.LeerEquipos();

            while (opcion != 20)
            {
                Console.WriteLine("\n==== CONSULTAS ====");

                Console.WriteLine("1. Tabla de posiciones");
                Console.WriteLine("2. Lider del torneo");
                Console.WriteLine("3. Mas goles a favor");
                Console.WriteLine("4. Menos goles en contra");
                Console.WriteLine("5. Mas partidos ganados");
                Console.WriteLine("6. Mas empates");
                Console.WriteLine("7. Mas derrotas");
                Console.WriteLine("8. Equipos invictos");
                Console.WriteLine("9. Equipos sin victorias");
                Console.WriteLine("10. Top 3");
                Console.WriteLine("11. Diferencia de gol positiva");
                Console.WriteLine("12. Equipos con mas de X puntos");
                Console.WriteLine("13. Buscar equipo por nombre");
                Console.WriteLine("14. Promedio goles a favor");
                Console.WriteLine("15. Promedio goles en contra");
                Console.WriteLine("16. Total goles torneo");
                Console.WriteLine("17. Total puntos torneo");
                Console.WriteLine("18. Ranking");
                Console.WriteLine("19. Estadisticas destacadas");
                Console.WriteLine("20. Volver al menu principal");

                Console.Write("\nSeleccione opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Numero invalido");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        consultas.MostrarTabla(equipos);
                        break;

                    case 2:
                        consultas.Lider(equipos);
                        break;

                    case 3:
                        consultas.MasGolesFavor(equipos);
                        break;

                    case 4:
                        consultas.MenosGolesContra(equipos);
                        break;

                    case 5:
                        consultas.MasGanados(equipos);
                        break;

                    case 6:
                        consultas.MasEmpates(equipos);
                        break;

                    case 7:
                        consultas.MasDerrotas(equipos);
                        break;

                    case 8:
                        consultas.Invictos(equipos);
                        break;

                    case 9:
                        consultas.SinVictorias(equipos);
                        break;

                    case 10:
                        consultas.Top3(equipos);
                        break;

                    case 11:
                        consultas.DiferenciaPositiva(equipos);
                        break;

                    case 12:
                        PedirPuntos();
                        break;

                    case 13:
                        BuscarEquipo();
                        break;

                    case 14:
                        consultas.PromedioGF(equipos);
                        break;

                    case 15:
                        consultas.PromedioGC(equipos);
                        break;

                    case 16:
                        consultas.TotalGoles(equipos);
                        break;

                    case 17:
                        consultas.TotalPuntos(equipos);
                        break;

                    case 18:
                        consultas.RankingSimple(equipos);
                        break;

                    case 19:
                        consultas.Destacados(equipos);
                        break;

                    case 20:
                        Console.WriteLine("Volviendo...");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
        public void PedirPuntos()
        {
            Console.Write("Ingrese puntos: ");

            var equipos = readWriteJson.LeerEquipos();
            if (!int.TryParse(Console.ReadLine(), out int puntos))
            {
                Console.WriteLine("Numero invalido");
                return;
            }

            consultas.MasDeXPuntos(equipos, puntos);
        }

        public void BuscarEquipo()
        {   

            var equipos = readWriteJson.LeerEquipos();
            Console.Write("Nombre equipo: ");
            string? nombre = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("Nombre no valido");
                return;
            }
            consultas.BuscarEquipo(equipos, nombre);
        }
        
    }
}