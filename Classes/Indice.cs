using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackovid
{
    public class Indice
    {
        private string cod_Indice;
        private string metodo;
        private List<Indice> indices;

        public string Cod_Indice { get => cod_Indice; set => cod_Indice = value; }
        public string Metodo { get => metodo; set => metodo = value; }
        public List<Indice> Indices { get => indices; set => indices = value; }

        public Indice(string cod_Indice, string metodo, List<Indice> indices)
        {
            Cod_Indice = cod_Indice;
            Metodo = metodo;
            Indices = indices;
        }

        public Indice()
        {
            Cod_Indice = "";
            Metodo = "";
            Indices = new List<Indice>();
        }
    }
}
