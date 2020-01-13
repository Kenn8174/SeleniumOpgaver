using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumOpgaver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;

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
        public void Exercise_3_CheckIfSubmitWorks()
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
        public void Exercise_3_CheckIfTagNameCanBeFound()
        {
            // ARANGE
            string url = "http://toolsqa.com/automation-practice-form/";
            string actual = "Simple Button";

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


        #region Practice Exercise – Til afsnit Forms Del 1

        [TestMethod]
        public void Exercise_4_1_CheckIfRadioButtonSelectIsSecond()
        {
            // ARANGE
            string url = "http://toolsqa.com/automation-practice-form/";

            // ACT
            chromeDriver.Url = url;

            chromeDriver.FindElement(By.Id("cookie_action_close_header")).Click();

            IList<IWebElement> radioSex = chromeDriver.FindElements(By.Name("sex"));

            radioSex.ElementAt(0).Click();

            bool radioValue = radioSex.ElementAt(0).Selected;

            if (radioValue == true)
            {
                radioSex.ElementAt(1).Click();
            }
            else
            {
                radioSex.ElementAt(0).Click();
            }

            bool expected = radioSex.ElementAt(1).Selected;

            chromeDriver.Close();

            // ASSERT
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void Exercise_4_2_CheckIfRadioButtonSelectIsCorrect()
        {
            // ARANGE
            string url = "http://toolsqa.com/automation-practice-form/";

            // ACT
            chromeDriver.Url = url;
            chromeDriver.FindElement(By.Id("cookie_action_close_header")).Click();

            chromeDriver.FindElement(By.Id("exp-2")).Click();

            bool expected = chromeDriver.FindElement(By.Id("exp-2")).Selected;

            chromeDriver.Close();

            // ASSERT
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void Exercise_4_2_CheckIfCheckBoxProfessionIsCorrect()
        {
            // ARANGE
            string url = "http://toolsqa.com/automation-practice-form/";

            // ACT
            chromeDriver.Url = url;
            chromeDriver.FindElement(By.Id("cookie_action_close_header")).Click();
            IList<IWebElement> checkboxProfession = chromeDriver.FindElements(By.Name("profession"));

            int profSize = checkboxProfession.Count();

            for (int i = 0; i < profSize; i++)
            {
                string value = checkboxProfession.ElementAt(i).GetAttribute("value");

                if (value.Equals("Automation Tester"))
                {
                    checkboxProfession.ElementAt(i).Click();
                    break;
                }
            }

            bool expected = checkboxProfession.ElementAt(1).Selected;

            chromeDriver.Close();

            // ASSERT
            Assert.IsTrue(expected);
        }


        #endregion


    }
}
