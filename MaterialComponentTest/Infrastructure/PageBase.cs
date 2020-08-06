using OpenQA.Selenium;

namespace MaterialComponentTest.Infrastructure
{
    public class PageBase
    {
        public IWebDriver Driver;

        public PageBase(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement Element(By by)
        {
            return Driver.FindElement(by);
        }

        public void Click(By by)
        {
            Element(by).Click();
        }
    }
}
