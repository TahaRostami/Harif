using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tataiee.Harif.Infrastructures.Data.Curriculum;
using Tataiee.Harif.Infrastructures.OfferedCourses;
using Tataiee.Harif.Infrastructures.OfferedCourses.Models;
using Tataiee.Harif.Infrastructures.Curriculum;
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;
using Tataiee.Harif.Infrastructures.OfferedCourses;
using Tataiee.Harif.Infrastructures.ReductionSteps;
using Tataiee.Harif.Infrastructures.StudentHistory;
using Tataiee.Harif.WpfApplication.Models;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Enums;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Models;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.WeeklyProgram;

namespace Tataiee.Harif.WpfApplication
{
    /// <summary>
    /// Interaction logic for UcTest.xaml
    /// </summary>
    public partial class UcWeeklyProgram : UserControl
    {
        ObservableCollection<DataGridInfoRow> collection = new ObservableCollection<DataGridInfoRow>();      

        private int startHour;
        private int length;
        ReportFeaturs reportFeaturs;

        WeeklyProgram weeklyProgram;

        public UcWeeklyProgram(int startHour, int len, ReportFeaturs rf)
        {
            InitializeComponent();
            
            this.startHour = startHour;
            this.length = len;
            this.reportFeaturs = rf;

            if (rf == ReportFeaturs.ALL_FEATURES)
            {
                dataGridInfo.AutoGeneratingColumn += dataGridInfo_AutoGeneratingColumn;
                dataGridInfo.ItemsSource = collection;
                weeklyProgram = new WeeklyProgram(startHour, len);
            }
            else
            {
                wrapPanelMenu.Visibility = Visibility.Collapsed;
                weeklyProgram = new WeeklyProgram(startHour, len);
            }


        }
      
        public void PrintWeeklyProgram(List<GoalVersionOfferedCoursesRow> dataSource, double minuteWidth = 1.1, double borderThickness = 1, double padding = 5, double fontSize = 13, double minHeight = 87)
        {
            if (reportFeaturs == ReportFeaturs.ALL_FEATURES || reportFeaturs == ReportFeaturs.JUST_WEEKLY_PROGRAM)
            {
                weeklyProgram.DataSource = dataSource;
                weeklyProgram.Render(canvas, minuteWidth, borderThickness, padding, fontSize, minHeight);
            }

        }

        public void PrintCoursesList(List<GoalVersionOfferedCoursesRow> dataSource, double dataGridInfoWidth = 800)
        {
            if (reportFeaturs == ReportFeaturs.ALL_FEATURES)
            {
                dataGridInfo.Width = dataGridInfoWidth;

                collection.Clear();
                foreach (var item in dataSource)
                {
                    collection.Add(new DataGridInfoRow { Code = item.Id, Title = item.CourseTitle, RawStringTimeAndSitesAndExam = item.RawStringTimeAndSitesAndExam });
                }
            }
        }

        public void Print(List<GoalVersionOfferedCoursesRow> dataSource, double minuteWidth = 1.1, double borderThickness = 1, double padding = 5, double fontSize = 13, double minHeight = 87, double dataGridInfoWidth = 800)
        {
            PrintWeeklyProgram(dataSource, minuteWidth, borderThickness, padding, fontSize, minHeight);
            PrintCoursesList(dataSource, dataGridInfoWidth);
        }

        private void dataGridInfo_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            var desc = e.PropertyDescriptor as PropertyDescriptor;
            var att = desc.Attributes[typeof(ColumnNameAttribute)] as ColumnNameAttribute;
            if (att != null)
            {
                DataGridBoundColumn column = e.Column as DataGridBoundColumn;
                if (column != null)
                {
                    column.Binding = new Binding(e.PropertyName);
                    Style elementStyle = new Style(typeof(TextBlock));
                    elementStyle.Setters.Add(new Setter(TextBlock.TextWrappingProperty, TextWrapping.WrapWithOverflow));
                    column.ElementStyle = elementStyle;
                }
                e.Column.Header = att.Name;
                if (att.Name != "کد درس")
                {
                    e.Column.IsReadOnly = true;
                }
                else
                {
                    e.Column.IsReadOnly = false;
                }
            }
        }
                   
        private void btnTab_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var c in wrapPanelMenu.Children)
                {
                    if (c is Button)
                    {
                        var currBtn = (c as Button);
                        if (c == sender)
                        {
                            if (currBtn.BorderThickness.Bottom != 1)
                                currBtn.BorderThickness = new Thickness(0, 0, 0, 1);
                        }
                        else
                        {
                            if (currBtn.BorderThickness.Bottom != 0)
                                currBtn.BorderThickness = new Thickness(0, 0, 0, 0);
                        }
                    }
                }
                foreach (var child in PanelMain.Children)
                {
                    if (child is StackPanel)
                    {
                        var sch = ((StackPanel)child);
                        if (sch.Visibility != Visibility.Collapsed)
                            sch.Visibility = Visibility.Collapsed;
                    }
                }

                if (sender == btnTab1)
                {
                    stackPanelTab1.Visibility = Visibility.Visible;
                }
                else if (sender == btnTab2)
                {
                    stackPanelTab2.Visibility = Visibility.Visible;
                }

            }
            catch { }
        }
    }
}
