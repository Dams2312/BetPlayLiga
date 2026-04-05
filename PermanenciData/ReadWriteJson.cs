using System.Text.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using LigaBetPlay.Equipos;

namespace LigaBetPlay.PermanenciData
{
    public class ReadWriteJson
    {
        private string ruta = "equipo.json";
        // leer datos del Json
        public List<Equipo> LeerEquipos()
        {
            if(!File.Exists(ruta))
            {
                return new List<Equipo>();
            }
            string json = File.ReadAllText(ruta);
            return JsonSerializer.Deserialize<List<Equipo>>(json) ?? new List<Equipo>();
        }

        //Guardar datos en el json
        public void GuardarEquipos(List<Equipo> equipos){
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json  = JsonSerializer.Serialize(equipos, opciones);
            File.WriteAllText(ruta, json);
        }
    }
}