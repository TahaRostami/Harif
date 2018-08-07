using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.Curriculum;
using Tataiee.Harif.Infrastructures.Data.Curriculum;
using Tataiee.Harif.Infrastructures.Curriculum.Constraints;
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;

namespace Tataiee.Harif.Infrastructures.Curriculum.Curriculums
{
    //قوانین چارت
    public class BasicRulesStateValidator
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="curriculum">updated curriculm provided by StudentHistoryServiceProvider.CreateNewCurriculmWithSpecificCreditAndFilledBySpecificCourseInforamtion() must be passed</param>
        /// <param name="takenCoursesId">id's of courses which you want to take and after it you want to khonw curriculum is in valid sate now</param>
        /// <returns></returns>
        public static bool IsValidState(MainCurriculum curriculum, List<int> takenCoursesId)
        {
            bool[] takenCoursesArray = new bool[curriculum.Courses.Count];
            takenCoursesId.ForEach(t => takenCoursesArray[t] = true);

            //-----------------------------------------------------------------
            //place that we must check preR and R are ok or not ?

            bool o = PrerequisitesAndRequisitesRegarded(curriculum, takenCoursesArray, takenCoursesId);
            if (o == false) return false;

            //------------------------------------------------------------------

            var satList = curriculum.CreateNewSatelliteInformationList();

            PopulateSatelliteInformationHelper(curriculum.Root, satList, curriculum, takenCoursesArray);
            //PopulateSatelliteInformation(curriculum, satList, takenCoursesId);

            return IsValidState(curriculum, satList);
        }

        private static bool PrerequisitesAndRequisitesRegarded(MainCurriculum curriculum, bool[] takenCoursesArray, List<int> takenCoursesId)
        {
            bool succ = true;
            for (int i = 0; i < takenCoursesId.Count; i++)
            {
                //if (!curriculum.Courses[takenCoursesId[i]].IsAvailable())
                //{
                //    succ = false;
                //    break;
                //}
                succ = PrerequisitesAndRequisitesRegardedHelper(curriculum.Courses[takenCoursesId[i]], curriculum, takenCoursesArray);
                if (!succ) break;
            }
            return succ;
        }

        private static bool PrerequisitesAndRequisitesRegardedHelper(Course course, MainCurriculum curriculum, bool[] takenCoursesArray)
        {
            bool succ = true;

            succ = PrerequisitesAndRequisitesRegardedRequisitesHelper(course, curriculum, takenCoursesArray);

            if (!succ) return false;

            succ = PrerequisitesAndRequisitesRegardedPreRequisitesHelper(course, curriculum, takenCoursesArray);

            return succ;
        }

        private static bool PrerequisitesAndRequisitesRegardedPreRequisitesHelper(Course course, MainCurriculum curriculum, bool[] takenCoursesArray)
        {
            bool succ = true;
            for (int i = 0; i < course.PrerequisiteCourses.Count; i++)
            {
                var curr = course.PrerequisiteCourses[i];
                //if (!curr.IsAvailable())
                //{
                //succ = false;
                //break;
                //}
                if (!curr.IsPassed)
                {
                    if (curr.NumberOfFailed > 1)
                    {
                        if (!takenCoursesArray[curr.Id])
                        {
                            succ = false;
                            break;
                        }
                    }
                    else
                    {
                        succ = false;
                        break;
                    }
                }
            }
            return succ;
        }

