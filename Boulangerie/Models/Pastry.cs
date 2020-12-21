namespace Boulangerie.Models
{
  public class Pastry : Prices
  {
    public override int FullPrice()
      {
        return 2;
      }
    public override int DiscountPrice()
      {
        return 1;
      }
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