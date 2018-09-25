using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Enums;

namespace Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Models
{
    internal class StudentHistoryGridRow
    {
        public int Id { get; set; }
        public string CodeInDesUni { get; set; }
        public string TitleInDesUni { get; set; }

        public StudentHistoryGridRowColors StatusColor{get;set;}

    }    

}
