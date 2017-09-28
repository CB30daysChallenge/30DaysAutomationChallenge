using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace _30DaysAutomationChallenge.Reports
{
    public static class ToDoMvcReport
    {
        public static ExtentReports extent;
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentTest test;
        public static string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
        public static string actualPath = path.Substring(0, path.LastIndexOf("bin"));
        public static string projectPath = new Uri(actualPath).LocalPath;
        public static string reportPath = projectPath + "Reports\\ToDoMvcReport.html";
        

        public static void SetupReport()
        {

            extent = new ExtentReports();
            htmlReporter = new ExtentHtmlReporter(reportPath);
            htmlReporter.Configuration().Theme = Theme.Dark;
            htmlReporter.Configuration().DocumentTitle = "ToDoMvc Report";
            htmlReporter.Configuration().ReportName = "ToDoNMvc Report";
            extent.AttachReporter(htmlReporter);
           

        }


    }
}
