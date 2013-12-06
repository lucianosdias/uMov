using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilheteria
{
    public class CalculadoraDeIngresso
    {
        private Ingresso ingresso;

        public CalculadoraDeIngresso(Ingresso ingresso)
        {
            this.ingresso = ingresso;
        }

        public double CalcularValor()
        {
            switch (ingresso.DiaDaSemana)
            {
                case DiaDaSemana.Segunda:
                    return this.Calcular(ingresso.ValorUnitario, 10);

                case DiaDaSemana.Terça:
                    if (ingresso.TipoPessoa != TipoPessoa.Estudante)
                        return this.Calcular(ingresso.ValorUnitario, 15);

                    return this.Calcular(ingresso.ValorUnitario, 5);
                case DiaDaSemana.Quarta:
                    if (ingresso.TipoPessoa == TipoPessoa.Criança)
                        return this.Calcular(ingresso.ValorUnitario, 30);

                    if (ingresso.TipoPessoa == TipoPessoa.Estudante)
                        return this.Calcular(ingresso.ValorUnitario, 50);

                    return this.Calcular(ingresso.ValorUnitario, 40);
                case DiaDaSemana.Quinta:
                    if (ingresso.TipoPessoa != TipoPessoa.Criança)
                        return this.Calcular(ingresso.ValorUnitario, 30);

                    break;
                case DiaDaSemana.Sexta:
                    if (ingresso.TipoPessoa == TipoPessoa.Criança)
                        return this.Calcular(ingresso.ValorUnitario, 11);
                    break;
            }

            return this.Calcular(ingresso.ValorUnitario, 0);
        }

        private double Calcular(double valor, int desconto)
        {
            return valor - (valor / 100 * desconto);
        }
    }
}
