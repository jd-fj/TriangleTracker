using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Shape;

namespace Shape.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_DoTheseThreeSidesMakeATriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(4, 5, 6));
    }
    [TestMethod]
    public void IsEquilateral_AreAllSidesEqualToEachOther_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsEquilateral(2,2,2));
    }
    [TestMethod]
    public void IsIsosceles_AreExactlyTwoSidesEqualToEachOther_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsIsosceles(3,3,7));
    }
    [TestMethod]
    public void IsScalene_TriangleHasNoEqualSides_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsScalene(4,5,6));
    }
  }
}