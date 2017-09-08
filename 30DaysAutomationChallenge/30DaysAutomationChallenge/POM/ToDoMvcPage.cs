using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using NUnit.Framework;

namespace _30DaysAutomationChallenge.POM
{
    public class ToDoMvcPage
    {
   
        public IWebDriver driver;
        WebDriverWait wait;
        private const string xpathofTextbox="//*[@id=\"new-todo\"]";
        private const string xpathofClearCompleted = "//*[@id=\"clear-completed\"]";
        private const string linkTextActive = "Active";
        private const string linkTextCompleted = "Completed";
        private const string listClassView = "view";
        private const string allLinkText = "All";


        [FindsBy(How = How.ClassName, Using = listClassView)]
        public IList<IWebElement> CheckboxList;

        [FindsBy(How = How.XPath, Using = xpathofTextbox)]
        public IWebElement NewToDoXPath { get; set; }
    
        [FindsBy(How = How.LinkText, Using = linkTextActive)]
        public IWebElement Active { get; set; }

        [FindsBy(How = How.LinkText, Using = linkTextCompleted)]
        public IWebElement Completed { get; set; }

        [FindsBy(How = How.LinkText, Using = allLinkText)]
        public IWebElement All { get; set; }

        [FindsBy(How = How.XPath, Using = xpathofClearCompleted)]
        public IWebElement ClearCompleted { get; set; }

        [FindsBy(How = How.ClassName, Using = listClassView)]
        public IList<IWebElement> ListTasks { get; set; }


        public ToDoMvcPage(IWebDriver driver)
        {
            this.driver = driver;
            wait =new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            PageFactory.InitElements(driver, this);
        }


