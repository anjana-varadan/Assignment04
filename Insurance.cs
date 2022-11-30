﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

[TestFixture]

public class Assignment04
{
    public class Insurance
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }

        //
        [Test]
        public void firstTest_25Age_3Experince_0Accidents_2500Insurance()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1440, 900);
            //Action
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Dhruvi");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Lad");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("300 Regina");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Toronto");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("905-966-1930");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("dhruvihl369@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("25");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$2500"));
            }
        }
        [Test]
        public void secondTest_25Age_3Experience_4Accidents_NoInsurance()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1440, 900);
            //Action
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Jiya");
            driver.FindElement(By.Id("lastName")).Click();
            {
                var element = driver.FindElement(By.Id("lastName"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            driver.FindElement(By.Id("lastName")).SendKeys("Joy");
            driver.FindElement(By.Id("address")).Click();
            {
                var element = driver.FindElement(By.Id("address"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            driver.FindElement(By.Id("address")).SendKeys("360 King Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("905-966-1930");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("jiyajo@gmail.com");

            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("25");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("4");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
            }
        }
        [Test]
        public void thirdTest_35Age_10Experience_2Accidents_1350Insurance()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1440, 900);
            //Action
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Anjana");
            driver.FindElement(By.CssSelector(".card:nth-child(1) > div:nth-child(2)")).Click();
            {
                var element = driver.FindElement(By.CssSelector(".card:nth-child(1) > div:nth-child(2)"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Varadan");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("216 Albert Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Toronto");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4C8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("656-985-0234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("anjana@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("35");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("10");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("2");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$1350"));
            }
        }
        [Test]
        public void fourthTest_19059661930PhoneNo_27Age_3Experience_0Accidents_InvalidPhoneNo()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1440, 900);
            //Action
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Dhruvi");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Lad");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("300 Regina");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("+19059661930");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("dhruvihl369@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("27");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            {
                string value = driver.FindElement(By.Id("age")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("27"));
            }
            {
                string value = driver.FindElement(By.Id("experience")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("3"));
            }
            {
                string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("0"));
            }
            Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
        }
        [Test]
        public void fifthTest_adsfEmail_28Age_3Experience_0Accidents_InvalidEmail()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1440, 786);
            //Action
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Jiya");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Joy");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("360 King Street");
            driver.FindElement(By.CssSelector(".form-row:nth-child(4)")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Toronto");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 6H7");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("905-966-1930");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("adsf");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("28");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("3");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            {
                string value = driver.FindElement(By.Id("age")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("28"));
            }
            {
                string value = driver.FindElement(By.Id("experience")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("3"));
            }
            {
                string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("0"));
            }
            Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
        }
        [Test]

        public void sixthTest_N2J3BPostalCode_35Age_17Experience_1Accidents_InvalidPostalCode()

        {

            //Arrange 

            driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");

            driver.Manage().Window.Size = new System.Drawing.Size(1440, 786);

            //Action 

            driver.FindElement(By.CssSelector(".btn")).Click();

            driver.FindElement(By.Id("firstName")).Click();

            driver.FindElement(By.Id("firstName")).SendKeys("Anjana");

            driver.FindElement(By.Id("lastName")).Click();

            driver.FindElement(By.Id("lastName")).SendKeys("Varadan");

            driver.FindElement(By.Id("address")).Click();

            driver.FindElement(By.Id("address")).SendKeys("216 Albert Street");

            driver.FindElement(By.Id("city")).Click();

            driver.FindElement(By.Id("city")).SendKeys("Waterloo");

            driver.FindElement(By.Id("postalCode")).Click();

            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B8");

            driver.FindElement(By.Id("phone")).Click();

            driver.FindElement(By.Id("phone")).SendKeys("905-966-1930");

            driver.FindElement(By.Id("email")).Click();

            driver.FindElement(By.Id("email")).SendKeys("dhruvihl369@gmail.com");

            driver.FindElement(By.Id("postalCode")).Click();

            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 3B");

            driver.FindElement(By.Id("age")).Click();

            driver.FindElement(By.Id("age")).SendKeys("35");

            driver.FindElement(By.Id("experience")).Click();

            driver.FindElement(By.Id("experience")).SendKeys("17");

            driver.FindElement(By.Id("accidents")).Click();

            driver.FindElement(By.Id("accidents")).SendKeys("1");

            driver.FindElement(By.Id("btnSubmit")).Click();

            //Assert 

            {

                string value = driver.FindElement(By.Id("age")).GetAttribute("value");

                Assert.That(value, Is.EqualTo("35"));

            }

            {

                string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

                Assert.That(value, Is.EqualTo("17"));

            }

            {

                string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

                Assert.That(value, Is.EqualTo("1"));

            }

            Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));

        }

        [Test]

        public void seventhTest_omittedAge_5Experience_0Accidents_AgeError()

        {

            //Arrange 

            driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");

            driver.Manage().Window.Size = new System.Drawing.Size(1440, 786);

            //Action 

            driver.FindElement(By.CssSelector(".btn")).Click();

            driver.FindElement(By.Id("firstName")).Click();

            driver.FindElement(By.Id("firstName")).SendKeys("Dhruvi");

            driver.FindElement(By.Id("lastName")).Click();

            driver.FindElement(By.Id("lastName")).SendKeys("Lad");

            driver.FindElement(By.Id("address")).Click();

            driver.FindElement(By.Id("address")).SendKeys("300 Regina");

            driver.FindElement(By.Id("city")).Click();

            driver.FindElement(By.Id("city")).SendKeys("Toronto");

            driver.FindElement(By.Id("postalCode")).Click();

            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4C8");

            driver.FindElement(By.Id("phone")).Click();

            driver.FindElement(By.Id("phone")).SendKeys("905-966-1930");

            driver.FindElement(By.CssSelector(".form-row:nth-child(5)")).Click();

            driver.FindElement(By.Id("email")).Click();

            driver.FindElement(By.Id("email")).SendKeys("dhruvihl369@gmail.com");

            driver.FindElement(By.Id("experience")).Click();

            driver.FindElement(By.Id("experience")).SendKeys("5");

            driver.FindElement(By.CssSelector(".card-body")).Click();

            driver.FindElement(By.Id("accidents")).Click();

            driver.FindElement(By.Id("accidents")).SendKeys("0");

            driver.FindElement(By.Id("btnSubmit")).Click();

            //Assert 

            {

                string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

                Assert.That(value, Is.EqualTo("5"));

            }

            {

                string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

                Assert.That(value, Is.EqualTo("0"));

            }

            Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));

        }
    }

}
