﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Создайте приложение «Список книг для прочтения». Приложение
должно содержать класс списка книг и позволять добавлять книги в список,
удалять книги из списка, проверять есть ли книга в списке, и т. д. Реализуйте
интерфейс IEnumerable и ICloneable для класса списка книг.
 */
namespace Program
{
    public class ListBook : IEnumerable, ICloneable
    {
        private List<string> _books;

        public ListBook()
        {
            _books = new List<string>();
        }

        public ListBook(string[] books)
        {
            _books.AddRange(books);
        }

        public ListBook(List<string> books)
        {
            _books = books;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _books.GetEnumerator();
        }

        object ICloneable.Clone()
        {
            return this;
        }

        public void Add(string item)
        {
            _books.Add(item);
        }

        public void Delete(int index)
        {
            _books.RemoveAt(index);
        }

        public void ShowBooks()
        {
            for (int i = 0; i < _books.Count; i++)
                Console.WriteLine(i + ") книга: " + _books[i]);
        }

        public bool Find(string item)
        {
            foreach (string book in _books)
                if (item == book) return true;

            return false;
        }
    }
}
