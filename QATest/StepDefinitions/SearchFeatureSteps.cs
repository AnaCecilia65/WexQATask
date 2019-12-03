using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QATest.PageObjects;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;

namespace QATest.StepDefinitions
{
    [Binding]
    public class SearchFeatureSteps
    {
        private SearchPage _searchPage;
        private IWebElement _option;
        private IWebElement _searchButton;
        private IWebElement _searchBox;
        private IWebElement _optionActive;
        private IWebElement _message;
        private IWebElement _nextButton;
        private IWebElement _nextPage;
        private IWebElement _previousButton;
        private IWebElement _previousPage;
        private IWebElement _linkTitle;
        private IWebElement _title;
        private IWebElement _readMore;

        public SearchFeatureSteps()
        {
            _searchPage = new SearchPage();
        }

        [Given(@"I navigate to ""(.*)""\.")]
        public void NavigateToUrl(IWebDriver _driver)
        {
            _driver.Navigate().GoToUrl("https://www.wexinc.com");
        }

        [When(@"I select the option ""(.*)"" in the dropdown next to the search\.")]
        public void SelectTheDropdownOption(IWebDriver _driver, String text)
        {
            _option = _searchPage.GetOption(_driver);
            new SelectElement(_option).SelectByText(text);
        }

        [When(@"I click on the ""(.*)"" Button\.")]
        public void ClickOnTheSearchButton02(IWebDriver _driver)
        {
            _searchButton = _searchPage.GetSearchButton02(_driver);
            _searchButton.Click();
        }

        [When(@"I search for ""(.*)""\.")]
        public void InputSearchTerm(IWebDriver _driver, string text)
        {
            _searchBox = _searchPage.GetSearchBox(_driver);
            _searchBox.Click();
            _searchBox.SendKeys(text);

        }

        [When(@"I should see the search results that fit the criteria")]
        public void WhenIShouldSeeTheSearchResultsThatFitTheCriteria()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press ""(.*)"" on the Keyboard\.")]
        public void PressEnterOnTheKeyboard(IWebDriver _driver)
        {
            _searchBox = _searchPage.GetSearchBox(_driver);
            _searchBox.SendKeys(Keys.Enter);
        }

        [When(@"I click on the ""(.*)"" Button, I check if a navigated to the next page")]
        public String ClickOnTheNextPageButton(IWebDriver _driver)
        {
            _nextButton = _searchPage.GetNextButton(_driver);
            _nextButton.Click();

            _nextPage = _searchPage.GetNextPage(_driver);

            bool isEnable = _nextPage.Enabled;

            if (isEnable == true)
            {
                return "The button shouldn't be enable!";
            }
            else
            {
                return "The button is enable!";
            }
        }

        [When(@"I click on the ""(.*)"" Button, I check if a navigated to the page (.*)")]
        public void WhenIClickOnTheButtonICheckIfANavigatedToThePage(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I search for ""(.*)"" in the dropdown next to the search\.")]
        public void WhenISearchForInTheDropdownNextToTheSearch_(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the ""(.*)"", I check if a navigated to the link title page")]
        public void ClickOnTheLinkTitlePage(IWebDriver _driver, string text)
        {
            _linkTitle = _searchPage.GetLinkTitle(_driver, text);
            _linkTitle.Click();
            _title = _searchPage.GetTitle(_driver, text);
        }

        [When(@"I click on the ""(.*)"" Button, I check if a navigated to the link title page")]
        public void ClickOnTheReadMoreButton(IWebDriver _driver, string text)
        {
            _readMore = _searchPage.GetReadMore(_driver);
            _readMore.Click();
            _title = _searchPage.GetTitle(_driver, text);

        }

        [Then(@"I click on the ""(.*)"" Button in the menu\.")]
        public void ClickOnTheSearchButton01(IWebDriver _driver)
        {
            _searchButton = _searchPage.GetSearchButton01(_driver);
            _searchButton.Click();
        }

        [Then(@"I should see the search results that fit the criteria")]
        public String VerifyTheSearchResults(IWebDriver _driver)
        {
            _optionActive = _searchPage.GetOptionSearchCriteriaActive(_driver);
            bool isDisplayed = _optionActive.Displayed;

            if (isDisplayed == true)
            {
                return "The message was displayed!";
            }
            else
            {
                return "The message was not displayed!";
            }
        }

        [Then(@"I click on the ""(.*)"" Button\.")]
        public void ThenIClickOnTheButton_(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the message ""(.*)""\.")]
        public String CheckMessageNoResults(IWebDriver _driver)
        {
            _message = _searchPage.GetOptionSearchCriteriaActive(_driver);
            bool isDisplayed = _optionActive.Displayed;

            if (isDisplayed == true)
            {
                return "The message was displayed!";
            }
            else
            {
                return "The message was not displayed!";
            }
        }

        [Then(@"I see the search results that fit the criteria")]
        public void ThenISeeTheSearchResultsThatFitTheCriteria()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I click on the ""(.*)"" Button, I check if a navigated to the previous page")]
        public String ClickOnThePreviousPageButton(IWebDriver _driver)
        {
            _previousButton = _searchPage.GetPreviousButton(_driver);
            _previousButton.Click();

            _previousPage = _searchPage.GetPreviousPage(_driver);

            bool isEnable = _previousPage.Enabled;

            if (isEnable == true)
            {
                return "The button shouldn't be enable!";
            }
            else
            {
                return "The button is enable!";
            }
        }
    }
}
