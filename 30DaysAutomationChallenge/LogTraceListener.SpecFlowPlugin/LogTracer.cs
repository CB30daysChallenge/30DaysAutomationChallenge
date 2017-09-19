using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Tracing;
using TechTalk.SpecFlow.Plugins;
using System.Globalization;
using TechTalk.SpecFlow.Bindings;
using TechTalk.SpecFlow.Bindings.Reflection;
using LogTraceListener.SpecFlowPlugin;
using System.IO;

[assembly: RuntimePlugin(typeof(LogTraceListener.SpecFlowPlugin.LogTraceListenerPlugin))]
namespace LogTraceListener.SpecFlowPlugin
{
    public class LogTraceListenerPlugin : IRuntimePlugin
    {

        public void Initialize(RuntimePluginEvents runtimePluginEvents, RuntimePluginParameters runtimePluginParameters)
        {
            runtimePluginEvents.CustomizeTestThreadDependencies += (sender, args) => { args.ObjectContainer.RegisterTypeAs<LogTracer, ITraceListener>(); };
        }
    }

    public class LogTracer : ITraceListener
    {
        public static string logMessage;
        public static string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
        public static string actualPath = path.Substring(0, path.LastIndexOf("bin"));
        public static string projectPath = new Uri(actualPath).LocalPath;
        public static string logPath = projectPath + "Reports\\LogFile.txt";
        //public static string reportPath = @"C:\AutomationProjects\30DaysAutomationChallenge\30DaysAutomationChallenge\30DaysAutomationChallenge\Reports\WriteLines.txt";
        //public StreamWriter outputFile = new StreamWriter(reportPath);
        public void WriteTestOutput(string message)
        {

            logMessage = message;
            using (StreamWriter outputFile = new StreamWriter(logPath, true))
            {

                outputFile.WriteLine(message);
                outputFile.Flush();
                outputFile.Close();
            }
            //Debug.WriteLine(message);
            //Console.WriteLine(message);
            //EventLog.WriteEntry("mysource", "output: " + message);
            //File.WriteAllText("myfile.txt", message);
        }
        public void WriteToolOutput(string message)
        {
            //File.WriteAllText("myfile.txt", message);
            using (StreamWriter outputFile = new StreamWriter(logPath,true))
            {

                outputFile.WriteLine(message);
                outputFile.Flush();
                outputFile.Close();
            }
            //Debug.WriteLine(message);
            //Console.WriteLine(message);
            //EventLog.WriteEntry("mysource", "specflow: " + message);
        }
    }


}


