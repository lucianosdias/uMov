
namespace Bilheteria
{
    public class Ingresso
    {
        private TipoPessoa _tipoPessoa;

        public Ingresso(TipoPessoa tipoPessoa)
        {
            this._tipoPessoa = tipoPessoa;
        }

        public double CalcularValor()
        {
            if (_tipoPessoa == TipoPessoa.Idoso)
                return 5.4;

            if (_tipoPessoa == TipoPessoa.Estudante)
                return 7.2;

            return 4.95;
        }
    }
}
