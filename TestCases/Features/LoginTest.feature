Feature: LoginTest

Scenario: Correct User and Pass
Given I navigate to Homepage
And I enter correct credentials
When I press login
Then I should see welcome page


Scenario: wrong User and correct Pass
Given I navigate to Homepage
And I enter wrong credentials
When I press login
Then I should see errorMessage


Scenario: correct User and wrong Pass
Given I navigate to Homepage
And I enter wrong credentials
When I press login
Then I should see errorMessage
