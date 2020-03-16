using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SeleniumSpecflow.StepBindings
{
    [Binding]
    public class SampleSteps
    {

        IWebElement element = null;
       
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            //Driver
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todvachev.com/");
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
           
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            //Thread.Sleep(3000);
            System.Console.ReadKey();
            //driver.Quit();
        }
    }
}
