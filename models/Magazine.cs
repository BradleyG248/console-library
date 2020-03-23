using library.Interfaces;

namespace library.Models
{
  class Magazine : Literature, IRentable
  {
    public string Publisher { get; private set; }

    public Magazine(string title, string author, string publisher, string desc) : base(title, author, desc)
    {
      Publisher = publisher;
      CheckedOut = false;
    }
  }
}