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
        public By GmailButton;
        public string title;

        public LoginPage()
        {
            search = By.XPath("//*[@id=\"tsf\"]/div[2]/div/div[1]/div/div[1]/input");
            LoginButton = By.LinkText("Zaloguj się");
            GmailButton = By.LinkText("Gmail");
        }
        public void GotoPage(String URL= "https://www.google.com/?hl=pl")  
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
        public void EnterGmail()
        {
            driver.FindElement(GmailButton).Click();
        }

    }
}
 