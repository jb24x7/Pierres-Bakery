namespace PierresBakery.Models
{
  public class Bread
  {
    public int Order { get; set; }
    public Bread(int breadNumber)
    {
      Order = breadNumber;
    }
    public int BreadPrice(int bread)
    {
      int _cost = 5 * bread;
      return (_cost);
    }
  }
}