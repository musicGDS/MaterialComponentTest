// Home Page Object (Src\PageObject\Pages\HomePage.cs)

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
    class HomePage
    {
        String test_url = "https://www.google.com";

        private IWebDriver driver;
        private WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        //[FindsBy(How = How.XPath, Using = "//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input")]
        [FindsBy(How = How.Name, Using = "q")]
        [CacheLookup]
        private IWebElement elem_search_text;

        //[FindsBy(How = How.XPath, Using = "//*[@id='tsf']/div[2]/div/div[3]/center/input[1]")]
        [FindsBy(How = How.Name, Using = "btnI")]
        [CacheLookup]
        private IWebElement elem_submit_button;

        //[FindsBy(How = How.XPath, Using = "//*[@id='hplogo']")]
        [FindsBy(How = How.Id, Using = "hplogo")]
        [CacheLookup]
        private IWebElement elem_logo_img;

        // Go to the designated page
        public void goToPage()
        {
            driver.Navigate().GoToUrl(test_url);
        }

        // Returns the Page Title
        public String getPageTitle()
        {
            return driver.Title;
        }

        // Returns the search string
        public String getSearchText()
        {
            return elem_search_text.Text;
        }

        // Checks whether the Logo is displayed properly or not
        public bool getWebPageLogo()
        {
            return elem_logo_img.Displayed;
        }

        public SearchPage test_search(string input_search)
        {
            elem_search_text.SendKeys(input_search);
            //wait.Until(ExpectedConditions.ElementToBeClickable(elem_submit_button)).Submit();
            elem_search_text.Submit();
            return new SearchPage(driver);
        }
    }
}