using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;

namespace Tataiee.Harif.WpfApplication.Infrastructures.Curriculum.Curriculums
{
    public class SecondaryRulesStateValidator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="takenCoursesArray"></param>
        /// <param name="curriculum">!important :=> updated or not</param>
        /// <returns></returns>
        public static bool IsValidState(MainCurriculum curriculum, List<int> takenCoursesId)
        {
            //اگر در یک ترم بیش از یک معارف خواست بگیرد مجاز نیست
            //اگر در ترم کارآموزی خواست بردارد حداکثر تا 6 واحد مجاز است

            bool hasKarAmoozi = false;

            int numberOfUnits = 0;

            int numberOfMaaref = 0;

            for (int i = 0; i < takenCoursesId.Count; i++)
            {
                numberOfUnits += curriculum.Courses[takenCoursesId[i]].Units;
                if (takenCoursesId[i] <= 15)//assume :=> i >=0 
                {
                    numberOfMaaref++;
                    if (numberOfMaaref > 1) return false;
                }
                if(takenCoursesId[i] == 59 || takenCoursesId[i] == 66 || takenCoursesId[i] == 75 || takenCoursesId[i] == 83 )
                {
                    hasKarAmoozi = true;
                }
                if (hasKarAmoozi && numberOfUnits > 6) return false;
            } 

            return true;
        }
    }
}
