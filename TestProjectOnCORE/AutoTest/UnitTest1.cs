using NUnit.Framework;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Pages;
using System.IO;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void GoogleTest()
        {
            using(IWebDriver dr = new ChromeDriver(Directory.GetCurrentDirectory()))
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
                Thread.Sleep(10000);
                //google.MoveNext();
            }
        }
    }
}