using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.WpfApplication.Layer.GeneralEnums;
using Tataiee.Harif.WpfApplication.Layer.OfferedCourses.Models;

namespace Tataiee.Harif.WpfApplication.Layers.OfferedCourses
{
    public class OfferedCoursesServiceProvider
    {

        public static bool DoTheyExamCollide(Exam exam1, Exam exam2)
        {
            if (exam1 == null || exam2 == null) return false;

            if (exam1.Date == null || exam2.Date == null) return false;

            /*
            * if you want to strictly check
            * but in the current golestan system this may not occure bacause every exam have one data and finish on it day
            * 
            PersianCalendar pc = new PersianCalendar();

            DateTime dtExam1Start = pc.ToDateTime(exam1.Date.Year, exam1.Date.Month, exam1.Date.Day, exam1.StartTime.Hour, exam1.StartTime.Minute, 0, 0);
            DateTime dtExam1Finish = pc.ToDateTime(exam1.Date.Year, exam1.Date.Month, exam1.Date.Day, exam1.FinishTime.Hour, exam1.FinishTime.Minute, 0, 0);

            DateTime dtExam2Start = pc.ToDateTime(exam2.Date.Year, exam2.Date.Month, exam2.Date.Day, exam2.StartTime.Hour, exam2.StartTime.Minute, 0, 0);
            DateTime dtExam2Finish = pc.ToDateTime(exam2.Date.Year, exam2.Date.Month, exam2.Date.Day, exam2.FinishTime.Hour, exam2.FinishTime.Minute, 0, 0);

            if (dtExam1Finish.Subtract(dtExam2Start).TotalSeconds < 0 || dtExam1Start.Subtract(dtExam2Finish).TotalSeconds > 0)
                return false;
            else
                return true;
            */


            if (exam1.Date.Day != exam2.Date.Day || exam1.Date.Month != exam2.Date.Month || exam1.Date.Year != exam2.Date.Year) return false;

            return DoTheyTimeCollide(exam1.StartTime, exam1.FinishTime, exam2.StartTime, exam2.FinishTime);
        }

        public static bool DoTheyCollide(List<TimeAndSite> row1, List<TimeAndSite> row2)
        {
            if (row1 == null || row2 == null || row1.Count == 0 || row2.Count == 0)
                return false;

            for (int i = 0; i < row1.Count; i++)
            {
                var obj1 = row1[i];
                for (int j = 0; j < row2.Count; j++)
                {
                    var obj2 = row2[j];
                    if (CompareDay(obj1.Day, obj2.Day) == 0 && DoTheyTimeCollide(obj1.StartTime, obj1.FinishTime, obj2.StartTime, obj2.FinishTime))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool DoTheyTimeCollide(LocalTime StartTime1, LocalTime FinishTime1, LocalTime StartTime2, LocalTime FinishTime2)
        {
            //if we can not consider edge of them
            if ((CompareTime(FinishTime1, StartTime2) == 0 && CompareTime(StartTime1, FinishTime2) < 0)
                ||
                (CompareTime(FinishTime2, StartTime1) == 0 && CompareTime(StartTime2, FinishTime1) < 0)
                )
            {
                return false;
            }

            if (CompareTime(FinishTime1, StartTime2) < 0 || CompareTime(StartTime1, FinishTime2) > 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="time1"></param>
        /// <param name="time2"></param>
        /// <returns>time1 > time2 -> 1 , time1 = time2 -> 0 , else -> -1 </returns>
        public static int CompareTime(LocalTime time1, LocalTime time2)
        {
            //int t1 = time1.Hour * 60 + time1.Minute;
            //int t2 = time2.Hour * 60 + time2.Minute;

            //if (t1 > t2)
            //{
            //    return 1;
            //}
            //else if (t1 == t2)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return -1;
            //}

            if (time1.Hour > time2.Hour)
            {
                return 1;
            }
            else if (time1.Hour < time2.Hour)
            {
                return -1;
            }
            else//time1.Hour<time2.Hour
            {
                if (time1.Minute > time2.Minute)
                {
                    return 1;
                }
                else if (time1.Minute < time2.Minute)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="day1"></param>
        /// <param name="day2"></param>
        /// <returns>day1 -> 1 , day1 = day2 -> 0 , else -> -1</returns>
        public static int CompareDay(Day day1, Day day2)
        {
            if (day1 == day2)
            {
                return 0;
            }
            else if (day1 > day2)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

    }
}
