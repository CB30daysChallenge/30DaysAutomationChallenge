using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BoDi;

namespace _30DaysAutomationChallenge.Helpers
{
    public class Drivers
    {
        public static IWebDriver driver;
        public static string browserName = System.Configuration.ConfigurationManager.AppSettings["browser"];
        private readonly IObjectContainer _objectContainer;

        //public static IWebDriver GetDriver(string browserName, IWebDriver driver)
        //{
        //    if (browserName.Equals("Chrome"))
        //    {
        //        driver = new ChromeDriver();
        //        driver = driver;
        //    }
        //    if (browserName.Equals("Firefox"))
        //    {
        //        driver = new FirefoxDriver();
        //        driver = driver;
        //    }
        //    //if (browserName.Equals("IE"))
        //    //{
        //    //    driver = new
        //    //}
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        //    return driver;
        //}

        //public static IWebDriver GetDriver()
        //{
        //    if (browserName.Equals("Chrome"))
        //    {
        //        driver = new ChromeDriver();
        //       // driver = driver;
        //    }
        //    if (browserName.Equals("Firefox"))
        //    {
        //        driver = new FirefoxDriver();
        //        //driver = driver;
        //    }
        //    //if (browserName.Equals("IE"))
        //    //{
        //    //    driver = new
        //    //}
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        //    return driver;
        //}

        public Drivers(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        public Drivers()
        {
            
        }

        public static void SetDriver(string browserName)
        {
            switch (browserName)
            {
                case ("Chrome"):
                {
                        driver = new ChromeDriver();
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
                        driver.Manage().Cookies.DeleteAllCookies();
                        driver.Manage().Window.Maximize();
                        break;
                    }
                case ("Firefox"):
                {
                        driver = new FirefoxDriver();
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
                        driver.Manage().Cookies.DeleteAllCookies();
                        driver.Manage().Window.Maximize();
                        break;
                    }
                default:
                    {
                        driver = new FirefoxDriver();
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
                        driver.Manage().Cookies.DeleteAllCookies();
                        driver.Manage().Window.Maximize();
                        break;
                    }
            }

        }

        public static IWebDriver GetDriver()
        {

            return driver;
        }

        public static void goToUrl()
        {

            driver.Navigate().GoToUrl((Constants.GlobalConstants.ToDOMvcHomePage));
        }
        public static void CloseDriver()
        {
            //_objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
            driver.Close();
            driver.Quit();
        }

    }
}
