using System;

namespace Boulangerie
{
class ConsoleInterface
{
static void YesOrNoQuestion(string confirmation)
{
  if (confirmation == "YES")
{
}
else if (confirmation == "NO")
{
}
else
{
  Console.WriteLine("Wanna run that by me one more time? YES or NO?");
  string repeat = Console.ReadLine().ToUpper();
  YesOrNoQuestion(repeat);
}
}

static void PastryConsole()
{
  Console.WriteLine("how many u want");
  int pastry = int.TryParse(Console.ReadLine(), out pastry) ? pastry : 0;
  Console.WriteLine("So you want " + pastry + " pastries?");
  Pastry cartTotal = new Pastry();
  int pastryCost = cartTotal.PastryFinalCost(pastry);
  Console.WriteLine("That'll cost you $" + pastryCost +". You good with that?");
  Console.WriteLine("You can answer YES or NO");
  string confirmation = Console.ReadLine().ToUpper();
  YesOrNoQuestion(confirmation);
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