namespace library.Interfaces
{
  interface IRentable
  {
    bool CheckedOut { get; set; }
    void CheckOut()
    {
    }
    void Return()
    {
    }
  }
}