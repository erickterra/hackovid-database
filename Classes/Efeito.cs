using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackovid
{
    public class Efeito
    {
        private Fator fator;
        private string operaçao;
        private float valor;
        private string text;
        private float v;

        public Efeito()
        {
            Fator = new Fator();
            Operaçao = "";
            Valor = 0;
        }

        public Efeito(Fator fator, string text, float v)
        {
            Fator = fator;
            Operaçao = text;
            Valor = v;
        }

        public Fator Fator { get => fator; set => fator = value; }
        public string Operaçao { get => operaçao; set => operaçao = value; }
        public float Valor { get => valor; set => valor = value; }
    }
}
