/*
 * Project: Using Myntra Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   15/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyntraDemoTestProjectUsingSelenium.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //used to find the profile button by speifying its locator
        [FindsBy(How = How.XPath, Using = "//span[@class = 'desktop-userTitle']")]
        [CacheLookup]
        public IWebElement profileButton;

        //used to find the signin button by speifying its locator
        [FindsBy(How = How.XPath, Using = "//div[@class = 'desktop-getUserInLinks desktop-getInLinks']")]
        [CacheLookup]
        public IWebElement signButton;

        //used to find the element mobilenumber by speifying its locator
        [FindsBy(How = How.XPath , Using = "//input[@class='form-control mobileNumberInput']")]
        [CacheLookup]
        public IWebElement mobileNumber;

        //used to find the continue button by speifying its locator
        [FindsBy(How = How.XPath, Using = "//div[@class='submitBottomOption']")]
        [CacheLookup]
        public IWebElement CONTINUEButton;

    }
}