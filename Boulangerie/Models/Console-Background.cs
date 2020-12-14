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
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        return YesOrNoQuestion();
      }
    }
    public bool EndOfTransaction(int breadCart, int pastryCart)
    {
    if ((breadCart  == 0) && (pastryCart == 0)) 
      { 
        Console.WriteLine("Oh, you're funny.");
        Console.WriteLine("Just for that, we have to do this all again.");
        Console.WriteLine("I hope you're happy.");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        return false;
      }
      else if ((breadCart  != 0) && (pastryCart != 0)) 
      { 
        Console.WriteLine("Your grand total is $" + (breadCart + pastryCart)); 
        Console.WriteLine(" ");
        return true;
      }
      else if (breadCart  != 0) 
      { 
        Console.WriteLine("Your total is $" + breadCart); 
        Console.WriteLine(" ");
        return true;
      }
      else if (pastryCart != 0) 
      { 
        Console.WriteLine("Your total is $" + pastryCart); 
        Console.WriteLine(" ");
        return true;
      }
      else 
      { 
        Console.WriteLine("¯\\_(ツ)_/¯");
        Console.WriteLine(" ");
        return false;
      }
    }
  }
}