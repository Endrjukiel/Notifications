using NUnit.Framework;


namespace SeleniumAutomation.Testcases
{ 

    [TestFixture]
    public abstract class BaseTest: Configuration

    {

        [SetUp]
       
        public void startBrowser()
        {
            Configuration.CreateDriver(chrome_type);
        }

        [TearDown]

        public void closeBrowser()
        {
            Configuration.CloseDriver();            
        }

    }
}