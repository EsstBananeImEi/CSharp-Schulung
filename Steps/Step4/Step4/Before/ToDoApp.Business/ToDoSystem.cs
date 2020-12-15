using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Business
{
    public class ToDoSystem
    {
        public static double CalculateWorkingDays(DateTime myStart, DateTime myEnd)
        {
            double myResult = 0;
            for (DateTime i = myStart; i <= myEnd; i=i.AddDays(1))
            {
                if( i.DayOfWeek!= DayOfWeek.Saturday && i.DayOfWeek!= DayOfWeek.Sunday)
                    myResult++;
            }

            return myResult;
        }
    }
}
