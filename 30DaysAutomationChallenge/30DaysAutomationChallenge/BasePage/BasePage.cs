using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysAutomationChallenge.BasePage
{
    public abstract class BasePage:Helpers.Drivers
    {
        public IWebDriver drivers { get; set; }
        public BasePage()
        {
            drivers = driver;
            PageFactory.InitElements(driver, this);

        }
    }
}
