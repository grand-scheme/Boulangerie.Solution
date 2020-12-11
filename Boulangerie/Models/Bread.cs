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
      // in this test, bread input quantity is 2
      int breadToCalc = BreadFullPrice(breadQuantity) + BreadDeal(breadQuantity); // this should = 0 + 2
      return breadToCalc * 5; // at this point, should return 10
    }
  }
}