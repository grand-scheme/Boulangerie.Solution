using System;

namespace Boulangerie
{
  class ConsoleInterface
  {
    static bool YesOrNoQuestion(string confirmation)
    {
      if (confirmation == "YES")
      { 
        return true;
      }
      else if (confirmation == "NO")
      { 
        return false; 
      }
      else
      {
        Console.WriteLine("Wanna run that by me one more time? YES or NO?");
        string repeat = Console.ReadLine().ToUpper();
        return YesOrNoQuestion(repeat);
      }
    }

    static int PastryConsole()
    {
      Console.WriteLine("how many pastries u want");
      int pastry = int.TryParse(Console.ReadLine(), out pastry) ? pastry : 0;


      Console.WriteLine("So you want " + pastry + " pastries?");
      Pastry cartTotal = new Pastry();
      int pastryCost = cartTotal.PastryFinalCost(pastry);
      Console.WriteLine("That'll cost you $" + pastryCost +". You good with that?");
      Console.WriteLine("You can answer YES or NO");
      string confirmation = Console.ReadLine().ToUpper();
      if (YesOrNoQuestion(confirmation) == true)
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
      Console.WriteLine("You can answer YES or NO");
      string confirmation = Console.ReadLine().ToUpper();
      if (YesOrNoQuestion(confirmation) == true)
      {
        return breadCost;
      }
      else
      {
        breadCost = BreadConsole();
        return breadCost;
      }
    }




    static void Main()
    {
      Console.WriteLine("Hello");
      Console.WriteLine("Select: bread or pastry");
      string selection = Console.ReadLine().ToLower();
      Console.WriteLine("You chose " + selection);
      if (selection == "pastry") 
      {
        int pastryCart = PastryConsole();
        Console.WriteLine("back in main, with " + pastryCart);
      }
      else if (selection == "bread")
      {
        int breadCart = BreadConsole();
        Console.WriteLine("back in main, with $" + breadCart + "in bread");
        Console.WriteLine("did you want some pastries too?");
        Console.WriteLine("You can answer YES or NO");
        string confirmation = Console.ReadLine().ToUpper();
        if (YesOrNoQuestion(confirmation) == true)
        {
          int pastryCart = PastryConsole();
          Console.WriteLine("back in main, with $" + pastryCart + " in pastries");
          Console.WriteLine("You still have $" + breadCart + "in bread, too.");
        }
        else
        {
        
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