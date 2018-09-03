using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.Data.Curriculum;
using Tataiee.Harif.Infrastructures.Curriculum.Constraints;
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;
using Tataiee.Harif.Infrastructures.OfferedCourses;
using Tataiee.Harif.Infrastructures.Curriculum;
using Tataiee.Harif.Infrastructures.StudentHistory;
using Tataiee.Harif.Infrastructures.OfferesdCourses;

namespace Tataiee.Harif.Infrastructures.ReductionSteps
{
    public class ReductionStep1
    {
        //1
        //Layers.ReductionSteps.ReductionStep1.TryReduce(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CreditDeterminerSavedName, DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CourseInformationSavedName, termNumberNow,out lst)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="curriculum">باید خصوصیات آن با توجه به credit و CourseInfo ذخیره شده ست شده باشد </param>
        /// <param name="currentTermNumber"></param>
        /// <returns></returns>
        public static List<Course> Reduce(MainCurriculum curriculum, int currentTermNumber, int cntPassedUnits)
        {
            List<SatelliteInformation> satList = curriculum.CreateNewSatelliteInformationList();
            PopulateSatelliteInformation(curriculum, satList);
            return ReduceStep1Helper(curriculum, satList, cntPassedUnits, currentTermNumber);
        }

        public static List<Course> Reduce(CreditDeterminer creditDeterminer, List<CourseInformation> courseInfoLst, int currentTermNumber)
        {
            int passedUnitsNumber = 0;

            //create a curriculum object with specific credit
            MainCurriculum curriculum = new MainCurriculum(MainCurriculum.CreateStudentCredit(creditDeterminer.Level1, creditDeterminer.Level2));

            //update curriculm's courses properties considering student history information
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
                    passedUnitsNumber += currentCourse.Units;
                }
                else if (currentCourseInfo.NumberOfFailed > 1)
                {
                    currentCourse.NumberOfFailed = 2;
                }

            }

