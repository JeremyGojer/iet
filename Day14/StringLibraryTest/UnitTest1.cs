using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalogLib;
namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        bool result=Manager.IsOutofStock();
        Assert.IsTrue(result);
    }


    [TestMethod]
    public void TestMethod2()
    {
        bool result=Manager.IsProductAvailable();
        Assert.IsTrue(result);
    }


    [TestMethod]
    public void TestMethod3()
    {
       int result=Manager.GetProductStock();
        Assert.AreEqual(900,result);
    }
}