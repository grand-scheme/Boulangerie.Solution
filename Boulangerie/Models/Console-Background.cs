using System;

namespace Boulangerie
{
  public class ConsoleBackground
  {
    public bool YesOrNoQuestion()
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
        return YesOrNoQuestion();
      }
    }
    public bool CheckoutCart(int breadCart, int pastryCart)
      {
      if ((breadCart  == 0) && (pastryCart == 0)) 
        { 
          Console.WriteLine("Oh, you're funny.");
          Console.WriteLine("Just for that, we have to do this all again.");
          Console.WriteLine("I hope you're happy.");
          return false;
        }
        else if ((breadCart  != 0) && (pastryCart != 0)) 
        { 
          Console.WriteLine("Your grand total is $" + (breadCart + pastryCart)); 
          return true;
        }
        else if (breadCart  != 0) 
        { 
          Console.WriteLine("Your total is $" + breadCart); 
          return true;
        }
        else if (pastryCart != 0) 
        { 
          Console.WriteLine("Your total is $" + pastryCart); 
          return true;
        }
        else 
        { 
          Console.WriteLine("¯\\_(ツ)_/¯");
          return false;
        }
      }

  }
}