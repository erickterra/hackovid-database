namespace Hackovid
{
    public class Fator
    {
        private string nome;
        private int valorMax;

        public Fator()
        {
            Nome = "";
            ValorMax = 0;
        }

        public Fator(string nome, int valorMax)
        {
            Nome = nome;
            ValorMax = valorMax;
        }

        public string Nome { get => nome; set => nome = value; }
        public int ValorMax { get => valorMax; set => valorMax = value; }
    }
}
