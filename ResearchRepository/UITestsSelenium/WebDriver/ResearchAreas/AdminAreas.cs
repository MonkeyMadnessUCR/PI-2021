// Generated by Selenium IDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;

namespace UITestSelenium.WebDriver.ResearchAreas
{
    public class AdminAreas : IDisposable
    {
        public IWebDriver driver { get; private set; }
        public IDictionary<String, Object> vars { get; private set; }
        public IJavaScriptExecutor js { get; private set; }
        public AdminAreas()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<String, Object>();
        }
        public void Dispose()
        {
            driver.Quit();
        }
        [Fact]
        public void AdminAreasTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44331/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.FindElement(By.CssSelector(".mud-toolbar")).Click();
            driver.FindElement(By.LinkText("Iniciar Sesión")).Click();
            {
                var element = driver.FindElement(By.LinkText("Iniciar Sesión"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.TagName("body"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element, 0, 0).Perform();
            }
            driver.FindElement(By.CssSelector(".mud-grid-item:nth-child(2) .mud-input-slot")).Click();
            driver.FindElement(By.CssSelector(".mud-grid-item:nth-child(2) .mud-input-slot")).SendKeys("Prueba@ucr.ac.cr");
            driver.FindElement(By.CssSelector(".mud-input-root-adorned-end")).Click();
            driver.FindElement(By.CssSelector(".mud-input-root-adorned-end")).SendKeys("Prueba123@");
            driver.FindElement(By.CssSelector(".mud-button-filled > .mud-button-label")).Click();

            Task.Delay(5000).Wait();

            driver.Navigate().GoToUrl("https://localhost:44331/");
            driver.Navigate().GoToUrl("https://localhost:44331/admin/1/0");
            Assert.Equal(driver.FindElement(By.CssSelector(".mud-typography-h5")).Text, "Administración");
            driver.FindElement(By.CssSelector(".mud-grid-item-md-5")).Click();
            Assert.Equal(driver.FindElement(By.CssSelector(".mud-grid-item-xs-5 > .mud-typography")).Text, "Áreas de investigación");
            driver.FindElement(By.CssSelector(".mud-grid-item-xs-7 > .mud-typography")).Click();
            Assert.Equal(driver.FindElement(By.CssSelector(".mud-grid-item-xs-7 > .mud-typography")).Text, "Subáreas de investigación");
            driver.FindElement(By.CssSelector(".mud-table-body > .mud-table-row:nth-child(1) > .mud-table-cell > .mud-button-root .mud-icon-root")).Click();
            {
                IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.CssSelector(".mud-snackbar-content-message"));
                Assert.True(elements.Count > 0);
            }
            driver.FindElement(By.CssSelector(".mud-table-body > .mud-table-row:nth-child(1) > .mud-table-cell > .mud-button-root path:nth-child(2)")).Click();
            {
                IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.CssSelector(".mud-snackbar-content-message"));
                Assert.True(elements.Count > 0);
            }
        }
    }
}