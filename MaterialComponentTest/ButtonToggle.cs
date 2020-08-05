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
    public class ButtonToggle
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public ButtonToggle(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button-toggle-overview-example//mat-button-toggle[1]//button[1]")]
        private IWebElement elem_boldButton;

        public void PressButton()
        {
            elem_boldButton.Click();
        }

        public string GetAriaPressed()
        {
            return elem_boldButton.GetAttribute("aria-pressed");
        }

    }
}