using System;

namespace ToDoApp.Business
{
    public class ToDoSystem
    {
        public static double CalculateWorkingDays(DateTime myStart, DateTime myEnd)
        {
            double totalDays = (myEnd - myStart).TotalDays;
            int missingDays = myStart.DayOfWeek - myEnd.DayOfWeek;

            double calcBusinessDays = 1 + (totalDays * 5 - missingDays * 2) / 7;

            if (myEnd.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
            if (myStart.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;

            return calcBusinessDays;
        }
    }

   

}
