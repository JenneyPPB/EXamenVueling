using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver= new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            driver.Manage().Window.Maximize();
            IWebElement input= driver.FindElement(By.ClassName("style-scope ytd-masthead"));
            input.SendKeys("Tutoriales y más");
        }
    }
}
