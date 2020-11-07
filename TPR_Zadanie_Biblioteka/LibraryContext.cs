﻿using DL.DataObjects;
using DL.DataObjects.EventsObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DL
{
    public class LibraryContext
    {
        private List<Author> _authors;
        private Dictionary<int, Book> _books;
        private List<CopyOfBook> _copiesOfBooks;
        private List<Employee> _employees;
        private List<Reader> _readers;
        private ObservableCollection<Rent> _rents;
        private ObservableCollection<Return> _returns;

        public LibraryContext()
        {
            _authors = new List<Author>();
            _books = new Dictionary<int, Book>();
            _copiesOfBooks = new List<CopyOfBook>();
            _employees = new List<Employee>();
            _readers = new List<Reader>();
            _rents = new ObservableCollection<Rent>();
            _returns = new ObservableCollection<Return>();
        }

        public List<Author> Authors { get => _authors;}
        public Dictionary<int, Book> Books { get => _books;}
        public List<CopyOfBook> CopiesOfBooks { get => _copiesOfBooks;}
        public List<Employee> Employees { get => _employees;}
        public List<Reader> Readers { get => _readers;}
        public ObservableCollection<Rent> Rents { get => _rents;}
        internal ObservableCollection<Return> Returns { get => _returns; set => _returns = value; }
    }
}
