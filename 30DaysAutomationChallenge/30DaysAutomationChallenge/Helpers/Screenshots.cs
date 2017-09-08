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
            string fileName = Constants.GlobalConstants.ReportingFolder+".png";
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(fileName, ScreenshotImageFormat.Png);
            return fileName;
        }
    }
}
