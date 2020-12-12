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
    }
}