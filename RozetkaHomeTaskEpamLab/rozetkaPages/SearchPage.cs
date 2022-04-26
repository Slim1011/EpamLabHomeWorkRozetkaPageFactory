using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace RozetkaHomeTaskEpamLab.rozetkaPages
{
    public class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Алфавитный указатель')]/parent::button/parent::div/preceding-sibling::div/input")]
        private IWebElement _searchBrandInput;

        [FindsBy(How = How.XPath, Using = "//a[@data-id='Razer']")]
        private IWebElement _razerCheckBox;

        [FindsBy(How = How.XPath, Using = "(//button[@class='buy-button goods-tile__buy-button ng-star-inserted'])[2]")]
        private IWebElement _firstGood;

        [FindsBy(How = How.XPath, Using = "//rz-cart//button[contains(@class, 'header__button ng-star-inserted')]")]
        private IWebElement _cartButton;

        
        public void SendKeysToSearchBrandInput(string brand)
        {
            _searchBrandInput.SendKeys(brand);
        }

        public void ClickRazerCheckBox()
        {
            _razerCheckBox.Click();
        }

        public void ChooseFirstGood()
        {
            _firstGood.Click();
        }

        public void ClickCartButton()
        {
            _cartButton.Click();
        }

    }
}
