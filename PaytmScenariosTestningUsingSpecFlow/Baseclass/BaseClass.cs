using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using PaytmScenariosTestningUsingSpecFlow.Configuration;
using PaytmScenariosTestningUsingSpecFlow.CustumException;
using PaytmScenariosTestningUsingSpecFlow.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaytmScenariosTestningUsingSpecFlow.Baseclass
{
    [TestClass]
   public class BaseClass
    {
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximised");
            return option;
        }
        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }
        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }
        [AssemblyInitialize]
        public static void InitWebdriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();
            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;

                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIEDriver();
                    break;

                default:
                    throw new NoSuitableDriverFound("Driver Not Found:" + ObjectRepository.Config.GetBrowser().ToString());




            }
        }
        //[AssemblyCleanup]
        //public static void TearDown()
        //{
        //    if(ObjectRepository.Driver!=null)
        //    {
        //        ObjectRepository.Driver.Close();
        //        ObjectRepository.Driver.Quit();

        //    }
        //}
    }
}
