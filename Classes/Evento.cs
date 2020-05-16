using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackovid
{
    public class Evento
    {
        private string cod_Evento;
        private string titulo;
        private string descricao;
        private List<Efeito> efeitos;
        private List<Noticia> noticias;
        private decimal probab_Acontecer;

        public Evento()
        {
            Cod_Evento = "";
            Titulo = "";
            Descricao = "";
            Efeitos = new List<Efeito>();
            Noticias = new List<Noticia>();
            probab_Acontecer = 0;
        }

        public Evento(string cod_Evento, string titulo, string descricao, List<Efeito> efeitos, List<Noticia> noticias, decimal probab_Acontecer)
        {
            Cod_Evento = cod_Evento;
            Titulo = titulo;
            Descricao = descricao;
            Efeitos = efeitos;
            Noticias = noticias;
            Probab_Acontecer = probab_Acontecer;
        }

        public string Cod_Evento { get => cod_Evento; set => cod_Evento = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public List<Efeito> Efeitos { get => efeitos; set => efeitos = value; }
        public List<Noticia> Noticias { get => noticias; set => noticias = value; }
        public decimal Probab_Acontecer { get => probab_Acontecer; set => probab_Acontecer = value; }
    }
}
