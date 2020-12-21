namespace Boulangerie.Models
{
  public class Pastry : Prices
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
        (FullPriceQuantity(pastryQuantity) * PastryFullPrice()) 
        +
        (AtDiscountQuantity(pastryQuantity) * PastryDiscountPrice())
      );
    }
  }
}