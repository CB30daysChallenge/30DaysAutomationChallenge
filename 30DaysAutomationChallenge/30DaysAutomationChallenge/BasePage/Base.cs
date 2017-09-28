//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30DaysAutomationChallenge.BasePage
//{
//    public class Base
//    {
//        public BasePage CurrentPage { get; set; }

//        public IWebDriver _driver { get; set; }

//        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
//        {
//            TPage pageInstance = new TPage()
//            {
//                _driver = Helpers.Drivers._driver
//            };

//            PageFactory.InitElements(Helpers.Drivers._driver, pageInstance);

//            return pageInstance;
//        }

//        public TPage As<TPage>() where TPage : BasePage
//        {
//            return (TPage)this;
//        }
//    }
//}
