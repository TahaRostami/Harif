using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.OfferedCourses;
using Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Enums;
using Tataiee.Harif.WpfApplication.Infrastructures.Algorithm.Models;

namespace Tataiee.Harif.WpfApplication.Infrastructures.Algorithm
{
    public class ReductionStep2ServiceProvider
    {

        public static List<Box> Validate(List<Box> boxes, bool examCollideCheck = false)
        {
            if (boxes == null) throw new Exception();

            if (boxes.Count == 1 && boxes[0].Rows.Count == 0)
                return null;

            //foreach (var b in boxes){if (b.Rows.Count == 0) return null;}


            List<Box> bxs = new List<Box>();

            bxs.Add(boxes[0]);


            bool con0 = true;
            for (int i = 1; i < boxes.Count; i++)
            {
                var b1 = bxs[0];
                var b2 = boxes[i];

                Box newBox = new Box();

                for (int j = 0; j < b2.Rows.Count; j++)
                {

                    for (int k = 0; k < b1.Rows.Count; k++)
                    {
                        bool con = true;

                        Row newRow = new Row();


                        for (int m = 0; m < b1.Rows[k].Columns.Count; m++)
                        {

                            bool collide = OfferedCoursesServiceProvider.DoTheyCollide(b1.Rows[k].Columns[m].GoalVersionOfferedCourseRow.TimeAndSitesAndExam.TimeAndSites,
                                             b2.Rows[j].Columns[0].GoalVersionOfferedCourseRow.TimeAndSitesAndExam.TimeAndSites
                                              );
                            if (collide)
                            {
                                con = false;
                                break;
                            }

                            if (examCollideCheck &&
                                OfferedCoursesServiceProvider.DoTheyExamCollide(b1.Rows[k].Columns[m].GoalVersionOfferedCourseRow.TimeAndSitesAndExam.Exam,
                                             b2.Rows[j].Columns[0].GoalVersionOfferedCourseRow.TimeAndSitesAndExam.Exam
                                              )
                                )
                            {

                                //collide = true;
                                con = false;
                                break;

                            }


                            newRow.Columns.Add(b1.Rows[k].Columns[m]);

                        }

                        newRow.Columns.Add(b2.Rows[j].Columns[0]);

                        if (con)
                        {
                            newBox.Rows.Add(newRow);

                            //if just we want to say true/false we can un comment below lines of code

                            //if (i == boxes.Count - 1)
                            //{
                            //    bxs[0] = newBox;
                            //    return bxs;
                            //    break;
                            //}
                        }
                    }
                }

                if (newBox.Rows.Count == 0)
                {
                    con0 = false;
                    break;
                }
                else
                {
                    bxs[0] = newBox;
                }
            }

            if (con0)
            {
                return bxs;
            }
            else
            {
                return null;
            }

        }

        public static List<Box> Validate(List<OfferedCourse> offeredCoursesList, bool examCollideCheck = false)
        {
            List<Box> lst = new List<Box>();
            for (int i = 0; i < offeredCoursesList.Count; i++)
            {
                lst.Add(CreateBoxForOfferedCourse(offeredCoursesList[i]));
            }
            return Validate(lst, examCollideCheck);
        }

        public static Box CreateBoxForOfferedCourse(OfferedCourse offeredCourse)
        {
            Box box = new Box();

            offeredCourse.OfferedCourseRows.ForEach(r =>
            {
                if (r.Color == ReductionStep2ColorStatus.WHITE)
                {
                    Row row = new Row();
                    row.Columns.Add(r);
                    box.Rows.Add(row);
                }
            });

            return box;
        }

    }
}
