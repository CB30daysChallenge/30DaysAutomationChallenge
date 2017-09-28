using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium.Support.UI;

namespace _30DaysAutomationChallenge.POM
{
    public class DriverContext
    {
        public static IWebDriver driver;

        //public static IWebDriver GetDriver(string browserName)
        //{
        //    if (browserName.Equals("Chrome"))
        //    {
        //        driver = new ChromeDriver();
        //    }
        //    if (browserName.Equals("Firefox"))
        //    {
        //        driver = new FirefoxDriver();
        //    }
        //    //if (browserName.Equals("IE"))
        //    //{
        //    //    driver = new
        //    //}
        //    return driver;
        //}

        public  DriverContext()
        {
        }

        public static void SetDriverContext(string browserName)
        {
            if (browserName.Equals("Chrome"))
            {
                driver = new ChromeDriver();
                
            }
            if (browserName.Equals("Firefox"))
            {
                driver = new FirefoxDriver();
                
            }

        }

        public static IWebDriver GetDriverContext()
        {

            return driver;
        }
        public static void CloseDriverContext()
        {
            driver.Close();
            driver.Quit();
        }

    }
}

