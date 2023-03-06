using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
 [TestClass]
  public class Pastriestests
  {
    [TestMethod]
    public void PastriesConstructor_CreatesInstanceOfPastries_Pastries()
    {
      Pastries pastries = new Pastries(6);
      Assert.AreEqual(typeof(Pastries), pastries.GetType());
    }

       [TestMethod]
    public void GetCost_ReturnsCostOfAllPastries1_Int()
    {
      Pastries pastries = new Pastries(6);
      Assert.AreEqual(pastries.PastriesPrice(), 10);
    }

           [TestMethod]
    public void GetCost_ReturnsCostOfAllPastries2_Int()
    {
      Pastries pastries = new Pastries(8);
      Assert.AreEqual(pastries.PastriesPrice(), 12);
    }
  }
}