using System;

namespace Boulangerie
{
  public class PurchaseTerminal
  {
    static bool YesOrNo() 
    {
      ConsoleBackground question = new ConsoleBackground();
      return question.YesOrNoQuestion();
    }
    
    static int Checkout(int quantity, string productType)
    {
      BuyOneGetTwoX checkout = new BuyOneGetTwoX();
      return checkout.TheEquation(quantity, productType);
    }
    public int Purchases(string input)
    {
      string product = (input == "BREAD") ? "bread" : "pastry";
      string pluralProducts = (input == "BREAD") ? "loaves of bread" : "pastries";
      Console.WriteLine("How many " + pluralProducts + " do you want?");

      int quantity = (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0) ? quantity : 0;
      if (quantity % 3 == 2)
      {
        Console.WriteLine("You only want " + quantity + "? You know we have a deal going on right now...");
        if (input == "BREAD") 
        {
          Console.WriteLine("It's 'Buy two, get one free' for our bread. If you add one more, it's on the house. Do you want to add one more?");
          quantity = YesOrNo() ? quantity++ : quantity;
        }
        else
        {
          Console.WriteLine("It's 'Buy three for $5` for our pastries. It's only a dollar to add one more to your bag. Do you want to add one more?");
          quantity = YesOrNo() ? quantity++ : quantity;
        }
      }
      Console.WriteLine("Alright, so it looks like you're getting " + quantity + " " + pluralProducts + ".");
      int productTotal = Checkout(quantity, input);
      Console.WriteLine("For that, your total's going to be $" + productTotal + ".");
      Console.WriteLine("Are you good with that?");
      if (YesOrNo() == true) 
      {
        return productTotal;
      }
      else
      {
        Console.WriteLine("Okay, let's go back.");
        productTotal = Purchases(input);
        return productTotal;
      }
    }
  }
}