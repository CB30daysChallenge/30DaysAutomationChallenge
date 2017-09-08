using _30DaysAutomationChallenge.Helpers;
using _30DaysAutomationChallenge.POM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace _30DaysAutomationChallenge.StepDefinitions
{
    [Binding]
    public sealed class FeatureStepDefinition
    {
        //private static IWebDriver driver = ScenarioContext.Current.Get<IWebDriver>();
        public static IWebDriver driver = Helpers.Drivers.GetDriver();


        ToDoMvcPage toDoMvcPage = new ToDoMvcPage(driver);



        [Given(@"I am on the ToDoMvc AngularJS Page")]
        public void GivenIAmOnTheToDoMvcAngularJSPage()
        {


            toDoMvcPage.OpenPage();

        }

        [When(@"I Click on the All")]
        public void WhenIClickOnTheAll()
        {
            toDoMvcPage.ClickAllButton();
        }

        [Then(@"allautomation are displayed")]
        public void ThenAllautomationAreDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I Click on the Completed")]
        public void WhenIClickOnTheCompleted()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"completedUS Racing are displayed")]
        public void ThenCompletedUSRacingAreDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I Click on the Active")]
        public void WhenIClickOnTheActive()
        {
            toDoMvcPage.ClickActiveButton();
        }

        [When(@"I Enter a New (.*)")]
        public void WhenIEnterANew(string Task)
        {
            toDoMvcPage.CreateTask(Task);
        }

        [When(@"I Enter New tasks")]
        public void WhenIEnterNewTasks(Table table)
        {

            var listOfTasks = table.CreateSet<Task>();
            ScenarioContext.Current.Set(listOfTasks);

            foreach (var tsk in listOfTasks)
            {
                toDoMvcPage.CreateTask(tsk.Tasks.ToString());
                toDoMvcPage.enter();

            }


        }

        [Then(@"active(.*) are displayed")]
        public void ThenActiveAreDisplayed(string task)
        {

            string value = toDoMvcPage.GetTask(task);
            try
            {
                Assert.AreEqual(task, value);
            }
            catch (Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Test Failed " + ex);
            }

        }
        [When(@"I click on the checkbox of one of the tasks")]
        public void WhenIClickOnTheCheckboxOfOneOfTheTasks()
        {

            toDoMvcPage.ClickOnActiveTask();

        }

        [Then(@"all entered tasks are displayed")]
        public void ThenAllEnteredTasksAreDisplayed()
        {

            var tskList = ScenarioContext.Current.Get<IEnumerable<Task>>();
            try
            {
                foreach (var tsk in tskList)
                {
                    string task = toDoMvcPage.GetTask(tsk.Tasks);
                    Assert.AreEqual(tsk.Tasks, task);

                }
            }
            catch (Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Test Failed " + ex);
            }
            }


        [When(@"I click on Checkbox of Acive (.*)")]
        public void WhenIClickOnCheckboxOfAcive(string task)
        {
            toDoMvcPage.ClickOnActiveTask();
            
        }

        [When(@"I Click on the Complete")]
        public void WhenIClickOnTheComplete()
        {
            toDoMvcPage.ClickCompletedButton();
            
        }

        [Then(@"the (.*) is displayed on the Completed List")]
        public void ThenTheIsDisplayedOnTheCompletedList(string task)
        {
            string value = toDoMvcPage.GetTask(task);
            try
            {
                Assert.AreEqual(task, value);
               
            }
            catch (Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Test Failed " + ex);
            }



        }

        [When(@"I press Enter")]
        public void WhenIPressEnter()
        {
            toDoMvcPage.enter();
        }

        [Then(@"the new (.*) is populated on the List")]
        public void ThenTheNewIsPopulatedOnTheList(string task)
        {
            string value = toDoMvcPage.GetTask(task);
            try
            {
                Assert.AreEqual(task, value);
               
            }
            catch (Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Test Failed " + ex);
            }
        }

        [When(@"click on Completed (.*)")]
        public void WhenClickOnCompleted(string task)
        {
           

            toDoMvcPage.clickOnCompletedtTask();
            
        }

        [When(@"I click on Checkbox of one of Acive tasks")]
        public void WhenIClickOnCheckboxOfOneOfAciveTasks(Table table)
        {
            var tskList = ScenarioContext.Current.Get<IEnumerable<Task>>();
            foreach (var tsk in tskList)
            {
                string task = toDoMvcPage.GetTask(tsk.Tasks);

            }
        }


        [When(@"I click on Checkbox of '(.*)' one of Acive tasks")]
        public void WhenIClickOnCheckboxOfOneOfAciveTasks(string task)
        {
            var tskList = ScenarioContext.Current.Get<IEnumerable<Task>>();
            foreach (var tsk in tskList)
            {
                if (tsk.Tasks.Equals(task))
                {
                    toDoMvcPage.ClickOnActiveTask(task);

                }
            }
        }


        [When(@"click on Checkbox one of the Completed tasks")]
        public void WhenClickOnCheckboxOneOfTheCompletedTasks(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        [When(@"click on Checkbox of '(.*)'one of the Completed tasks")]
        public void WhenClickOnCheckboxOfOneOfTheCompletedTasks(string task)
        {
            var tskList = ScenarioContext.Current.Get<IEnumerable<Task>>();
            foreach (var tsk in tskList)
            {
                if (tsk.Tasks.Equals(task))
                {
                    toDoMvcPage.clickOnCompletedtTask(task);

                }
            }
        }

        [When(@"I Click on the ClearCompleted")]
        public void WhenIClickOnTheClearCompleted()
        {
            toDoMvcPage.ClickClearAllButton();
        }



        [Then(@"only (.*) is Displayed")]
        public void ThenOnlyIsDisplayed(string task2)
        {
            

            string value = toDoMvcPage.GetTask(task2);
            try
            {
                Assert.AreEqual(task2, value);
            }
            catch(Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Test Failed "+ex);
            }
            
        }

        [Then(@"only '(.*)' is Displayed  in")]
        public void ThenOnlyIsDisplayedIn(string task)
        {
            var tskList = ScenarioContext.Current.Get<IEnumerable<Task>>();
            foreach (var tsk in tskList)
            {
                if (tsk.ToString() == task)
                {
                   string value= toDoMvcPage.GetTask(task);
                    Assert.AreEqual(task, value);

                }
            }
        }

        [Then(@"(.*) is not Displayed")]
        public void ThenIsNotDisplayed(string task1)
        {
            string value = toDoMvcPage.GetTask(task1);
            try
            {
                Assert.AreNotEqual(task1, null);

            }
            catch(Exception ex)
            {
                Reports.ToDoMvcReport.test.Fail("Test Failed "+ex);
            }
            

        }
        [Then(@"(.*) and (.*) are Displayed")]
        public void ThenAndAreDisplayed(string task1, string task2)
        {
            string value1 = toDoMvcPage.GetTask(task1);
            string value2 = toDoMvcPage.GetTask(task2);
            Assert.AreEqual(task1, value1);
            Assert.AreEqual(task2, value2);
        }


    }
}
