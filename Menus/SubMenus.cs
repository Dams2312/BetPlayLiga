using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LigaBetPlay.LogicgTorneo;
using LigaBetPlay.Equipos;

namespace LigaBetPlay.Menus
{
    public class SubMenus
    {
        Consultas consultas = new Consultas();
        Torneo torneo = new Torneo();
        
        public void SubmenuConsultas()
        {
            int opcion = 0;

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
                        consultas.MostrarTabla(torneo.Equipos);
                        break;

                    case 2:
                        consultas.Lider(torneo.Equipos);
                        break;

                    case 3:
                        consultas.MasGolesFavor(torneo.Equipos);
                        break;

                    case 4:
                        consultas.MenosGolesContra(torneo.Equipos);
                        break;

                    case 5:
                        consultas.MasGanados(torneo.Equipos);
                        break;

                    case 6:
                        consultas.MasEmpates(torneo.Equipos);
                        break;

                    case 7:
                        consultas.MasDerrotas(torneo.Equipos);
                        break;

                    case 8:
                        consultas.Invictos(torneo.Equipos);
                        break;

                    case 9:
                        consultas.SinVictorias(torneo.Equipos);
                        break;

                    case 10:
                        consultas.Top3(torneo.Equipos);
                        break;

                    case 11:
                        consultas.DiferenciaPositiva(torneo.Equipos);
                        break;

                    case 12:
                        PedirPuntos();
                        break;

                    case 13:
                        BuscarEquipo();
                        break;

                    case 14:
                        consultas.PromedioGF(torneo.Equipos);
                        break;

                    case 15:
                        consultas.PromedioGC(torneo.Equipos);
                        break;

                    case 16:
                        consultas.TotalGoles(torneo.Equipos);
                        break;

                    case 17:
                        consultas.TotalPuntos(torneo.Equipos);
                        break;

                    case 18:
                        consultas.RankingSimple(torneo.Equipos);
                        break;

                    case 19:
                        consultas.Destacados(torneo.Equipos);
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

            if (!int.TryParse(Console.ReadLine(), out int puntos))
            {
                Console.WriteLine("Numero invalido");
                return;
            }

            consultas.MasDeXPuntos(torneo.Equipos, puntos);
        }

        public void BuscarEquipo()
        {
            Console.Write("Nombre equipo: ");
            string nombre = Console.ReadLine();

            consultas.BuscarEquipo(torneo.Equipos, nombre);
        }
        
    }
}