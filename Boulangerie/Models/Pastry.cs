namespace Boulangerie.Models
{
  public class Pastry2
  {
    public int PastryQuantity { get; set; } 
    
    public Pastry2(int pastryQuantity)
    {
      PastryQuantity = pastryQuantity;
    }

    public int PastryTotalCost()
    {
      Buy2Get1 dummy = new Buy2Get1();
      return dummy.FinalCost(PastryQuantity, "PASTRY");
    }
  }
}