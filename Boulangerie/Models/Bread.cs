namespace Boulangerie
{
  public class Bread
  {
    public int BreadDeal(int breadQuantity)
    {
      int breadWithoutDiscount = breadQuantity % 3;
      return breadWithoutDiscount;
      // this is the bread where no discount applies. will be added to calculation prior to formulating price.
    }
    public int BreadFullPrice(int breadQuantity)
    {
      int breadWithDiscount = breadQuantity - BreadDeal(breadQuantity);
      breadWithDiscount = (2 * breadWithDiscount / 3);
      return breadWithDiscount;
    }
    public int BreadFinalCost(int breadQuantity)
    {
      // in this test, bread input quantity is 30
      int breadToCalc = BreadFullPrice(breadQuantity); // should return 2/3s bread input, so 20
      return breadToCalc; // at this point, should still return 20
    }
  }
}