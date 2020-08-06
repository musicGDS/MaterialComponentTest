using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
// For supporting Page Object Model
// Obsolete - using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace MaterialComponentTest
{
    public class Badge
    {
        
        private IWebDriver driver;
        private WebDriverWait wait;

        public Badge(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@class='mat-focus-indicator mat-badge mat-raised-button mat-button-base mat-badge-overlap mat-badge-above mat-badge-after mat-badge-medium']")]
        private IWebElement elem_button;

        public void PressButton()
        {
            elem_button.Click();
        }

        public string getButtonClass()
        {
            return elem_button.GetAttribute("class");
        }
    }
}



//Assert.That(classes, Does.Contain(badgeCss), "Test 2 OK");