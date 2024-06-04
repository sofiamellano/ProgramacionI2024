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
        public async Task TestObtenerLibros()
        {
            BooksRepo bookRepo = new BooksRepo();
            var Books = await bookRepo.ObtenerLibrosAsync();
            Assert.That(Books.Count, Is.Not.EqualTo(0));
        }
        [Test]
        public async Task TestAddBook()
        {
            BooksRepo booksRepo = new BooksRepo();
            var book = await booksRepo.AddAsync("LibroTest3", "AutorTest3", "EditorialTest3", "PortadaTes3t", "SinopsisTest3", 100, "GeneroTest3");
            Assert.That(book.nombre, Is.EqualTo("LibroTest3"));
        }
        [Test]  
        public async Task TestDeleteBook()
        {
            BooksRepo booksRepo = new BooksRepo();
            var delete = await booksRepo.RemoveAsync("665a1c3c69e958000003ed2b");
            Assert.That(delete, Is.EqualTo(true));
        }
        [Test]
        public async Task TestGetBook()
        {
            BooksRepo booksRepo = new BooksRepo();
            var get = await booksRepo.GetById("651480d8e97f55390000dbdf");
            Assert.That(get.nombre, Is.EqualTo("Roger Federer: La biografía definitiva"));
        }
        [Test]
        public async Task TestUpdateBook()
        {
            BooksRepo booksRepo = new BooksRepo();
            var update = await booksRepo.UpdateAsync("LibroTest2Actualizado", "autoTest2", "EditorialTest2", "PortadaUrlTest2","sinopsis prueba", 100,  "GeneroURL2", "665a258e69e958000003edaa");
            Assert.That(update.nombre, Is.EqualTo("LibroTest2Actualizado"));
        }
    }
}