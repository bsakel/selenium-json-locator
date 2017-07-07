using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_json_locator
{
    //{
    //	"fooText": {
    //		"locator": "#foo input.texty",
    //		"type": "css"
    //	},
    //	"fooButton": {
    //		"locator": "#foo input[type='button']",
    //		"type": "css"
    //	}
    //}

    public class CustomBy : By
    {
        public CustomBy(string jsonString)
        {


            //FindElementMethod = (ISearchContext context) =>
            //{
            //    IWebElement mockElement = context.FindElement(By.XPath("//img[@src='" + imageByString + "']"));
            //    return mockElement;
            //};

            //FindElementsMethod = (ISearchContext context) =>
            //{
            //    ReadOnlyCollection<IWebElement> mockElements = context.FindElements(By.XPath("//img[@src='" + imageByString + "']"));
            //    return mockElements;
            //};
        }
    }
}
