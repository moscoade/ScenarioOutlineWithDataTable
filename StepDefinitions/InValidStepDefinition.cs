using FormAutomation.Hooks;
using FormAutomation.PageObject;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace FormAutomation.StepDefinitions
{
    [Binding]
    public class InValidStepDefinition : WebHook
    {
        InValidPage invalidPage = new InValidPage();

        [Given(@"I enter First Mame")]
        public void GivenIEnterFirstMame()
        {
            invalidPage.EnterUsername();

        }

        [Given(@"I enter Lastname")]
        public void GivenIEnterLastname()
        {
            invalidPage.EnterLastName();
        }

        [Given(@"I enter incurrect Email Adress")]
        public void GivenIEnterIncurrectEmailAdress()
        {
            invalidPage.EnterIncurrectEmailAdress(); 
        }


        [Then(@"I see a Message ""([^""]*)""")]
        public void ThenISeeAMessage(string Message)
        {
            Thread.Sleep(1000);
            Assert.IsTrue(invalidPage.AMessageIsDisplayed());
            Assert.AreEqual(Message, invalidPage.GetTextMessage());

        }


    }
}
