using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
// For supporting Page Object Model
// Obsolete - using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace MaterialComponentTest
{
    public class Button
    {
        
        private IWebDriver driver;
        private WebDriverWait wait;

        public Button(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='mat-focus-indicator mat-raised-button mat-button-base']")]
        private IWebElement elem_button;

        public void ClickButton()
        {
            elem_button.Click();
        }
    }
}