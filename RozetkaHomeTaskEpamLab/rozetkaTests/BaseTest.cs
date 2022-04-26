using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RozetkaHomeTaskEpamLab.rozetkaPages;
using RozetkaHomeTaskEpamLab.Utils;
using Serilog;
using System;
using System.Collections.Generic;


namespace RozetkaHomeTaskEpamLab.rozetkaTests
{
    public class BaseTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(@"E:\Projects\RozetkaHomeTaskEpamLab\RozetkaHomeTaskEpamLab\Logs\Logs.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Log.Information("Log started");      
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            PropertyReader propReader = new PropertyReader();
            driver.Navigate().GoToUrl(propReader.GetURL());
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            Log.Information("Log closed"); 
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        public HomePage GetHomePage()
        {
            return new HomePage(GetDriver());
        }

        public SearchPage GetSearchPage()
        {
            return new SearchPage(GetDriver());
        }

        public CartPage GetCartPage()
        {
            return new CartPage(GetDriver());
        }
    }
}
