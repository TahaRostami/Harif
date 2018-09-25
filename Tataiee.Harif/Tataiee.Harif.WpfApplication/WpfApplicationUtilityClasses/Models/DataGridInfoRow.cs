using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.WpfApplication.Models;

namespace Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Models
{
    internal class DataGridInfoRow
    {
        [ColumnName("کد درس")]
        public string Code { get; set; }
        [ColumnName("عنوان درس")]
        public string Title { get; set; }
        [ColumnName("نام استاد")]
        public string ProfessorName { get; set; }
        [ColumnName("زمان/مکان برگزاری کلاس ها و امتحان")]
        public string RawStringTimeAndSitesAndExam { get; set; }
    }
}
