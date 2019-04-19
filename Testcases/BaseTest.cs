using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumAutomation.pageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AventStack.ExtentReports;

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