using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaHomeTaskEpamLab.rozetkaPages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }

        [FindsBy(How = How.XPath, Using = "//input[@class='search-form__input ng-untouched ng-pristine ng-valid']")]
        private IWebElement _searchInput;
        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 'button button_color_green')]")]
        private IWebElement _searchButton;

        public void SendKeysToSearchInput(string typeOfGood)
        {
            _searchInput.SendKeys(typeOfGood);
        }

        public void ClickSearhcButton()
        {
            _searchButton.Click();
        }
    }
}
