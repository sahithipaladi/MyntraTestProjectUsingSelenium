/*
 * Project: Using Myntra Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   15/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyntraDemoTestProjectUsingSelenium
{
    public class Tests : Base.BaseClass
    {
        [Test, Order(0)]
        public void Inputmobilenumber()
        {
            ActionDo.ActionDo.AssertAfterLauching(driver);

            ActionDo.ActionDo.LoginToMyntra(driver);
        }
        [Test, Order(1)]
        public void SearchinganItem()
        {

            ActionDo.ActionDo.SearchintoMyntra(driver);

        }
        //[Test,Order(2)]

        //public void AddToBag()
        //{
            
        //    ActionDo.ActionDo.AddToBagFeature(driver);

        //}
        [Test]

        public void TakeScreenshot()
        {
           
            ActionDo.ActionDo.TakeScreenshot1(driver);
        }
    }
}
