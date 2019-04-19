using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using AventStack.ExtentReports;

public class Configuration
    {
    public static string browser_type = 
    public static string chrome_type 
        {
            get
            {
            browser_type = TestContext.Parameters["browser_type"].ToString();
                return browser_type;
            }
        }

        public static IWebDriver driver;
        

        public static IWebDriver CreateDriver(string chrome_type) 
        {
        switch (chrome_type)
            {
                case "Chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("incognito");
                    options.AddArgument("–disable-extensions");
                    options.AddArgument("--start-maximized"); // "--disable-cache"
                    options.AddArgument("--disable-cache");
                    driver = new ChromeDriver(options);
                    break;
                case "IE":

                    driver = new InternetExplorerDriver();
                    break;
                default:

                    FirefoxOptions ffoptions = new FirefoxOptions();
                    ffoptions.AcceptInsecureCertificates = true;
                    driver = new FirefoxDriver(ffoptions);
                    break;
            }

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();
            return driver;
        }
        public static void ProcessKill()
        {
            List<string> processesToKill = new List<string>() { "Upload", "chromedriver", "geckodriver", "IEDriverServer" };
            foreach (string process in processesToKill)
            {
                Process[] processes = Process.GetProcessesByName(process);
                if (processes.Length > 0)
                {
                    foreach (Process processToKill in processes)
                    {
                        if (!processToKill.HasExited)
                        {
                            processToKill.Kill();
                        }
                    }
                }
            }
        }
        public static void CloseDriver()
        {
            //driver.Close();
            driver.Quit();
            ProcessKill();
        }
    }
