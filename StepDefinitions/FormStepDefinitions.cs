using FluentAssertions;
using FormAutomation.Hooks;
using FormAutomation.PageObject;
using Microsoft.VisualBasic;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace FormAutomation.StepDefinitions
{
    [Binding]
    public class FormStepDefinitions : WebHook
    {
        FormPage formPage = new FormPage();
        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            driver.Navigate().GoToUrl("https://developertraining.reteicons.com/Rita/index.php/automation-form/");
        }

        [Given(@"I enter ""([^""]*)"" as name")]
        public void GivenIEnterAsName(string username)
        {
            formPage.EnterUsername(username);
        }

        [Given(@"I enter the ""([^""]*)""")]
        public void GivenIEnterThe(string lastname)
        {
            formPage.EnterLastName(lastname);
        }

        [Given(@"I enter field for my ""([^""]*)""")]
        public void GivenIEnterFieldForMy(string email)
        {
            formPage.EnterMyEmail(email);
        }


        [Given(@"I enter my (.*)")]
        public void GivenIEnterMy(string Hght)
        {

            formPage.EnterMyHeight(Hght);
        }

        [Given(@"I select No for vegetarian")]
        public void GivenISelectNoForVegetarian()
        {
            formPage.SelectVegetarinStaturs();

        }

        [Given(@"I enteet my location")]
        public void GivenIEnteetMyLocation()
        {
           formPage.EnterMyLocation();
        }

        [When(@"I select career change")]
        public void WhenISelectCareerChange()
        {
            formPage.SelectCareer();
        }

        [When(@"I enter my favorite hobbies ""([^""]*)""")]
        public void WhenIEnterMyFavoriteHobbies(string sport)
        {
            formPage.FavoriteHobbiesAndInterests(sport);
        }

        /*
        [When(@"I enter my favorite hobbies and interests")]
        public void WhenIEnterMyFavoriteHobbiesAndInterests()
        {
            formPage.FavoriteHobbiesAndInterests();
        }
        */

        [When(@"I Select my choice course")]
        public void WhenISelectMyChoiceCourse()
        {
            formPage.MyChoiceCourse();
        }

        [When(@"I select three career progression")]
        public void WhenISelectThreeCareerProgression()
        {
            formPage.CareerProgression();
        }

        [When(@"I select all work days best for me")]
        public void WhenISelectAllWorkDaysBestForMe()
        {
            formPage.WorkDaysBestForMe();
        }

        [When(@"I select time best for me")]
        public void WhenISelectTimeBestForMe()
        {
            formPage.TimeBestForMe();
        }

        [When(@"I select favourite music")]
        public void WhenISelectFavouriteMusic()
        {
            formPage.SelectFavouriteMusic();
        }

        [When(@"I click on submit")]
        public void WhenIClickOnSubmit()
        {
            formPage.ClickSubmit();
        }

        [Then(@"My form should be submited")]
        public void ThenMyFormShouldBeSubmited()
        {
            formPage.Formsubmited().Should().BeTrue();
        }

        [Then(@"""([^""]*)"" is displayed")]
        public void ThenIsDisplayed(string p0)
        {

            
        }



    }
}
