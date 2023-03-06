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
      int cost = 5 * Order;
      int finalCost = cost - (5 * ((Order - (Order % 3)) / 3));
      return (finalCost);
    }
  }
}