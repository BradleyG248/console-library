using System;
using System.Collections.Generic;


namespace library.Models
{
  class Library
  {
    public string Location { get; private set; }
    public string Name { get; private set; }
    private List<Book> Books { get; set; }
    private List<Magazine> Magazines { get; set; }
    private List<Literature> Literature { get; set; }

    public Library(string location, string name)
    {
      Location = location;
      Name = name;
      Books = new List<Book>();
      Magazines = new List<Magazine>();
      Literature = new List<Literature>();
    }

    public void printLiterature()
    {
      for (int i = 0; i < Literature.Count; i++)
      {
        Literature current = Literature[i];
        if (!current.CheckedOut)
        {
          if (current is Book)
          {
            Book book = (Book)current;
            Console.WriteLine($"{i + 1}. {book.Title} by {book.Author}, Fiction: {book.Fiction} \n Description: {book.Desc} (Book)");
          }
          if (current is Magazine)
          {
            Magazine magazine = (Magazine)current;
            Console.WriteLine($"{i + 1}. {magazine.Title} by {magazine.Author}, {magazine.Publisher} \n Description: {magazine.Desc} (Magazine)");
          }
        }
      }
    }
    public void printCheckedOut()
    {
      for (int i = 0; i < Literature.Count; i++)
      {
        Literature current = Literature[i];
        if (current.CheckedOut)
        {
          Console.WriteLine($"{i + 1}. {current.Title} by {current.Author}");
        }
      }
    }
    public void AddBook(Book book)
    {
      Books.Add(book);
      Literature.Add(book);
    }
    public void AddBook(IEnumerable<Book> books)
    {
      Books.AddRange(books);
    }
    public void AddMagazine(Magazine magazine)
    {
      Magazines.Add(magazine);
      Literature.Add(magazine);
    }
    public void AddMagazine(IEnumerable<Magazine> magazines)
    {
      Magazines.AddRange(magazines);
    }

    public void CheckOut(int selection)
    {
      selection--;
      if (Literature.Contains(Literature[selection]))
      {
        if (Literature[selection].CheckedOut)
        {
          Console.WriteLine("This book is checked out!");
          return;
        }
        Literature[selection].CheckOut(Literature[selection]);
        Console.WriteLine($"{Literature[selection].Title} checked out!");
      }
      else
      {
        Console.Write("That's not a book!");
      }
    }
    public void Return(int selection)
    {
      selection--;
      if (!Literature[selection].CheckedOut)
      {
        Console.WriteLine("You don't have this book!");
        return;
      }
      if (Literature.Contains(Literature[selection]))
      {
        Literature[selection].Return(Literature[selection]);
        Console.WriteLine($"{Literature[selection].Title} returned!");
      }
      else
      {
        Console.Write("That's not a book!");
      }
    }
  }
}