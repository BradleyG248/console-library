using library.Interfaces;

namespace library.Models
{
  class Book : Literature, IRentable
  {

    public bool Fiction { get; set; }

    public Book(string title, string author, string desc, bool fiction) : base(title, author, desc)
    {
      CheckedOut = false;
      Fiction = fiction;
    }
  }
}