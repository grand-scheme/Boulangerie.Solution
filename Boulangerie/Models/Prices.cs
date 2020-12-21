namespace Boulangerie.Models
{
  public abstract class Prices
  {
    public int PastryFullPrice()
    {
      return 2;
    }
    public int PastryDiscountPrice()
    {
      return 1;
    }
    public int BreadFullPrice()
    {
      return 5;
    }
    public int BreadDiscountPrice()
    {
      return 0;
    }
  }
}