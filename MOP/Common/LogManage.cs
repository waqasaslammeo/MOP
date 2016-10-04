using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MOP.Common
{
    public static class LogManage
    {
        public static void Log(string log)
        {
            //File name: DayMonthYear i.e 08092016 --- 08= day, 09= month, 2016=year

            var fileName = DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() +
                           DateTime.Now.Date.Year.ToString() + ".txt";
            var path = "/Log/" + fileName;
            if (!System.IO.File.Exists(path))
            {
                //File.Create(path);
            }

            //File.AppendAllText(path, log);

        }
    }
}