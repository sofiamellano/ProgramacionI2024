using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectApp
{
    public class TestFechaValida
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test31Abril()
        {
            bool result = ProgramEjercicios.ControlFechaValida(31, 04, 2023);
            Assert.IsFalse(result);
        }
        [Test]
        public void Test31Junio()
        {
            bool result = ProgramEjercicios.ControlFechaValida(31, 6, 2023);
            Assert.IsFalse(result);
        }
        [Test]
        public void Test30Febrero2024()
        {
            bool result = ProgramEjercicios.ControlFechaValida(30, 2, 2024);
            Assert.IsFalse(result);
        }
    }
}
