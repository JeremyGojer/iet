using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalogLib;
namespace StringLibraryTest;

[TestClass]
public class UnitLoginTest
{
    [TestMethod]
    public void TestLogin(){
        
        string email="ravi.tambade@transflower.in";
        string password="seed123";
        bool expectedValue=true;
        bool actualresult=AuthManager.Validate(email, password);

        Assert.AreEqual(expectedValue, actualresult);

    }

    
    [TestMethod]
    public void TestLogin2(){
        
        string email="chetan.patil@transflower.in";
        string password="seed";
        bool expectedValue=false;
        bool actualresult=AuthManager.Validate(email, password);

        Assert.AreEqual(expectedValue, actualresult);

    }


}