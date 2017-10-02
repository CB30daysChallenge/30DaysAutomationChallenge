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
        public static string browserName = System.Configuration.ConfigurationManager.AppSettings["browser"];
        private ScenarioContext _scenarioContext;

        public void ShareDataWithContextInjectionSteps1(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            
        }

        [BeforeStep]
        public static void LogStep()
        {

        }

        [BeforeTestRun]
        public static void BeforeTest()
        {
            
            Helpers.Drivers.SetDriver(browserName);
        }
        [AfterTestRun]
        public static void AfterTest()
        {

            Helpers.Drivers.CloseDriver();

        }

    }
}
