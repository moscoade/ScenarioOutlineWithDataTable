using FluentAssertions;
using FormAutomation.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Bindings;

namespace FormAutomation.PageObject
{
    class FormPage : WebHook
    {
        IWebElement fristName => driver.FindElement(By.XPath("//*[@id='wpforms-18-field_1']"));
        IWebElement lastName => driver.FindElement(By.XPath("(//*[@type='text'])[2]"));
        IWebElement myEmail => driver.FindElement(By.XPath("(//*[@type='email'])"));
        IWebElement myHeight => driver.FindElement(By.XPath("(//*[@id='wpforms-18-field_7'])"));
        IWebElement vegetarian => driver.FindElement(By.CssSelector("option[value='No']"));
        IWebElement ctry => driver.FindElement(By.XPath("(//*[@name='wpforms[fields][5]'])"));
        IWebElement career => driver.FindElement(By.CssSelector("option[value='2years - 3 years']"));
        IWebElement hobbies => driver.FindElement(By.XPath("//textarea[@id='wpforms-18-field_14']"));
        IWebElement course => driver.FindElement(By.XPath("//input[@id='wpforms-18-field_29_3']"));
        IWebElement careerProA => driver.FindElement(By.CssSelector("#wpforms-18-field_31_3"));
        IWebElement careerProB => driver.FindElement(By.CssSelector("#wpforms-18-field_31_2"));
        IWebElement careerProC => driver.FindElement(By.CssSelector("#wpforms-18-field_31_1"));
        IWebElement workDay => driver.FindElement(By.CssSelector("#wpforms-18-field_32_1"));
        IWebElement time => driver.FindElement(By.XPath("//input[@id='wpforms-18-field_38_2']"));
        IWebElement music => driver.FindElement(By.XPath("//input[@id='wpforms-18-field_33_3']"));
        IWebElement subMt => driver.FindElement(By.XPath("(//*[@class='wpforms-submit'])"));


       

        public void EnterUsername( string username)
        {
              fristName.SendKeys(username);

        }

        public void EnterLastName(string lastname)
        {

            lastName.SendKeys(lastname);
        }

        public void EnterMyEmail(string email)
        {
            myEmail.SendKeys(email);
        }

        public void EnterMyHeight(string Hght)
        {

            myHeight.SendKeys(Hght);
        }

        public void SelectVegetarinStaturs()
        {

            vegetarian.Click();
            //SelectElement element = new SelectElement(vegetarian);
           // element.SelectByText("No");

        }

        public void EnterMyLocation()
        {
            ctry.SendKeys("Uk");
        }

        public void SelectCareer()
        {
            career.Click();
        }

        public void FavoriteHobbiesAndInterests(string sport)
        {
            hobbies.SendKeys(sport);
        }

        public void MyChoiceCourse()
        {
            course.Click();
        }

        public void CareerProgression()
        {
            Thread.Sleep(1000);
            careerProA.Click();
            careerProB.Click();
            careerProC.Click();
        }
        public void WorkDaysBestForMe()
        {
            Thread.Sleep(1000);
            workDay.Click(); 
        }

        public void TimeBestForMe()
        {
            time.Click();
        }

        public void SelectFavouriteMusic()
        {
            music.Click();
        }
        public void ClickSubmit()
        {

            subMt.Click();
        }

        public bool Formsubmited() 
        {
            return driver.Url.Contains("https://developertraining.reteicons.com/Rita/index.php/automation-form/");
           // return driver.Title.Contains("Automation form");
        }


    }
}
