/*
 * Project: Using Myntra Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   15/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace MyntraDemoTestProjectUsingSelenium.Pages
{
    //using the Page factory
    public class AddToBagPage
    {
        public AddToBagPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

       //adding the items into bag  from myntra using findsby method

        [FindsBy(How = How.XPath, Using = "//span[@class='myntraweb-sprite pdp-whiteBag sprites-whiteBag pdp-flex pdp-center']")]
        [CacheLookup]
        public IWebElement addtobagbutton;
    }
}