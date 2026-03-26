using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LigaBetPlay.Equipos;  

namespace LigaBetPlay.LogicgTorneo
{
    public class Consultas
    {
        // TABLA ORDENADA
        public List<Equipo> TablaOrdenada(List<Equipo> equipos)
        {
            return equipos
                .OrderByDescending(e => e.Puntos)
                .ThenByDescending(e => e.DiferenciaGol())
                .ThenByDescending(e => e.GF)
                .ThenBy(e => e.Nombre)
                .ToList();
        }

        // Método completo tabla
        public void MostrarTabla(List<Equipo> equipos)
        {
            var tabla = TablaOrdenada(equipos);

            Console.WriteLine("\nTABLA DE POSICIONES");

            foreach (var e in tabla)
            {
                Console.WriteLine(
                    $"{e.Nombre} PJ:{e.PJ} PG:{e.PG} PE:{e.PE} PP:{e.PP} GF:{e.GF} GC:{e.GC} DG:{e.DiferenciaGol()} PTS:{e.Puntos}"
                );
            }
        }

        // líder
        public void Lider(List<Equipo> equipos)
        {
            var lider = TablaOrdenada(equipos).First();

            Console.WriteLine($"\nLider: {lider.Nombre}");
        }

        // más goles a favor
        public void MasGolesFavor(List<Equipo> equipos)
        {
            int max = equipos.Max(e => e.GF);

            var lista = equipos.Where(e => e.GF == max);

            Console.WriteLine("\nMas goles a favor:");

            foreach (var e in lista)
                Console.WriteLine(e.Nombre);
        }

        // menos goles en contra
        public void MenosGolesContra(List<Equipo> equipos)
        {
            int min = equipos.Min(e => e.GC);

            var lista = equipos.Where(e => e.GC == min);

            Console.WriteLine("\nMenos goles recibidos:");

            foreach (var e in lista)
                Console.WriteLine(e.Nombre);
        }

        // más partidos ganados
        public void MasGanados(List<Equipo> equipos)
        {
            int max = equipos.Max(e => e.PG);

            var lista = equipos.Where(e => e.PG == max);

            Console.WriteLine("\nMas partidos ganados:");

            foreach (var e in lista)
                Console.WriteLine(e.Nombre);
        }

        // más empates
        public void MasEmpates(List<Equipo> equipos)
        {
            int max = equipos.Max(e => e.PE);

            var lista = equipos.Where(e => e.PE == max);

            Console.WriteLine("\nMas empates:");

            foreach (var e in lista)
                Console.WriteLine(e.Nombre);
        }

        // más derrotas
        public void MasDerrotas(List<Equipo> equipos)
        {
            int max = equipos.Max(e => e.PP);

            var lista = equipos.Where(e => e.PP == max);

            Console.WriteLine("\nMas derrotas:");

            foreach (var e in lista)
                Console.WriteLine(e.Nombre);
        }

        // invictos
        public void Invictos(List<Equipo> equipos)
        {
            var lista = equipos.Where(e => e.PP == 0);

            Console.WriteLine("\nEquipos invictos:");

            foreach (var e in lista)
                Console.WriteLine(e.Nombre);
        }

        // sin victorias
        public void SinVictorias(List<Equipo> equipos)
        {
            var lista = equipos.Where(e => e.PG == 0);

            Console.WriteLine("\nEquipos sin victorias:");

            foreach (var e in lista)
                Console.WriteLine(e.Nombre);
        }

        // top 3
        public void Top3(List<Equipo> equipos)
        {
            var lista = TablaOrdenada(equipos).Take(3);

            Console.WriteLine("\nTOP 3");

            foreach (var e in lista)
                Console.WriteLine($"{e.Nombre} {e.Puntos} pts");
        }

        // diferencia de gol positiva
        public void DiferenciaPositiva(List<Equipo> equipos)
        {
            var lista = equipos.Where(e => e.DiferenciaGol() > 0);

            Console.WriteLine("\nDiferencia positiva:");

            foreach (var e in lista)
                Console.WriteLine(e.Nombre);
        }

        // más de cierta cantidad de puntos
        public void MasDeXPuntos(List<Equipo> equipos, int puntos)
        {
            var lista = equipos.Where(e => e.Puntos > puntos);

            Console.WriteLine($"\nEquipos con mas de {puntos} puntos:");

            foreach (var e in lista)
                Console.WriteLine(e.Nombre);
        }

        //Buscar nombre de equipo
        public void BuscarEquipo(List<Equipo> equipos, string nombre)
        {
            var equipo = equipos
                .FirstOrDefault(e => e.Nombre.ToLower() == nombre.ToLower());

            if (equipo != null)
            {
                Console.WriteLine($"\nEncontrado: {equipo.Nombre} {equipo.Puntos} pts");
            }
            else
            {
                Console.WriteLine("No existe");
            }
        }

        // promedio goles a favor
        public void PromedioGF(List<Equipo> equipos)
        {
            double promedio = equipos.Average(e => e.GF);

            Console.WriteLine($"\nPromedio goles a favor: {promedio}");
        }

        // promedio goles en contra
        public void PromedioGC(List<Equipo> equipos)
        {
            double promedio = equipos.Average(e => e.GC);

            Console.WriteLine($"\nPromedio goles en contra: {promedio}");
        }

        // total goles
        public void TotalGoles(List<Equipo> equipos)
        {
            int total = equipos.Sum(e => e.GF);

            Console.WriteLine($"\nTotal goles torneo: {total}");
        }

        //Total Puntos
        public void TotalPuntos(List<Equipo> equipos)
        {
            int total = equipos.Sum(e => e.Puntos);

            Console.WriteLine($"\nTotal puntos torneo: {total}");
        }

         // tabla personalizada 
        public void TablaSimple(List<Equipo> equipos)
        {
            var lista = TablaOrdenada(equipos);

            Console.WriteLine("\nTabla simple:");

            foreach (var e in lista)
                Console.WriteLine($"{e.Nombre} {e.Puntos}");
        }

        // por debajo del promedio de puntos
        public void BajoPromedioPuntos(List<Equipo> equipos)
        {
            double promedio = equipos.Average(e => e.Puntos);

            var lista = equipos.Where(e => e.Puntos < promedio);

            Console.WriteLine("\nDebajo del promedio:");

            foreach (var e in lista)
                Console.WriteLine(e.Nombre);
        }

          // ranking simple numerado
        public void RankingSimple(List<Equipo> equipos)
        {
            var lista = TablaOrdenada(equipos);

            Console.WriteLine("\nRanking:");

            int pos = 1;

            foreach (var e in lista)
            {
                Console.WriteLine($"{pos}. {e.Nombre}");
                pos++;
            }
        }

        // estadísticas destacadas
        public void Destacados(List<Equipo> equipos)
        {
            Lider(equipos);
            MasGolesFavor(equipos);
            MenosGolesContra(equipos);
            MasGanados(equipos);
        }

    }
}