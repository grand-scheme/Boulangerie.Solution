namespace Boulangerie
{
  public class Bread
  {
    public bool BreadDeal(int breadQuantity)
    {
      int breadWithoutDiscount = breadQuantity % 3;
      return breadWithoutDiscount == 0;
    }
  }
}