using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace _30DaysAutomationChallenge.SpecflowHooks
{
    [Binding]
    public sealed class SpecflowHooks
    {

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks


        [BeforeFeature]
        public static void BeforeFeature()
        {
            //Reports.ToDoMvcReport.SetupReport();
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            
            //TODO: implement logic that has to run before executing each scenario
            Reports.ToDoMvcReport.test =  Reports.ToDoMvcReport.extent.CreateTest("Running Scenario-->" + ScenarioContext.Current.ScenarioInfo.Title);


        }
        [BeforeStep]
        public static void LogStep()
        {
            //Reports.ToDoMvcReport.test.Log(Status.Info,Reports.LogTrace.LastGherkinMessage);
            //S.Info(Reports.LogTrace.LastGherkinMessage);
            //string value = ScenarioContext.Current.ScenarioInfo.ToString();
            //Reports.ToDoMvcReport.test.Log(Status.Info,value);
        }
        
       
        [AfterScenario]
        public static void AfterScenario()
        {
            


        }
        [BeforeTestRun]
        public static void BeforeTest()
        {
            Reports.ToDoMvcReport.SetupReport();
        }
        [AfterTestRun]
        public static void AfterTest()
        {
            Reports.ToDoMvcReport.extent.Flush();
            Helpers.Drivers.CloseDriver();
  
        }
    }
}
