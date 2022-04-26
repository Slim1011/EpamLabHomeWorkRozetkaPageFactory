using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace RozetkaHomeTaskEpamLab.rozetkaPages
{
    public class BasePage
    {
        readonly IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//select[@_ngcontent-rz-client-c184]")]
        private IWebElement _sortDropdownMenu;

        

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ImplicitWait(int timeToWait)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeToWait);
        }

        public void WaitVisibilityOfElement(int timeToWait, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait));
            wait.Until(driver => element.Displayed);
        }

        public void checkSortOfPriceFromDropdownMenu(string typeOfSort)
        {
            var selectElement = new SelectElement(_sortDropdownMenu);
            selectElement.SelectByText(typeOfSort);
        }
    }
}