        private static bool PrerequisitesAndRequisitesRegardedRequisitesHelper(Course course, MainCurriculum curriculum, bool[] takenCoursesArray)
        {
            bool succ = true;
            for (int i = 0; i < course.RequisiteCourses.Count; i++)
            {
                var curr = course.RequisiteCourses[i];
                //if(!curr.IsAvailable())
                //{
                //succ = false;
                //break;
                //}
                if (!curr.IsPassed && !takenCoursesArray[curr.Id])
                {
                    succ = false;
                    break;
                }
            }
            return succ;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="curriculum"></param>
        /// <param name="satList">pass empty satLst that created bt MainCurriculum.CreateNewSatelliteInformationList() to fill it</param>
        /// <param name="takenCoursesId"></param>
        public static void PopulateSatelliteInformation(MainCurriculum curriculum, List<SatelliteInformation> satList, List<int> takenCoursesId)
        {
            bool[] takenCoursesArray = new bool[curriculum.Courses.Count];
            takenCoursesId.ForEach(t => takenCoursesArray[t] = true);
            PopulateSatelliteInformationHelper(curriculum.Root, satList, curriculum, takenCoursesArray);
        }
        private static void PopulateSatelliteInformationHelper(CourseCategory courseCategory, List<SatelliteInformation> satList, MainCurriculum curriculum, bool[] takenCoursesArray)
        {
            if (courseCategory.IsEdge())
            {
                courseCategory.Courses.ForEach(c =>
                {
                    if (c.IsPassed || takenCoursesArray[c.Id])//*v.i
                    {
                        satList[courseCategory.Id].NumberOfCoursesPassed += 1;
                        satList[courseCategory.Id].UnitsOfCoursesPassed += c.Units;
                        if (c.IsLabOrWorkshop())
                        {
                            satList[courseCategory.Id].NumberOfWorkshopOrLabPassed += 1;
                            satList[courseCategory.Id].UnitsOfWorkshopOrLabPassed += c.Units;
                        }
                    }
                });
            }
            else
            {
                courseCategory.OutputGates.ForEach(og =>
                {
                    var courseCategoryChild = og.DesCourseCategory;
                    var courseCategorySrc = og.SrcCourseCategory;

                    if (og.IsAllowedAllCredits(curriculum.StudentCredit))
                    {
                        //first calc
                        PopulateSatelliteInformationHelper(courseCategoryChild, satList, curriculum, takenCoursesArray);

                        //then set values
                        satList[courseCategorySrc.Id].NumberOfCoursesPassed += satList[courseCategoryChild.Id].NumberOfCoursesPassed;
                        satList[courseCategorySrc.Id].UnitsOfCoursesPassed += satList[courseCategoryChild.Id].UnitsOfCoursesPassed;
                        satList[courseCategorySrc.Id].NumberOfWorkshopOrLabPassed += satList[courseCategoryChild.Id].NumberOfWorkshopOrLabPassed;
                        satList[courseCategorySrc.Id].UnitsOfWorkshopOrLabPassed += satList[courseCategoryChild.Id].UnitsOfWorkshopOrLabPassed;
                    }

                });
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="curriculum"></param>
        /// <param name="satList">pass satList that filled by MainCurriculumSateValidator.PopulateSatelliteInformation()</param>
        /// <returns></returns>
        public static bool IsValidState(MainCurriculum curriculum, List<SatelliteInformation> satList)
        {
            return IsValidStateHelper(curriculum, satList, curriculum.Root);
        }

        private static bool IsValidStateHelper(MainCurriculum curriculum, List<SatelliteInformation> satList, CourseCategory courseCategory)
        {
            if (courseCategory.IsEdge())
                return true;

            var graphEdges = courseCategory.OutputGates;

            for (int i = 0; i < graphEdges.Count; i++)
            {
                var graphEdge = graphEdges[i];

                if (graphEdge.IsAllowedAllCredits(curriculum.StudentCredit))
                {
                    var crtLst = graphEdge.CertificateList;

                    bool isOk = true;

                    for (int j = 0; j < crtLst.Count; j++)
                    {
                        var crt = crtLst[j];
                        for (int m = 0; m < crt.ConstraintList.Count; m++)
                        {
                            var constraint = crt.ConstraintList[m];

                            if (constraint is MinNumberMaxNumberOfCoursesConstraint)
                            {
                                isOk = constraint.IsOk(satList[graphEdge.DesCourseCategory.Id].NumberOfCoursesPassed);
                            }
                            else if (constraint is MinUnitsMaxUnitsOfCoursesConstraint)
                            {
                                isOk = constraint.IsOk(satList[graphEdge.DesCourseCategory.Id].UnitsOfCoursesPassed);
                            }
                            else if (constraint is NumberOfCoursesMustBeLabOrWorkshopConstraint)
                            {
                                isOk = constraint.IsOk(satList[graphEdge.DesCourseCategory.Id].NumberOfWorkshopOrLabPassed);
                            }
                            else if (constraint is UnitOfCoursesMustBeLabOrWorkshopConstraint)
                            {
                                isOk = constraint.IsOk(satList[graphEdge.DesCourseCategory.Id].UnitsOfWorkshopOrLabPassed);
                            }
                            else
                                throw new Exception();
                            if (!isOk) break;
                        }

                        if (!isOk) break;

                    }

                    if (!isOk) return false;

                    if (IsValidStateHelper(curriculum, satList, graphEdge.DesCourseCategory) == false)
                        return false;

                }

            }

            return true;
        }
    }
}
