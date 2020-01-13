using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Support.UI;

namespace SeleniumOpgaver
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver chromeDriver = new ChromeDriver();
            string url = "http://shop.demoqa.com/";
            string formUrl = "http://toolsqa.com/automation-practice-form/";
            string practiceUrl = "http://toolsqa.com/automation-practice-switch-windows/";
            chromeDriver.Url = url;


            #region Practice Exercise – 1

            /*
                * Launch a new Firefox browser.
                * Open Store.DemoQA.com
                * Get Page Title name and Title length
                * Print Page Title and Title length on the Console.
                * Get Page URL and Page Url Length
                * Print Page URL and Page Url Length on the Console.
                * Get Page Source (HTML Source code) and Page Source length
                * Print Page Length on Console.
                * Close the Browser.
            */

            /*string title = chromeDriver.Title;

            Console.WriteLine(title);
            Console.WriteLine(title.Length);


            string url = chromeDriver.Url;

            Console.WriteLine("URL \t\t-" + url);
            Console.WriteLine("URL Length \t-" + url.Length);


            string source = chromeDriver.PageSource;

            Console.WriteLine("Source Length \t-" + source.Length);*/

            #endregion


            #region Practice Exercise – 2

            /*     
                * Launch new Browser
                * Open http://shop.demoqa.com/ website
                * Click on Registration link using FindElement(By.ClassName("cart-button")).Click();
                * Come back to Home page (Use ‘Back’ command)
                * Again go back to Registration page (This time use ‘Forward’ command)
                * Again come back to Home page (This time use ‘To’ command)
                * Refresh the Browser (Use ‘Refresh’ command)
                * Close the Browser
            */

            /*chromeDriver.FindElement(By.ClassName("cart-button")).Click();

            chromeDriver.Navigate().Back();

            chromeDriver.Navigate().Forward();

            chromeDriver.Navigate().GoToUrl(url);

            chromeDriver.Navigate().Refresh();*/

            #endregion


            #region Practice Exercise – Til afsnit 4

            /*DEL 1*/

            /*
                * Launch new Browser
                * Open URL http://toolsqa.com/automation-practice-form/
                * Type Name & Last Name (Use Name locator)
                * Click on Submit button (Use ID locator)
            */

            //chromeDriver.Navigate().GoToUrl(formUrl);
            //chromeDriver.FindElement(By.Id("cookie_action_close_header")).Click();

            //chromeDriver.FindElement(By.Name("firstname")).SendKeys("Kenneth");
            //chromeDriver.FindElement(By.Id("lastname")).SendKeys("Jessen");

            //chromeDriver.FindElement(By.Name("submit")).Submit();



            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            /*DEL 2*/

            /*
                * Launch new Browser
                * Open URL http://toolsqa.com/automation-practice-form/
                * Click on the Link “Partial Link Test” (Use ‘PatialLinkTest’ locator and search by ‘Partial’ word)
                * Identify Submit button with ‘TagName’, convert it into string and print it on the console
                * Click on the Link “Link Test” (Use ‘LinkTest’ locator)
             */

            //chromeDriver.Navigate().GoToUrl(formUrl);
            //chromeDriver.FindElement(By.Id("cookie_action_close_header")).Click();

            //chromeDriver.FindElement(By.PartialLinkText("Partial")).Click();

            //string tagNameSubmit = chromeDriver.FindElement(By.TagName("Button")).Text;
            //Console.WriteLine(tagNameSubmit);

            //chromeDriver.FindElement(By.LinkText("Link Test")).Click();

            #endregion


            #region Practice Exercise – Til afsnit Forms Del 1

            /*
                * Launch new Browser
                * Open “http://toolsqa.com/automation-practice-form/“
                * Challenge One – Select the deselected Radio button (female) for category Sex (Use Selected method)
                * Challenge Two – Select the Third radio button for category ‘Years of Exp’ (Use Id attribute to select Radio button)
                * Challenge Three – Check the Check Box ‘Automation Tester’ for category ‘Profession'( Use Value attribute to match the selection)
                * Challenge Four – Check the Check Box ‘Selenium IDE’ for category ‘Automation Tool’ (Use CssSelector)
             */

            /*chromeDriver.Navigate().GoToUrl(formUrl);
            chromeDriver.FindElement(By.Id("cookie_action_close_header")).Click();*/

            //Challenge One
            /*IList<IWebElement> radioSex = chromeDriver.FindElements(By.Name("sex"));

            radioSex.ElementAt(0).Click();

            bool radioValue = radioSex.ElementAt(0).Selected;

            if (radioValue == true)
            {
                radioSex.ElementAt(1).Click();
            }
            else
            {
                radioSex.ElementAt(0).Click();
            }*/


            //Challenge Two
            /*chromeDriver.FindElement(By.Id("exp-2")).Click();*/


            //Challenge Three
            /*IList<IWebElement> checkboxProfession = chromeDriver.FindElements(By.Name("profession"));

            int profSize = checkboxProfession.Count();

            for (int i = 0; i < profSize; i++)
            {
                string value = checkboxProfession.ElementAt(i).GetAttribute("value");

                if (value.Equals("Automation Tester"))
                {
                    checkboxProfession.ElementAt(i).Click();
                    break;
                }
            }*/


            //Challenge Four
            /*IWebElement autoToolCheckbox = chromeDriver.FindElement(By.CssSelector("input[value='Selenium IDE']"));

            autoToolCheckbox.Click();*/


            #endregion Del 1


            #region Practice Exercise – Til afsnit Forms Del 2

            /*
                * Launch new Browser
                * Open “http://toolsqa.com/automation-practice-form/”
                * Select ‘Continents’ Drop down ( Use Id to identify the element )
                * Select option ‘Europe’ (Use SelectByIndex)
                * Select option ‘Africa’ now (Use SelectByText)
                * Print all the options for the selected drop down and select one option of your choice
                * Close the browser
             */

            /*chromeDriver.Navigate().GoToUrl(formUrl);

            IWebElement dropdownContinent = chromeDriver.FindElement(By.Id("continents"));

            SelectElement selectContinent = new SelectElement(dropdownContinent);

            selectContinent.SelectByIndex(1);
            selectContinent.SelectByText("Africa");

            IList<IWebElement> continentList = selectContinent.Options;

            foreach (var continents in continentList)
            {
                Console.WriteLine("\nContinent: {0}", continents.Text);
                if (continents.Text == "Europe")
                {
                    selectContinent.SelectByText(continents.Text);
                }
            }*/

            #endregion


            #region Practice Exercise – Til afsnit Waiting

            /*
                * Launch new Browser
                * Navigate to the page “http://toolsqa.com/automation-practice-switch-windows/”
                * Try to find an element with ID=”target”
                * Check if you get any exception while finding this element?
                * If you get an exception finding this element, try to put a Wait and see if you can handle this delay. Try to put a simple Thread sleep or maybe an Implicit wait.
             */


            /*chromeDriver.Navigate().GoToUrl(practiceUrl);
            
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);   //Virker
            //System.Threading.Thread.Sleep(5000);  -Virker ikke

            chromeDriver.FindElement(By.Id("target"));*/



            #endregion


            #region Practice Exercise – Til afsnit Explicit Waiting

            /*
                * Go to http://toolsqa.com/automation-practice-switch-windows/
                * There is a clock on the page that counts down till 0 from 60 second.
                * You have to wait for the clock to show text “Buzz Buzz”
             */


            /*chromeDriver.Navigate().GoToUrl(practiceUrl);

            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMinutes(1));
            try
            {
                wait.Until(x => x.Url == string.Empty);
            }
            catch (Exception)
            {

            }
            finally
            {
                chromeDriver.Close();
            }*/

            #endregion

            //chromeDriver.Close();

        }
    }
}
