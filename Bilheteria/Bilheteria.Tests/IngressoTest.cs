using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bilheteria.Tests
{
    [TestClass]
    public class IngressoTest
    {
        /*
        Calcule os seguintes descontos para as entradas dado o preço dos ingressos:

        - Crianças: R$ 5.50
        - Estudantes: R$ 8.00
        - Idosos: R$ 6.00

        Segunda-Feira: 
            - 10% para todos(crianças, idosos, estudantes)
         * deve retornar valor com 10 de desconto para crianças na segunda feira -> 4.95 (OK)
         * deve retornar valor com 10 de desconto para idosos na segunda feira -> 5.4 (OK)
         * deve retornar valor com 10 de desconto para estudantes na segunda feira -> 7.2 (OK)

        Terça-Feira:
            - 15% idosos e crianças;
            - 5% estudantes;
         * deve retornar valor com 15 de desconto para idosos na terça feira -> 5.1 (OK)
         * deve retornar valor com 15 de desconto para crianças na terça feira -> 4.675 (OK)
         * deve retornar valor com 5 de desconto para estudantes na terça feira -> 7.6 (OK)

        Quarta-Feira:
            - 40% idosos
            - 30% crianças
            - 50% estudantes
         * deve retornar valor com 40 de desconto para idosos na quarta feira -> 3.6 (OK)
         * deve retornar valor com 30 de desconto para crianças na quarta feira -> 3.85 (OK)
         * deve retornar valor com 50 de desconto para estudantes na quarta feira -> 4 (OK)

        Quinta-Feira
            - 30% idosos e estudantes
         * deve retornar valor com 30 de desconto para idosos na quinta feira -> 4.2 (OK)
         * deve retornar valor com 30 de desconto para estudantes na quinta feira -> 5.6 (OK)
         * deve retornar valor sem desconto para crianças na quinta feira -> 5.50 (OK)

        Sexta-Feira
            - 11% crianças
         * deve retornar valor com 11 de desconto para crianças na sexta feira (OK)
         * deve retornar valor sem desconto para idosos na sexta feira (OK)
         * deve retornar valor sem desconto para estudantes na sexta feira (OK)

        Domingo/Sábados/Feriados
            - 5% Idosos
         * deve retornar valor com 5 de desconto para idosos no sabado/domingo/feriado (OK)
         * deve retornar valor sem desconto para crianças no sabado/domingo/feriado (OK)
         * deve retornar valor sem desconto para estudantes no sabado/domingo/feriado (OK)

        OBS1.: Todo estudante mediante apresentação da carteirinha de estudante 
            possui para todos os dias da semana, exceto finais de semana, 
            35% de desconto em todos os ingressos;
         * deve retornar valor com 35% de desconto para estudantes com documento de segunda a sexta
         * deve retornar valor sem desconto para estudantes com documento no sabado e domingo

        OBS2.: Descontos não são cumulativos.         
         
        Acho que mudaria a classe ingresso para que o calculo do valor seja interno e quem consome apenas use propriedade Valor.
        Terminaria os testes.
        Buscaria também uma forma de organizar os valores descontos por pessoa e dia para não ter que passar "na mão" cada vez que for calcular.
         */

        [TestMethod]
        public void Deve_retornar_valor_com_10_de_desconto_para_crianças_na_segunda_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Criança, DiaDaSemana.Segunda);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(4.95, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_10_de_desconto_para_idosos_na_segunda_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Idoso, DiaDaSemana.Segunda);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(5.4, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_10_de_desconto_para_estudantes_na_segunda_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Estudante, DiaDaSemana.Segunda);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(7.2, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_15_de_desconto_para_idosos_na_terça_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Idoso, DiaDaSemana.Terça);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(5.1, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_15_de_desconto_para_crianças_na_terça_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Criança, DiaDaSemana.Terça);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(4.675, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_5_de_desconto_para_estudantes_na_terça_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Estudante, DiaDaSemana.Terça);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(7.6, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_40_de_desconto_para_idosos_na_quarta_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Idoso, DiaDaSemana.Quarta);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(3.6, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_30_de_desconto_para_crianças_na_quarta_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Criança, DiaDaSemana.Quarta);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(3.85, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_50_de_desconto_para_estudantes_na_quarta_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Estudante, DiaDaSemana.Quarta);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(4, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_30_de_desconto_para_idosos_na_quinta_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Idoso, DiaDaSemana.Quinta);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(4.2, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_30_de_desconto_para_estudantes_na_quinta_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Estudante, DiaDaSemana.Quinta);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(5.6, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_sem_desconto_para_crianças_na_quinta_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Criança, DiaDaSemana.Quinta);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(5.5, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_11_de_desconto_para_crianças_na_sexta_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Criança, DiaDaSemana.Sexta);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(4.895, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_sem_desconto_para_idosos_na_sexta_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Idoso, DiaDaSemana.Sexta);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(6, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_sem_desconto_para_estudantes_na_sexta_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Estudante, DiaDaSemana.Sexta);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(8, calculadora.CalcularValor());
        }


        [TestMethod]
        public void Deve_retornar_valor_com_5_de_desconto_para_idosos_final_de_semana_e_feriados()
        {
            var ingresso = new Ingresso(TipoPessoa.Idoso, DiaDaSemana.Feriado);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(5.7, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_sem_desconto_para_estudantes_final_de_semana_e_feriados()
        {
            var ingresso = new Ingresso(TipoPessoa.Estudante, DiaDaSemana.Sabado);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(8, calculadora.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_sem_desconto_para_crianças_final_de_semana_e_feriados()
        {
            var ingresso = new Ingresso(TipoPessoa.Criança, DiaDaSemana.Domingo);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(5.5, calculadora.CalcularValor());
        }
        
        [TestMethod]
        public void Deve_retornar_valor_com_35_de_desconto_para_estudantes_com_documento_de_segunda_a_sexta()
        {
            var ingresso = new Ingresso(TipoPessoa.Estudante, DiaDaSemana.Sexta, true);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(5.2, calculadora.CalcularValor());
        }
        [TestMethod]
        public void Deve_retornar_valor_sem_desconto_para_estudantes_com_documento_final_de_semana_e_feriados()
        {
            var ingresso = new Ingresso(TipoPessoa.Estudante, DiaDaSemana.Sabado, true);

            var calculadora = new CalculadoraDeIngresso(ingresso);

            Assert.AreEqual(8, calculadora.CalcularValor());
        }

    }
}
