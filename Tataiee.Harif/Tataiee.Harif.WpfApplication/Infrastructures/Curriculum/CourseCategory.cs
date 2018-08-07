using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.Infrastructures.Data.Curriculum
{
    //Node
    public class CourseCategory
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<Gate> OutputGates { get; set; } = new List<Gate>();
        public List<Gate> InputGates { get; set; } = new List<Gate>();

        public List<Course> Courses { get; set; } = new List<Course>();


        public bool IsRoot() => InputGates.Count == 0 && OutputGates.Count > 0;

        public bool IsLevel1() => InputGates.Count == 1 && InputGates[0].SrcCourseCategory.IsRoot();

        public bool IsInputOutput() => InputGates.Count > 0 && OutputGates.Count > 0;//or -> !IsRoot() && !IsEdge();

        public bool IsEdge() => OutputGates.Count == 0 && InputGates.Count > 0;

    }
}
