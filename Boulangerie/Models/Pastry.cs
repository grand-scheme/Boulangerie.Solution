namespace Boulangerie
{
  public class Pastry
  {
    public int PastryDeal(int pastryQuantity)
    {
      return pastryQuantity % 3;
    }
    public int PastryTwoAtFullPrice(int pastryQuantity)
    { // testing: number being bought is 4
      return pastryQuantity; // bad test, should return 4
    }
  }
}