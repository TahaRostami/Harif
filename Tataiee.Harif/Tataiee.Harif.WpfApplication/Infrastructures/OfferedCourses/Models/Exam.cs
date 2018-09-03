using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.Infrastructures.OfferedCourses.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Exam
    {
        /// <summary>
        /// 
        /// </summary>
        public LocalTime StartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public LocalTime FinishTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public LocalDate Date { get; set; }
    }
}
