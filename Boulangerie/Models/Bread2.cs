namespace Boulangerie.Models
{
  public class Bread2
  {
    private int _breadQuantity {get; set;} 
    
    public int BreadQuantity()
    {
      return _breadQuantity;
    }
    
    public void SetQuantity(int quantity)
    {
      _breadQuantity = quantity;
    }

    public int BreadTotalCost()
    {
      Buy2Get1 dummy = new Buy2Get1();
      return dummy.FinalCost(_breadQuantity, "bread");
    }
  }
}