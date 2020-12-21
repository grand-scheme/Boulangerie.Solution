namespace Boulangerie.Models
{
  public abstract class Prices
  {
    protected int PastryFullPrice()
    {
      return 2;
    }
    protected int PastryDiscountPrice()
    {
      return 1;
    }
    protected int BreadFullPrice()
    {
      return 5;
    }
    protected int BreadDiscountPrice()
    {
      return 0;
    }
  }
}