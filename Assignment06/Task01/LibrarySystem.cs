using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibrarySystem
{
    public class Book
    {
        private string? _title;
        private string? _author;
        private DateOnly? _year;
        private string? _genre;

        public Book(string? title, string? author, DateOnly? year, string? genre)
        {
            _title = title;
            _author = author;
            _year = year;
            _genre = genre;
        }

        public string? Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string? Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string? Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public DateOnly? Year
        {
            get { return _year; }
            set { _year = value; }
        }
    }

    public class Library
    {
        private Book[]? _bookList;

        public Library()
        {
            _bookList = new Book[0];
        }

        public Book this[int i]
        {
            get
            {
                return _bookList[i];
            }
            set
            {
                if(i > _bookList.Length)
                {
                    Console.WriteLine("Given index is out of bounds, choose between; 0 - " + _bookList.Length);
                }
                else
                {
                    Array.Resize(ref _bookList, _bookList.Length + 1);
                    _bookList[i] = value;
                }
                
            }
        }
        
        public void SetBookList(Book[] bookList)
        {
            _bookList = bookList;
        }


        public int Count
        {
            get { return _bookList.Length; }
        }

        public void AddBook(Book book)
        {
            Book search = _bookList.FirstOrDefault(var => var == book);

            if (search == null)
            {
                Array.Resize(ref _bookList, _bookList.Length + 1);
                _bookList[_bookList.Length - 1] = book;
            }
            else
            {
                Console.WriteLine("Given book is already this library");
            }
        }

        public void RemoveBook(Book book)
        {
            Book search = _bookList.FirstOrDefault(var => var == book);

            if (search == null)
            {
                Console.WriteLine("Given book isn't in this library");
            }
            else
            {
                _bookList = _bookList.Where(var => var != book).ToArray();
            }
            
        }

        public Book FindBook(string name)
        {
            Book search = _bookList.FirstOrDefault(var => var.Title == name);

            if(search == null)
            {
                Console.WriteLine("Given book isn't in this library");
                return search;
            }
            else
            {
                return search;
            }
            
        }
    }
}
