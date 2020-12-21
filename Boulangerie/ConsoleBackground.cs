using System;
using Boulangerie.Models;

namespace Boulangerie
{
  public abstract class FrequentCallback
    {
      public static void LineBreak()
      {
        Console.WriteLine(" ");
      }
      public static bool YesOrNo()
      {
        Console.WriteLine("You can answer YES or NO");
        string confirmation = Console.ReadLine().ToUpper();
        if (confirmation == "YES" || confirmation == "Y")
        { 
          return true;
        }
        else if (confirmation == "NO" || confirmation == "N")
        { 
          return false; 
        }
        else
        { 
          Console.WriteLine("Wanna run that by me one more time?");
          LineBreak();
          LineBreak();
          return YesOrNo();
        }
      }
    
    }
  public class ConsoleBackground : FrequentCallback
  {
    public bool EndOfTransaction(object bread, object pastry)
    {
      Bread2 testBread = (Bread2)bread;
      int breadQuantity = testBread.Quantity;
      int breadPrice = testBread.BreadTotalCost();
      
      Pastry2 testPastry = (Pastry2)pastry;
      int pastryQuantity = testPastry.Quantity;
      int pastryPrice = testPastry.PastryTotalCost();
      
      if ((breadQuantity == 0) && (pastryQuantity == 0)) 
      { 
        Console.WriteLine("Oh, you're funny.");
        Console.WriteLine("Just for that, we have to do this all again.");
        Console.WriteLine("I hope you're happy.");
        LineBreak();
        LineBreak();
        LineBreak();
        LineBreak();
        return false;
      }
      else if ((breadQuantity  != 0) && (pastryQuantity != 0)) 
      { 
        Console.WriteLine("For " + testBread.Product + ", it looks like you're getting " + breadQuantity + " at " + breadPrice + ".");
        Console.WriteLine("And for " + testPastry.Plural + ", it's " + pastryQuantity + " at " + pastryPrice + ".");
        Console.WriteLine("Your grand total is $" + (breadPrice + pastryPrice)); 
        LineBreak();
        return true;
      }
      else if (breadQuantity  != 0) 
      { 
        Console.WriteLine("For " + testBread.Product + ", it looks like you're getting " + breadQuantity);
        Console.WriteLine("Your total is $" + breadPrice); 
        LineBreak();
        return true;
      }
      else // if (pastryQuantity != 0) 
      { 
        Console.WriteLine("For " + testPastry.Plural + ", it looks like you're getting " + pastryQuantity);
        Console.WriteLine("Your total is $" + pastryPrice); 
        LineBreak();
        return true;
      }
    }
  }
}