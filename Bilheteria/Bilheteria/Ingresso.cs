
namespace Bilheteria
{
    public class Ingresso
    {
        private string _tipoPessoa;

        public Ingresso(string tipoPessoa)
        {
            this._tipoPessoa = tipoPessoa;
        }

        public double CalcularValor()
        {
            if (_tipoPessoa == "idoso")
                return 5.4;

            return 4.95;
        }
    }
}
