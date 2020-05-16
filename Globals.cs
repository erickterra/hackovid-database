using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackovid
{
    public  static class Globals
    {
        public static JsonDatabase database;
        public static string FilePath
        {
            get
            {
                return ConfigurationManager.AppSettings["FILEPATH"];
            }
        }

        public static string FileName
        {
            get
            {
                return ConfigurationManager.AppSettings["FILENAME"];
            }
        }

        public static Indice GetIndice(string cod)
        {
            database = new JsonDatabase();
            database = database.ReadJson();
            Indice indice = database.indices.Where(i => i.Cod_Indice == cod).FirstOrDefault();
            return indice;
        }

        public static Açao GetAçao(string cod)
        {
            database = new JsonDatabase();
            database = database.ReadJson();
            Açao açao = database.açoes.Where(i => i.Cod_Acao == cod).FirstOrDefault();
            return açao;
        }

        internal static Noticia GetNoticia(string cod )
        {
            database = new JsonDatabase();
            database = database.ReadJson();
            Noticia obj = database.noticias.Where(i => i.Cod_noticia == cod).FirstOrDefault();
            return obj;
        }

        internal static Fator GetFator(string cod)
        {
            database = new JsonDatabase();
            database = database.ReadJson();
            Fator obj = database.fatores.Where(i => i.Nome == cod).FirstOrDefault();
            return obj;
        }


        public static List<Fator> GetFatores()
        {
            database = new JsonDatabase();
            database = database.ReadJson();
            return database.fatores;
        }
    }
}
