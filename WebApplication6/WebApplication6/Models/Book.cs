using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Book
    {
        public Book()
        {

        }
        public Book(int id, string title, string author, decimal price, string path, string description,int year)
        {
            Id = id;
            Title = title;
            Author = author;
            Price = price;
            Path = path;
            Description = description;
            Year = year;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
    }
}