using Bytescout.Spreadsheet;
using HerfaTest_Batch_6.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerfaTest_Batch_6.Helpers
{
    public class CommonMethods
    {
        public static void NavigateToURL(string url)
        {
            ManageDriver.driver.Navigate().GoToUrl(url);
        }
        public static void Highlightelement(IWebElement element)
        {
            IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)ManageDriver.driver;
            javaScriptExecutor.ExecuteScript("arguments[0].setAttribute('style', 'background: yellow !important')", element);
            Thread.Sleep(1000);
            javaScriptExecutor.ExecuteScript("arguments[0].setAttribute('style', 'background: none !important')", element);
        }

        public static Worksheet ReadExcel(string sheetName)//Register
        {
            Spreadsheet Excel = new Spreadsheet();
            Excel.LoadFromFile(GlobalConstant.HerfaTestDataPath);
           Worksheet worksheet = Excel.Workbook.Worksheets.ByName(sheetName);
            return worksheet;
        }

    }
}
