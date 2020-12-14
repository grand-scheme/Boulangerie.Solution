namespace Boulangerie
{
  public class BuyOneGetTwoX
  {
    public int SetPrice (string input)
    {
      int price = 100;
      if (input == "bread" || input == "b")
      { 
        price = 5;
      }
      else if (input == "pastry" || input == "p")
      {
        price = 2;
      }
      else 
      {
        return 999999;
      }
      return price;
    }
    public int SetDiscount (string input)
    {
      int discount = 100;
      if (input == "bread" || input == "b")
      { 
        discount = 0;
      }
      else if (input == "pastry" || input == "p")
      {
        discount = 1;
      }
      else 
      {
        return 999999;
      }
      return discount;
    }
  }
}