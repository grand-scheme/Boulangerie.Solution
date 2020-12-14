namespace Boulangerie
{
  public class BuyOneGetTwoX
  {
    public string NoticeProduct (string input)
    {
      if (input == "bread" || input == "b") 
      {
        return "bread";
      } 
      else if (input == "pastry" || input == "p") 
      {
      return "pastry"; 
      }
      else 
      {
        return "bad input";
      }
    }
    public int SetPrice (string input)
    {
      int price = 100;
      int discount = 100;
      if (NoticeProduct(input) == "bread")
      { 
        price = 5;
        discount = 0;
      }
      else
      {
        price = 2;
        discount = 1;
      }
      return price;
    }
  }
}