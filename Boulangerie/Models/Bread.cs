namespace Boulangerie.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    public string Product { get; }
    public string Plural { get; }
    public string Singular { get; }
    public string DealMinusOne { get; }
    
    public Bread()
    {
      Product = "bread";
      Plural = "loaves of bread";
      Singular = "loaf of bread";
      DealMinusOne = "It's 'Buy two, get one free' for our bread. If you add one more, it's on the house. Why would you say no to free bread?";
    }
    public Bread(int quantity)
    : this()
    {
      Quantity = quantity;
    }
    public int BreadTotalCost()
    {
      Buy2Get1 dummy = new Buy2Get1();
      return dummy.FinalCost(Quantity, "BREAD");
    }
  }
}