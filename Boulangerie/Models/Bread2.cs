namespace Boulangerie.Models
{
  public class Bread2
  {
    public int BreadQuantity { get; set; } 
    
    public Bread2(int breadQuantity)
    {
      BreadQuantity = breadQuantity;
    }

    public int BreadTotalCost()
    {
      Buy2Get1 dummy = new Buy2Get1();
      return dummy.FinalCost(BreadQuantity, "bread");
    }
  }
}