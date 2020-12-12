using System;

namespace Boulangerie
{
class ConsoleInterface
{
static void PastryConsole()
{
  Console.WriteLine("how many u want");
  string input = Console.ReadLine();
  int pastry = int.TryParse(input, out pastry) ? pastry:0;
  Console.WriteLine("So you want " + pastry + " pastries?");
  Pastry cartTotal = new Pastry();
  int pastryCost = cartTotal.PastryFinalCost(pastry);
  Console.WriteLine("That'll cost you $" + pastryCost +". You good with that?");
}
// static void BreadConsole()
// {
// }






static void Main()
{
Console.WriteLine("Hello");
Console.WriteLine("Select: bread or pastry");
string selection = Console.ReadLine().ToLower();
Console.WriteLine("You chose " + selection);
if (selection == "pastry") 
{
PastryConsole();
}
else
{
  Console.WriteLine("i'll get to u later");
  Main();
}







}
}
}