using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.WpfApplication.Layers.StudentHistory
{
    public class CourseInformation
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string CorrespondingTitleInDesUni { get; set; }

        public string CodeInDesUni { get; set; }

        public bool IsPassed { get; set; }

        public int NumberOfFailed { get; set; }
    }
}
