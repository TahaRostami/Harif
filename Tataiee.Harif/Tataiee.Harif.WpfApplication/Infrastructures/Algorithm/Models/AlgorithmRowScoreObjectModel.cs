using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.OfferedCourses.Models;

namespace Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Models
{
    public class AlgorithmRowScoreObjectModel
    {
        public static int Compare(AlgorithmRowScoreObjectModel m1, AlgorithmRowScoreObjectModel m2)
        {
            if (m1 == null || m2 == null) throw new Exception();

            return m1.WeeklyProgramScore > m2.WeeklyProgramScore ? 1 : m1.WeeklyProgramScore == m2.WeeklyProgramScore ? 0 : -1;

        }

        public static bool Equal(AlgorithmRowScoreObjectModel m1, AlgorithmRowScoreObjectModel m2)
        {
            if (m1 == null || m2 == null) throw new Exception();

            if (m1.WeeklyProgram.Columns.Count != m2.WeeklyProgram.Columns.Count) return false;

            int i = 0;
            while (i < m1.WeeklyProgram.Columns.Count)
            {
                if (m1.WeeklyProgram.Columns[i].GoalVersionOfferedCourseRow != m2.WeeklyProgram.Columns[i].GoalVersionOfferedCourseRow)
                {
                    return false;
                }
                i++;
            }
            return true;
        }


        public Row WeeklyProgram { get; set; }
        public double WeeklyProgramScore { get; set; }
        public static double CalculateWeeklyProgramScore(List<OfferedCourseRow> lst)
        {
            double res = 0;
            int units = 0;

            SortedList<int, TimeAndSite> rows = new SortedList<int, TimeAndSite>();

            foreach (var item in lst)
            {
                if (item.GoalVersionOfferedCourseRow.TimeAndSitesAndExam != null && item.GoalVersionOfferedCourseRow.TimeAndSitesAndExam.TimeAndSites != null)
                {
                    foreach (var timeAndSite in item.GoalVersionOfferedCourseRow.TimeAndSitesAndExam.TimeAndSites)
                    {
                        rows.Add((((int)timeAndSite.Day) * 60 * 24 + timeAndSite.StartTime.Hour * 60 + timeAndSite.StartTime.Minute), timeAndSite);
                    }
                }
                units += item.OfferedCourse.Course.Units;
            }

            for (int i = 1; i < rows.Count; i++)
            {
                int dt = (((int)rows.Values[i].Day) * 60 * 24 + rows.Values[i].StartTime.Hour * 60 + rows.Values[i].StartTime.Minute) -
                         (((int)rows.Values[i - 1].Day) * 60 * 24 + rows.Values[i - 1].FinishTime.Hour * 60 + rows.Values[i - 1].FinishTime.Minute);
                res += dt;
            }
            //7*24*60 - res * -1
            return (res * -1.0 * 1.3) / units;
        }
    }
}
