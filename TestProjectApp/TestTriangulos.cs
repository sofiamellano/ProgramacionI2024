using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectApp
{
    public class TestTriangulos
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEquilatero()
        {
            string result = ProgramEjercicios.Triangulo(1, 1, 1);
            Assert.That(result, Is.EqualTo("Equilatero"));
        }
        [Test]
        public void TestIsosceles()
        {
            string result = ProgramEjercicios.Triangulo(1, 1, 2);
            Assert.That(result, Is.EqualTo("Equilatero"));
        }
        [Test]
        public void TestEscaleno()
        {
            string result = ProgramEjercicios.Triangulo(1, 2, 3);
            Assert.That(result, Is.EqualTo("Equilatero"));
        }
    }
}
