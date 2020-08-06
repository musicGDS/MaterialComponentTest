using MaterialComponentTest.Infrastructure;
using OpenQA.Selenium;
using NUnit.Framework;
// For supporting Page Object Model
// Obsolete - using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;


namespace MaterialComponentTest
{
    public class TestCases : TestBase
    {
        private ButtonTogglePage _buttonTogglePage;
        private ComponentsPage _componentsPage;
        public TestCases()
        {
            _buttonTogglePage = new ButtonTogglePage(Driver);
            _componentsPage = new ComponentsPage(Driver);
        }
        
        [Test]
        public void test1_Autocompleate()
        {
            string expResult = "Two";

            string input = "Tw";



            IWebDriver driver = new ChromeDriver();

            ComponentsPage page = new ComponentsPage(driver);

            page.goToPage();

            System.Threading.Thread.Sleep(1000);

            

            Autocompleate autocompleate = page.GoToAutocompleate();

            System.Threading.Thread.Sleep(1000);

            autocompleate.EnterText(input);

            System.Threading.Thread.Sleep(1000);

            autocompleate.ClickSuggestion();

            System.Threading.Thread.Sleep(1000);

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

            Button button = page.GoToButton(); 

            button.ClickButton();

            var browserTabs = driver.WindowHandles;

            driver.SwitchTo().Window(browserTabs[1]);


            string pageTitle = driver.Title;

            Assert.That(expTitle, Is.EqualTo(pageTitle));
        }

        [Test]
        public void test5_ButtonToggle()
        {
            _componentsPage.goToPage();
            _componentsPage.GoToButtonToggle();
            var before = _buttonTogglePage.GetAriaPressed();

            _buttonTogglePage.PressButton();

            var after = _buttonTogglePage.GetAriaPressed();

            Assert.That(before, Is.Not.EqualTo(after));

            Driver.Quit();
            //reikia pasirūpinti browserio užclose'inimu po testo, tai neturi būt čia daroma, pagalvok, kur galima tai padaryti
            //bendros pastabos:
            //maniau buttontoggle bus pabaigtas iki galo ir padarys darbą, bet neatpažino man elementų, tai pakeičaiu
            //bendrai kalbant visi testai turi būti išskirti į skirtingas klases, čia aš refactorinau užsimerkęs į kitus testus
            //Kuo mažiau pasikartojančio kodo, pastebėk kaip driver'į galima patalpint, kad visur jo nekartot (suprantu, kad to nemokėjai, bet pritaikyt e-shop'e)
            //jei bus klausimų, tai klausk :)
        }

    }
}