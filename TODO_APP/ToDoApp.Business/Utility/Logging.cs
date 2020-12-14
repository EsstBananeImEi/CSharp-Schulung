using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDoApp.Business.Utility
{
    public static class Logging
    {

        public static void WriteLog(string myMessage)
        {

            string myPath = @"ToDoLogging.txt";
            string date = GetDateString();
            string myText = date + " - " + myMessage + "\r\n";

            DoWrite(myPath, myText);
        }

        public static string GetDateString()
        {
            return DateTime.Now.ToString("dd.MM.yyyy-HH:mm:ss");
        }

        public static void DoWrite(string myPath, string myText)
        {
            if (File.Exists(myPath))
                File.AppendAllText(myPath, myText);
            else
                File.WriteAllText(myPath, myText);
        }
    }

    
}
