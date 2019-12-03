using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using QATest.StepDefinitions;

namespace QATest
{
    [TestClass]
    public class QATestTestCases
    {

        private IWebDriver _driver;
        private SearchFeatureSteps steps;

        public QATestTestCases()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            _driver = new ChromeDriver(options);
            steps = new SearchFeatureSteps();


        }
        
        [TestMethod] //Validate the Filter Search Results by Category
        public void Scenario_01()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.SelectTheDropdownOption(_driver, "Corporate Payments");
            steps.ClickOnTheSearchButton02(_driver);
            steps.VerifyTheSearchResults(_driver);

        }

        [TestMethod] //Validate the Filter Search Results by Search Term
        public void Scenario_02()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.InputSearchTerm(_driver, "Corporate");
            steps.ClickOnTheSearchButton02(_driver);

        }

        [TestMethod] //Validate the Filter Search Results by Category and Search Term
        public void Scenario_03()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.SelectTheDropdownOption(_driver, "Corporate Payments");
            steps.InputSearchTerm(_driver, "Corporate");
            steps.ClickOnTheSearchButton02(_driver);
            steps.VerifyTheSearchResults(_driver);
        }

        [TestMethod] //Validate the Search by Exact Match Search Term
        public void Scenario_04()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.InputSearchTerm(_driver, "The Future for Mobile Wallets and B2B Corporate Payment Systems");
            steps.ClickOnTheSearchButton02(_driver);
        }

        [TestMethod] //Validate the Search by Similar Match Search Term
        public void Scenario_05()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.InputSearchTerm(_driver, "Mobile Wallets");
            steps.ClickOnTheSearchButton02(_driver);
        }

        [TestMethod] //Validate the Search by Search Term Without Results
        public void Scenario_06()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.InputSearchTerm(_driver, "XYZ");
            steps.ClickOnTheSearchButton02(_driver);
            steps.CheckMessageNoResults(_driver);
        }

        [TestMethod] //Validate the Search Term with Alphanumeric Characters
        public void Scenario_07()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.InputSearchTerm(_driver, "B2B Corporate Payment Systems");
            steps.ClickOnTheSearchButton02(_driver);
        }

        [TestMethod] //Validate the Search Term with Special Characters
        public void Scenario_08()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.InputSearchTerm(_driver, "What’s New in Corporate Business Traveller Booking?");
            steps.ClickOnTheSearchButton02(_driver);
        }


        [TestMethod] //Validate the Search Clicking the Search Button
        public void Scenario_09()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.InputSearchTerm(_driver, "Corporate Payment");
            steps.ClickOnTheSearchButton02(_driver);
        }

        [TestMethod] //Validate the Search Clicking the Search Button
        public void Scenario_10()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.InputSearchTerm(_driver, "Corporate Payment");
            steps.PressEnterOnTheKeyboard(_driver);
        }

        [TestMethod] //Validate the "Next" button
        public void Scenario_11()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.InputSearchTerm(_driver, "Corporate Payment");
            steps.ClickOnTheSearchButton02(_driver);
            steps.ClickOnTheNextPageButton(_driver);
        }

        [TestMethod] //Validate the "Previous" button
        public void Scenario_12()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.InputSearchTerm(_driver, "Corporate Payment");
            steps.ClickOnTheSearchButton02(_driver);
            steps.ClickOnTheNextPageButton(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            steps.ClickOnThePreviousPageButton(_driver);
        }

        [TestMethod] //Validate the Navigation Between Pages
        public void Scenario_13()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.InputSearchTerm(_driver, "Corporate Payment");
            steps.ClickOnTheSearchButton02(_driver);
            steps.ClickOnTheNextPageButton(_driver);
        }

        [TestMethod] //Validate the Link Title button
        public void Scenario_14()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.InputSearchTerm(_driver, "The Future for Mobile Wallets and B2B Corporate Payment Systems");
            steps.ClickOnTheSearchButton02(_driver);
            steps.ClickOnTheLinkTitlePage(_driver, "The Future for Mobile Wallets and B2B Corporate Payment Systems");
        }

        [TestMethod] //Validate the "Read more" button
        public void Scenario_15()
        {
            steps.NavigateToUrl(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            steps.ClickOnTheSearchButton01(_driver);
            steps.InputSearchTerm(_driver, "The Future for Mobile Wallets and B2B Corporate Payment Systems");
            steps.ClickOnTheSearchButton02(_driver);
            steps.ClickOnTheReadMoreButton(_driver, "The Future for Mobile Wallets and B2B Corporate Payment Systems");
        }

    }
}
