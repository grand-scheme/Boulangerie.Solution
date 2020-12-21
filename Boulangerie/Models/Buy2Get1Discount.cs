namespace Boulangerie.Models
{
  public abstract class Discount : Prices
  {
    int SoldAtDiscount(int quantity)
    {
      int outsideDiscount = (quantity % 3)
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