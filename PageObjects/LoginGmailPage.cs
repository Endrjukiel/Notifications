using OpenQA.Selenium;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAutomation.pageObjects
{
    class LoginGmailPage : Configuration
    {
        public By LoginButton;
        public By Username;
        public By Password;
        public By NextPassword;
        public By NextUser;

        public LoginGmailPage()
        {
            Username = By.Id("identifierId");
            Password = By.XPath("//*[@name='password']");
            NextUser = By.Id("identifierNext");
            NextPassword = By.Id("passwordNext");

        }
        public void SetUser(String user)
        {
            IWebElement userButton = driver.FindElement(NextUser);
            driver.FindElement(Username).SendKeys(user);
            Assert.AreEqual("Dalej", userButton.Text);
            userButton.Click();
        }
       public void SetPassword(String user)
        {
            IWebElement userButton = driver.FindElement(NextPassword);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(Password));
            driver.FindElement(Password).SendKeys(user);
            Assert.AreEqual("Dalej", userButton.Text);
            userButton.Click();
        }

    }
}
    
