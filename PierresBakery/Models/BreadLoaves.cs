namespace PierresBakery.Models
{
  public class Bread
  {
    public int Order { get; set; }
    public Bread(int breadNumber)
    {
      Order = breadNumber;
    }
    public int BreadPrice()
    {
      int _cost = 5 * Order;
      return (_cost);
    }
  }
}