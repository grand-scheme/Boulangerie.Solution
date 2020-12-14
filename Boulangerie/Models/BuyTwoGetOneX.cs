namespace Boulangerie
{
  public class BuyOneGetTwoX
  {
    public int SetPrice (string input)
    {
      int price = 100;
      int discount = 100;
      if (input == "bread" || input == "b")
      { 
        price = 5;
        discount = 0;
      }
      else if (input == "pastry" || input == "p")
      {
        price = 2;
        discount = 1;
      }
      else 
      {
        return 999999;
      }
      return price;
    }
  }
}