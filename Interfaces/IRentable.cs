namespace library.Interfaces
{
  interface IRentable
  {
    bool CheckedOut { get; set; }
    void CheckOut(IRentable obj)
    {
      obj.CheckedOut = true;
    }
    void Return(IRentable obj)
    {
      obj.CheckedOut = false;
    }
  }
}