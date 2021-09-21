/*
 * Project: Using Myntra Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   15/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyntraDemoTestProjectUsingSelenium.Pages
{
    public class SearchPage
    {
        //using the Page factory
        public SearchPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //searching the items from myntra using findsby method
        [FindsBy(How = How.XPath, Using = "//input[@class='desktop-searchBar']")]
        [CacheLookup]
        public IWebElement searchbar;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'product-productMetaInfo'][1]")]
        [CacheLookup]
        public IWebElement Product;

        
    }
}
