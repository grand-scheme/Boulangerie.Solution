using System;

namespace Boulangerie
{
  class ConsoleInterface
  {
    static bool YesOrNo() 
    {
      ConsoleBackground question = new ConsoleBackground();
      return question.YesOrNoQuestion();
    }
    static bool Checkout(int x, int y)
    {
      ConsoleBackground checkout = new ConsoleBackground();
      return checkout.CheckoutCart(x, y);
    }

    // static int BuyBread()
    // {
    //   ConsoleCalcs buyBread = new ConsoleCalcs();
    //   return buyBread.BreadConsole();
    // }

    // static int BuyPastries()
    // {
    //   ConsoleCalcs buyPastries = new ConsoleCalcs();
    //   return buyPastries.PastryConsole();
    // }

    static int ConsolidatedTerminal(string input)
    {
      PurchaseTerminal buyProducts = new PurchaseTerminal();
      return buyProducts.Purchases(input);
    }

    static void Main()
    {
      int breadCart = 0;
      int pastryCart = 0;

      Console.WriteLine("Hello");
      Console.WriteLine("Select: bread or pastry");
      string selection = Console.ReadLine().ToUpper();
      
      if (selection == "PASTRY" || selection == "P") 
      {
        pastryCart = ConsolidatedTerminal("PASTRY");

        Console.WriteLine("did you want some bread too?");
        if (YesOrNo() == true) { breadCart = ConsolidatedTerminal("BREAD"); }
        Console.WriteLine("Are you ready to check out?");
        if (YesOrNo() == true)
        {
          if (Checkout(breadCart, pastryCart) == false) { Main(); }
        }
        else
        {
          Main();
        }
      }
      else if (selection == "BREAD" || selection == "B")
      {
        breadCart = ConsolidatedTerminal("BREAD");

        Console.WriteLine("did you want some pastries too?");
        if (YesOrNo() == true)
        {
          pastryCart = ConsolidatedTerminal("PASTRY");
        }
        Console.WriteLine("Are you ready to check out?");
        if (YesOrNo() == true)
        {
          if (Checkout(breadCart, pastryCart) == false) { Main(); }
        }
        else
        {
          Main();
        }
      }
      else
      {
        Console.WriteLine("i'll get to u later");
        Main();
      }
    }
  }
}