using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumProject.TestCases.StepDefinitions
{
    [Binding]
    public sealed class LoginSteps
    {
        [Given(@"I navigate to Homepage")]
        public void GivenINavigateToHomepage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter correct credentials")]
        public void GivenIEnterCorrectCredentials()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see welcome page")]
        public void ThenIShouldSeeWelcomePage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter wrong credentials")]
        public void GivenIEnterWrongCredentials()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see errorMessage")]
        public void ThenIShouldSeeErrorMessage()
        {
            ScenarioContext.Current.Pending();
        }

    }

}