        public void OpenPage()
        {
            try
            {
                driver.Navigate().GoToUrl(Constants.GlobalConstants.ToDOMvcHomePage);
            }
            catch (Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Unable to open ToDoMvc Page " + ex);
                Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
        }
        public void ClearCheckBox()
        {
            //Reports.ToDoMvcReport.test.Log(Status.Info, "public void ClearCheckBox()");
            NewToDoXPath.Clear();
        }
        public void ClearList()
        {
            //Reports.ToDoMvcReport.test.Log(Status.Info, "public void ClearList()");
            try
            {
                for (int i = 0; i < CheckboxList.Count; i++)
                {
                    CheckboxList.ElementAt(i).Clear();
                }
            }
            catch (Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Unable to Find the ClearAll Button " + ex);
                Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
        }

 
        public void ClickAllButton()
        {
        }
        public void ClickClearAllButton() 
        {
            //Reports.ToDoMvcReport.test.Log(Status.Info, "public void ClickClearAllButton()");
            //ClearCompleted.Displayed.Equals(true);
            try
            {
                ClearCompleted.Click();
            }
            catch(Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Unable to Find the ClearAll Button " + ex);
                Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
        }
        public void ClickCompletedButton()
        {
            //Reports.ToDoMvcReport.test.Log(Status.Info, "public void ClickCompletedButton()");
            try
            {
                Completed.Click();
            }

            catch (Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Unable to Find the Complete Button " + ex);
                Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
        }
        public void ClickActiveButton()
        {
            //Reports.ToDoMvcReport.test.Log(Status.Info, "public void ClickActiveButton()");
            try
            {
                Active.Click();
            }
            catch (Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Unable to Find/click the Active Button  " + ex);
                Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
        }
        public ToDoMvcPage CreateTask(string newTask)
        {

            //Reports.ToDoMvcReport.test.Log(Status.Info, "public ToDoMvcPage CreateTask(string newTask)");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            try
            {
                NewToDoXPath.SendKeys(newTask);
            }
            catch (Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Unable to Find the Textbox " + ex);
                Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
            return this;
         }
        //public string GetAllTasks( List<string> tasks)
        //{
        //    int size = ListTasks.Count();
        //    List<IWebElement> elementList = new List<IWebElement>;
        //    foreach (IWebElement ele in ListTasks)
        //    {
        //        elementList = ele;
        //    }

        public string GetTask(string task)
        {

            IWebElement element = null;
            int size = ListTasks.Count();
            try
            {
                for (int i = 0; i < size; i++)
                {
  
                    element = ListTasks.ElementAt(i);
                    if (element.Text == task)
                    {

                        break;


                    }
                }
            }
            catch (Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Unable to Find the Task " + ex);
                Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
                
                return element.Text;

           // }
            //catch (Exception ex)
            //{
            //    Reports.ToDoMvcReport.test.Fail("Unable to Find the Element" +ex);
            //    Helpers.Screenshots.TakeScreenshot(driver);
            //    //Reports.ToDoMvcReport.test.Error("Error" + MediaEntityBuilder.CreateScreenCaptureFromPath(Helpers.Screenshots.TakeScreenshot(driver)).Build());
            //    return ex.ToString();

            //}
             


        }
        public void enter()
        {
            //Reports.ToDoMvcReport.test.Log(Status.Info, "public void enter()");
            try
            {
   
                NewToDoXPath.SendKeys(Keys.Enter);
                //Reports.ToDoMvcReport.test.Pass("Element Found");
            }
            catch (Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Unable to Find the Textbox " + ex);
                Helpers.Screenshots.TakeScreenshot(driver);
            }

        }
        public void ClickOnActiveTask()
        {

            //Reports.ToDoMvcReport.test.Log(Status.Info, "public void ClickOnActiveTask()");
            CheckboxList = driver.FindElements(By.ClassName("view"));
           
            int size = CheckboxList.Count();
            try
            {
                if (size == 1)
                {
                    IWebElement element = driver.FindElement(By.CssSelector("#todo-list > li > div > input"));
                    element.Click();
                }
                else if (size > 1)
                {

                    for (int i = 1; i <= size; i++)
                    {

                        IWebElement element = driver.FindElement(By.CssSelector("#todo-list > li:nth-child(" + i + ") > div > input"));
                        element.Click();

                    }
                }
                Reports.ToDoMvcReport.test.Pass("Element Found");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unable to find elements "+ex );
                Reports.ToDoMvcReport.test.Fail("Unable to Find the Element " +ex);
                Helpers.Screenshots.TakeScreenshot(driver);
                //Reports.ToDoMvcReport.test.Error("Error" + MediaEntityBuilder.CreateScreenCaptureFromPath(Helpers.Screenshots.TakeScreenshot(driver)).Build());
            }

        }

        public void ClickOnActiveTask(string task)
        {

            //Reports.ToDoMvcReport.test.Log(Status.Info, "public void ClickOnActiveTask()");
            CheckboxList = driver.FindElements(By.ClassName("view"));

            int size = CheckboxList.Count();
            try
            {
                if (size == 1)
                {
                    IWebElement element = driver.FindElement(By.CssSelector("#todo-list > li > div > input"));
                    if (element.GetAttribute(task) == task)
                    {
                        element.Click();
                        //break;
                    }
                    //break;
                }
                else if (size > 1)
                {

                    for (int i = 1; i <= size; i++)
                    {

                        IWebElement element = driver.FindElement(By.CssSelector("#todo-list > li:nth-child(" + i + ") > div > input"));
                        IWebElement ele= driver.FindElement(By.CssSelector("#todo-list > li:nth-child(" + i + ") > div > label"));
                        string text = element.Text.ToString();
                        if (ele.Text == task)
                        {
                            element.Click();
                            //break;
                        }

                    }
                }
                Reports.ToDoMvcReport.test.Pass("Element Found");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to find elements " + ex);
                Reports.ToDoMvcReport.test.Fail("Unable to Find the Element " + ex);
                Helpers.Screenshots.TakeScreenshot(driver);
                //Reports.ToDoMvcReport.test.Error("Error" + MediaEntityBuilder.CreateScreenCaptureFromPath(Helpers.Screenshots.TakeScreenshot(driver)).Build());
            }

        }

        public void clickOnCompletedtTask()
        {
            //Reports.ToDoMvcReport.test.Log(Status.Info, "public void clickOnCompletedtTask()");
            CheckboxList = driver.FindElements(By.ClassName("view"));


            int size = CheckboxList.Count();
            try
            {
                if (size == 1)
                {
                    IWebElement element = driver.FindElement(By.CssSelector("#todo-list > li > div > input"));
                    element.Click();
                }
                else if (size > 1)
                {

                    for (int i = 1; i <= size - 1; i++)
                    {

                        IWebElement element = driver.FindElement(By.CssSelector("#todo-list > li:nth-child(" + i + ") > div > input"));
                        element.Click();

                    }
                }
                Reports.ToDoMvcReport.test.Pass("Element Found");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Unable to find elements " + ex);
                Reports.ToDoMvcReport.test.Fail("Unable to Find the Element "+ex);
                Helpers.Screenshots.TakeScreenshot(driver);
                //Reports.ToDoMvcReport.test.Error("Error "+ex + MediaEntityBuilder.CreateScreenCaptureFromPath(Helpers.Screenshots.TakeScreenshot(driver)).Build());
            }
            
        }

        public void clickOnCompletedtTask(string task)
        {
            //Reports.ToDoMvcReport.test.Log(Status.Info, "public void clickOnCompletedtTask()");
            CheckboxList = driver.FindElements(By.ClassName("view"));


            int size = CheckboxList.Count();
            try
            {
                if (size == 1)
                {
                    IWebElement element = driver.FindElement(By.CssSelector("#todo-list > li > div > input"));
                    if (element.Text == task)
                    {
                        element.Click();
                        //break;
                    }
                }
                else if (size > 1)
                {

                    for (int i = 1; i <= size - 1; i++)
                    {

                        IWebElement element = driver.FindElement(By.CssSelector("#todo-list > li:nth-child(" + i + ") > div > input"));
                        if (element.Text == task)
                        {
                            element.Click();
                            //break;
                        }

                    }
                }
                Reports.ToDoMvcReport.test.Pass("Element Found");
            }

            catch (Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Unable to Find the Element " + ex);
                Helpers.Screenshots.TakeScreenshot(driver);
                //Reports.ToDoMvcReport.test.Error("Error "+ex + MediaEntityBuilder.CreateScreenCaptureFromPath(Helpers.Screenshots.TakeScreenshot(driver)).Build());
            }

        }


    }
}
