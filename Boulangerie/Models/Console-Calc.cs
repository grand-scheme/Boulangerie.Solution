using System;

namespace Boulangerie
{
  public class ConsoleCalcs
  {
    static bool YesOrNo() 
    {
      ConsoleBackground question = new ConsoleBackground();
      return question.YesOrNoQuestion();
    }
    
    public int BreadConsole()
    {
      Console.WriteLine("how many breads u want");
      int bread = (int.TryParse(Console.ReadLine(), out bread) && bread > 0) ? bread : 0;
      
      string plural = (bread != 1) ? "loaves" : "loaf";
      Console.WriteLine("So you want " + bread + " " + plural + " of bread?");

      Bread cartTotal = new Bread();
      int breadCost = cartTotal.BreadFinalCost(bread);
      
      Console.WriteLine("That'll cost you $" + breadCost +". You good with that?");
      if (YesOrNo() == true)
      {
        return breadCost;
      }
      else
      {
        return breadCost = BreadConsole();
      }
    }
    public int PastryConsole()
    {
      Console.WriteLine("how many pastries u want");
      int pastry = (int.TryParse(Console.ReadLine(), out pastry) && pastry > 0) ? pastry : 0;

      string plural = (pastry != 1) ? "pastries" : "pastry";
      Console.WriteLine("So you want " + pastry + " " + plural + "?");

      Pastry cartTotal = new Pastry();
      int pastryCost = cartTotal.PastryFinalCost(pastry);

      Console.WriteLine("That'll cost you $" + pastryCost +". You good with that?");
      if (YesOrNo() == true)
      {
        return pastryCost;
      }
      else
      {
        return pastryCost = PastryConsole();
      }
    }
    






  }
}