            return Reduce(curriculum, currentTermNumber, passedUnitsNumber);
        }

        public static List<Course> Reduce(string creditDeterminerFileName, string courseInfoLstFileName, int currentTermNumber)
        {
            CreditDeterminer creditDeterminer;
            FileServiceProvider.DeserializeFromXmlFile(creditDeterminerFileName, out creditDeterminer);

            List<CourseInformation> courseInfoLst;
            FileServiceProvider.DeserializeFromXmlFile(courseInfoLstFileName, out courseInfoLst);

            return Reduce(creditDeterminer, courseInfoLst, currentTermNumber);
        }

        public static bool TryReduce(string creditDeterminerFileName, string courseInfoLstFileName, int currentTermNumber, out List<Course> resultLst)
        {
            bool succ = true;
            try
            {
                resultLst = Reduce(creditDeterminerFileName, courseInfoLstFileName, currentTermNumber);
            }
            catch
            {
                resultLst = null;
                succ = false;
            }

            return succ;
        }

        private static List<Course> ReduceStep1Helper(MainCurriculum curriculum, List<SatelliteInformation> satList, int cntPassedUnits, int currentTermNumber)
        {
            bool[] visited = new bool[curriculum.Courses.Count];
            bool[] achivable = new bool[visited.Length];

            List<Course> lst = new List<Course>();
            curriculum.Courses.ForEach(c =>
            {
                if (Acheivable(visited, achivable, curriculum, satList, c, cntPassedUnits, currentTermNumber))
                {
                    lst.Add(c);
                }
            });
            return lst;
        }

        private static bool Acheivable(bool[] visited, bool[] achivable, MainCurriculum curriculum, List<SatelliteInformation> satList, Course c, int cntPassedUnits, int currentTermNumber)
        {
            //memoization :=> dynamic programming
            if (visited[c.Id])
            {
                return achivable[c.Id];
            }


            if (!c.IsAvailable())
            {
                return false;
            }
            else if (c.IsPassed)
            {
                return false;
            }
            else if (c.MinRequireTerm > currentTermNumber)
            {
                return false;
            }
            else if (c.MinReuireUnits > cntPassedUnits)
            {
                return false;
            }

            for (int i = 0; i < c.PrerequisiteCourses.Count; i++)
            {
                var pr = c.PrerequisiteCourses[0];
                if (!pr.IsPassed)
                {
                    if (pr.NumberOfFailed > 1)
                    {
                        if (!Acheivable(visited, achivable, curriculum, satList, pr, cntPassedUnits, currentTermNumber))
                            return false;
                    }
                    else
                    {
                        return false;
                    }

                }

            }

            for (int i = 0; i < c.RequisiteCourses.Count; i++)
            {
                var r = c.RequisiteCourses[i];

                if (!r.IsAvailable())
                    return false;
                if (r.IsPassed == false && !Acheivable(visited, achivable, curriculum, satList, r, cntPassedUnits, currentTermNumber))
                    return false;

            }



            var res = RecursiveCourseAcheivableCheck(curriculum, satList, c);

            //memoization
            visited[c.Id] = true;
            achivable[c.Id] = res;

            return res;
        }

        private static bool RecursiveCourseAcheivableCheck(MainCurriculum curriculum, List<SatelliteInformation> satList, Course c)
        {
            var ccLst = c.CourseCategories;
            bool succ = false;
            for (int i = 0; i < ccLst.Count; i++)
            {
                var cc = ccLst[i];
                if (RecursiveCourseAcheivableCheckHelper(curriculum, satList, c, cc))
                {
                    succ = true;
                    break;
                }
            }

            return succ;
        }

        private static bool RecursiveCourseAcheivableCheckHelper(MainCurriculum curriculum, List<SatelliteInformation> satList, Course c, CourseCategory courseCategory)
        {
            if (courseCategory == curriculum.Root)
            {
                return true;
            }
            else
            {
                List<CourseCategory> allowedCourseCategories = new List<CourseCategory>();

                for (int i = 0; i < courseCategory.InputGates.Count; i++)
                {
                    var graphEdge = courseCategory.InputGates[i];

                    if (!graphEdge.IsAllowedAllCredits(curriculum.StudentCredit)) continue;

                    bool graphEdgeCon = true;

                    for (int j = 0; j < graphEdge.CertificateList.Count; j++)
                    {
                        var crt = graphEdge.CertificateList[j];

                        for (int m = 0; m < crt.ConstraintList.Count; m++)
                        {
                            var constraint = crt.ConstraintList[m];

                            if (constraint is MinNumberMaxNumberOfCoursesConstraint)
                            {
                                graphEdgeCon = constraint.IsOk(satList[courseCategory.Id].NumberOfCoursesPassed + 1);
                            }
                            else if (constraint is MinUnitsMaxUnitsOfCoursesConstraint)
                            {
                                graphEdgeCon = constraint.IsOk(satList[courseCategory.Id].UnitsOfCoursesPassed + c.Units);
                            }
                            else if (constraint is NumberOfCoursesMustBeLabOrWorkshopConstraint)
                            {
                                graphEdgeCon = constraint.IsOk(satList[courseCategory.Id].NumberOfWorkshopOrLabPassed + (c.IsLabOrWorkshop() ? 1 : 0));
                            }
                            else if (constraint is UnitOfCoursesMustBeLabOrWorkshopConstraint)
                            {
                                graphEdgeCon = constraint.IsOk(satList[courseCategory.Id].UnitsOfWorkshopOrLabPassed + (c.IsLabOrWorkshop() ? c.Units : 0));
                            }
                            else
                            {
                                throw new ArgumentException();
                            }

                            if (!graphEdgeCon) break;

                        }
                        if (!graphEdgeCon) break;
                    }

                    if (graphEdgeCon)
                    {
                        allowedCourseCategories.Add(graphEdge.SrcCourseCategory);
                    }
                }

                bool suuc = false;
                for (int i = 0; i < allowedCourseCategories.Count; i++)
                {
                    var accc = allowedCourseCategories[i];
                    if (RecursiveCourseAcheivableCheckHelper(curriculum, satList, c, accc))
                    {
                        suuc = true;
                        break;
                    }

                }
                return suuc;
            }
        }

        private static void PopulateSatelliteInformation(MainCurriculum curriculum, List<SatelliteInformation> satList)
        {
            BasicRulesStateValidator.PopulateSatelliteInformation(curriculum, satList, new List<int>());
        }
      
    }
}
