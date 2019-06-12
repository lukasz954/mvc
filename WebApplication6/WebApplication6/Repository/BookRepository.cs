using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;
using WebApplication6.TestData;

namespace WebApplication6.Repository
{
    public class BookRepository: IRepository<Book>
    {
        private BookData _bookData;
        public BookRepository()
        {
            _bookData = new BookData();
        }
       
        public List<Book> EntitiesList { get => _bookData.Books().ToList(); set => _bookData.Books(); }

        public void Add(Book book) => EntitiesList.Add(book);

        public void Delete(Book book) => EntitiesList.Remove(book);

        public IEnumerable<Book> Get() => EntitiesList;

        public Book GetById(int id) => EntitiesList.Single(x => x.Id == id);

        public void Update(Book book)
        {
            var update = EntitiesList.Single(c => c.Id == book.Id);
            update.Id = book.Id;
            update.Path = book.Path;
            update.Price = book.Price;
            update.Title = book.Title;
            update.Year = book.Year;
            update.Author = book.Author;
            update.Description = book.Description;
        }
    }
}