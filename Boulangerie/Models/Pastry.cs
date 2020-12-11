namespace Boulangerie
{
  public class Pastry
  {
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
  }
}