using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumOpgaver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProjekt
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver chromeDriver = new ChromeDriver();
        //http://shop.demoqa.com/
        //http://toolsqa.com/automation-practice-form/
        //http://toolsqa.com/automation-practice-switch-windows/

        #region Practice Exercise – 1

        [TestMethod]
        public void Exercise_1_CheckIfTitleIsMoreThanZero()
        {
            // ARANGE
             string url = "http://shop.demoqa.com/";

            // ACT
            chromeDriver.Url = url;

            string title = chromeDriver.Title;

            chromeDriver.Close();

            // ASSERT
            Assert.IsTrue(title.Length > 0);
        }

        [TestMethod]
        public void Exercise_1_CheckIfUrlIsMoreThanZero()
        {
            // ARANGE
            string url = "http://shop.demoqa.com/";

            // ACT
            chromeDriver.Url = url;

            string urlCheck = chromeDriver.Url;

            chromeDriver.Close();

            // ASSERT
            Assert.IsTrue(urlCheck.Length > 0);
        }

        [TestMethod]
        public void Exercise_1_CheckIfSourceCodeIsMoreThanZero()
        {
            // ARANGE
            string url = "http://shop.demoqa.com/";

            // ACT
            chromeDriver.Url = url;

            string sourceCode = chromeDriver.PageSource;

            chromeDriver.Close();

            // ASSERT
            Assert.IsTrue(sourceCode.Length > 0);
        }

        #endregion


        #region Practice Exercise – 2

        [TestMethod]
        public void Exercise_2_CheckIfRoutingWorks()
        {
            // ARANGE
            string url = "http://shop.demoqa.com/";

            // ACT
            chromeDriver.Url = url; 
            
            chromeDriver.FindElement(By.ClassName("cart-button")).Click();

            chromeDriver.Navigate().Back();

            chromeDriver.Navigate().Forward();

            chromeDriver.Navigate().GoToUrl(url);

            chromeDriver.Navigate().Refresh();

            string urlFinal = chromeDriver.Url;

            chromeDriver.Close();

            // ASSERT
            Assert.AreEqual(urlFinal, url);
        }

        #endregion


        #region Practice Exercise – Til afsnit 4

        [TestMethod]
        public void Exercise_4_Del1_CheckIfSubmitWorks()
        {
            // ARANGE
            string url = "http://toolsqa.com/automation-practice-form/";
            string actual = "https://www.toolsqa.com/automation-practice-form/?firstname=Kenneth&submit=&photo=&continents=AS";

            // ACT
            chromeDriver.Url = url;
            
            chromeDriver.FindElement(By.Id("cookie_action_close_header")).Click();

            chromeDriver.FindElement(By.Name("firstname")).SendKeys("Kenneth");

            chromeDriver.FindElement(By.Id("lastname")).SendKeys("Jessen");

            chromeDriver.FindElement(By.Name("submit")).Submit();

            string expected = chromeDriver.Url;

            chromeDriver.Close();

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Exercise_4_Del2_CheckIfTagNameCanBeFound()
        {
            // ARANGE
            string url = "http://toolsqa.com/automation-practice-form/";
            string actual = "Button";

            // ACT
            chromeDriver.Url = url;

            chromeDriver.FindElement(By.Id("cookie_action_close_header")).Click();

            chromeDriver.FindElement(By.PartialLinkText("Partial")).Click();

            string tagNameSubmit = chromeDriver.FindElement(By.TagName("Button")).Text;

            chromeDriver.FindElement(By.LinkText("Link Test")).Click();

            chromeDriver.Close();

            // ASSERT
            Assert.AreEqual(tagNameSubmit, actual);
        }

        #endregion


    }
}
