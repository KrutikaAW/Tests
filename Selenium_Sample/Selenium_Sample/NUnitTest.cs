using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Sample
{
    class NUnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void InitializeTest()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:8080/test.html");
        }


        [Test]
        public void OpenTest()
        {     

            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();

          
            IWebElement selectRadio = driver.FindElement(By.CssSelector("input[value='Miss']"));
            selectRadio.Click();
            

            IWebElement firstnameTB = driver.FindElement(By.Name("fname"));
            firstnameTB.SendKeys("Kavya");
            System.Threading.Thread.Sleep(1000);

            IWebElement lastnameTB = driver.FindElement(By.Name("lname"));
            lastnameTB.SendKeys("Sehgal");
            System.Threading.Thread.Sleep(1000);

            IWebElement emailTB = driver.FindElement(By.Name("email"));
            emailTB.SendKeys("ksehgal@gmail.com");
            System.Threading.Thread.Sleep(1000);

            IWebElement phoneTB = driver.FindElement(By.Name("phone"));
            phoneTB.SendKeys("221-346-6754");
            System.Threading.Thread.Sleep(1000);

            IWebElement addTB = driver.FindElement(By.Name("add1"));
            addTB.SendKeys("212 Glassgow Street");
            System.Threading.Thread.Sleep(1000);

            IWebElement cityTB = driver.FindElement(By.Name("city"));
            cityTB.SendKeys("Arlington");
            System.Threading.Thread.Sleep(1000);

            IWebElement zipTB = driver.FindElement(By.Name("zip"));
            zipTB.SendKeys("20330");
            System.Threading.Thread.Sleep(1000);

            IWebElement oCheckBox = driver.FindElement(By.Name("female"));
            oCheckBox.Click();

            IWebElement StateDropDown = driver.FindElement(By.Name("state"));
            SelectElement selection = new SelectElement(StateDropDown);
            selection.SelectByText("Virginia");

            IWebElement date = driver.FindElement(By.Name("date"));
            //SelectElement dselection = new SelectElement(date);
            //date.Click();
            date.SendKeys("2011-02-03");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.Name("Submit")).Click();
            
        }

      
   
        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
