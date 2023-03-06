namespace PierresBakery.Models
{
  public class Bread
  {
    public int Order { get; set; }
    private static int _cost = 5;
    public Bread(int breadNumber)
    {
      Order = breadNumber;
    }
    public int BreadPrice()
    {
      return (_cost);
    }
  }
}