using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.GeneralEnums;

namespace Tataiee.Harif.Infrastructures.Data.Curriculum
{
    public class Course
    {
        //note
        public bool IsAvailable() => CodeInDesUni != SPECIAL_NULL_STRING_SYMBOL;

        public bool IsLabOrWorkshop() => Title.StartsWith("کارگاه") || Title.StartsWith("آزمایشگاه") 
                                        || CorrespondingTitleInDesUni.StartsWith("کارگاه") || CorrespondingTitleInDesUni.StartsWith("آزمایشگاه")
                                        ;

        public const string SPECIAL_NULL_STRING_SYMBOL = "-";

        public int Id { get; set; }

        //عنوان درس
        public string Title { get; set; }
        //تعداد واحد
        public int Units { get; set; }
        //حداقل ترمی که میتوان این درس را اخذ کرد
        public int MinRequireTerm { get; set; }
        //حداقل واحدی که باید برای اخذ این درس گذرانده شده باشد
        public int MinReuireUnits { get; set; }

        //لیست پیشنیاز ها
        public List<Course> PrerequisiteCourses = new List<Course>();
        //لیست همنیاز ها
        public List<Course> RequisiteCourses = new List<Course>();

        //عملی/نظری
        public CourseStatus Status { get; set; }

        //آیا درس را با موفقیت گذرانده است
        public bool IsPassed { get; set; }//default false

        //تعداد دفعاتی که درس را افتاده است
        public int NumberOfFailed { get; set; }

        //تعداد دفعاتی که این درس توسط دانشجو حذف شده است
        public int NumberOfRemove { get; set; }

        public List<CourseCategory> CourseCategories = new List<CourseCategory>();//subset name,SubsetType

        //------------------------------------

        //عنوان متناظر برای درس در دانشگاه مقصد
        public string CorrespondingTitleInDesUni { get; set; } = SPECIAL_NULL_STRING_SYMBOL;

        //با فرض ساده سادی اینکه هر درس در برنامه درسی مصوبه بتواند متناظر با یک درس در دانشگاه مقصد باشد
        //کد درس در دانشگاه مقصد
        public string CodeInDesUni { get; set; } = SPECIAL_NULL_STRING_SYMBOL;
    }
}
