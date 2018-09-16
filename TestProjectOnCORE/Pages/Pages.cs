using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class Google
    {
        public Google(IWebDriver driver)
        {
            Google.driver = driver;
            this.wait = new WebDriverWait(driver,TimeSpan.FromSeconds(2));
        }
        private static IWebDriver driver;
        private string url = "http://google.com";
        private WebDriverWait wait;
        //Creatin properties for elements at page
        private static IWebElement SearchField{get{return driver.FindElement(By.CssSelector("#lst-ib"));}}
        private static IWebElement SearchButton{get{return driver.FindElement(By.CssSelector("#tsf"));}}
        //creating methods for tests
        public void MoveToGoogle()
        {
            driver.Navigate().GoToUrl(url);

        }
        public void Search(string txt)
        {
            SearchField.Clear();
            SearchField.SendKeys(txt);
        }
        public static Rozetka MoveNext()
        {
            return new Rozetka(Google.driver);
        }
        public void Click()
        {
            SearchButton.Click();
        }
        public void FullScreen()
        {
            driver.Manage().Window.Maximize();
        }
    }
    public class Rozetka
    {
        public Rozetka(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
        }
        private IWebDriver driver;
        public static string Url = "rozetka.com.ua";
        private WebDriverWait wait;
        private IWebElement RozetkaButton{get{return driver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div > div > h3 > a"));}}
        private IWebElement LepTopButton{ get { return driver.FindElement(By.Name("fat_menu_link")); }}
        private IWebElement AppleBlock{ get { return driver.FindElement(By.CssSelector("#content-inner-block > div:nth-child(4) > div > div > div.pos-fix.c-cols-r.portal-c-cols-r > div > div:nth-child(1) > div.c-cols-inner-l-wrap.portal-c-cols-inner-l-wrap > div > div.portal-automatic > div > div > div:nth-child(1) > div > div:nth-child(1) > div:nth-child(1) > div > ul > li:nth-child(6) > a")); }}
        private IWebElement AppleDevice{ get { return driver.FindElement(By.CssSelector("#catalog_goods_block > div > div:nth-child(3) > div.over-wraper > div > div > div > div.g-i-tile-i-title.clearfix > a")); }}
        public void MoveToRozetka()
        {
            if(RozetkaButton.Displayed)
                RozetkaButton.Click();
        }
        public void FindLepTop()
        {
            if (LepTopButton.Displayed)
                LepTopButton.Click();
        }
        public void FindApple()
        {
            if (AppleBlock.Displayed)
                AppleBlock.Click();
        }
        public void MoveToAppleLepTop()
        {
            if (AppleDevice.Displayed)
                AppleDevice.Click();
        }
    }
}
