using System;
using System.IO;
using System.Threading;
using ClassLibrary1;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



namespace UnitTestProject1
{
    [TestFixture]
    public class BingTest
    {
        [Test]
        public void FirstTest()
        {
            using (IWebDriver dr = new ChromeDriver(Directory.GetCurrentDirectory()))
            {
                var google = new Google(dr);
                google.FullScreen();
                Thread.Sleep(2000);
                google.MoveToGoogle();
                Thread.Sleep(2000);
                google.Search(Rozetka.Url);
                Thread.Sleep(2000);
                google.Click();
                Thread.Sleep(2000);
                var rozetka = Google.MoveNext();
                Thread.Sleep(2000);
                rozetka.MoveToRozetka();
                Thread.Sleep(2000);
                rozetka.FindLepTop();
                Thread.Sleep(2000);
                rozetka.FindApple();
                Thread.Sleep(2000);
                rozetka.MoveToAppleLepTop();
                Thread.Sleep(2000);
                rozetka.BuyLepTop();
                Thread.Sleep(2000);
                //google.MoveNext();
            }
        }
    }
}
