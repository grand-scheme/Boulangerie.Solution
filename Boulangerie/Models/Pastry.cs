namespace Boulangerie.Models
{
  public abstract class PastryPrices
  {
    public int FullPrice()
    {
      return 2;
    }
    public int DiscountPrice()
    {
      return 1;
    }
  }
  public class Pastry : PastryPrices
  {
    public int ExcessQuantity(int pastryQuantity)
    {
      return pastryQuantity % 3;
    }
    public int AtDiscountQuantity(int pastryQuantity)
    {
      int WithinDealQuantity = pastryQuantity - ExcessQuantity(pastryQuantity);
      return (WithinDealQuantity / 3);
    }
    public int FullPriceQuantity(int pastryQuantity)
    {
      return pastryQuantity - AtDiscountQuantity(pastryQuantity);
    }
    public int PastryFinalCost(int pastryQuantity)
    {
      return 
      (
        (FullPriceQuantity(pastryQuantity) * FullPrice()) 
        +
        (AtDiscountQuantity(pastryQuantity) * DiscountPrice())
      );
    }
  }
}