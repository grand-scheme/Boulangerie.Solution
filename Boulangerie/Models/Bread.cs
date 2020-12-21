namespace Boulangerie.Models
{
  public class Bread : Prices
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
        (FullPriceQuantity(breadQuantity) * BreadFullPrice())
        +
        (AtDiscountQuantity(breadQuantity) * BreadDiscountPrice())
      );
    }
  }
}