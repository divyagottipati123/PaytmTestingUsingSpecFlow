using Excel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaytmScenariosTestningUsingSpecFlow.DataDriven
{
    
     public class ExcelPackage
    {
       
     
            private static IDictionary<string, IExcelDataReader> _cache;
            private static FileStream stream;
            private static IExcelDataReader reader;
            static ExcelPackage()
            {
                 _cache = new Dictionary<string, IExcelDataReader>();
                    
            }
        public static string GetCellData(string xlpath,string sheetname,int row ,int column)
        {
            if(_cache.ContainsKey(sheetname))
            {
                reader = _cache[sheetname];
            }
            else
            {
                stream = new FileStream(xlpath, FileMode.Open, FileAccess.Read);
                reader= ExcelReaderFactory.CreateOpenXmlReader(stream);
                _cache.Add(sheetname, reader);

            }
            DataTable table = reader.AsDataSet().Tables[sheetname];
            return table.Rows[row][column].ToString();


        }



        }
    }

