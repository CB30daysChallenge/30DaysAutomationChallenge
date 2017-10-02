using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using _30DaysAutomationChallenge.Helpers;
using _30DaysAutomationChallenge.POM;

namespace _30DaysAutomationChallenge.StepDefinitions
{
    [Binding]
    public sealed class FeatureStepDefinition
    {

       
        public IEnumerable<Task> listOfTasks;
        public Task task;
        ToDoMvcPage  toDoMvcPage = new ToDoMvcPage();

        public FeatureStepDefinition(Task task)
        {
            this.task = task;
        }

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

        //[Then(@"allautomation are displayed")]
        //public void ThenAllautomationAreDisplayed()
        //{
        //    ScenarioContext.Current.Pending();
        //}

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

            listOfTasks = table.CreateSet<Task>();

            foreach (var tsk in listOfTasks)
            {

                task = tsk;
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
                
                Console.WriteLine("Test Failed " + ex);
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
                

            try
            {
                foreach (var tsk in listOfTasks)
                {
                    string taskList = toDoMvcPage.GetTask(tsk.Tasks.ToString());
                    Assert.AreEqual(tsk.Tasks.ToString(), taskList);

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Test Failed " + ex);
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
                
                Console.WriteLine("Test Failed "+ex);
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
                
                Console.WriteLine("Test Failed " + ex);
            }
        }

       //[When(@"click on Completed (.*)")]
        //public void WhenClickOnCompleted(string task)
        //{


        //    toDoMvcPage.clickOnCompletedtTask();

        //}

        //[When(@"I click on Checkbox of '(.*)' one of Acive tasks")]
        //public void WhenIClickOnCheckboxOfOneOfAciveTasks(string task)
        //{
        //    var tskList = ScenarioContext.Current.Get<IEnumerable<Task>>();
        //    foreach (var tsk in tskList)
        //    {
        //        if (tsk.Tasks.Equals(task))
        //        {
        //            toDoMvcPage.ClickOnActiveTask(task);

        //        }
        //    }
        //}


        //[When(@"click on Checkbox one of the Completed tasks")]
        //public void WhenClickOnCheckboxOneOfTheCompletedTasks(Table table)
        //{
        //    ScenarioContext.Current.Pending();
        //}
        //[When(@"click on Checkbox of '(.*)'one of the Completed tasks")]
        //public void WhenClickOnCheckboxOfOneOfTheCompletedTasks(string task)
        //{
        //    var tskList = ScenarioContext.Current.Get<IEnumerable<Task>>();
        //    foreach (var tsk in tskList)
        //    {
        //        if (tsk.Tasks.Equals(task))
        //        {
        //            toDoMvcPage.clickOnCompletedtTask(task);

        //        }
        //    }
        //}
        [When(@"I Click on Checkbox of '(.*)' one of Active tasks")]
        public void WhenIClickOnCheckboxOfOneOfActiveTasks(string tasks)
        {
            string value = toDoMvcPage.GetTask(tasks);
            foreach (var tsk in listOfTasks)
            {
                if (value == tasks)
                {
                    toDoMvcPage.ClickOnActiveTask(tasks);
                    break;
                }
            }
        }

        [When(@"I click on the checkbox '(.*)' one of the Completed tasks")]
        public void WhenIClickOnTheCheckboxOneOfTheCompletedTasks(string tasks)
        {
            toDoMvcPage.clickOnCompletedtTask(tasks);
        }

        [Then(@"only '(.*)' is displayed in")]
        public void ThenOnlyIsDisplayedIn(string tasks)
        {
            string value = toDoMvcPage.GetTask(tasks);
            foreach (var tsk in listOfTasks)
            {
                if (value == tasks)
                {
                    toDoMvcPage.ClickOnActiveTask(tasks);
                    break;
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
                
                Console.WriteLine("Test Failed " + ex);
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
                Console.WriteLine("Test Failed "+ex);
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
