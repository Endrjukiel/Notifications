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
    
    public class BaseTest: Configuration

    {

        [OneTimeSetUp]
        
        public void startBrowser()
        {
            
            string browser_type = TestContext.Parameters["browser_type"].ToString();
            Configuration.CreateDriver(chrome_type);
        }

        [OneTimeTearDown]

        public void closeBrowser()
        {
            Configuration.CloseDriver();
             
        }

    }
    }