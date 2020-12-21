using System;

namespace Boulangerie
{
  class ConsoleInterface
  {
//     static bool YesOrNo() 
//     {
//       ConsoleBackground question = new ConsoleBackground();
//       return question.YesOrNoQuestion();
//     }
//     static bool Checkout(int breadCart, int pastryCart)
//     {
//       ConsoleBackground checkout = new ConsoleBackground();
//       return checkout.EndOfTransaction(breadCart, pastryCart);
//     }
//     static int BuyBread()
//     {
//       ConsoleCalcs buyBread = new ConsoleCalcs();
//       return buyBread.Purchases("BREAD");
//     }
//     static int BuyPastries()
//     {
//       ConsoleCalcs buyPastries = new ConsoleCalcs();
//       return buyPastries.Purchases("PASTRY");
//     }
//     static void Closer()
//     {
//       Console.WriteLine("Great! We'll have those ready for you at 4 AM.");
//       Console.WriteLine(" ");
//       Console.WriteLine("╔═══════════════════════════════════════════╗");
//       Console.WriteLine("║                                           ║");
//       Console.WriteLine("║           THANK YOU FOR CHOOSING          ║");
//       Console.WriteLine("║                                           ║");
//       Console.WriteLine("║            PIERRE'S BOULANGERIE           ║");
//       Console.WriteLine("║                                           ║");
//       Console.WriteLine("╠═══════════════════════════════════════════╣");
//       Console.WriteLine("║                                           ║");
//       Console.WriteLine("║           ! NOW OPEN WEEKDAYS !           ║");
//       Console.WriteLine("║           ! NOW OPEN WEEKENDS !           ║");
//       Console.WriteLine("║                                           ║");
//       Console.WriteLine("╚═══════════════════════════════════════════╝");
//     }

// UI CONSOLE BEGINS HERE
    static void Main()
    {
//       int breadCart = 0;
//       int pastryCart = 0;
      Console.WriteLine("╔═══════════════════════════════════════════╗");
//       Console.WriteLine("║            PIERRE'S BOULANGERIE           ║");
//       Console.WriteLine("╠═══════════════════════════════════════════╣");
//       Console.WriteLine("║   - BREAD: $5 PER LOAF                    ║");
//       Console.WriteLine("║   SPECIAL: BUY TWO LOAVES, GET ONE FREE   ║");
//       Console.WriteLine("╟───────────────────────────────────────────╢");
//       Console.WriteLine("║   - PASTRIES: $2 PER PASTRY               ║");
//       Console.WriteLine("║   SPECIAL: 3 PASTRIES FOR $5              ║");
//       Console.WriteLine("╚═══════════════════════════════════════════╝");
//       Console.WriteLine(" ");
//       Console.WriteLine("Welcome! Please select what you would like to purchase today.");
//       Console.WriteLine("Type: BREAD or PASTRY");
      
//       string selection = Console.ReadLine().ToUpper();
//       if (selection == "PASTRY" || selection == "P") 
//       {
//         pastryCart = BuyPastries();

//         Console.WriteLine(" ");
//         Console.WriteLine("Would you like some bread as well?");
//         if (YesOrNo() == true) { breadCart = BuyBread(); }
      
//         Console.WriteLine(" ");
//         Console.WriteLine("Are you ready to check out?");
//         if (YesOrNo() == true)
//         {
//           if (Checkout(breadCart, pastryCart) == false) 
//           { 
//             Main(); 
//           }
//           else
//           {
//             Closer();
//           }
//         }
//         else
//         {
//           Console.WriteLine("That's okay. Let's take it from the top.");
//           Console.WriteLine(" ");
//           Main();
//         }
//       }
//       else if (selection == "BREAD" || selection == "B")
//       {
//         breadCart = BuyBread();

//         Console.WriteLine(" ");
//         Console.WriteLine("Would you like some pastries too?");
//         if (YesOrNo() == true)
//         {
//           pastryCart = BuyPastries();
//         }
//         Console.WriteLine(" ");
//         Console.WriteLine("Are you ready to check out?");
//         if (YesOrNo() == true)
//         {
//           if (Checkout(breadCart, pastryCart) == false) 
//           { 
//             Main(); 
//           }
//           else
//           {
//             Closer();
//           }
//         }
//         else
//         {
//           Console.WriteLine("That's okay. Let's take it from the top.");
//           Console.WriteLine(" ");
//           Main();
//         }
//       }
//       else
//       {
//         Console.WriteLine(" ");
//         Console.WriteLine(" ");
//         Console.WriteLine(" ");
//         Console.WriteLine("Sorry, that wasn't an item on our menu.");
//         Console.WriteLine("Could you please try that again?");
//         Console.WriteLine(" ");
//         Console.WriteLine("All our products are either a loaf of BREAD.");
//         Console.WriteLine("Or they're a PASTRY.");
//         Console.WriteLine("Here's our menu again.");
//         Main();
//       }
    }
  }
}