namespace Boulangerie
{
  public class Pastry
  {
    public int PastryOutsideDiscount(int pastryQuantity)
    {
      return pastryQuantity % 3;
    }
    public int PastryTwoAtFullPrice(int pastryQuantity)
    {
      int twoAtFullPrice = pastryQuantity - PastryOutsideDiscount(pastryQuantity);
      return (2 * twoAtFullPrice / 3);
    }
    public int PastryOneAtHalfPrice(int pastryQuantity)
    {
      int oneAtHalfPrice = pastryQuantity - PastryOutsideDiscount(pastryQuantity);
      return (oneAtHalfPrice / 3);
    }
    public int AllFullPricePastries(int pastryQuantity)
    { 
      return 
      (
        PastryTwoAtFullPrice(pastryQuantity) 
        + 
        PastryOutsideDiscount(pastryQuantity)
      );
    }
    public int PastryFinalCost(int pastryQuantity)
    {
      int fullPrice = 2;
      int discountPrice = 1;
      return 
      (
        (AllFullPricePastries(pastryQuantity) * fullPrice)
        + 
        (PastryOneAtHalfPrice(pastryQuantity) * discountPrice)
      );
    }
  }
}