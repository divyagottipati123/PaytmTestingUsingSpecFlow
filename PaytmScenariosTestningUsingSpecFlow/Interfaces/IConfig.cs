using PaytmScenariosTestningUsingSpecFlow.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaytmScenariosTestningUsingSpecFlow.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        String GetWebsite();
    }
}
