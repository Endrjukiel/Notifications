using NUnit.Framework;
using SeleniumAutomation.pageObjects;
using System;
using System.Threading;

namespace SeleniumAutomation.Testcases
{
    [TestFixture]
    public class ConfigTests : BaseTest
    {

        [Test]
        public void CanAccessGoogle()
        {
            LoginPage new_page = new LoginPage();

            new_page.GotoPage("http://www.google.com");
            new_page.CheckTitle();

        }

        [Test]
        public void CanSearchInGoogle()
        {
            LoginPage new_page = new LoginPage();

            new_page.GotoPage();
            new_page.Search_something("malaga krakow flights today");
        }
        [Test]
        public void CanAccesLoginPane()
        {
            LoginPage new_page = new LoginPage();

            new_page.GotoPage();
            new_page.GotoLogin();
        }
        [Test]
        public void CanLoginToGoogle()
        {
            LoginPage new_page = new LoginPage();

            new_page.GotoPage();
            new_page.GotoLogin();

            LoginGmailPage new_login = new LoginGmailPage();

            new_login.SetUser("endrjukiller@gmail.com");
            new_login.SetPassword("a.1666665");
        }

        [Test]
        public void CanNavToGmailAndSeeEmails()
        {
            CanLoginToGoogle();

            LoginPage new_page = new LoginPage();

            new_page.EnterGmail();
        }


    }
}

