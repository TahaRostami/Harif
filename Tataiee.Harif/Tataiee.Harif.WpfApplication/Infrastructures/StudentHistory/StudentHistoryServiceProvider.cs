using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;
using Tataiee.Harif.Infrastructures.OfferedCourses;
using Tataiee.Harif.Infrastructures.OfferesdCourses;

namespace Tataiee.Harif.Infrastructures.StudentHistory
{
    public class StudentHistoryServiceProvider
    {
        public static bool TryCreateNewCurriculmWithSpecificCreditAndFilledBySpecificCourseInforamtion(string creditFileName, string courseInforamtionFileName, out MainCurriculum curriculum)
        {
            bool succ;
            try
            {
                curriculum = CreateNewCurriculmWithSpecificCreditAndFilledBySpecificCourseInforamtion(creditFileName, courseInforamtionFileName);
                succ = true;
            }
            catch
            {
                curriculum = null;
                succ = false;
            }

            return succ;
        }
        public static MainCurriculum CreateNewCurriculmWithSpecificCreditAndFilledBySpecificCourseInforamtion(string creditFileName, string courseInforamtionFileName)
        {
            CreditDeterminer creditDeterminer;
            FileServiceProvider.DeserializeFromXmlFile(creditFileName, out creditDeterminer);

            List<CourseInformation> courseInfoLst = null;
            FileServiceProvider.DeserializeFromXmlFile(courseInforamtionFileName, out courseInfoLst);

            //create a curriculum object with specify credit
            MainCurriculum curriculum = new MainCurriculum(MainCurriculum.CreateStudentCredit(creditDeterminer.Level1, creditDeterminer.Level2));

            //update curriculm's courses properties noted by student history information
            for (int i = 0; i < courseInfoLst.Count; i++)
            {
                var currentCourseInfo = courseInfoLst[i];
                var currentCourse = curriculum.Courses[i];

                if (currentCourseInfo.Id != currentCourse.Id)
                    throw new ArgumentException();

                currentCourse.CodeInDesUni = currentCourseInfo.CodeInDesUni;
                currentCourse.CorrespondingTitleInDesUni = currentCourseInfo.CorrespondingTitleInDesUni;

                if (currentCourseInfo.IsPassed)
                {
                    currentCourse.IsPassed = true;
                }
                else if (currentCourseInfo.NumberOfFailed > 1)
                {
                    currentCourse.NumberOfFailed = 2;
                }

            }

            return curriculum;

        }
    }
}
