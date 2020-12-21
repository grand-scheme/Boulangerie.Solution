namespace Boulangerie.Models
{
  public abstract class Prices
  {
    protected int PastryFullPrice() { return 2; }
    protected int PastryDiscountPrice() { return 1; }
    protected int BreadFullPrice() { return 5; }
    protected int BreadDiscountPrice() { return 0; }
  }

  public class Buy2Get1 : Prices
  {
    private int _soldAtDiscount(int quantity)
    {
      int outsideDiscount = (quantity % 3);
      int insideDiscount = (quantity - outsideDiscount);
      return (insideDiscount / 3);
    }

    private int _soldAtFullPrice(int quantity)
    {
      return (quantity - _soldAtDiscount(quantity));
    }

    public int FinalCost(int quantity, string productType)
    {
      if (productType == "BREAD")
      {
        return
        (
          (_soldAtFullPrice(quantity) * BreadFullPrice())
          +
          (_soldAtDiscount(quantity) * BreadDiscountPrice())
        );
      }
      else // if (type == "PASTRY") 
      {
        return 
        (
          (_soldAtFullPrice(quantity) * PastryFullPrice()) 
          +
          (_soldAtDiscount(quantity) * PastryDiscountPrice())
        );
      }
    }
  }
}