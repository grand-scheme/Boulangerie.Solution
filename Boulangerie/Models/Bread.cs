namespace Boulangerie
{
  public abstract class BreadPrices
  {
    public int FullPrice()
    {
      return 5;
    }
    public int DiscountPrice()
    {
      return 0;
    }
  }
  public class Bread : BreadPrices
  {
    public int ExcessQuantity(int breadQuantity)
    {
      return (breadQuantity % 3);
    }
    public int AtDiscountQuantity(int breadQuantity)
    {
      int WithinDealQuantity = breadQuantity - ExcessQuantity(breadQuantity);
      return (WithinDealQuantity / 3);
    }

    public int FullPriceQuantity(int breadQuantity)
    {
      return breadQuantity - AtDiscountQuantity(breadQuantity);
    }
    public int BreadFinalCost(int breadQuantity)
    {
      return 
      (
        (FullPriceQuantity(breadQuantity) * FullPrice()) 
        +
        (AtDiscountQuantity(breadQuantity) * DiscountPrice())
      );  
    }
  }
}