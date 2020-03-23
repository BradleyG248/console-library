using library.Interfaces;

namespace library.Models
{
  class Magazine : IRentable
  {
    public string Title { get; private set; }
    public string Publisher { get; private set; }
    public string Author { get; private set; }
    public bool CheckedOut { get; set; }

    public Magazine(string title, string author, string publisher)
    {
      Title = title;
      Author = author;
      Publisher = publisher;
      CheckedOut = false;
    }
  }
}