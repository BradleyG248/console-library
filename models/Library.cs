using System;
using System.Collections.Generic;
using library.Interfaces;

namespace library.Models
{
  class Library
  {
    public string Location { get; private set; }
    public string Name { get; private set; }
    private List<Book> Books { get; set; }
    private List<Magazine> Magazines { get; set; }
    private IRentable Mngr;
    public Library(string location, string name)
    {
      Location = location;
      Name = name;
      Books = new List<Book>();
    }

    public void printBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        Book current = Books[i];
        if (!current.CheckedOut)
        {
          Console.WriteLine($"{i + 1}. {current.Title} by {current.Author} \n Description: {current.Desc}");
        }
      }
    }
    public void printCheckedOut()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        Book current = Books[i];
        if (current.CheckedOut)
        {
          Console.WriteLine($"{i + 1}. {current.Title} by {current.Author}");
        }
      }
    }
    public void AddBook(Book book)
    {
      Books.Add(book);
    }
    public void AddBook(IEnumerable<Book> books)
    {
      Books.AddRange(books);
    }
    public void AddMagazine(Magazine magazine)
    {
      Magazines.Add(magazine);
    }
    public void AddMagazine(IEnumerable<Magazine> magazines)
    {
      Magazines.AddRange(magazines);
    }

    public void CheckOut(int selection)
    {
      selection--;
      if (Books.Contains(Books[selection]))
      {
        if (Books[selection].CheckedOut)
        {
          Console.WriteLine("This book is checked out!");
          return;
        }
        Mngr.CheckOut(Books[selection]);
        Console.WriteLine($"{Books[selection].Title} checked out!");
      }
      else
      {
        Console.Write("That's not a book!");
      }
    }
    public void Return(int selection)
    {
      selection--;
      if (!Books[selection].CheckedOut)
      {
        Console.WriteLine("You don't have this book!");
        return;
      }
      if (Books.Contains(Books[selection]))
      {
        Mngr.Return(Books[selection]);
        Console.WriteLine($"{Books[selection].Title} returned!");
      }
      else
      {
        Console.Write("That's not a book!");
      }
    }
  }
}