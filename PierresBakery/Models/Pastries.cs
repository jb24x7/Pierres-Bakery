namespace PierresBakery.Models
{
  public class Pastries
  {
    public int Order { get; set; }
    public Pastries(int pastriesNumber)
    {
      Order = pastriesNumber;
    }
    public int PastriesPrice()
    {
      int cost = 2 * Order;
      int finalCost = cost - (2 * ((Order - (Order % 4)) / 4));
      return (finalCost);
    }
  }
}