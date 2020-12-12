using System;

namespace Boulangerie
{
  class ConsoleInterface
  {
    static bool YesOrNo() {
      ConsoleBackground question = new ConsoleBackground();
      return question.YesOrNoQuestion();
    }
    static int PastryConsole()
    {
      Console.WriteLine("how many pastries u want");
      int pastry = int.TryParse(Console.ReadLine(), out pastry) ? pastry : 0;


      Console.WriteLine("So you want " + pastry + " pastries?");
      Pastry cartTotal = new Pastry();
      int pastryCost = cartTotal.PastryFinalCost(pastry);

      Console.WriteLine("That'll cost you $" + pastryCost +". You good with that?");
      if (YesOrNo() == true)
      {
        return pastryCost;
      }
      else
      {
        pastryCost = PastryConsole();
        return pastryCost;
      }
    }
    static int BreadConsole()
    {
      Console.WriteLine("how many breads u want");
      int bread = int.TryParse(Console.ReadLine(), out bread) ? bread : 0;
      
      // add if else for language re: 1 loaves
      // add if else for Get That Deal
      Console.WriteLine("So you want " + bread + " loaves of bread?");
      Bread cartTotal = new Bread();
      int breadCost = cartTotal.BreadFinalCost(bread);
      
      Console.WriteLine("That'll cost you $" + breadCost +". You good with that?");
      if (YesOrNo() == true)
      {
        return breadCost;
      }
      else
      {
        breadCost = BreadConsole();
        return breadCost;
      }
    }

    static void CheckoutCart(int breadCart, int pastryCart)
    {
      if ((breadCart  == 0) && (pastryCart == 0)) 
      { 
        Console.WriteLine("Oh, you're funny.");
        Console.WriteLine("Just for that, we have to do this all again.");
        Console.WriteLine("I hope you're happy.");
        Main(); 
      }
      else if ((breadCart  != 0) && (pastryCart != 0)) 
      { 
        Console.WriteLine("Your grand total is $" + (breadCart + pastryCart)); 
      }
      else if (breadCart  != 0) 
      { 
        Console.WriteLine("Your total is $" + breadCart); 
      }
      else if (pastryCart != 0) 
      { 
        Console.WriteLine("Your total is $" + pastryCart); 
      }
      else 
      { 
        Console.WriteLine("¯\\_(ツ)_/¯");
      }
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
        pastryCart = PastryConsole();

        Console.WriteLine("Your pastry total is $" + pastryCart);
        Console.WriteLine("did you want some bread too?");
        if (YesOrNo() == true)
        {
          breadCart = BreadConsole();
        }
        Console.WriteLine("Are you ready to check out?");
        if (YesOrNo() == true)
        {
          CheckoutCart(breadCart, pastryCart);
        }
        else
        {
          Main();
        }
      }
      else if (selection == "BREAD" || selection == "B")
      {
        breadCart = BreadConsole();

        Console.WriteLine("Your bread total is $" + breadCart);
        Console.WriteLine("did you want some pastries too?");
        if (YesOrNo() == true)
        {
          pastryCart = PastryConsole();
        }
        Console.WriteLine("Are you ready to check out?");
        if (YesOrNo() == true)
        {
          CheckoutCart(breadCart, pastryCart);
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