using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DatingApp.AutomationTesting
{
    public class LangingPage
    {
        IWebDriver webDriver;
        public LangingPage()
        {
            webDriver = new ChromeDriver();
        }
        [SetUp]
        public void Setup()
        {
            
            webDriver.Url = "https://datingappcourse.herokuapp.com/";
            webDriver.Navigate();
        }

        [Test]
        public void LoadedLanginPage()
        {
            Assert.That(
                webDriver.FindElement(By.Name("username")).Displayed && 
                webDriver.FindElement(By.Name("password")).Displayed && 
                webDriver.FindElement(By.XPath("/html/body/app-root/app-nav/nav/div/form/button")).Displayed);
        }

        [TearDown]
        public void CleanUp()
        {
            webDriver.Close();
        }
    }
}