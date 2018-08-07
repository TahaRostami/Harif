using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.Data.Curriculum;
using Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Enums;

namespace Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Models
{
    public class OfferedCourse
    {
        public OfferedCourse(Course course, int courseId, ReductionStep2ColorStatus color)
        {
            this.CourseId = courseId;
            Course = course;
            this.Color = color;
        }

        //index in offeredCourses list
        public int CourseId { get; set; }

        public Course Course { get; private set; }

        public int OriginCourseIdInMainCurriculum { get => Course.Id; }

        public string OfferedCourseName { get => Course.CorrespondingTitleInDesUni; }
        public string OfferedCourseCode { get => Course.CodeInDesUni; }

        public List<OfferedCourseRow> OfferedCourseRows { get; set; } = new List<OfferedCourseRow>();

        public ReductionStep2ColorStatus Color { get; set; }

    }
}
