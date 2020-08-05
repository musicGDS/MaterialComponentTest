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
    public class BottomSheet
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public BottomSheet(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@class='mat-focus-indicator mat-raised-button mat-button-base']")]
        private IWebElement elem_button;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[2]/div[1]/mat-bottom-sheet-container[1]")]
        private IWebElement elem_sheet;

        public void PressButton()
        {
            elem_button.Click();
        }

        public bool bottomSheetPresent()
        {
            try
            {
                //ASK ABOUT THIS
                driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[2]/div[1]/mat-bottom-sheet-container[1]"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}