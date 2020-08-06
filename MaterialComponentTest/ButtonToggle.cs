using System;
using MaterialComponentTest.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MaterialComponentTest
{
    public class ButtonTogglePage : PageBase
    {
        private WebDriverWait wait;

        public ButtonTogglePage(IWebDriver driver) : base(driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private By elem_boldButton = By.Id("mat-button-toggle-1-button");

        public void PressButton()
        {
            Click(elem_boldButton);
        }

        public string GetAriaPressed()
        {
            return Element(elem_boldButton).GetAttribute("aria-pressed");
        }

    }
}