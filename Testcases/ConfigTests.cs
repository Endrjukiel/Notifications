using NUnit.Framework;
using SeleniumAutomation.pageObjects;
using System;
using System.Threading;

namespace SeleniumAutomation.Testcases
{
    [TestFixture]
    public class InboxPageTest: BaseTest
    {
        
        [Test]
        public void test()
        {
            LoginPage new_page = new LoginPage();

            new_page.GotoPage("http://www.google.com");
            new_page.CheckTitle();
       
        }
        
        [Test]
        public void test2()

        {
           
           LoginPage new_page = new LoginPage();

            new_page.GotoPage("http://www.google.com");

        }
        //[Category("Gmail Login")]
        //[Test]
        //public void test2()
        //{
        //    new_page.GotoPage("http://google.com");

        //    new_page.CheckTitle();

        //}
    }

}
//    public class ConfigTest : SeleniumAutomation.Testcases.BaseTest
//{
//        LoginPage new_page = new LoginPage();

//        public void VerifyDriver()
//        {
//            new_page.GotoPage("http://www.google.co.in");
//            new_page.CheckTitle();
//        }
//    }
