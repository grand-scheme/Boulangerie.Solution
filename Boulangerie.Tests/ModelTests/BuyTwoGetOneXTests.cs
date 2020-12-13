using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boulangerie.Tests
{
  [TestClass]
  public class BuyOneGetTwoXTests
  {
    [TestMethod]
    public void NoticeProduct_CanTellIfSelectingBreadOrPastry_True()
    {
      BuyOneGetTwoX testProductInput = new BuyOneGetTwoX();
      Assert.AreEqual("bread", testProductInput.NoticeProduct("bread"));
    }

  }
}