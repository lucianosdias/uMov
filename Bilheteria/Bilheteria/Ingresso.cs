
using System.Collections.Generic;
namespace Bilheteria
{
    public class Ingresso
    {
        private TipoPessoa _tipoPessoa;
        private string _diaDaSemana;
        private Dictionary<TipoPessoa, double> _valores = new Dictionary<TipoPessoa, double>
        {
            { TipoPessoa.Criança, 5.50 },
            { TipoPessoa.Estudante, 8 },
            { TipoPessoa.Idoso, 6 }
        };

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
            if (_diaDaSemana == "terça")
            {
                if (_tipoPessoa != TipoPessoa.Estudante)
                    return this.Calcular(_valores[_tipoPessoa], 15);

                return this.Calcular(_valores[_tipoPessoa], 5);
            }
            else if (_diaDaSemana == "quarta" && _tipoPessoa == TipoPessoa.Idoso)
            {
                return 3.6;
            }

            return this.Calcular(_valores[_tipoPessoa], 10);
        }

        private double Calcular(double valor, int desconto)
        {
            return valor - (valor / 100 * desconto);
        }
    }
}
