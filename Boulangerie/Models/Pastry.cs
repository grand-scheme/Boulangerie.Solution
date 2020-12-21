namespace Boulangerie.Models
{
  public class Pastry
  {
    public int Quantity { get; set; } 
    public string Product { get; }
    public string Plural { get; }
    public string Singular { get; }
    public string DealMinusOne { get; }
    
    public Pastry()
    {
      Product = "pastry";
      Plural = "pastries";
      Singular = "pastry";
      DealMinusOne = "It's 'Buy three for $5' for our pastries. It's only a dollar to add one more to your bag. Do you want to add one more?";
    }
    public Pastry(int quantity)
    {
      Quantity = quantity;
    }

    public int PastryTotalCost()
    {
      Buy2Get1 dummy = new Buy2Get1();
      return dummy.FinalCost(Quantity, "PASTRY");
    }
  }
}