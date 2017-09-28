using _30DaysAutomationChallenge.POM;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using BoDi;
using OpenQA.Selenium;
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
        //DriverContext driverContext = new DriverContext();
        public static string browserName = System.Configuration.ConfigurationManager.AppSettings["browser"];
        //public IWebDriver driver;
        //Helpers.Drivers driver = new Helpers.Drivers();

        private ScenarioContext _scenarioContext;
        private readonly IObjectContainer _objectContainer;


        //[BeforeFeature]
        //public static void BeforeFeature()
        //{
        //    //Reports.ToDoMvcReport.SetupReport();
        //}

        public void ShareDataWithContextInjectionSteps1(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            //Reports.ToDoMvcReport.SetupReport();
        }

        //[BeforeScenario]
        //public void BeforeScenario()
        //{
        //    Reports.ToDoMvcReport.SetupReport();
        //    driver.SetDriver(browserName);
        //    //Helpers.Drivers.SetDriver(browserName);
        //    //driver.SetDriver(browserName);


        //    ////TODO: implement logic that has to run before executing each scenario
        //    ////Reports.ToDoMvcReport.test =  Reports.ToDoMvcReport.extent.CreateTest("Running Scenario-->" + ScenarioContext.Current.ScenarioInfo.Title +StepDefinitions.FeatureStepDefinition.browserName);
        //    ////Reports.ToDoMvcReport.test = Reports.ToDoMvcReport.extent.CreateTest("Running Scenario-->"  + StepDefinitions.FeatureStepDefinition.browserName);
        //    //Reports.ToDoMvcReport.test = Reports.ToDoMvcReport.extent.CreateTest("Running Scenario-->" + browserName);


        //}

        //[BeforeScenario]
        //public static void BeforeScenario()
        //{
        //    //Reports.ToDoMvcReport.SetupReport();
        //    ////Helpers.Drivers.SetDriver(browserName);
        //    //Helpers.Drivers.goToUrl();
      




        //    //TODO: implement logic that has to run before executing each scenario
        //    //Reports.ToDoMvcReport.test =  Reports.ToDoMvcReport.extent.CreateTest("Running Scenario-->" + ScenarioContext.Current.ScenarioInfo.Title +StepDefinitions.FeatureStepDefinition.browserName);
        //    //Reports.ToDoMvcReport.test = Reports.ToDoMvcReport.extent.CreateTest("Running Scenario-->"  + StepDefinitions.FeatureStepDefinition.browserName);
        //    Reports.ToDoMvcReport.test = Reports.ToDoMvcReport.extent.CreateTest("Running Scenario-->" + browserName);


        //}
        //[BeforeStep]
        //public  void LogStep()
        //{
        //    //Reports.ToDoMvcReport.test.Log(Status.Info,Reports.LogTrace.LastGherkinMessage);
        //    //S.Info(Reports.LogTrace.LastGherkinMessage);
        //    //string value = ScenarioContext.Current.ScenarioInfo.ToString();
        //    //Reports.ToDoMvcReport.test.Log(Status.Info,value);
        //}
        [BeforeStep]
        public static void LogStep()
        {
            //Reports.ToDoMvcReport.test.Log(Status.Info,Reports.LogTrace.LastGherkinMessage);
            //S.Info(Reports.LogTrace.LastGherkinMessage);
            //string value = ScenarioContext.Current.ScenarioInfo.ToString();
            //Reports.ToDoMvcReport.test.Log(Status.Info,value);
        }


        //[AfterScenario]
        //public void AfterScenario()
        //{

        //    //Reports.ToDoMvcReport.extent.Flush();
        //    //_driver.Close();
        //    //var driver = _scenarioContext.GetBindingInstance(_driver);
        //    driver.CloseDriver();


        //}

        //[AfterScenario]
        //public void AfterScenario()
        //{

        //    //Reports.ToDoMvcReport.extent.Flush();
        //    //Helpers.Drivers.CloseDriver();
        //    driver.CloseDriver();

        //}
        //[BeforeTestRun]
        //public void BeforeTest()
        //{
        //    //Reports.ToDoMvcReport.SetupReport();
        //    driver.SetDriver(browserName);
        //}


        [BeforeTestRun]
        public static void BeforeTest()
        {
            Reports.ToDoMvcReport.SetupReport();
            Helpers.Drivers.SetDriver(browserName);
        }
        [AfterTestRun]
        public static void AfterTest()
        {
            Reports.ToDoMvcReport.extent.Flush();
            ////Helpers.Drivers.CloseDriver();
            ////DriverContext driverContext = new DriverContext();
            ////driverContext.CloseDriverContext();
            ////DriverContext.CloseDriverContext();
            Helpers.Drivers.CloseDriver();

        }
        //[AfterTestRun]
        //public void AfterTest()
        //{
        //    Reports.ToDoMvcReport.extent.Flush();
        //    driver.CloseDriver();
        //    //DriverContext driverContext = new DriverContext();
        //    //driverContext.CloseDriverContext();
        //    //DriverContext.CloseDriverContext();

        //}
    }
}
