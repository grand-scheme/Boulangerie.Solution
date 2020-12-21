namespace Boulangerie.Models
{
  public abstract class Discount : Prices
  {
    int ExcessQuantity(int quantity)
    {
      return (quantity % 3);
    }

    int AtDiscountQuantity(int quantity)
    {
      int WithinDealQuantity = quantity - ExcessQuantity(quantity);
      return (WithinDealQuantity / 3);
    }

    int FullPriceQuantity(int quantity)
    {
      return quantity - AtDiscountQuantity(quantity);
    }

    public int FinalCost(int quantity, string type)
    {
      if (type == "bread") 
      {
        return 
        (
          (FullPriceQuantity(quantity) * BreadFullPrice())
          +
          (AtDiscountQuantity(quantity) * BreadDiscountPrice())
        );
      }

      if (type == "pastry") 
      {
        return 
        (
          (FullPriceQuantity(quantity) * PastryFullPrice()) 
          +
          (AtDiscountQuantity(quantity) * PastryDiscountPrice())
        );
      }

      else
      {
        return 999999;
      }
    }
  }
}