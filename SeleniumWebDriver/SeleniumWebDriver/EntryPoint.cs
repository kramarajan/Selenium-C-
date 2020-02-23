using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumWebDriver
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            IWebElement element = null;

            //Driver
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            //Selector
            //SampleBySelector(driver, element);

            //Special Element
            SampleBySpecialElement(driver, element);

            //Thread.Sleep(3000);
            System.Console.ReadKey();
            driver.Quit();
        }

        private static void SampleBySpecialElement(IWebDriver driver, IWebElement element)
        {
            //Text Box
            driver.Navigate().GoToUrl("http://testing.todvachev.com/special-elements/text-input-field/");
            element = driver.FindElement(By.Name("username"));
            element.SendKeys("Hello!");
            //element.Clear();
            Console.WriteLine(element.GetAttribute("value"));
            Console.WriteLine(element.GetAttribute("maxlength"));

            //Check Box
            driver.Navigate().GoToUrl("http://testing.todvachev.com/special-elements/check-button-test-3/");
            element = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(3)"));
            //element.Click();
            if (element.GetAttribute("checked") == "true")
            {
                GreenMessage("The check box is Checked!");
            }
            GreenMessage(element.GetAttribute("value"));

            //Radio Button
            driver.Navigate().GoToUrl("http://testing.todvachev.com/special-elements/radio-button-test/");
            element = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(1)"));
            if (element.GetAttribute("checked") == "true")
            {
                GreenMessage("The radio button is Checked!");
            }

            //DropDown
            driver.Navigate().GoToUrl("http://testing.todvachev.com/special-elements/drop-down-menu-test/");
            element = driver.FindElement(By.Name("DropDownTest"));
            //element.Click();
            GreenMessage(element.GetAttribute("value"));

            //Alert
            driver.Navigate().GoToUrl("http://testing.todvachev.com/special-elements/alert-box/");
            IAlert alert = driver.SwitchTo().Alert();
            GreenMessage(alert.Text);
            alert.Accept();
            element = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));
            if (element.Displayed)
            {
                GreenMessage("Yes! Alert accepted successfully!");
            }
        }

        private static void SampleBySelector(IWebDriver driver, IWebElement element)
        {
            //Name
            driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/name/");
            element = driver.FindElement(By.Name("myName"));
            if (element.Displayed)
            {
                GreenMessage("Yes! successfully find the element by Name!");
            }
            else
            {
                RedMessage("Well, Something went wrong!");
            }

            //ID
            driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/id/");
            element = driver.FindElement(By.Id("testImage"));
            if (element.Displayed)
            {
                GreenMessage("Yes! successfully find the element By ID!");
            }
            else
            {
                RedMessage("Well, Something went wrong!");
            }

            //Class Name
            driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/class-name/");
            element = driver.FindElement(By.ClassName("testClass"));
            GreenMessage(element.Text.ToString());

            //CSS Path
            driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/css-path/");
            element = driver.FindElement(By.CssSelector("#post-108 > div > figure > img"));
            if (element.Displayed)
            {
                GreenMessage("Yes! successfully find the element By CSS Selector!");
            }
            else
            {
                RedMessage("Well, Something went wrong!");
            }

            //XPath
            driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/xpath/");
            element = driver.FindElement(By.XPath("//*[@id=\"post-109\"]/div/figure/img"));
            if (element.Displayed)
            {
                GreenMessage("Yes! successfully find the element By XPath!");
            }
            else
            {
                RedMessage("Well, Something went wrong!");
            }
        }

        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
