using EjercicioDePrueba.Repositories;

namespace TestProjectApp
{
    public class TestBook
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ObtenerLibros()
        {
            BooksRepo bookRepo = new BooksRepo();
            Assert.Pass();
        }
    }
}