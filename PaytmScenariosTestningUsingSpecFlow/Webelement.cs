using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaytmScenariosTestningUsingSpecFlow
{
    static class Webelement
    {

        public const string Mobile = "//img[@class='_3thc' and @data-reactid='68']";
        public const string Electricity = "//img[@class='_3thc' and @data-reactid='73']";
        public const string DTH = "//img[@class='_3thc' and @data-reactid='78']";
        public const string Metro = "//img[@class='_3thc' and @data-reactid='83']";
        public const string MobileLink = "//img[@alt='Mobile ']";
        public const string MobileNum = "//input[@type='tel']";
        public const string Amount = "//*[@id='app']/div/div[4]/div[1]/div[1]/div/div[2]/div[2]/ul/li[3]/div[1]/div[1]/input";
        public const string ProceedToRecharge = "//*[@id='app']/div/div[4]/div[1]/div[1]/div/div[2]/div[5]/button";
        public const string Navigation= " //*[@id='app']/div";
    }
}
