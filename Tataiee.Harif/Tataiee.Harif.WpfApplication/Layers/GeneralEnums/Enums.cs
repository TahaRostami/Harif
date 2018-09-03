using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.WpfApplication.Layer.GeneralEnums
{
    public enum CourseStatus
    {
        THERORYCAL,
        PRACTICAL,
    }

    /// <summary>
    /// 0-شنبه=Saturday 
    ///,1-يكشنبه=Sunday 
    ///,2-دوشنبه=Monday 
    ///,3-سه شنبه=Tuesday 
    ///,4-چهارشنبه=Wednesday 
    ///,5-پنچشنبه=Thursday 
    ///,6-جمعه=Friday
    /// </summary>
    public enum Day
    {
        /// <summary>
        /// 
        /// </summary>
        NAN = -1,
        /// <summary>
        /// 
        /// </summary>
        SATURDAY = 0,
        /// <summary>
        /// 
        /// </summary>
        SUNDAY = 1,
        /// <summary>
        /// 
        /// </summary>
        MONDAY = 2,
        /// <summary>
        /// 
        /// </summary>
        TUESDAY = 3,
        /// <summary>
        /// 
        /// </summary>
        WEDNESDAY = 4,
        /// <summary>
        /// 
        /// </summary>
        THURSDAY = 5,
        /// <summary>
        /// 
        /// </summary>
        FRIDAY = 6,
    }

    /// <summary>
    /// 
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// 
        /// </summary>
        COEDUCATIONAL,
        /// <summary>
        /// 
        /// </summary>
        MALE,
        /// <summary>
        /// 
        /// </summary>
        FEMALE,
        /// <summary>
        /// 
        /// </summary>
        TRANSSEXUAL,
        /// <summary>
        /// 
        /// </summary>
        NAN,
    }

}
