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
    int SoldAtDiscount(int quantity)
    {
      int outsideDiscount = (quantity % 3);
      int insideDiscount = (quantity - outsideDiscount);
      return (insideDiscount / 3);
    }

    int SoldAtFullPrice(int quantity)
    {
      return (quantity - SoldAtDiscount(quantity));
    }

    public int FinalCost(int quantity, string productType)
    {
      if (productType == "BREAD")
      {
        return
        (
          (SoldAtFullPrice(quantity) * BreadFullPrice())
          +
          (SoldAtDiscount(quantity) * BreadDiscountPrice())
        );
      }
      else // if (type == "PASTRY") 
      {
        return 
        (
          (SoldAtFullPrice(quantity) * PastryFullPrice()) 
          +
          (SoldAtDiscount(quantity) * PastryDiscountPrice())
        );
      }
    }
  }
}