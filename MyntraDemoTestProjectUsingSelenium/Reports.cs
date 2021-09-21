/*
 * Project: Using Myntra Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   18/09/2021
 */
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace MyntraDemoTestProjectUsingSelenium
{
   public  class Reports
    {
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;
        public static ExtentTest test;



        public static ExtentReports report()
        {
            if (extent == null)
            {
                string reportPath = @"C:\Users\sahithi.p\source\repos\MyntraDemoTestProjectUsingSelenium\MyntraDemoTestProjectUsingSelenium\MyntraReports\MyntraReportsCollection.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("UserName", "sahithi");
                extent.AddSystemInfo("ProviderName", "sahithi");
                extent.AddSystemInfo("Domain", "QA");
                extent.AddSystemInfo("ProjectName", "Myntra Automation");




                //giving the config file path
                string conifgPath = @"C:\Users\sahithi.p\source\repos\MyntraDemoTestProjectUsingSelenium\MyntraDemoTestProjectUsingSelenium\ReportsCollection.xml";
                htmlReporter.LoadConfig(conifgPath);






            }
            return extent;
        }

    }
}
