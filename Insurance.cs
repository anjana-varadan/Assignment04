// Generated by Selenium IDE
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
        public void tenthTest_4Accidents_NoInsurance()

        {

            //Arrange 

            driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");

            driver.Manage().Window.Size = new System.Drawing.Size(1296, 688);

            //Action 

            driver.FindElement(By.CssSelector(".btn")).Click();

            driver.FindElement(By.CssSelector(".card:nth-child(1) > div > .form-group:nth-child(1)")).Click();

            driver.FindElement(By.Id("firstName")).Click();

            driver.FindElement(By.Id("firstName")).SendKeys("jiya");

            driver.FindElement(By.Id("lastName")).Click();

            driver.FindElement(By.Id("lastName")).SendKeys("joy");

            driver.FindElement(By.Id("address")).Click();

            driver.FindElement(By.Id("address")).SendKeys("51 Nine Pines rd");

            driver.FindElement(By.Id("city")).Click();

            driver.FindElement(By.Id("city")).SendKeys("Kitchener");

            driver.FindElement(By.Id("postalCode")).Click();

            driver.FindElement(By.Id("postalCode")).SendKeys("N2E 1L3");

            driver.FindElement(By.Id("phone")).Click();

            driver.FindElement(By.Id("phone")).SendKeys("226-978-5186");

            driver.FindElement(By.Id("email")).Click();

            driver.FindElement(By.Id("email")).SendKeys("jiyajoy123@gmail.com");

            driver.FindElement(By.Id("age")).Click();

            driver.FindElement(By.Id("age")).SendKeys("30");

            {

                var element = driver.FindElement(By.Id("experience"));

                Actions builder = new Actions(driver);

                builder.MoveToElement(element).ClickAndHold().Perform();

            }

            {

                var element = driver.FindElement(By.Id("experience"));

                Actions builder = new Actions(driver);

                builder.MoveToElement(element).Perform();

            }

            {

                var element = driver.FindElement(By.Id("experience"));

                Actions builder = new Actions(driver);

                builder.MoveToElement(element).Release().Perform();

            }

            driver.FindElement(By.Id("experience")).Click();

            driver.FindElement(By.Id("experience")).SendKeys("1");

            driver.FindElement(By.Id("experience")).Click();

            driver.FindElement(By.Id("accidents")).SendKeys("1");

            driver.FindElement(By.Id("accidents")).Click();

            driver.FindElement(By.Id("accidents")).SendKeys("2");

            driver.FindElement(By.Id("accidents")).Click();

            {

                var element = driver.FindElement(By.Id("accidents"));

                Actions builder = new Actions(driver);

                builder.DoubleClick(element).Perform();

            }

            driver.FindElement(By.Id("accidents")).SendKeys("3");

            driver.FindElement(By.Id("accidents")).Click();

            driver.FindElement(By.Id("accidents")).SendKeys("4");

            driver.FindElement(By.Id("accidents")).Click();

            driver.FindElement(By.Id("finalQuote")).Click();

            driver.FindElement(By.Id("finalQuote")).Click();

            driver.FindElement(By.Id("btnSubmit")).Click();

            driver.FindElement(By.Id("finalQuote")).Click();

            //Assert 

            {

                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");

                Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));

            }

            {

                var element = driver.FindElement(By.Id("finalQuote"));

                Actions builder = new Actions(driver);

                builder.DoubleClick(element).Perform();

            }

        }

        [Test]

        public void eleventhTest_28Age_10Experience_1800BaseRate()

        {

            //Arrange 

            driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");

            driver.Manage().Window.Size = new System.Drawing.Size(1296, 688);

            //Action 

            driver.FindElement(By.CssSelector(".btn")).Click();

            driver.FindElement(By.Id("firstName")).Click();

            driver.FindElement(By.Id("firstName")).SendKeys("jiya");

            driver.FindElement(By.Id("lastName")).Click();

            driver.FindElement(By.Id("lastName")).SendKeys("joy");

            driver.FindElement(By.Id("address")).Click();

            driver.FindElement(By.Id("address")).SendKeys("51 Nine Pines rd");

            driver.FindElement(By.Id("city")).Click();

            driver.FindElement(By.Id("city")).SendKeys("Kitchener");

            driver.FindElement(By.Id("postalCode")).Click();

            driver.FindElement(By.Id("postalCode")).SendKeys("N2E 1L3");

            driver.FindElement(By.Id("phone")).Click();

            driver.FindElement(By.Id("phone")).SendKeys("226-978-5186");

            driver.FindElement(By.Id("email")).Click();

            driver.FindElement(By.Id("email")).SendKeys("jiyajoy123@gmail.com");

            driver.FindElement(By.Id("age")).Click();

            driver.FindElement(By.Id("age")).SendKeys("28");

            driver.FindElement(By.Id("experience")).Click();

            driver.FindElement(By.Id("experience")).SendKeys("10");

            driver.FindElement(By.Id("accidents")).Click();

            driver.FindElement(By.Id("accidents")).SendKeys("0");

            driver.FindElement(By.Id("btnSubmit")).Click();

            //Assert 

            {

                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");

                Assert.That(value, Is.EqualTo("$1800"));

            }

        }
        [Test]

        public void twelthTest_29Age_0Experience_4000BaseRate()

        {

            //Arrange 

            driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");

            driver.Manage().Window.Size = new System.Drawing.Size(1296, 688);

            //Action 

            driver.FindElement(By.CssSelector(".btn")).Click();

            driver.FindElement(By.Id("firstName")).Click();

            driver.FindElement(By.Id("firstName")).SendKeys("anjana");

            driver.FindElement(By.Id("lastName")).Click();

            driver.FindElement(By.Id("lastName")).SendKeys("varadan");

            {

                var element = driver.FindElement(By.Id("address"));

                Actions builder = new Actions(driver);

                builder.MoveToElement(element).ClickAndHold().Perform();

            }

            {

                var element = driver.FindElement(By.Id("address"));

                Actions builder = new Actions(driver);

                builder.MoveToElement(element).Perform();

            }

            {

                var element = driver.FindElement(By.Id("address"));

                Actions builder = new Actions(driver);

                builder.MoveToElement(element).Release().Perform();

            }

            driver.FindElement(By.Id("address")).Click();

            driver.FindElement(By.Id("address")).SendKeys("210 nine pines");

            driver.FindElement(By.Id("city")).Click();

            driver.FindElement(By.Id("city")).SendKeys("waterloo");

            driver.FindElement(By.Id("postalCode")).Click();

            driver.FindElement(By.Id("postalCode")).SendKeys("N2E 3R2");

            driver.FindElement(By.Id("phone")).Click();

            driver.FindElement(By.Id("phone")).SendKeys("226-978-5186");

            driver.FindElement(By.Id("phone")).SendKeys("226-978-5189");

            driver.FindElement(By.Id("email")).Click();

            driver.FindElement(By.Id("email")).SendKeys("anjana@gmail.com");

            driver.FindElement(By.Id("age")).Click();

            driver.FindElement(By.Id("age")).Click();

            driver.FindElement(By.Id("age")).SendKeys("29");

            driver.FindElement(By.Id("experience")).Click();

            driver.FindElement(By.Id("experience")).SendKeys("0");

            driver.FindElement(By.Id("accidents")).Click();

            driver.FindElement(By.Id("accidents")).SendKeys("0");

            //Assert 

            {

                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");

                Assert.That(value, Is.EqualTo(""));

            }

        }
        [Test]
        public void eigthTest_omittedAccidents_37Age_8Experience_AccidentsError()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1440, 786);
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
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4C8");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("jiya@gmail");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("656-985-0234");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("37");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("8");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            {
                string value = driver.FindElement(By.Id("age")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("37"));
            }
            {
                string value = driver.FindElement(By.Id("experience")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("8"));
            }
            Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Number of accidents is required"));
        }
        [Test]
        public void ninthTest_omittedExperience_45Age_0Accidents_ExperienceError()
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
            driver.FindElement(By.CssSelector(".col-md-2")).Click();
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4C8");
            driver.FindElement(By.CssSelector(".col-md-4:nth-child(1)")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("904-232-2332");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("anjana@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("45");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            {
                string value = driver.FindElement(By.Id("age")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("45"));
            }
            {
                string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("0"));
            }
            Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));
        }
        [Test]
        public void thirteenthTest_29Age_2Experience_2500BaseRate()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1296, 688);
            //Action
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("dhruvi");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Lad");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("210 nine pines");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E 1L3");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-978-5189");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("dhruvi@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("29");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("2");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.Id("finalQuote")).Click();
            driver.FindElement(By.Id("finalQuote")).Click();
            //Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$2500"));
            }
        }
        [Test]
        public void fourteenthTest_32Age_2Experience_1875BaseRate()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1280, 672);
            //Action
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.CssSelector(".card:nth-child(1) > div > .form-group:nth-child(1)")).Click();
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("dhruvi");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("Lad");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("210 nine pines");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("waterloo");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E 3R2");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-978-5186");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("dhruvi@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).SendKeys("32");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("experience")).SendKeys("2");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("0");
            driver.FindElement(By.Id("btnSubmit")).Click();
            driver.FindElement(By.Id("finalQuote")).Click();
            driver.FindElement(By.Id("finalQuote")).Click();
            //Assert
            {
                string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
                Assert.That(value, Is.EqualTo("$1875"));
            }
        }

        [Test]
        public void fifteenthTest_omittedFirstname_FirstNameError()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1280, 672);
            //Action
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("varadan");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).SendKeys("210 nine pines");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("postalCode")).Click();
            driver.FindElement(By.Id("postalCode")).SendKeys("N2E 1L3");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("226-978-5186");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("anjana@gmail.com");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Click();
            {
                var element = driver.FindElement(By.Id("age"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            driver.FindElement(By.Id("age")).SendKeys("30");
            driver.FindElement(By.Id("experience")).SendKeys("1");
            driver.FindElement(By.Id("experience")).Click();
            driver.FindElement(By.Id("accidents")).SendKeys("1");
            driver.FindElement(By.Id("accidents")).Click();
            driver.FindElement(By.Id("btnSubmit")).Click();
            //Assert
            Assert.That(driver.FindElement(By.Id("firstName-error")).Text, Is.EqualTo("First Name is required"));

            driver.FindElement(By.CssSelector(".container")).Click();
        }
    }

}


