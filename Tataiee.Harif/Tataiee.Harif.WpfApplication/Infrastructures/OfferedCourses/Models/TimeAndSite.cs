using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.GeneralEnums;
using Tataiee.Harif.Infrastructures.GeneralEnums;

namespace Tataiee.Harif.Infrastructures.OfferedCourses.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class TimeAndSite
    {
        /// <summary>
        /// 
        /// </summary>
        public TimeAndSite()
        {
            Site = new LocalSite();
        }
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
        public LocalSite Site { get; set; }
        /// <summary>
        /// شنبه 0ویک شنبه 1و دو شنبه 3 و...و جمعه 6
        /// </summary>
        public Day Day { get; set; }
        
    }
}
