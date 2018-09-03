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
    public class LocalDate
    {
        private int year = 1;
        private int month = 1;
        private int day = 1;

        /// <summary>
        /// 
        /// </summary>
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1 && value < int.MaxValue)
                {
                    year = value;
                }
                else
                    throw new Exception();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }
                else
                    throw new Exception();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Day
        {
            //می توان اعتبار سنجی برای این مورد را پیچیده تر کرد و سالهای کبیسه را در نظر گرفن اما در اینجا ما اینکار را انجام نداده ایم
            get { return day; }
            set
            {
                if (value >= 1 && value <= 31)
                {
                    day = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
