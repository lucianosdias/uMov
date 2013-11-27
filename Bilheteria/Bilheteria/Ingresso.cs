
namespace Bilheteria
{
    public class Ingresso
    {
        private TipoPessoa _tipoPessoa;
        private string _diaDaSemana;

        public Ingresso(TipoPessoa tipoPessoa)
        {
            this._tipoPessoa = tipoPessoa;
        }

        public Ingresso(TipoPessoa tipoPessoa, string diaDaSemana)
        {
            this._tipoPessoa = tipoPessoa;
            this._diaDaSemana = diaDaSemana;
        }

        public double CalcularValor()
        {
            if (_tipoPessoa == TipoPessoa.Idoso && _diaDaSemana == "terça")
                return 5.1;
            else if (_tipoPessoa == TipoPessoa.Idoso)
                return 5.4;

            if (_tipoPessoa == TipoPessoa.Estudante)
                return 7.2;

            return 4.95;
        }
    }
}
