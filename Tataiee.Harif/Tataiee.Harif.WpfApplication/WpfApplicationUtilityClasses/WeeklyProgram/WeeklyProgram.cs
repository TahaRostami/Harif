using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Tataiee.Harif.Infrastructures.OfferedCourses.Models;

namespace Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.WeeklyProgram
{
    internal class WeeklyProgram
    {
        public int StartHour { get; private set; }
        public int Length { get; private set; }

        public WeeklyProgramRow[] Rows { get; set; }

        private List<GoalVersionOfferedCoursesRow> dataSource;
        public List<GoalVersionOfferedCoursesRow> DataSource
        {
            get => dataSource;
            set
            {
                if (value != null)
                {
                    for (int i = 1; i < 8; i++)
                    {
                        Rows[i].Cells.Clear();
                    }
                    foreach (var item in value)
                    {
                        if (item.TimeAndSitesAndExam.TimeAndSites != null)
                        {
                            foreach (var r in item.TimeAndSitesAndExam.TimeAndSites)
                            {
                                WeeklyProgramCell cell = new WeeklyProgramCell(item, r.StartTime, r.FinishTime);
                                Rows[(int)r.Day + 1].Cells.Add(cell);
                            }
                        }
                    }
                }
                dataSource = value;
            }
        }

        public WeeklyProgram(int startHour = 7, int len = 15)
        {
            StartHour = startHour;
            Length = len;
            Rows = new WeeklyProgramRow[8];
            for (int i = 0; i < 8; i++)
            {
                Rows[i] = new WeeklyProgramRow();
            }

            Rows[0].ReadOnlyTextCell.Add("ساعت/روز");
            Rows[1].ReadOnlyTextCell.Add("شنبه");
            Rows[2].ReadOnlyTextCell.Add("یک شنبه");
            Rows[3].ReadOnlyTextCell.Add("دوشنبه");
            Rows[4].ReadOnlyTextCell.Add("سه شنبه");
            Rows[5].ReadOnlyTextCell.Add("چهار شنبه");
            Rows[6].ReadOnlyTextCell.Add("پنج شنبه");
            Rows[7].ReadOnlyTextCell.Add("جمعه");

            for (int i = StartHour; i < StartHour + Length; i++)
            {
                Rows[0].ReadOnlyTextCell.Add(new LocalTime { Hour = i, Minute = 0 }.ToString() + System.Environment.NewLine + new LocalTime { Hour = i + 1, Minute = 0 }.ToString());
            }


        }

        public void Render(Canvas originCanvas, double minuteWidth = 1.1, double borderThickness = 1, double padding = 5, double fontSize = 13, double minHeight = 87)
        {
            //double minuteWidth = 1.1;
            double hourWidth = 60 * minuteWidth;
            //double borderThickness = 1;
            //double padding = 5;
            //double fontSize = 13;
            //double minHeight = 87;

            originCanvas.Children.Clear();

            List<Border> bs = new List<Border>();
            double maxBorderHeight = 0;

            WeeklyProgramServiceProvider.AddNewHorizontalLineToCanvas(originCanvas, borderThickness, 0, hourWidth * Rows[0].ReadOnlyTextCell.Count);
            //row 0
            for (int i = 0; i < Rows[0].ReadOnlyTextCell.Count; i++)
            {
                Border newBorder = WeeklyProgramServiceProvider.AddNewBorderedTextBlockToCanvas(originCanvas, Rows[0].ReadOnlyTextCell[i], 0, hourWidth * i, hourWidth, 0, 0, i + 1 == Rows[0].ReadOnlyTextCell.Count ? 0 : borderThickness, 0, padding, fontSize);
                bs.Add(newBorder);

                newBorder.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
                newBorder.Arrange(new Rect(newBorder.DesiredSize));

                maxBorderHeight = Math.Max(newBorder.ActualHeight, maxBorderHeight);

            }
            for (int i = 0; i < bs.Count; i++)
            {
                if (bs[i].Height != maxBorderHeight)
                    bs[i].Height = maxBorderHeight;
            }

            WeeklyProgramServiceProvider.AddNewHorizontalLineToCanvas(originCanvas, borderThickness, maxBorderHeight, hourWidth * Rows[0].ReadOnlyTextCell.Count);

            double top = maxBorderHeight + 1;


            bs.Clear();

            //row 1 to 7
            for (int i = 1; i < Rows.Length; i++)
            {
                maxBorderHeight = minHeight;

                var currentRow = Rows[i];

                Border newBorder = WeeklyProgramServiceProvider.AddNewBorderedTextBlockToCanvas(originCanvas, Rows[i].ReadOnlyTextCell[0], top, 0, hourWidth, 0, 0, i + 1 == Rows[i].ReadOnlyTextCell.Count ? 0 : borderThickness, 0, padding, fontSize);
                bs.Add(newBorder);

                newBorder.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
                newBorder.Arrange(new Rect(newBorder.DesiredSize));

                maxBorderHeight = Math.Max(newBorder.ActualHeight, maxBorderHeight);

                for (int j = 0; j < currentRow.Cells.Count; j++)
                {
                    var currentCell = currentRow.Cells[j];

                    double left = hourWidth + (currentCell.StartTime.Minute * minuteWidth + (currentCell.StartTime.Hour - StartHour) * hourWidth);

                    double w = (currentCell.FinishTime.Hour - currentCell.StartTime.Hour) * hourWidth + (currentCell.FinishTime.Minute - currentCell.StartTime.Minute) * minuteWidth;

                    newBorder = WeeklyProgramServiceProvider.AddNewBorderedTextBlockToCanvas(originCanvas, currentCell.CourseName, top, left, w,
                        currentCell.StartTime.Minute == 0 && currentCell.StartTime.Hour == StartHour ? 0 : borderThickness, 0,
                        currentCell.StartTime.Minute == 0 && currentCell.FinishTime.Hour == StartHour + Length ? 0 : borderThickness, 0, padding, fontSize);


                    bs.Add(newBorder);

                    newBorder.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
                    newBorder.Arrange(new Rect(newBorder.DesiredSize));

                    maxBorderHeight = Math.Max(newBorder.ActualHeight, maxBorderHeight);

                }

                for (int k = 0; k < bs.Count; k++)
                {
                    if (bs[k].Height != maxBorderHeight)
                        bs[k].Height = maxBorderHeight;
                }
                top += maxBorderHeight + 1;
                bs.Clear();

                WeeklyProgramServiceProvider.AddNewHorizontalLineToCanvas(originCanvas, borderThickness, top - 1, hourWidth * Rows[0].ReadOnlyTextCell.Count);

            }

            WeeklyProgramServiceProvider.AddNewVerticalLineToCanvas(originCanvas, borderThickness, hourWidth * Rows[0].ReadOnlyTextCell.Count, top);
            WeeklyProgramServiceProvider.AddNewVerticalLineToCanvas(originCanvas, borderThickness, 0, top);

            double canvasH = top;
            double canvasW = hourWidth * Rows[0].ReadOnlyTextCell.Count;

            originCanvas.Height = canvasH;
            originCanvas.Width = canvasW;
        }

    }
}
