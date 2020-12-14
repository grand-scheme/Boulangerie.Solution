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
      int price = SetPrice(input);
      int discount = SetDiscount(input);
      int outsideDiscount = number % 3;
      int buyTwo = ((number - outsideDiscount) * 2 / 3);
      int fullPrice = buyTwo + outsideDiscount;
      int getOne = ((number - outsideDiscount) / 3);
    return input + " " + price + " " + discount + " " + number + " " + outsideDiscount + " " + fullPrice + " " + getOne; 
    }
    public int TheEquation (int number, string input)
    {
      string product = input;
      int price = SetPrice(product);
      int discount = SetDiscount(product);
      
      int outsideDiscount = (number % 3);
      int getOne = ((number - outsideDiscount) / 3);
      int fullPrice = (number - getOne);

      int checkout = ((fullPrice * price) + (getOne * discount));
      return checkout;
    }

  }
}