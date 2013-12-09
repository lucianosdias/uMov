
using System.Collections.Generic;
namespace Bilheteria
{
    public class Ingresso
    {
        private Dictionary<TipoPessoa, double> _valores = new Dictionary<TipoPessoa, double>
        {
            { TipoPessoa.Criança, 5.50 },
            { TipoPessoa.Estudante, 8 },
            { TipoPessoa.Idoso, 6 }
        };

        private TipoPessoa _tipoPessoa;
        public TipoPessoa TipoPessoa
        {
            get { return _tipoPessoa; }
            set { _tipoPessoa = value; }
        }
        private DiaDaSemana _diaDaSemana;
        public DiaDaSemana DiaDaSemana
        {
            get { return _diaDaSemana; }
            set { _diaDaSemana = value; }
        }
        public double ValorUnitario
        {
            get { return _valores[this._tipoPessoa]; }
        }

        private bool _apresentouDocumento;
        public bool ApresentouDocumento
        {
            get { return _apresentouDocumento; }
            set { _apresentouDocumento = value; }
        }

        public Ingresso(TipoPessoa tipoPessoa, DiaDaSemana diaDaSemana, bool apresentouDocumento = false)
        {
            this._tipoPessoa = tipoPessoa;
            this._diaDaSemana = diaDaSemana;
            this._apresentouDocumento = apresentouDocumento;
        }
    }
}
