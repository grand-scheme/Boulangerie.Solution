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

  public class Buy2Get1 : Prices
  {
    // getters for testing only
    public int GetSoldAtDiscount(int quantity)
    {
      return SoldAtDiscount(quantity);
    }
    public int GetSoldAtFullPrice(int quantity)
    {
      return SoldAtFullPrice(quantity);
    }

    int SoldAtDiscount(int quantity)
    {
      int outsideDiscount = (quantity % 3);
      int insideDiscount = quantity - outsideDiscount;
      return (insideDiscount / 3);
    }

    int SoldAtFullPrice(int quantity)
    {
      return quantity - SoldAtDiscount(quantity);
    }

    public int FinalCost(int quantity, string type)
    {
      if (type == "bread")
      {
        return
        (
          (SoldAtFullPrice(quantity) * BreadFullPrice())
          +
          (SoldAtDiscount(quantity) * BreadDiscountPrice())
        );
      }
      else // if (type == "pastry") 
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