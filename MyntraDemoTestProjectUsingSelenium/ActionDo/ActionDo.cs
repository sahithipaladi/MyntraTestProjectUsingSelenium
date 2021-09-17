/*
 * Project: Using Myntra Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   15/09/2021
 */
using MyntraDemoTestProjectUsingSelenium.Pages;
using NUnit.Framework;
using OpenQA.Selenium;


namespace MyntraDemoTestProjectUsingSelenium.ActionDo
{
    public class ActionDo
    {
        //Asserting the title
        public static LoginPage login;
        public static void AssertAfterLauching(IWebDriver driver)
        {
            string title1 = "Online Shopping for Women, Men, Kids Fashion & Lifestyle - Myntra";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        //checking Login feature  into myntra
        public static void LoginToMyntra(IWebDriver driver)
        {
            login = new LoginPage(driver);

            login.profileButton.Click();
            System.Threading.Thread.Sleep(5000);

            login.signButton.Click();
            System.Threading.Thread.Sleep(5000);

            login.mobileNumber.SendKeys("6302921479");
            System.Threading.Thread.Sleep(1000);

            login.CONTINUEButton.Click();
            System.Threading.Thread.Sleep(12000);
        }
        //checking the Search Feature
        public static SearchPage search;

        public static void SearchintoMyntra(IWebDriver driver)
        {
            search = new SearchPage(driver);
            search.searchbar.SendKeys("Dresses for woman");
            System.Threading.Thread.Sleep(10000);
            search.searchbar.SendKeys(Keys.ArrowDown);
            search.searchbar.SendKeys(Keys.Enter);
        }

        public static AddToBagPage addToBag;

        //checking the AddToBag Feature
        public static void AddToBagFeature(IWebDriver driver)
        {
            addToBag = new AddToBagPage(driver);
            addToBag.addtobagbutton.Click();
            System.Threading.Thread.Sleep(10000);
        }
       //checking the TakeScreenShot method
        public static  void TakeScreenshot1(IWebDriver driver)
        {

            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\sahithi.p\source\repos\MyntraDemoTestProjectUsingSelenium\MyntraDemoTestProjectUsingSelenium\Screenshot\.jpg");
            System.Threading.Thread.Sleep(1000);
        }


    }
    }

