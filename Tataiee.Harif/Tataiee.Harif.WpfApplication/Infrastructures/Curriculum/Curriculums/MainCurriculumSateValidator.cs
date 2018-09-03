using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;

namespace Tataiee.Harif.WpfApplication.Infrastructures.Curriculum.Curriculums
{    
    public class MainCurriculumSateValidator
    {
        /// <summary>
        /// all rules
        /// </summary>
        /// <param name="curriculum">updated curriculm provided by StudentHistoryServiceProvider.CreateNewCurriculmWithSpecificCreditAndFilledBySpecificCourseInforamtion() must be passed</param>
        /// <param name="takenCoursesId">id's of courses which you want to take and after it you want to know :=> curriculum is in valid state or not?</param>
        /// <returns></returns>
        public static bool IsValidState(MainCurriculum curriculum, List<int> takenCoursesId)
        {
            //secondary rules
            bool o = SecondaryRulesStateValidator.IsValidState(curriculum, takenCoursesId);
            if (!o) return false;

            //basic rules
            return BasicRulesStateValidator.IsValidState(curriculum, takenCoursesId);
        }
    }
}
