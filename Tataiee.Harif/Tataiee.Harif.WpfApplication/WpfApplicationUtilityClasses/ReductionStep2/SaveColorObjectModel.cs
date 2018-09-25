using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.Data.Curriculum;
using Tataiee.Harif.Infrastructures.OfferedCourses.Models;
using Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Enums;

namespace Tataiee.Harif.WpfApplication
{
    public class SaveColorObjectModel
    {
        public int CorrespondingIdInSourceList { get; set; }
        public ReductionStep2ColorStatus Color { get; set; }
    }
}
