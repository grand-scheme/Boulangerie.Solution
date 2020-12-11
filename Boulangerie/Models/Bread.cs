namespace Boulangerie
{
  public class Bread
  {
    public int BreadDeal(int breadQuantity)
    {
      int breadWithoutDiscount = breadQuantity % 3;
      return breadWithoutDiscount;
    }
    public int BreadFullPrice(int breadQuantity)
    {
      int breadWithDiscount = breadQuantity - BreadDeal(breadQuantity);
      breadWithDiscount = (2 * breadWithDiscount / 3);
      return breadWithDiscount;
    }
    public int BreadFinalCost(int breadQuantity)
    {
      int breadToCalc = BreadFullPrice(breadQuantity) + BreadDeal(breadQuantity);
      return breadToCalc * 5;
    }
  }
}