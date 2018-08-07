using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.WpfApplication.Layer.OfferedCourses.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class TimeAndSiteAndExams
    {
        /// <summary>
        /// 
        /// </summary>
        public List<TimeAndSite> TimeAndSites { get; set; } = new List<TimeAndSite>();
        /// <summary>
        /// 
        /// </summary>
        public Exam Exam { get; set; }
    }
}
