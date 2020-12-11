namespace Boulangerie
{
  public class Bread
  {
    public int BreadDeal(int breadQuantity)
    {
      int breadWithoutDiscount = breadQuantity % 3;
      return breadWithoutDiscount;
    }
  }
}