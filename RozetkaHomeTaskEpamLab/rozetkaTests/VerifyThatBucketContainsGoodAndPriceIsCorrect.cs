using System;
using NUnit.Framework;
using RozetkaHomeTaskEpamLab.DataSource;
using Serilog;


namespace RozetkaHomeTaskEpamLab.rozetkaTests
{
    class VerifyThatBucketContainsGoodAndPriceIsCorrect : BaseTest
    {

        [Test]

        public void VerifyThatBucketContainsGoodWithCorrectPrice()
        {
            try
            {
                Filters.InitCurrent();
                GetHomePage().SendKeysToSearchInput(Filters.Current.TypeOfGood);
                GetHomePage().ClickSearhcButton();
                GetSearchPage().SendKeysToSearchBrandInput(Filters.Current.Brand);
                GetSearchPage().ClickRazerCheckBox();
                GetSearchPage().checkSortOfPriceFromDropdownMenu(Filters.Current.TypeOfSort);
                GetSearchPage().ChooseFirstGood();
                GetSearchPage().ClickCartButton();
                GetCartPage().WaitVisibilityOfElement(10, GetCartPage().GetPriceWindow());
                Assert.IsTrue(GetCartPage().GetTextFromPriceWindow() < Filters.Current.PriceLimit);

            }
            catch (Exception ex)
            {

                Log.Error(ex, "Error log");

            }


        }
    }
}
