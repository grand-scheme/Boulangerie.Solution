namespace Boulangerie
{
  public class BuyOneGetTwoX
  {
    private int SetPrice (string input)
    {
      return (input == "BREAD") ? 5 : 2;
    }
    private int SetDiscount (string input)
    {
      return (input == "BREAD") ? 0 : 1;
    }
    public int TheEquation (int number, string input)
    {
      string product = input;
      int price = SetPrice(product);
      int discount = SetDiscount(product);
      
      int outsideDiscount = (number % 3);
      int getOne = ((number - outsideDiscount) / 3);
      int fullPrice = (number - getOne);

      return ((fullPrice * price) + (getOne * discount));
    }
  }
}