using OpenQA.Selenium;
using System;
using System.Collections.Generic;


namespace MyntraDemoTestProjectUsingSelenium.Pages
{
    public class Searchingaproductbrandname : Base.BaseClass
    {
        public static void ProductBrand(IWebDriver driver)
        {

            IList<IWebElement> productbrand = driver.FindElements(By.XPath("//*[@class='product-brand']"));
            foreach (IWebElement productbrandname in productbrand)
            {
                string brandname = productbrandname.Text;
                Console.WriteLine(brandname);
            }
        }
    }
}
