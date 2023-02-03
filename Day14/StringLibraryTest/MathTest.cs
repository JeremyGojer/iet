using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalogLib;
namespace StringLibraryTest;

[TestClass]
public class UnitMathTest
{
    [TestMethod]
    public void TestAddition()
    {
        int num1=56;
        int num2=56;

        int  actualresult=MathEngine.Add(num1,num2);
        Assert.AreEqual(112,actualresult);
    }


    [TestMethod]
    public void TestSubtraction()
    {
        int num1=76;
        int num2=6;
        int  actualresult=MathEngine.Subtract(num1,num2);
        Assert.AreEqual(70,actualresult);
    }

    [TestMethod]
    public void TestSubtraction2()
    {
        int num1=176;
        int num2=6;
        int  actualresult=MathEngine.Subtract(num1,num2);
        Assert.AreEqual(170,actualresult);
    }



     

 
}