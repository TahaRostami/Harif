using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.WpfApplication.Data.Curriculum;
using Tataiee.Harif.WpfApplication.Layer.GeneralEnums;
using Tataiee.Harif.WpfApplication.Layer.OfferedCourses;
using Tataiee.Harif.WpfApplication.Layer.OfferedCourses.Models;

namespace Tataiee.Harif.WpfApplication.Layers.ReductionSteps
{
    public class ReductionStep2
    {
        public static List<GoalVersionOfferedCoursesRow> Reduce(List<Course> courses, List<GoalVersionOfferedCoursesRow> goalVersionOfferedCoursesRows, Gender studGender)
        {
            if (studGender == Gender.NAN || studGender == Gender.TRANSSEXUAL || studGender == Gender.COEDUCATIONAL)
                throw new NotSupportedException();

            int len = courses[0].CodeInDesUni.Length;

            var groups = from c in goalVersionOfferedCoursesRows
                         where c.Gender == studGender || c.Gender == Layer.GeneralEnums.Gender.COEDUCATIONAL
                         group c by c.Id.Substring(0, len);

            List<GoalVersionOfferedCoursesRow> newLst = new List<GoalVersionOfferedCoursesRow>();

            foreach (var group in groups)
            {
                var q = courses.FirstOrDefault(c => c.CodeInDesUni == group.Key);
                if (q != null)
                {
                    foreach (var row in group)
                    {
                        newLst.Add(row);
                    }
                }
            }

            return newLst;
        }

        public static List<GoalVersionOfferedCoursesRow> Reduce(List<Course> courses,string goalVersionOfferedCoursesRowsFileName, Gender studGender)
        {
            List<GoalVersionOfferedCoursesRow> lst;
            FileServiceProvider.DeserializeFromXmlFile(goalVersionOfferedCoursesRowsFileName, out lst);
            return Reduce(courses, lst, studGender);
        }

        public static bool TryReduce(List<Course> courses, List<GoalVersionOfferedCoursesRow> goalVersionOfferedCoursesRows, Gender studGender,out List<GoalVersionOfferedCoursesRow> resultLst)
        {
            bool succ = true;
            try
            {
                resultLst = Reduce(courses, goalVersionOfferedCoursesRows, studGender);
            }
            catch
            {
                resultLst = null;
                succ = false;
            }
            return succ;
        }

        public static bool TryReduce(List<Course> courses, string goalVersionOfferedCoursesRowsFileName, Gender studGender, out List<GoalVersionOfferedCoursesRow> resultLst)
        {
            bool succ = true;
            try
            {
                List<GoalVersionOfferedCoursesRow> lst;
                FileServiceProvider.DeserializeFromXmlFile(goalVersionOfferedCoursesRowsFileName, out lst);
                resultLst = Reduce(courses, lst, studGender);
            }
            catch
            {
                resultLst = null;
                succ = false;                
            }
            return succ;
        }
        
    }
}
