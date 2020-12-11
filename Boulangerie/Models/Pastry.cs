namespace Boulangerie
{
  public class Pastry
  {
    // convert 'public' classes used only for calculations to private after testing is done with.
    // then... refactor, baby.
    public int PastryDeal(int pastryQuantity)
    {
      return pastryQuantity % 3;
    }
    public int PastryTwoAtFullPrice(int pastryQuantity)
    {
      int twoPastriesAtPrice = pastryQuantity - PastryDeal(pastryQuantity);
      return (2 * twoPastriesAtPrice / 3);
    }
    public int PastryOneAtHalfPrice(int pastryQuantity)
    {
      int onePastryAtPrice = pastryQuantity - PastryDeal(pastryQuantity);
      return (onePastryAtPrice / 3);
    }
    public int AllFullPricePastries(int pastryQuantity)
    { 
      return 
      (
        PastryTwoAtFullPrice(pastryQuantity) 
        + 
        PastryDeal(pastryQuantity)
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