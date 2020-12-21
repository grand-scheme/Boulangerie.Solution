using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Models.Tests
{
  [TestClass]
  public class ConsoleCalcTests
  {
    [TestMethod] // test 17
    public void ProductCart_CanInstantiateAndReturnNumber_Int()
    {
      ConsoleCalcs breadTest01 = new ConsoleCalcs();
      int quantity = 1;
      string productType = "TYPE";
      int output = breadTest01.ProductCart(quantity, productType);

      Assert.AreEqual(typeof(int), output.GetType());
    }
  }
}
// ProductCart_CanReturnFinalCostIfInputIsBread_Int()