using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaytmScenariosTestningUsingSpecFlow.DataDriven
{
    [TestClass]
   public class TestExceldata
    {
        [TestMethod]
        public void TestReadExcel()
        {
            string xlpath = @"C:\Users\ee210668\Desktop\Data.xlsx";

           Console.WriteLine( ExcelPackage.GetCellData(xlpath,"Details",1,0));
            Console.WriteLine(ExcelPackage.GetCellData(xlpath, "Details", 1, 1));


        }
    }
}
