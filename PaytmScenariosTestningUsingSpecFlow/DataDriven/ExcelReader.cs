using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PaytmScenariosTestningUsingSpecFlow.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaytmScenariosTestningUsingSpecFlow.DataDriven
{
    [TestClass]
    public class ExcelReader
    {
        private TestContext _testcontext;

        public TestContext TestContext
        {
            get { return _testcontext; }
            set { _testcontext = value; }
        }

        
        #region web elements
        private By Mobilelink = By.XPath(Webelement.MobileLink);
        private By MobileNum = By.XPath(Webelement.MobileNum);
        private By Amount = By.XPath(Webelement.Amount);
        private By ProceedToRecharge = By.XPath(Webelement.ProceedToRecharge);
        private By Navigation = By.XPath(Webelement.Navigation);
        #endregion 
        [TestMethod]
        [DataSource("System.Data.Odbc", @"Dsn=Excel Files; dbq=C:\Users\ee210668\Desktop\Data.xlsx;", "Details$", DataAccessMethod.Sequential)]
        public void Actions()
        {
            ObjectRepository.Driver.Navigate().GoToUrl("https://paytm.com/");
            ObjectRepository.Driver.Manage().Window.Maximize();
            ObjectRepository.Driver.FindElement(Mobilelink).Click();
            ObjectRepository.Driver.FindElement(MobileNum).SendKeys(TestContext.DataRow["MobileNumber"].ToString());
            ObjectRepository.Driver.FindElement(Amount).SendKeys(TestContext.DataRow["Amount"].ToString());
            ObjectRepository.Driver.FindElement(ProceedToRecharge).Click();


        }

    }
}
