using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AirlinesTestingApp.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        private const string url = "https://www.klm.com/home/by/ru";
        By addInput = By.ClassName("flightSearchForm.adultOrSeniorPassengerCount");
        By addPassenger = By.ClassName("flightSearchForm.adultOrSeniorPassengerCount > option");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.FindElement(addInput).Click();
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void AddPassengers()
        {
            driver.FindElements(addPassenger)[3].Click();
        }
    }
}
