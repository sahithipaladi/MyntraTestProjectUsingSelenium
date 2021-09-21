/*
 * Project: Using Myntra Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   15/09/2021
 */
using AventStack.ExtentReports;
using NUnit.Framework;


namespace MyntraDemoTestProjectUsingSelenium
{
    public class Tests : Base.BaseClass
    {
        ExtentReports report = Reports.report();
        ExtentTest test;
        //Testing for loginintomyntra
        [Test, Order(0)]
        public void Inputmobilenumber()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "MYNTRAAUTOMATION");
            ActionDo.ActionDo.AssertAfterLauching(driver);
            ActionDo.ActionDo.LoginToMyntra(driver);


            test.Log(Status.Pass, "TestCases Passed");
            report.Flush();
        }

        //Testing for SearchinganItem
        [Test, Order(1)]
        public void SearchinganItem()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "MYNTRAAUTOMATION");
            ActionDo.ActionDo.SearchintoMyntra(driver);
            test.Log(Status.Pass, "TestCases Passed");
            Pages.Searchingaproductbrandname.ProductBrand(driver);
            test.Log(Status.Pass, "ProductBrand TestCases Passed");
            report.Flush();

        }
        //[Test, Order(2)]

        //public void AddToBag()
        //{
        //    test = report.CreateTest("Tests");
        //    test.Log(Status.Info, "MYNTRAAUTOMATION");
        //    ActionDo.ActionDo.AddToBagFeature(driver);
        //    test.Log(Status.Pass, "AddToBag TestCases Passed");
        //    report.Flush();

        //}

        //testing for TakeScreenshot

        [Test]

        public void TakeScreenshot()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "MYNTRAAUTOMATION");
            ActionDo.ActionDo.TakeScreenshot1(driver);
            test.Log(Status.Pass, "TestCases Passed");
            report.Flush();
        }

    }
}
