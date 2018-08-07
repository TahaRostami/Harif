using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.WeeklyProgram
{

    internal class WeeklyProgramRow
    {
        public List<string> ReadOnlyTextCell { get; set; } = new List<string>();

        public List<WeeklyProgramCell> Cells { get; set; } = new List<WeeklyProgramCell>();
    }
}
