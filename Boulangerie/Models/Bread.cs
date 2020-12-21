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
      int withinDealQuantity = breadQuantity - ExcessQuantity(breadQuantity);
      return (withinDealQuantity / 3);
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