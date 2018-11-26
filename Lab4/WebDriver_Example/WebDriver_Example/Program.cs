using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.aa.com/homePage.do?locale=en_US";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts();

            
            driver.FindElement(By.Id("reservationFlightSearchForm.originAirport")).SendKeys("MHP");
            driver.FindElement(By.Id("reservationFlightSearchForm.destinationAirport")).SendKeys("LON"); 
            driver.FindElement(By.Id("flightSearchForm.tripType.oneWay")).Click();
            driver.FindElement(By.Id("flightSearchForm.button.reSubmit")).Click();

        }
    }
}
