using System;
using Boulangerie.Models;

namespace Boulangerie
{
	public class ConsoleCalcs
	{
		public bool YesOrNo() 
		{
			ConsoleBackground consoleBackground = new ConsoleBackground();
      return consoleBackground.YesOrNoQuestion();
		}
		public static void LineBreak()
		{
			ConsoleBackground consoleBackground = new ConsoleBackground();
      consoleBackground.LineBreak();
		}
		private int inputQuantity(string minus, string single, string plural)
		{
			Console.WriteLine("How many " + plural + " would you like?");
			int quantity = (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0) ? quantity : 0;
			LineBreak();
			if (quantity % 3 == 2)
			{
				Console.WriteLine("You only want " + quantity + "? You know we have a deal going on right now...");
				Console.WriteLine(minus);
				quantity = YesOrNo() ? quantity + 1 : quantity;
			}
			if (quantity == 1) 
			{
				Console.WriteLine("Alright, it looks like you're getting " + quantity + " " + single + ".");
			}
			else 
			{
				Console.WriteLine("Alright, it looks like you're getting " + quantity + " " + plural + ".");
			}
			return quantity;
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
		public object Purchases(object input)
		{
			if (input.GetType() == typeof(Bread2))
			{
				Bread2 bread = new Bread2();
				bread.Quantity = inputQuantity(bread.DealMinusOne, bread.Singular, bread.Plural);
				bread = (Bread2)Closeout(bread, bread.BreadTotalCost(), input);
				return bread;
			}
			else // if (input == "PASTRY")
			{
				Pastry2 pastry = new Pastry2();
				pastry.Quantity = inputQuantity(pastry.DealMinusOne, pastry.Singular, pastry.Plural);
				pastry = (Pastry2)Closeout(pastry, pastry.PastryTotalCost(), input);
				return pastry;
			}
		}
	}
}