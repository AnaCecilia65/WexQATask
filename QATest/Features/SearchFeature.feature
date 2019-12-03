Feature: SearchFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
	Scenario: Validate the Filter Search Results by Category
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu.
	When I select the option "Corporate Payments" in the dropdown next to the search.
	And I click on the "Search" Button.
	Then I should see the search results that fit the criteria

	Scenario: Validate the Filter Search Results by Search Term
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu.
	When I search for "Corporate".
	And I click on the "Search" Button.
	When I should see the search results that fit the criteria

	Scenario: Validate the Filter Search Results by Category and Search Term
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu.
	When I select the option "Corporate Payments" in the dropdown next to the search.
	And I search for "Corporate".
	And I click on the "Search" Button.
	Then I should see the search results that fit the criteria

	Scenario: Validate the Search by Exact Match Search Term
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu.
	When I search for "The Future for Mobile Wallets and B2B Corporate Payment Systems".
	And I click on the "Search" Button.
	Then I should see the search results that fit the criteria

	Scenario: Validate the Search by Similar Match Search Term
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu.
	When I search for "Mobile Wallets".
	And I click on the "Search" Button.
	Then I should see the search results that fit the criteria

	Scenario: Validate the Search by Search Term Without Results
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu.
	When I search for "XYZ".
	And I click on the "Search" Button.
	Then I should see the message "Sorry, there are no results that meet this criteria.".

	Scenario: Validate the Search Term with Alphanumeric Characters
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu.
	When I search for "B2B Corporate Payment Systems".
	And I click on the "Search" Button.
	Then I should see the search results that fit the criteria

	Scenario: Validate the Search Term with Special Characters
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu.
	When I search for "What’s New in Corporate Business Traveller Booking?".
	And I click on the "Search" Button.
	Then I should see the search results that fit the criteria

	Scenario: Validate the Search Clicking the Search Button
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu..
	When I search for "Corporate Payment Systems".
	And I click on the "Search" Button.
	Then I should see the search results that fit the criteria

	Scenario: Validate the Search Pressing "Enter" on the Keyboard
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu.
	When I search for "Corporate Payment Systems".
	And I press "Enter" on the Keyboard.
	Then I should see the search results that fit the criteria

	Scenario: Validate the "Next" button
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu..
	When I select the option "Corporate Payments" in the dropdown next to the search.
	And I click on the "Search" Button.
	Then I should see the search results that fit the criteria
	When I click on the "Next" Button, I check if a navigated to the next page

	Scenario: Validate the "Previous" button
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu.
	When I select the option "Corporate Payments" in the dropdown next to the search.
	And I click on the "Search" Button.
	Then I see the search results that fit the criteria
	When I click on the "Next" Button, I check if a navigated to the next page
	Then I click on the "Previous" Button, I check if a navigated to the previous page

	Scenario: Validate the Navigation Between Pages
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu.
	When I select the option "Corporate Payments" in the dropdown next to the search.
	And I click on the "Search" Button.
	Then I should see the search results that fit the criteria
	When I click on the "2" Button, I check if a navigated to the page 2

	Scenario: Validate the Link Title button
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu.
	When I search for "The Future for Mobile Wallets and B2B Corporate Payment Systems" in the dropdown next to the search.
	And I click on the "Search" Button.
	Then I should see the search results that fit the criteria
	When I click on the "Title", I check if a navigated to the link title page

	Scenario: Validate the "Read more" button
	Given I navigate to "https://www.wexinc.com".
	Then I click on the "Search" Button in the menu.
	When I select the option "Corporate Payments" in the dropdown next to the search.
	And I click on the "Search" Button.
	Then I should see the search results that fit the criteria
	When I click on the "Read more" Button, I check if a navigated to the link title page
