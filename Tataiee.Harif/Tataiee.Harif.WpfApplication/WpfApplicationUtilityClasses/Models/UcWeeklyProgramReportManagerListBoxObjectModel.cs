using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Models
{
    internal class UcWeeklyProgramReportManagerListBoxObjectModel
    {
        public string DisplayName { get; set; }
        public string FileName { get; set; }
        public override string ToString()
        {
            return DisplayName;
        }
    }
}
