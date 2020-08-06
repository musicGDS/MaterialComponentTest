using MaterialComponentTest.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
// For supporting Page Object Model
// Obsolete - using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;


namespace MaterialComponentTest
{
    public class ComponentsPage : PageBase
    {
        string componentsUrl = "https://material.angular.io/components/categories";

        private WebDriverWait wait;

        public ComponentsPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//div[text() = 'Autocomplete']")]
        private IWebElement elem_autocompleate;

        [FindsBy(How = How.Name, Using = "Badge")]
        private IWebElement elem_badge;

        [FindsBy(How = How.Name, Using = "Bottom Sheet")]
        private IWebElement elem_bottomSheet;

        [FindsBy(How = How.Name, Using = "Button")]
        private IWebElement elem_button;

        public By Elem_buttonToggle = By.XPath("(//a[@href='/components/button-toggle'])[1]");

        [FindsBy(How = How.Name, Using = "Checkbox")]
        private IWebElement elem_checkbox;

        [FindsBy(How = How.Name, Using = "Chips")]
        private IWebElement elem_chips;

        [FindsBy(How = How.Name, Using = "Datepicker")]
        private IWebElement elem_datepicker;

        [FindsBy(How = How.Name, Using = "Dialog")]
        private IWebElement elem_dialog;

        [FindsBy(How = How.Name, Using = "Expansion panel")]
        private IWebElement elem_expansionPanel;

        [FindsBy(How = How.Name, Using = "Form field")]
        private IWebElement elem_formField;

        [FindsBy(How = How.Name, Using = "Input")]
        private IWebElement elem_input;

        [FindsBy(How = How.Name, Using = "Menu")]
        private IWebElement elem_menu;

        [FindsBy(How = How.Name, Using = "Paginator")]
        private IWebElement elem_paginator;

        [FindsBy(How = How.Name, Using = "Radio button")]
        private IWebElement elem_radioButton;

        [FindsBy(How = How.Name, Using = "Select")]
        private IWebElement elem_select;

        [FindsBy(How = How.Name, Using = "Slide toggle")]
        private IWebElement elem_slideToggle;

        [FindsBy(How = How.Name, Using = "Slider")]
        private IWebElement elem_slider;

        [FindsBy(How = How.Name, Using = "Snackbar")]
        private IWebElement elem_snackbar;

        [FindsBy(How = How.Name, Using = "Sort header")]
        private IWebElement elem_sortHeader;

        [FindsBy(How = How.Name, Using = "Stepper")]
        private IWebElement elem_stepper;

        [FindsBy(How = How.Name, Using = "Tabs")]
        private IWebElement elem_tabs;

        [FindsBy(How = How.Name, Using = "Tooltip")]
        private IWebElement elem_tooltip;

        [FindsBy(How = How.Name, Using = "Tree")]
        private IWebElement elem_tree;

        // Go to the designated page
        public void goToPage()
        {
            Driver.Navigate().GoToUrl(componentsUrl);
        }

        // Methods

        public Autocompleate GoToAutocompleate()
        {
            elem_autocompleate.Click();
            return new Autocompleate(Driver);
        }

        public Badge GoToBadge()
        {
            elem_badge.Click();
            return new Badge(Driver);
        }

        public BottomSheet GoToBottomSheet()
        {
            elem_bottomSheet.Click();
            return new BottomSheet(Driver);
        }

        public Button GoToButton()
        {
            elem_button.Click();
            return new Button(Driver);
        }

        public void GoToButtonToggle()
        {
            Click(Elem_buttonToggle);
        }
    }
}
