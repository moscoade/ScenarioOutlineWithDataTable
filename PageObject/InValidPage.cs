using FluentAssertions;
using FormAutomation.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAutomation.PageObject
{
    class InValidPage : WebHook
    {
        IWebElement fristname => driver.FindElement(By.XPath("//*[@id='wpforms-18-field_1']"));
        IWebElement lastName => driver.FindElement(By.XPath("(//*[@type='text'])[2]"));
        IWebElement myEmail => driver.FindElement(By.XPath("(//*[@type='email'])"));
        IWebElement msgDisplay => driver.FindElement(By.XPath("//*[@id='wpforms-18-field_3-error']"));
      
        public void EnterUsername()
        {
            fristname.SendKeys("moses");
        }

        public void EnterLastName()
        {
            lastName.SendKeys("Ade");
        }

        public void EnterIncurrectEmailAdress()
        {
            myEmail.SendKeys("mavonoy187$camplvad.com");
        }

        public bool AMessageIsDisplayed()
        {
           return msgDisplay.Displayed;
        }

        public string GetTextMessage()
        {
            string Message = "Please enter a valid email address."; 

            return Message;
        }

       




    }  
}
