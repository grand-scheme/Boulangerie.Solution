// using System;
// using Boulangerie.Models;

// namespace Boulangerie
// {
//   public class ConsoleCalcs
//   {
//     static bool YesOrNo() 
//     {
//       ConsoleBackground question = new ConsoleBackground();
//       return question.YesOrNoQuestion();
//     }
    // static int ProductCart(int quantity, string productType)
    // {
    //   if (productType == "BREAD")
    // { 
    //   Bread cartTotal = new Bread();
    //   return cartTotal.BreadFinalCost(quantity);
    // }
    // else 
    // { 
    //   Pastry cartTotal = new Pastry();
    //   return cartTotal.PastryFinalCost(quantity); 
    //   }
    // }
//     public int Purchases(string input)
//     {
//       string product = (input == "BREAD") ? "bread" : "pastry";
//       string pluralProducts = (input == "BREAD") ? "loaves of bread" : "pastries";
//       string singleProduct = (input == "BREAD") ? "loaf of bread" : "pastry";
//       Console.WriteLine("How many " + pluralProducts + " would you like?");

//       int quantity = (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0) ? quantity : 0;
//       Console.WriteLine(" ");
//       if (quantity % 3 == 2)
//       {
//         Console.WriteLine("You only want " + quantity + "? You know we have a deal going on right now...");
//         if (input == "BREAD") 
//         {
//           Console.WriteLine("It's 'Buy two, get one free' for our bread. If you add one more, it's on the house. Why would you say no to free bread?");
//           quantity = YesOrNo() ? quantity + 1 : quantity;
//         }
//         else
//         {
//           Console.WriteLine("It's 'Buy three for $5` for our pastries. It's only a dollar to add one more to your bag. Do you want to add one more?");
//           quantity = YesOrNo() ? quantity + 1 : quantity;
//         }
//       }
//       Console.WriteLine(" ");
//       if (quantity == 1) 
//       {
//         Console.WriteLine("Alright, it looks like you're getting " + quantity + " " + singleProduct + ".");
//       }
//       else 
//       {
//         Console.WriteLine("Alright, it looks like you're getting " + quantity + " " + pluralProducts + ".");
//       }
//       int productTotal = ProductCart(quantity, input);
//       Console.WriteLine("For that, your total's going to be $" + productTotal + ".");
//       Console.WriteLine("Everything look good?");
//       if (YesOrNo() == true) 
//       {
//         return productTotal;
//       }
//       else
//       {
//         Console.WriteLine("Okay, let's go back.");
//         Console.WriteLine(" ");
//         Console.WriteLine(" ");
//         productTotal = Purchases(input);
//         return productTotal;
//       }
//     }
//   }
// }