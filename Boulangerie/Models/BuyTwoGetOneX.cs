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
    public string CheckVariables (int number, string input)
    {
    return 
    input // type
    + " " 
    + 5 // price
    + " " 
    + 0 // discount
    + " " 
    + number // quantity
    + " " 
    + 2 // not inside discount
    + " " 
    + 4 // full price
    + " " 
    + 1; // discounted price
    }

  }
}