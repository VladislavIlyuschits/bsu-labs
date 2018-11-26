using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace WebDriver
{
    [TestFixture()]
    public class Test
    {
        private HomePage homePage;

        [Test()]
        public void AllFunctionsTest()
        {
            OpenHomePage();
            AddForPassengers();
        }

        private void OpenHomePage()
        {
            var homePage = new HomePage(new ChromeDriver());
            homePage.OpenHomePage();
            homePage.CloseAds();
        }

        private void AddForPassengers()
        {
            homePage.AddPassengers();
        }
    }
}

