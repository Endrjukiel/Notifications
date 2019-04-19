//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
//using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using AventStack.ExtentReports;
using OpenQA.Selenium.Support.Extensions;
using NUnit.Framework;

namespace SeleniumAutomation.pageObjects
{
    class LoginPage : Configuration
    {
        public By search;
        public string title;

        public LoginPage()
        {
            search = By.XPath("//*[@id=\"tsf\"]/div[2]/div/div[1]/div/div[1]/input");
        }
        public void GotoPage(String URL)  //URL is local variable
        {
            driver.Navigate().GoToUrl(URL);

        }
        public void CheckTitle()
        {
            title = driver.Title;
            Assert.AreEqual("Google", title);
        }
    }
}
 