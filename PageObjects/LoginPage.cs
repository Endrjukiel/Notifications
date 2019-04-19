//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using NUnit.Framework;

namespace SeleniumAutomation.pageObjects
{
    class LoginPage : Configuration
    {
        public By search;
        public By LoginButton;
        public string title;

        public LoginPage()
        {
            search = By.XPath("//*[@id=\"tsf\"]/div[2]/div/div[1]/div/div[1]/input");
            LoginButton = By.LinkText("Zaloguj się");
        }
        public void GotoPage(String URL= "http://www.google.com")  
        {
            driver.Navigate().GoToUrl(URL);

        }
        public void CheckTitle()
        {
            title = driver.Title;
            Assert.AreEqual("Google", title);
        }
        public void Search_something(string searched_phrase)
        {
            driver.FindElement(search).SendKeys(searched_phrase);
            driver.FindElement(search).Submit(); 
        }
        public void GotoLogin()
        {
            driver.FindElement(LoginButton).Click(); //change to GmailPage Object
        }

    }
}
 