using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysAutomationChallenge.Helpers
{
    public class Screenshots
    {
        public static string TakeScreenshot(IWebDriver driver)
        {
            string id = Guid.NewGuid().ToString();
            string fileName = Constants.GlobalConstants.ReportingFolder+id+".png";
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            //string finalPath=pth.Substring(0,pth.LastIndexOf("bin"))+sscreenShotName+".png";
            //string localPath = new Uri(finalPath).LocalPath;
            //ss.SaveAsFile(localPath, ScreenshotImageFormat.Png);
            //return localPath;
            ss.SaveAsFile(fileName, ScreenshotImageFormat.Png);
            Console.WriteLine($"SCREENSHOT[ file:///{fileName} ]SCREENSHOT");
            return fileName;
        }
    }
}
