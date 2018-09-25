using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.OfferedCourses.Models;
using Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Enums;

namespace Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Models
{
    public class OfferedCourseRow
    {

        public OfferedCourse OfferedCourse { get; private set; }

        public int RowId { get; set; }

        public GoalVersionOfferedCoursesRow GoalVersionOfferedCourseRow { get; private set; }

        public OfferedCourseRow(GoalVersionOfferedCoursesRow goalVersion, ReductionStep2ColorStatus color, int rowId, OfferedCourse parentCourse)
        {
            GoalVersionOfferedCourseRow = goalVersion;
            Color = color;
            RowId = rowId;
            OfferedCourse = parentCourse;
        }

        public string ProfessorName { get => GoalVersionOfferedCourseRow.ProfessorName; }

        public int RemainedCapacity { get => GoalVersionOfferedCourseRow.Capacity - GoalVersionOfferedCourseRow.Registered; }

        public string TimeAndSiteAndExamRawString { get => GoalVersionOfferedCourseRow.RawStringTimeAndSitesAndExam; }

        public string Description { get => GoalVersionOfferedCourseRow.Description; }

        public ReductionStep2ColorStatus Color { get; set; }

    }
}
