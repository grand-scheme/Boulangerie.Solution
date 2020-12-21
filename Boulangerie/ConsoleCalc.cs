using System;
using Boulangerie.Models;

namespace Boulangerie
{
	public class ConsoleCalcs : ConsoleBackground
	{
		private int inputQuantity(string dealText, string single, string plural)
		{
			Console.WriteLine("How many " + plural + " would you like?");
			int quantity = (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0) ? quantity : 0;
			LineBreak();
			if (quantity % 3 == 2)
			{
				Console.WriteLine("You only want " + quantity + "? You know we have a deal going on right now...");
				Console.WriteLine(dealText);
				quantity = YesOrNo() ? quantity + 1 : quantity;
			}
			string matchNumber = (quantity != 1 ? plural : single);
			Console.WriteLine("Alright, it looks like you're getting " + quantity + " " + matchNumber + ".");
			return quantity;
		}
		public object Purchases(object input)
		{
			if (input.GetType() == typeof(Bread))
			{
				Bread bread = new Bread();
				bread.Quantity = inputQuantity(bread.DealMinusOne, bread.Singular, bread.Plural);
				bread = (Bread)Closeout(bread, bread.BreadTotalCost(), input);
				return bread;
			}
			else // if (input.GetType() == typeof(Pastry))
			{
				Pastry pastry = new Pastry();
				pastry.Quantity = inputQuantity(pastry.DealMinusOne, pastry.Singular, pastry.Plural);
				pastry = (Pastry)Closeout(pastry, pastry.PastryTotalCost(), input);
				return pastry;
			}
		}
		private object Closeout(object buyThis, int productTotal, object input)
		{
			Console.WriteLine("For that, your total's going to be $" + productTotal + ".");
			Console.WriteLine("Everything look good?");
			if (YesOrNo() == false) 
			{
				Console.WriteLine("Okay, let's go back.");
				LineBreak();
				LineBreak();
				buyThis = Purchases(input);
			}
			{
				return buyThis;
			}
		}
		public bool EndOfTransaction(object bread, object pastry)
    {
      Bread testBread = (Bread)bread;
      int breadQuantity = testBread.Quantity;
      int breadPrice = testBread.BreadTotalCost();
			string breadMatchNumber = (breadQuantity != 1 ? testBread.Plural : testBread.Singular);
      
      Pastry testPastry = (Pastry)pastry;
      int pastryQuantity = testPastry.Quantity;
      int pastryPrice = testPastry.PastryTotalCost();
			string pastryMatchNumber = (pastryQuantity != 1 ? testPastry.Plural : testPastry.Singular);
      
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
        Console.WriteLine("It looks like you're getting " + breadQuantity + breadMatchNumber + " at " + breadPrice + ".");
        Console.WriteLine("And for it's " + pastryQuantity + pastryMatchNumber + " at " + pastryPrice + ".");
        Console.WriteLine("Your grand total is $" + (breadPrice + pastryPrice)); 
        LineBreak();
        return true;
      }
      else if (breadQuantity  != 0) 
      { 
        Console.WriteLine("It looks like you're getting " + breadQuantity + breadMatchNumber);
        Console.WriteLine("Your total is $" + breadPrice); 
        LineBreak();
        return true;
      }
      else // if (pastryQuantity != 0) 
      { 
        Console.WriteLine("It looks like you're getting " + pastryQuantity + pastryMatchNumber);
        Console.WriteLine("Your total is $" + pastryPrice); 
        LineBreak();
        return true;
      }
    }
	}
}