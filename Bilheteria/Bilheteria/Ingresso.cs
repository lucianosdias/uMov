
using System.Collections.Generic;
namespace Bilheteria
{
    public class Ingresso
    {
        private TipoPessoa _tipoPessoa;
        private DiaDaSemana _diaDaSemana;
        private Dictionary<TipoPessoa, double> _valores = new Dictionary<TipoPessoa, double>
        {
            { TipoPessoa.Criança, 5.50 },
            { TipoPessoa.Estudante, 8 },
            { TipoPessoa.Idoso, 6 }
        };

        public Ingresso(TipoPessoa tipoPessoa, DiaDaSemana diaDaSemana)
        {
            this._tipoPessoa = tipoPessoa;
            this._diaDaSemana = diaDaSemana;
        }

        public double CalcularValor()
        {
            if (_diaDaSemana == DiaDaSemana.Terça)
            {
                if (_tipoPessoa != TipoPessoa.Estudante)
                    return this.Calcular(_valores[_tipoPessoa], 15);

                return this.Calcular(_valores[_tipoPessoa], 5);
            }
            else if (_diaDaSemana == DiaDaSemana.Quarta && _tipoPessoa == TipoPessoa.Idoso)
            {
                return this.Calcular(_valores[_tipoPessoa], 40);
            }

            return this.Calcular(_valores[_tipoPessoa], 10);
        }

        private double Calcular(double valor, int desconto)
        {
            return valor - (valor / 100 * desconto);
        }
    }
}
