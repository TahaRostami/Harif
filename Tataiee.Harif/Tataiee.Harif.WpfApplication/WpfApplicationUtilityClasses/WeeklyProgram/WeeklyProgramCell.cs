using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.OfferedCourses.Models;

namespace Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.WeeklyProgram
{
    internal class WeeklyProgramCell
    {
        public WeeklyProgramCell(GoalVersionOfferedCoursesRow courseRow, LocalTime start, LocalTime finish)
        {
            CoursesRow = courseRow;
            StartTime = start;
            FinishTime = finish;
        }
        public GoalVersionOfferedCoursesRow CoursesRow { get; private set; }

        public string CourseName { get => CoursesRow.CourseTitle; }

        public LocalTime StartTime { get; private set; }

        public LocalTime FinishTime { get; private set; }

    }
}
