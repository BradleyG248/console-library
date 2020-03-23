using library.Interfaces;

namespace library.Models
{
  class Literature : IRentable
  {
    public string Title { get; private set; }
    public string Desc { get; private set; }
    public string Author { get; private set; }
    public bool CheckedOut { get; set; }

    public Literature(string title, string author, string desc)
    {
      Title = title;
      Author = author;
      Desc = desc;
      CheckedOut = false;
    }
    public void CheckOut(Literature obj)
    {
      obj.CheckedOut = true;
    }
    public void Return(Literature obj)
    {
      obj.CheckedOut = false;
    }
  }
}