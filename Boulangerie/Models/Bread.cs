namespace Boulangerie
{
  public class Bread
  {
    public int BreadOutsideDiscount(int breadQuantity)
    {
      return (breadQuantity % 3);
    }
    public int BreadAtFullPrice(int breadQuantity)
    {
      int twoAtFullPrice = breadQuantity - BreadOutsideDiscount(breadQuantity);
      return (2 * twoAtFullPrice / 3);
    }
    public int BreadFinalCost(int breadQuantity)
    {
      int breadCostAfterDiscount = BreadAtFullPrice(breadQuantity) + BreadOutsideDiscount(breadQuantity);
      return (breadCostAfterDiscount * 5);
    }
  }
}