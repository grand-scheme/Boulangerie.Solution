using System;
using Boulangerie.Models;

namespace Boulangerie
{
  class ConsoleInterface : ConsoleBackground
  {
    private static bool Checkout(object bread, object pastry)
    {
      ConsoleCalcs consoleCalc = new ConsoleCalcs();
      return consoleCalc.EndOfTransaction(bread, pastry);
    }

    private static void Closer()
    {
      Console.WriteLine("Great! We'll have those ready for you at 4 AM.");
      LineBreak();
      Console.WriteLine("╔═══════════════════════════════════════════╗");
      Console.WriteLine("║                                           ║");
      Console.WriteLine("║           THANK YOU FOR CHOOSING          ║");
      Console.WriteLine("║                                           ║");
      Console.WriteLine("║            PIERRE'S BOULANGERIE           ║");
      Console.WriteLine("║                                           ║");
      Console.WriteLine("╠═══════════════════════════════════════════╣");
      Console.WriteLine("║                                           ║");
      Console.WriteLine("║           ! NOW OPEN WEEKDAYS !           ║");
      Console.WriteLine("║           ! NOW OPEN WEEKENDS !           ║");
      Console.WriteLine("║                                           ║");
      Console.WriteLine("╚═══════════════════════════════════════════╝");
    }

// UI CONSOLE BEGINS HERE
    static void Main()
    {
      ConsoleCalcs consoleCalc = new ConsoleCalcs();
      Bread buyBread = new Bread();
      Pastry buyPastry = new Pastry();
      
      Console.WriteLine("╔═══════════════════════════════════════════╗");
      Console.WriteLine("║            PIERRE'S BOULANGERIE           ║");
      Console.WriteLine("╠═══════════════════════════════════════════╣");
      Console.WriteLine("║   - BREAD: $5 PER LOAF                    ║");
      Console.WriteLine("║   SPECIAL: BUY TWO LOAVES, GET ONE FREE   ║");
      Console.WriteLine("╟───────────────────────────────────────────╢");
      Console.WriteLine("║   - PASTRIES: $2 PER PASTRY               ║");
      Console.WriteLine("║   SPECIAL: 3 PASTRIES FOR $5              ║");
      Console.WriteLine("╚═══════════════════════════════════════════╝");
      LineBreak();
      Console.WriteLine("Welcome! Please select what you would like to purchase today.");
      Console.WriteLine("Type: BREAD or PASTRY");
      
      string selection = Console.ReadLine().ToUpper();
      if (selection == "PASTRY" || selection == "P") 
      {
        buyPastry = (Pastry)consoleCalc.Purchases(buyPastry);
        LineBreak();
        Console.WriteLine("Would you like some bread as well?");
        if (YesOrNo() == true) { buyBread = (Bread)consoleCalc.Purchases(buyBread); }
        LineBreak();
        Console.WriteLine("Are you ready to check out?");
        if (YesOrNo() == true)
        {
          if (Checkout(buyBread, buyPastry) == false) 
          { 
            Main(); 
          }
          else
          {
            Closer();
          }
        }
        else
        {
          Console.WriteLine("That's okay. Let's take it from the top.");
          LineBreak();
          Main();
        }
      }
      else if (selection == "BREAD" || selection == "B")
      {
        buyBread = (Bread)consoleCalc.Purchases(buyBread);
        LineBreak();
        Console.WriteLine("Would you like some pastries too?");
        if (YesOrNo() == true)
        {
          buyPastry = (Pastry)consoleCalc.Purchases(buyPastry);
        }
        LineBreak();
        Console.WriteLine("Are you ready to check out?");
        if (YesOrNo() == true)
        {
          if (Checkout(buyBread, buyPastry) == false) 
          { 
            Main(); 
          }
          else
          {
            Closer();
          }
        }
        else
        {
          Console.WriteLine("That's okay. Let's take it from the top.");
          LineBreak();
          Main();
        }
      }
      else
      {
        LineBreak();
        LineBreak();
        LineBreak();
        Console.WriteLine("Sorry, that wasn't an item on our menu.");
        Console.WriteLine("Could you please try that again?");
        LineBreak();
        Console.WriteLine("All our products are either a loaf of BREAD.");
        Console.WriteLine("Or they're a PASTRY.");
        Console.WriteLine("Here's our menu again.");
        Main();
      }
    }
  }
}