//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TechTalk.SpecFlow.Tracing;

//namespace _30DaysAutomationChallenge.Reports
//{
//    public class LogTrace : ITraceListener
//    {
//        public static string LastGherkinMessage;
//        public void WriteTestOutput(string message)
//        {

//            LastGherkinMessage = message;
//            Console.WriteLine(message);
//            EventLog.WriteEntry("mysource", "output: " + message);
//        }
//        public void WriteToolOutput(string message)
//        {
//            Console.WriteLine(message);
//            EventLog.WriteEntry("mysource", "specflow: " + message);
//        }
//    }
//}
