using System;
namespace Boulangerie
{
class ConsoleInterface
{
static void Main()
{
Console.WriteLine("Hello");
Console.WriteLine("Select: bread or pastry");
string selection = Console.ReadLine().ToLower();
Console.WriteLine("You chose " + selection);












}
}
}