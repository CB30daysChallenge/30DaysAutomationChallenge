using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysAutomationChallenge.Helpers
{
    public class Drivers
    {
        public static IWebDriver driver;
        public static IWebDriver GetDriver()
        {
            driver = new ChromeDriver();

             return driver;
        }
        public static void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
