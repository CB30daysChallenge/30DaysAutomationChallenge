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

        public void WriteTestOutput(string message)
        {

            logMessage = message;
            Console.WriteLine(message);
            //using (StreamWriter outputFile = new StreamWriter(logPath, true))
            //{

            //    //outputFile.WriteLine(message);
            //    //outputFile.Flush();
            //    //outputFile.Close();
            //    Console.WriteLine(message);
            //}

        }
        public void WriteToolOutput(string message)
        {
            Console.WriteLine(message);
            //using (StreamWriter outputFile = new StreamWriter(logPath,true))
            //{

            //    //outputFile.WriteLine(message);
            //    //outputFile.Flush();
            //    //outputFile.Close();
            ////    Console.WriteLine(message);
            //}

        }
    }


}


