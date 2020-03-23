using library.Interfaces;

namespace library.Models
{
  class Book : IRentable
  {
    public string Title { get; private set; }
    public string Desc { get; private set; }
    public string Author { get; private set; }
    public bool CheckedOut { get; set; }

    public Book(string title, string author, string desc)
    {
      Title = title;
      Author = author;
      Desc = desc;
      CheckedOut = false;
    }
  }
}