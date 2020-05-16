using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackovid
{
    public class JsonDatabase
    {
        public List<Açao> açoes;
        public List<Efeito> efeitos;
        public List<Evento> eventos;
        public List<Fator> fatores;
        public List<Indice> indices;
        public List<Noticia> noticias;

        public JsonDatabase()
        {
            açoes = new List<Açao>();
            efeitos = new List<Efeito>();
            eventos = new List<Evento>();
            fatores = new List<Fator>();
            noticias = new List<Noticia>();
            indices = new List<Indice>();
        }

        public JsonDatabase ReadJson()
        {
            Debug.WriteLine("Lendo...");
            string jsonToString = File.ReadAllText(Globals.FilePath + Globals.FileName);
            return JsonConvert.DeserializeObject<JsonDatabase>(jsonToString);
        }

        public void WriteJson(JsonDatabase jsonDatabase)
        {
            Debug.WriteLine("Gravando");
            string jsonQuery = JsonConvert.SerializeObject(jsonDatabase, Formatting.Indented);
            File.WriteAllText(Globals.FilePath + Globals.FileName, jsonQuery);
        }

    }

}
