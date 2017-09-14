using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace _30DaysAutomationChallenge.Helpers
{
    public class Drivers
    {
        public static IWebDriver driver;
        
        public static IWebDriver GetDriver(string browserName)
        {
            if (browserName.Equals("Chrome"))
            {
                driver = new ChromeDriver();
            }
            if (browserName.Equals("Firefox"))
            {
                driver = new FirefoxDriver();
            }
            //if (browserName.Equals("IE"))
            //{
            //    driver = new
            //}
            return driver;
        }
        public static void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
        //public static IEnumerable<string> BrowserToRunWith()
        //{
        //    string[] browsers = { "chrome", "firefox" };
        //    foreach (string browser in browsers)
        //    {
        //       yield return browser;
        //    }
        //}
    }
}
