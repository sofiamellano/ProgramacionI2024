using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectApp
{
    public class TestDiasDeVida
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1año1mes1dia() 
        { 
           // int diasDeVida = ProgramEjercicios.CalcualarDiasDeVida(1, 1, 1);
           // Assert.That(diasDeVida, Is.EqualTo(396));
        }
        [Test]
        public void Test10año10mes1dia()
        {
           // int diasDeVida = ProgramEjercicios.CalcualarDiasDeVida(10, 10, 1);
          //  Assert.That(diasDeVida, Is.EqualTo(3951));
        }
    }
}
