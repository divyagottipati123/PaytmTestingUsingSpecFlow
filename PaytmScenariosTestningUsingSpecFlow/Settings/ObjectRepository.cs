﻿using OpenQA.Selenium;
using PaytmScenariosTestningUsingSpecFlow.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaytmScenariosTestningUsingSpecFlow.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
    }
}
