using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.OfferedCourses.Models;

namespace Tataiee.Harif.Infrastructures.Algorithm.Models
{
    public class OfferedWeeklyProgram
    {
        public List<GoalVersionOfferedCoursesRow> DataSource { get; set; }

        public double Score { get; set; }

        public int NumberOfUnits { get; set; }

        public int TermNumber { get; set; }

        public int UserScore { get; set; }

        public string Description { get; set; }

    }
}
