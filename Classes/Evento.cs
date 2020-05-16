using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackovid
{
    public class Evento
    {
        string Cod_Evento;
        string Titulo;
        string Descricao;
        List<Efeito> Efeitos;
        List<Noticia> Noticias;
        decimal probab_Acontecer;
    }
}
