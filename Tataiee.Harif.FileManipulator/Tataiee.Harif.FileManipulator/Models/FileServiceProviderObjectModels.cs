using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tataiee.Harif.FileManipulator.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class AvailableCoursesRow
    {
        /// <summary>
        /// گروه
        /// به عنوان مثال فنی و مهندسی
        /// </summary>
        public string Group { get; set; }


        /// <summary>
        /// کمیته تخصصی
        /// به عنوان مثال مهندسی برق
        /// </summary>
        public string SpecializedCommittee { get; set; }

        /// <summary>
        /// رشته
        /// به عنوان مثال مهندسی  برق،مهندسی کامپیوتر و غیره
        /// </summary>
        public string FieldTitle { get; set; }


        /// <summary>
        /// مقطع تحصیلی
        /// بعنوان مثال کارشناسی
        /// </summary>
        public string Degree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CourseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SubsetType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CourseTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Units { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Status Status { get; set; }
        /// <summary>
        ///
        /// </summary>
        public SpecialType SpecialType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> Prerequisites { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> Requisites { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MinRequireTerm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MinRequireUnits { get; set; }
    }
    /// <summary>
    /// Course Status
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// 
        /// </summary>
        THERORYCAL,
        /// <summary>
        ///
        /// </summary>
        PRACTICAL,
        /// <summary>
        /// 
        /// </summary>
        PRACTICAL_AND_THERORYCAL,
        /// <summary>
        /// 
        /// </summary>
        NAN,
    }
    /// <summary>
    /// LABORATORY/WORKSHOP/NAN
    /// </summary>
    public enum SpecialType
    {
        /// <summary>
        /// 
        /// </summary>
        LABORATORY,
        /// <summary>
        /// 
        /// </summary>
        WORKSHOP,
        /// <summary>
        /// 
        /// </summary>
        NAN,
    }
    /// <summary>
    /// A record of UserHistory
    /// </summary>
    public class UserHistory
    {
        /// <summary>
        /// 
        /// </summary>
        public int TermNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SemesterStatus SemesterStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CourseName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public CourseStatusHisotry Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Grade { get; set; }//default 0

    }
    /// <summary>
    /// 
    /// </summary>
    public enum SemesterStatus
    {
        /// <summary>
        /// 
        /// </summary>
        SEMESTER1,
        /// <summary>
        /// 
        /// </summary>
        SEMESTER2,
        /// <summary>
        /// 
        /// </summary>
        SUMMER,
    }
    /// <summary>
    /// 
    /// </summary>
    public enum CourseStatusHisotry
    {
        /// <summary>
        /// 
        /// </summary>
        PASSED,
        /// <summary>
        /// 
        /// </summary>
        FAILED,
        /// <summary>
        /// 
        /// </summary>
        REMOVED,
        /// <summary>
        /// 
        /// </summary>
        NAN,
    }

    /// <summary>
    /// 
    /// </summary>
    public class GoalVersionOfferedCoursesRow : OfferedCoursesRow
    {
        /*
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
        public Status Status { get; set; }

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
        */
        /// <summary>
        /// زمان و مکان و ارائه بصورت پردازش شده
        /// </summary>
        public TimeAndSiteAndExams TimeAndSitesAndExam { get; set; }
        /*
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        */

    }
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
        public Status Status { get; set; }

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
    }
    /// <summary>
    /// 
    /// </summary>
    public class LocalSite
    {
        /// <summary>
        /// 
        /// </summary>
        public string RawStringSiteValue { get; set; } = "";
    }
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
            //می توان اعتبار سنجی برای این مورد را پیچیده تر کرد و سالهای کبیشه را در نظر گرفن اما در اینجا ما اینکار را انجام نداده ایم
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
