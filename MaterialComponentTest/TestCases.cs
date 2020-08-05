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
using OpenQA.Selenium.Chrome;


namespace MaterialComponentTest
{
    public class TestCases
    {
        public TestCases()
        {
        }
        


        [Test]
        public void test1_Autocompleate()
        {
            IWebDriver driver = new ChromeDriver();

            string expResult = "Two";

            string input = "Tw";

            ComponentsPage page = new ComponentsPage(driver);

            page.GoToAutocompleate();

            Autocompleate autocompleate = new Autocompleate(driver);

            autocompleate.EnterText(input);

            autocompleate.ClickSuggestion();

            Assert.That(expResult == autocompleate.GetResult());
        }

        public void test2_Badge()
        {
            string badgeCss = "mat-badge-hidden";

            IWebDriver driver = new ChromeDriver();

            ComponentsPage page = new ComponentsPage(driver);

            page.GoToBadge();

            Badge badge = new Badge(driver);

            badge.PressButton();

            Assert.That(badge.getButtonClass, Does.Contain(badgeCss), "Test 2 OK");
        }

        [Test]
        public void test3_bottomSheet()
        {
            IWebDriver driver = new ChromeDriver();

            ComponentsPage page = new ComponentsPage(driver);

            page.GoToBottomSheet();

            BottomSheet bottomSheet = new BottomSheet(driver);

            bottomSheet.PressButton();

            Assert.IsTrue(bottomSheet.bottomSheetPresent());
        }

        [Test]
        public void test4_Button()
        {
            string expTitle = "Google";

            IWebDriver driver = new ChromeDriver();

            ComponentsPage page = new ComponentsPage(driver);

            page.GoToButton();

            Button button = new Button(driver);

            button.ClickButton();

            var browserTabs = driver.WindowHandles;

            driver.SwitchTo().Window(browserTabs[1]);


            string pageTitle = driver.Title;

            Assert.That(expTitle, Is.EqualTo(pageTitle));
        }

        [Test]
        public void test5_ButtonToggle()
        {
            IWebDriver driver = new ChromeDriver();

            ComponentsPage page = new ComponentsPage(driver);

            page.GoToButtonToggle();

            ButtonToggle buttonToggle = new ButtonToggle(driver);

            string before = buttonToggle.GetAriaPressed();

            buttonToggle.PressButton();

            string after = buttonToggle.GetAriaPressed();

            Assert.That(before != after);
        }
    }
}