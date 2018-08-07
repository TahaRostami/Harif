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
    public class OfferedCoursesRow
    {
        /// <summary>
        /// کد دانشکده
        /// </summary>
        public string DepartmentId { get; set; }
        /// <summary>
        ///نام دانشکده
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// کد گروه آموزشی
        /// </summary>
        public string EducationalGroupId { get; set; }
        /// <summary>
        /// نام گروه آموزشی
        /// </summary>
        public string EducationalGroupName { get; set; }
        /// <summary>
        /// شماره و گروه درس
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// عنوان درس
        /// </summary>
        public string CourseTitle { get; set; }

        /// <summary>
        /// //کل
        ///واحد درس
        /// </summary>
        public int Units { get; set; }

        /// <summary>
        /// آیا درس عملی است یا تئوری
        /// </summary>
        public CourseStatus Status { get; set; }

        /// <summary>
        /// ظرفیت
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// تعداد ثبت نام شده
        /// </summary>
        public int Registered { get; set; }

        /// <summary>
        /// تعداد لیست انتظار
        /// </summary>
        public int InWaitingList { get; set; }

        /// <summary>
        /// جنسیت
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// نام استاد
        /// </summary>
        public string ProfessorName { get; set; }

        /// <summary>
        /// زمان و مکان و ارائه بصورت رشته خام
        /// </summary>
        public string RawStringTimeAndSitesAndExam { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }

    }
}
