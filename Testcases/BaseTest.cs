using NUnit.Framework;
using System.Threading;

namespace SeleniumAutomation.Testcases
{ 

    [TestFixture]
    public abstract class BaseTest: Configuration

    {

        [SetUp]
        
        
        public void startBrowser()
        {
            Thread.Sleep(5000);
            Configuration.CreateDriver(chrome_type);
        }

        [TearDown]

        public void closeBrowser()
        {
            Configuration.CloseDriver();            
        }

    }
}