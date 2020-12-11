namespace Boulangerie
{
  public class Bread
  {
    public bool BreadDeal(int breadQuantity)
    {
      return breadQuantity % 3 == 0;
    }
  }
}