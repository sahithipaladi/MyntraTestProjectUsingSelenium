/*
 * Project: Using Myntra Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   15/09/2021
 */
using log4net;
using log4net.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace MyntraDemoTestProjectUsingSelenium.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;
       
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());
        //giving the url and setting up the process
        [SetUp]
        public void Setup()
        {
            var fileInfo = new FileInfo(@"App.config");

            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);

            log.Info("Entering Setup");
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-notifications");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.myntra.com/";
            log.Debug("navigating to url");

            log.Info("Exiting setup");

            

            //Implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);



            //Explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(500));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        
        


        //Closing the page 
        [TearDown]
        public void TearDown()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);
            driver.Quit();
        }

        
    }
}
