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
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//html//body//material-docs-app//app-component-sidenav//mat-sidenav-container//mat-sidenav-content//div//div//main//app-component-viewer//div//div//component-overview//doc-viewer//div//div//example-viewer//div//div//autocomplete-filter-example//form//mat-form-field//div//div//div//input")]
        private IWebElement elem_field;

        [FindsBy(How = How.XPath, Using = "//span[@class='mat-option-text']")]
        private IWebElement elem_suggestion;

        public void EnterText(string text)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            elem_field.SendKeys(text); 
        }

        public void ClickSuggestion()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            elem_suggestion.Click(); 
        }

        public string GetResult()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
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
