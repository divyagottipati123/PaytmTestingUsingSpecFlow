using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using PaytmScenariosTestningUsingSpecFlow.ComponentHElper;
using PaytmScenariosTestningUsingSpecFlow.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaytmScenariosTestningUsingSpecFlow
{
    
    public class PaytmHomePage
    {
        //private TestContext _testcontext;

        //public TestContext TestContext
        //{
        //    get { return _testcontext; }
        //    set { _testcontext = value; }
        //}
        // [DataSource("System.Data.Odbc", @"Dsn=Excel Files; dbq=C:\Users\ee210668\Desktop\Data.xlsx;", "Details$", DataAccessMethod.Sequential)]
        #region Webelements
        [FindsBy(How = How.XPath, Using = Webelement.Mobile)]
        private IWebElement Mobile;

        [FindsBy(How = How.XPath, Using = Webelement.Electricity)]
        private IWebElement Electricity;

        [FindsBy(How = How.XPath, Using = Webelement.DTH)]
        private IWebElement DTH;

        [FindsBy(How = How.XPath, Using = Webelement.Metro)]
        private IWebElement Metro;

        [FindsBy(How = How.XPath, Using = Webelement.MobileLink)]
        private IWebElement Mobilelink;

        [FindsBy(How = How.XPath, Using = Webelement.MobileNum)]
        private IWebElement MobileNum;

        [FindsBy(How = How.XPath, Using = Webelement.Amount)]
        private IWebElement Amount;

        [FindsBy(How = How.XPath, Using = Webelement.ProceedToRecharge)]
        private IWebElement ProceedToRecharge;

        [FindsBy(How = How.XPath, Using = Webelement.Navigation)]
        private IWebElement Navigation;

        #endregion
        public PaytmHomePage()
        {

            PageFactory.InitElements(ObjectRepository.Driver, this);

        }


        #region Actions

        public void NavigateToPaytmHomePage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.Manage().Window.Maximize();
        }
        public void Mobilelinkclick()
        {
            Mobilelink.Click();
        }
       
        public void EnterMobilenumandAmount()
        {
            MobileNum.SendKeys(Test.MobileNum);
            Amount.SendKeys(Test.Amount);
          // MobileNum.SendKeys(TestContext.DataRow["MobileNumber"].ToString());
           //Amount.SendKeys(TestContext.DataRow["Amount"].ToString());
        }
        public void Proceedtorecharge()
        {
           ProceedToRecharge.Click();
        }

        #endregion
        #region Validation
        public IWebElement MobileValidation()
        {
            return ObjectRepository.Driver.FindElement(By.XPath(Webelement.Mobile));
             

        }
        public IWebElement ElectricityValidation()
        {
           return ObjectRepository.Driver.FindElement(By.XPath(Webelement.Electricity));
        }
        public IWebElement DTHValidation()
        {
           return ObjectRepository.Driver.FindElement(By.XPath(Webelement.DTH));
        }
        public IWebElement MetroValidation()
        {
           return ObjectRepository.Driver.FindElement(By.XPath(Webelement.Metro));
        }
        #endregion

        #region Navigation

        public void NavigationtoRechargePage()
        {
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath(Webelement.Navigation)));
        }
        #endregion
        #region closeBrowser
        public  void CloseBrowser()
        {

            ObjectRepository.Driver.Close();
            ObjectRepository.Driver.Dispose();
        }
        #endregion
    }



}

