using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QATest.PageObjects
{
    public class SearchPage
    {

        public SearchPage()
        {

        }

        public IWebElement GetOption(IWebDriver _driver)
        {
            return _driver.FindElement(By.Id("bline"));
        }

        public IWebElement GetSearchButton01(IWebDriver _driver)
        {
            return _driver.FindElements(By.XPath("//i[@class='fas fa-search']"))[0];
            //return _driver.FindElements(By.XPath("//button[@class ='button wex-search-group-button ge-click-button']"))[1];
        }

        public IWebElement GetSearchButton02(IWebDriver _driver)
        {
            return _driver.FindElements(By.XPath("//i[@class='fas fa-search']"))[1];
            //return _driver.FindElements(By.XPath("//button[@class ='button wex-search-group-button ge-click-button']"))[1];
        }

        public IWebElement GetSearchBox(IWebDriver _driver)
        {
            return _driver.FindElement(By.Id("s"));
        }

        public IWebElement GetOptionSearchCriteriaActive(IWebDriver _driver)
        {
            return _driver.FindElement(By.XPath("//li[@class='tabs-title is-active']//a[contains(text(),'Corporate Payments')]"));
        }

        public IWebElement GetMessageNoResults(IWebDriver _driver)
        {
            return _driver.FindElement(By.XPath("//p[contains(text(),'Sorry, there are no results that meet this criteria.')]"));
        }

        public IWebElement GetNextButton(IWebDriver _driver)
        {
            return _driver.FindElement(By.XPath("//a[contains(text(),'Next')]"));
        }

        public IWebElement GetNextPage(IWebDriver _driver)
        {
            return _driver.FindElement(By.XPath("//span[@class=' current']"));
        }

        public IWebElement GetPreviousButton(IWebDriver _driver)
        {
            return _driver.FindElement(By.XPath("//a[contains(text(),'Previous')]"));
        }

        public IWebElement GetPreviousPage(IWebDriver _driver)
        {
            return _driver.FindElement(By.XPath("//span[@class=' current']"));
        }

        public IWebElement GetLinkTitle(IWebDriver _driver, string text)
        {
            string linkTitle = "//a[contains(text(),'" + text + "')]";

            return _driver.FindElement(By.XPath(linkTitle));
        }

        public IWebElement GetTitle(IWebDriver _driver, string text)
        {
            string title = "//h1[contains(text(),'" + text + "')]";

            return _driver.FindElement(By.XPath(title));
        }

        public IWebElement GetReadMore(IWebDriver _driver)
        {
            return _driver.FindElements(By.XPath("//a[contains(text(),'... Read more »')]"))[0];
        }

    }
}
