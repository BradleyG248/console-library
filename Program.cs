﻿using System;
using library.Models;

namespace library
{
  class Program
  {
    static void Main(string[] args)
    {
      bool running = true;
      Book myBook = new Book("Shadows of Death", "Bradley Graham", "so gud", true);
      Library myLibrary = new Library("123 Place", "Bradley's Library");
      Console.WriteLine($"You're at {myLibrary.Name}");
      myLibrary.AddBook(new Book("asdf", "asdf", "asdf", true));
      myLibrary.AddBook(new Book("Jurassic Park", "Michael Crichton", "Dinos!", true));
      myLibrary.AddBook(new Book("fads", "fasd", "fasdf", false));
      myLibrary.AddBook(new Book("qwerdf", "qwerf", "fqwe", false));
      myLibrary.AddBook(new Book("arewqf", "aewqf", "qwer", true));
      myLibrary.AddBook(new Book("weg", "qwer", "aasdfjlk", false));
      myLibrary.AddMagazine(new Magazine("The something", "Allen", "Magazine Co.", "Explore something"));
      myLibrary.AddBook(myBook);
      while (running)
      {
        int selection;
        Console.WriteLine("Would you like to check out or return a book?");
        char choice = Console.ReadLine()[0];
        if (choice == 'c')
        {
          myLibrary.printLiterature();
          if (Int32.TryParse(Console.ReadLine(), out selection))
          {
            myLibrary.CheckOut(selection);
          }
        }
        else
        {
          myLibrary.printCheckedOut();
          if (Int32.TryParse(Console.ReadLine(), out selection))
          {
            myLibrary.Return(selection);
          }
        }
        Console.WriteLine($"Would you like to leave {myLibrary.Name}?");
        choice = Console.ReadLine()[0];
        if (choice == 'y')
        {
          running = false;
        }
      }
    }
  }
}