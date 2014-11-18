using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hanoi;
using NUnit.Framework;
namespace Hanoi.Tests
{
    [TestFixture]
    public class MovimentoTests
    {
        Movimento movimento;

        [TestFixtureSetUp]
        public void Movimentar()
        {
            movimento = new Movimento();
        }

        //Eliminamos tres testes para atender todos em um único teste. Verificamos se:
        // o primeiro disco do pino foi removido;
        //se ele foi movido para pino de destino;
        // e se o disco foi removido do pino de origem.
        [Test]
        public void DeveMovimentarOPrimeiroDiscoDoPinoParaOutroPino()
        {
            movimento.Mover(movimento.Pino1, movimento.Pino3);
            Assert.IsFalse(movimento.Pino1.Contains(1));
            Assert.IsTrue(movimento.Pino3.Contains(1));
            Assert.AreEqual(2, movimento.Pino1.Count);
        }

        [Test]
        public void DeveMovimentarSegundoDiscoDaPilha()
        {
            movimento.Mover(movimento.Pino1, movimento.Pino3);
            movimento.Mover(movimento.Pino1, movimento.Pino2);
            Assert.IsFalse(movimento.Pino1.Contains(2));
        }

        [Test]
        public void NenhumDiscoDeveFicarSobreUmDiscoMenor()
        {
            movimento.Mover(movimento.Pino1, movimento.Pino3);
            movimento.Mover(movimento.Pino1, movimento.Pino2);
            Assert.IsTrue(movimento.ComparaDiscos(movimento.Pino3, movimento.Pino2));
        }

        //O método Mover vai ser executado dependendo da resposta do método CompararDiscos

        //Para finalizar precisa executar todos os movimentos e contar quantos movimentos foram executados
    }
}
