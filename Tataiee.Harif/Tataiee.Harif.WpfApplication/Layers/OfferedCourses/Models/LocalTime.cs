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
    public class LocalTime
    {
        private int hour;
        private int minute;
        /// <summary>
        /// 
        /// </summary>
        public int Hour
        {
            get { return hour; }
            set
            {
                if (value >= 0 && value < 24)
                {
                    hour = value;
                }
                else
                    throw new Exception();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Minute
        {
            get { return minute; }
            set
            {
                if (value >= 0 && value < 60)
                {
                    minute = value;
                }
                else
                    throw new Exception();
            }
        }

        public override string ToString()
        {
            return string.Format("{0:00}:{1:00}", Hour, Minute);
        }
    }
}
