using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackovid
{
    public class Açao
    {
        private string cod_Acao;
        private string titulo;
        private string descricao;
        private int custo;
        private List<Efeito> efeitos;
        private List<Noticia> noticias;
        private bool isCustoVariavel;
        private Fator fatorCusto;
  

        public string Cod_Acao { get => cod_Acao; set => cod_Acao = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Custo { get => custo; set => custo = value; }
        public List<Efeito> Efeitos { get => efeitos; set => efeitos = value; }
        public List<Noticia> Noticias { get => noticias; set => noticias = value; }
        public bool IsCustoVariavel { get => isCustoVariavel; set => isCustoVariavel = value; }
        public Fator FatorCusto { get => fatorCusto; set => fatorCusto = value; }

        public Açao(string cod_Acao, string titulo, string descricao, int custo, List<Efeito> efeitos, List<Noticia> noticias, bool isCustoVariavel, Fator fatorCusto)
        {
            Cod_Acao = cod_Acao;
            Titulo = titulo;
            Descricao = descricao;
            this.custo = custo;
            this.efeitos = efeitos;
            this.noticias = noticias;
            IsCustoVariavel = isCustoVariavel;
            FatorCusto = fatorCusto;
        }

        public Açao()
        {
        }
    }
}
