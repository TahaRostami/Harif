using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.WpfApplication.Models;

namespace Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Models
{
    internal class DataGridAdaptationTableGridRow
    {
        [ColumnName("شناسه")]
        public int Id { get; set; }

        [ColumnName("عنوان درس")]
        public string Title { get; set; }

        [ColumnName("عنوان درس در دانشگاه مقصد")]
        public string TitleInDesUni { get; set; }

        [ColumnName("کد درس در دانشگاه مقصد")]
        public string CodeInDesUni { get; set; }
    }
}
