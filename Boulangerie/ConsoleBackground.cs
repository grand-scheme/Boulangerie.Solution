using System;

namespace Boulangerie
{
  public abstract class ConsoleBackground
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
}