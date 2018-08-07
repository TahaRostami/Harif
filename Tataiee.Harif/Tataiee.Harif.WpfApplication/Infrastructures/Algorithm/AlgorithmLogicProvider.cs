using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;
using Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Models;
using Tataiee.Harif.WpfApplication.Infrastructures.Curriculum.Curriculums;

namespace Tataiee.Harif.WpfApplication.Infrastructures.Algorithm
{
    public class AlgorithmLogicProvider
    {
        private static readonly Random random = new Random();

        public int CurrentSelectedUnits { get; private set; }
        public double Score { get; private set; }
        public bool[] Selected { get; private set; }
        public AlgorithmLogicProvider()
        {
        }
        //inputs -> white courses list , len
        public void Run(double[] courseScore, List<OfferedCourse> whiteCourses, List<OfferedCourse> greenCourses, int minUnits, int maxUnits, int greenCoursesUnits, double totalScore, MainCurriculum mainCurriculum, List<Box> GreenCoursesBoxes, bool examCollideCheck, AlgorithmTopWeeklyProgramManager ChoosedWeeklyProgram, int timeout)
        {
            bool x = false;
            Task.Run(() =>
            {
                Thread.Sleep(timeout);
                x = true;
            });
            List<int> takenCoursesId = new List<int>();
            while (true)
            {
                if (x) return;
                while (true)
                {
                    if (x) return;
                    do
                    {
                        if (x) return;

                        Selected = new bool[whiteCourses.Count];
                        Score = 0;
                        CurrentSelectedUnits = 0;

                        takenCoursesId.Clear();

                        //init and assigning values to Selected array
                        for (int i = 0; i < Selected.Length; i++)
                        {
                            var offeredCourse = whiteCourses[i];
                            var course = whiteCourses[i].Course;

                            var pc = random.Next(100);

                            if (CurrentSelectedUnits + course.Units + greenCoursesUnits > maxUnits) continue;

                            if (pc <= courseScore[course.Id] * 100.0 / totalScore)
                            {
                                Selected[i] = true;
                                CurrentSelectedUnits += course.Units;
                                takenCoursesId.Add(course.Id);
                            }
                        }

                        if (minUnits > CurrentSelectedUnits + greenCoursesUnits)
                        {
                            //no valid
                        }
                    }
                    while (minUnits > CurrentSelectedUnits + greenCoursesUnits);
                    greenCourses.ForEach(gc => takenCoursesId.Insert(0, gc.Course.Id));
                    //two step validation                
                    bool o = MainCurriculumSateValidator.IsValidState(mainCurriculum, takenCoursesId);
                    if (o) break;
                }

                List<Box> boxes = new List<Box>();
                GreenCoursesBoxes.ForEach(b => boxes.Add(b));
                for (int i = 0; i < Selected.Length; i++)
                {
                    if (Selected[i])
                    {
                        Box b = ReductionStep2ServiceProvider.CreateBoxForOfferedCourse(whiteCourses[i]);
                        boxes.Add(b);
                    }
                }

                List<Box> res = ReductionStep2ServiceProvider.Validate(boxes, examCollideCheck);

                if (res != null)
                {
                    //break;
                    ChoosedWeeklyProgram.AddUpdateRangeData(res[0].Rows);

                }

            }
            //return new object();
        }//end method Run

    }
}
