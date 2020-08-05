using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
// For supporting Page Object Model
// Obsolete - using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace MaterialComponentTest
{
    public class Autocompleate
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public Autocompleate(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "mat-input-0")]
        private IWebElement elem_field;

        [FindsBy(How = How.XPath, Using = "//span[@class='mat-option-text']")]
        private IWebElement elem_suggestion;

        public void EnterText(string text)
        {
            elem_field.SendKeys(text);
        }

        public void ClickSuggestion()
        {
            elem_suggestion.Click();
        }

        public string GetResult()
        {
            return elem_field.GetAttribute("value");
        }
    }
}


//string expResult = "Two";


//    // Write an half of input and press selection


//    IWebElement field = driver.FindElement(By.Id("mat-input-0"));

//field.SendKeys("Tw");

//    driver.FindElement(By.XPath("//span[@class='mat-option-text']")).Click();

//string result = field.GetAttribute("value");

//driver.Close();

//    Assert.AreEqual(
