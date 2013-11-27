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
         * deve retornar valor com 40 de desconto para idosos na quarta feira -> 3.6
         * deve retornar valor com 30 de desconto para crianças na quarta feira -> 3.85
         * deve retornar valor com 50 de desconto para estudantes na quarta feira -> 4

        Quinta-Feira
            - 30% idosos e estudantes
         * deve retornar valor com 30 de desconto para idosos na quinta feira
         * deve retornar valor com 30 de desconto para estudantes na quinta feira
         * deve retornar valor sem desconto para crianças na quinta feira

        Sexta-Feira
            - 11% crianças
         * deve retornar valor com 11 de desconto para crianças na sexta feira
         * deve retornar valor sem desconto para idosos na sexta feira
         * deve retornar valor sem desconto para estudantes na sexta feira

        Domingo/Sábados/Feriados
            - 5% Idosos
         * deve retornar valor com 5 de desconto para idosos no sabado/domingo/feriado
         * deve retornar valor sem desconto para crianças no sabado/domingo/feriado
         * deve retornar valor sem desconto para estudantes no sabado/domingo/feriado

        OBS1.: Todo estudante mediante apresentação da carteirinha de estudante 
            possui para todos os dias da semana, exceto finais de semana, 
            35% de desconto em todos os ingressos;
         * deve retornar valor com 35% de desconto para estudantes com documento de segunda a sexta
         * deve retornar valor sem desconto para estudantes com documento no sabado e domingo

        OBS2.: Descontos não são cumulativos.         
         */

        [TestMethod]
        public void Deve_retornar_valor_com_10_de_desconto_para_crianças_na_segunda_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Criança);

            Assert.AreEqual(4.95, ingresso.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_10_de_desconto_para_idosos_na_segunda_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Idoso);

            Assert.AreEqual(5.4, ingresso.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_10_de_desconto_para_estudantes_na_segunda_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Estudante);

            Assert.AreEqual(7.2, ingresso.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_15_de_desconto_para_idosos_na_terça_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Idoso, "terça");

            Assert.AreEqual(5.1, ingresso.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_15_de_desconto_para_crianças_na_terça_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Criança, "terça");

            Assert.AreEqual(4.675, ingresso.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_5_de_desconto_para_estudantes_na_terça_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Estudante, "terça");

            Assert.AreEqual(7.6, ingresso.CalcularValor());
        }

        [TestMethod]
        public void Deve_retornar_valor_com_40_de_desconto_para_idosos_na_quarta_feira()
        {
            var ingresso = new Ingresso(TipoPessoa.Idoso, "quarta");

            Assert.AreEqual(3.6, ingresso.CalcularValor());
        }
    }
}
