using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;
using Tataiee.Harif.Infrastructures.OfferedCourses.Models;
using Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Enums;
using Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Models;
using Tataiee.Harif.WpfApplication.Infrastructures.Curriculum.Curriculums;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Algorithm;

namespace Tataiee.Harif.WpfApplication.Infrastructures.Algorithm
{
    public class MainAlgorithm
    {
        public AlgorithmTopWeeklyProgramManager ChoosedWeeklyProgram { get; private set; } = new AlgorithmTopWeeklyProgramManager(12);

        public MainAlgorithm(int r)
        {
            ChoosedWeeklyProgram = new AlgorithmTopWeeklyProgramManager(r);
        }

        // <param name="mainCurriculum">updated curriculum</param>
        public void Run(List<OfferedCourse> inputs, MainCurriculum mainCurriculum, int minUnitsRequired, int maxUnitsRequired, bool examCollideCheck, int timeout, AnimateStatusObjectModel model)
        {

            ChoosedWeeklyProgram.Clear();

            double[] courseScore = new double[mainCurriculum.Courses.Count];


            double numberOfGreenUnits = 0;

            List<OfferedCourse> greenCourses = new List<OfferedCourse>();
            List<OfferedCourse> whiteCourses = new List<OfferedCourse>();//white courses that have at least one white row

            int greenUnits = 0;
            for (int i = 0; i < inputs.Count; i++)
            {
                var offeredCourse = inputs[i];

                if (offeredCourse.Color == ReductionStep2ColorStatus.Green)
                {
                    greenCourses.Add(offeredCourse);
                    greenUnits += offeredCourse.Course.Units;
                }
                else if (offeredCourse.Color == ReductionStep2ColorStatus.WHITE)
                {
                    for (int r = 0; r < offeredCourse.OfferedCourseRows.Count; r++)
                    {
                        var offeredCourseRow = offeredCourse.OfferedCourseRows[r];
                        if (offeredCourseRow.Color == ReductionStep2ColorStatus.WHITE)
                        {
                            whiteCourses.Add(offeredCourse);
                            break;
                        }
                    }
                }

                var course = offeredCourse.Course;

                courseScore[course.Id] += (course.Units * 2 - 1) * 1;

                for (int c = 0; c < course.PrerequisiteCourses.Count; c++)
                {
                    var preCourse = course.PrerequisiteCourses[c];

                    if (!preCourse.IsPassed && preCourse.IsAvailable())
                    {
                        if (preCourse.NumberOfFailed > 1)
                        {
                            courseScore[preCourse.Id] += (course.Units * 2 - 1) * 0.20;
                        }
                        else
                        {
                            courseScore[preCourse.Id] += (course.Units * 2 - 1) * 0.25;
                        }
                    }

                }
                for (int c = 0; c < course.RequisiteCourses.Count; c++)
                {
                    var reqCourse = course.RequisiteCourses[c];

                    if (!reqCourse.IsPassed && reqCourse.IsAvailable())
                        courseScore[reqCourse.Id] += (course.Units * 2 - 1) * 0.20;
                }

            }

            double totalScore = 0;

            whiteCourses.ForEach(i =>
            {
                totalScore += courseScore[i.Course.Id];
            });

            List<Box> greenCoursesBoxes = new List<Box>();

            greenCourses.ForEach(gc =>
            {
                numberOfGreenUnits += gc.Course.Units;
                Box b = ReductionStep2ServiceProvider.CreateBoxForOfferedCourse(gc);
                greenCoursesBoxes.Add(b);
            });

            if (greenCoursesBoxes.Count > 0)
            {
                List<Box> res = ReductionStep2ServiceProvider.Validate(greenCoursesBoxes, examCollideCheck);
                if (res != null)
                {
                    greenCoursesBoxes.Clear();
                    greenCoursesBoxes.Add(res[0]);
                }
            }
            
            new AlgorithmLogicProvider().Run(courseScore, whiteCourses, greenCourses, minUnitsRequired, maxUnitsRequired, greenUnits, totalScore, mainCurriculum, greenCoursesBoxes, examCollideCheck, ChoosedWeeklyProgram, timeout);

            if (ChoosedWeeklyProgram.Count > 0) model.Succ = true;
            else model.Succ = false;
        }//end method Run       
    }
          
}
