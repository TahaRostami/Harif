using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Enums;

namespace Tataiee.Harif.WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fa-IR");
            InitializeComponent();
            #region setting and init
            if (!Properties.Settings.Default.HomePageVisibility)
                btnHome.Visibility = Visibility.Collapsed;
            if (!Properties.Settings.Default.CreditDeterminerVisibility)
                btnCreditDeterminer.Visibility = Visibility.Collapsed;
            if (!Properties.Settings.Default.AdaptTableVisibility)
                btnAdaptationTableCourses.Visibility = Visibility.Collapsed;
            if (!Properties.Settings.Default.StudHistoryVisibility)
                btnStudentHistory.Visibility = Visibility.Collapsed;
            if (!Properties.Settings.Default.OfferedCourseManagerVisibility)
                btnOfferedCoursesManager.Visibility = Visibility.Collapsed;
            if (!Properties.Settings.Default.ReductionStep2SettingVisibility)
                btnReductionStep2Settings.Visibility = Visibility.Collapsed;

            if (Properties.Settings.Default.StartPage == 0)
            {
                Button_Click(btnHome, null);
            }
            else if (Properties.Settings.Default.StartPage == 1)
            {
                Button_Click(btnStudentHistory, null);
            }
            else if (Properties.Settings.Default.StartPage == 2)
            {
                Button_Click(btnOfferedCoursesManager, null);
            }
            else if (Properties.Settings.Default.StartPage == 3)
            {
                Button_Click(btnReductionStep2Settings, null);
            }
            else if (Properties.Settings.Default.StartPage == 4)
            {
                Button_Click(btnReductionStep2, null);
            }
            else if (Properties.Settings.Default.StartPage == 5)
            {
                Button_Click(btnWeeklyProgram, null);
            }

            DirectoryManager.TryCreateApplicationDirectoriesIfNotExists();

            #endregion
        }


        private async void Button_Click(object sender, RoutedEventArgs e)
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
            if (sender == btnHome)
            {
                UcHomePage ucHomePage = new UcHomePage();
                gridMain.Children.Clear();

                if (gridMain.HorizontalAlignment != HorizontalAlignment.Stretch)
                    gridMain.HorizontalAlignment = HorizontalAlignment.Stretch;
                if (gridMain.VerticalAlignment != VerticalAlignment.Top)
                    gridMain.VerticalAlignment = VerticalAlignment.Top;

                if (scrollViewGridMain.HorizontalScrollBarVisibility != ScrollBarVisibility.Disabled)
                    scrollViewGridMain.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;

                gridMain.Children.Add(ucHomePage);

            }
            else if (sender == btnCreditDeterminer)
            {
                UcCreditDeterminer ucCredit = new UcCreditDeterminer();
                gridMain.Children.Clear();

                if (gridMain.HorizontalAlignment != HorizontalAlignment.Center)
                    gridMain.HorizontalAlignment = HorizontalAlignment.Center;
                if (gridMain.VerticalAlignment != VerticalAlignment.Center)
                    gridMain.VerticalAlignment = VerticalAlignment.Center;

                if (scrollViewGridMain.HorizontalScrollBarVisibility != ScrollBarVisibility.Disabled)
                    scrollViewGridMain.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;

                gridMain.Children.Add(ucCredit);

            }
            else if (sender == btnAdaptationTableCourses)
            {
                UcAdaptationTableCourses ucAdapt = new UcAdaptationTableCourses();
                gridMain.Children.Clear();

                if (gridMain.HorizontalAlignment != HorizontalAlignment.Center)
                    gridMain.HorizontalAlignment = HorizontalAlignment.Center;
                if (gridMain.VerticalAlignment != VerticalAlignment.Center)
                    gridMain.VerticalAlignment = VerticalAlignment.Center;

                if (scrollViewGridMain.HorizontalScrollBarVisibility != ScrollBarVisibility.Auto)
                    scrollViewGridMain.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;

                gridMain.Children.Add(ucAdapt);
                await ucAdapt.RunAfterCreateAsync();

            }
            else if (sender == btnStudentHistory)
            {
                UcStudentHistory ucStudHst = new UcStudentHistory();

                gridMain.Children.Clear();

                if (gridMain.HorizontalAlignment != HorizontalAlignment.Center)
                    gridMain.HorizontalAlignment = HorizontalAlignment.Center;
                if (gridMain.VerticalAlignment != VerticalAlignment.Center)
                    gridMain.VerticalAlignment = VerticalAlignment.Center;

                if (scrollViewGridMain.HorizontalScrollBarVisibility != ScrollBarVisibility.Disabled)
                    scrollViewGridMain.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;

                gridMain.Children.Add(ucStudHst);
                await ucStudHst.RunAfterCreateAsync();

            }
            else if (sender == btnOfferedCoursesManager)
            {
                UcOfferedCoursesManager ucOffCrs = new UcOfferedCoursesManager();
                gridMain.Children.Clear();

                if (gridMain.HorizontalAlignment != HorizontalAlignment.Center)
                    gridMain.HorizontalAlignment = HorizontalAlignment.Center;
                if (gridMain.VerticalAlignment != VerticalAlignment.Center)
                    gridMain.VerticalAlignment = VerticalAlignment.Center;

                if (scrollViewGridMain.HorizontalScrollBarVisibility != ScrollBarVisibility.Hidden)
                    scrollViewGridMain.HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;

                gridMain.Children.Add(ucOffCrs);

            }
            else if (sender == btnReductionStep2Settings)
            {
                UcProcessingSettings ucReductionStep2Settings = new UcProcessingSettings();
                gridMain.Children.Clear();
                gridMain.Children.Add(ucReductionStep2Settings);

                if (gridMain.HorizontalAlignment != HorizontalAlignment.Center)
                    gridMain.HorizontalAlignment = HorizontalAlignment.Center;
                if (gridMain.VerticalAlignment != VerticalAlignment.Center)
                    gridMain.VerticalAlignment = VerticalAlignment.Center;

                if (scrollViewGridMain.HorizontalScrollBarVisibility != ScrollBarVisibility.Hidden)
                    scrollViewGridMain.HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;


            }
            else if (sender == btnReductionStep2)
            {
                UcUnitSelection ucReductionStep2 = new UcUnitSelection();
                gridMain.Children.Clear();

                if (gridMain.HorizontalAlignment != HorizontalAlignment.Stretch)
                    gridMain.HorizontalAlignment = HorizontalAlignment.Stretch;
                if (gridMain.VerticalAlignment != VerticalAlignment.Top)
                    gridMain.VerticalAlignment = VerticalAlignment.Top;


                if (scrollViewGridMain.HorizontalScrollBarVisibility != ScrollBarVisibility.Auto)
                    scrollViewGridMain.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;

                gridMain.Children.Add(ucReductionStep2);
                await ucReductionStep2.RunAfterCreatedAsync();
            }
            else if (sender == btnWeeklyProgram)
            {

                UcWeeklyProgramReportManagerWithDirectorySelection ucWeeklyProgramReportManagerWithDirectorySelection
                    = new UcWeeklyProgramReportManagerWithDirectorySelection();
                gridMain.Children.Clear();
                gridMain.Children.Add(ucWeeklyProgramReportManagerWithDirectorySelection);

                if (gridMain.HorizontalAlignment != HorizontalAlignment.Stretch)
                    gridMain.HorizontalAlignment = HorizontalAlignment.Stretch;
                if (gridMain.VerticalAlignment != VerticalAlignment.Top)
                    gridMain.VerticalAlignment = VerticalAlignment.Top;

                if (scrollViewGridMain.HorizontalScrollBarVisibility != ScrollBarVisibility.Auto)
                    scrollViewGridMain.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;


            }
            else if (sender == btnMainSettings)
            {
                UcMainSettings ucMainSettings = new UcMainSettings();
                gridMain.Children.Clear();
                gridMain.Children.Add(ucMainSettings);

                if (gridMain.HorizontalAlignment != HorizontalAlignment.Stretch)
                    gridMain.HorizontalAlignment = HorizontalAlignment.Stretch;
                if (gridMain.VerticalAlignment != VerticalAlignment.Top)
                    gridMain.VerticalAlignment = VerticalAlignment.Top;

                if (scrollViewGridMain.HorizontalScrollBarVisibility != ScrollBarVisibility.Disabled)
                    scrollViewGridMain.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
            }

        }

    }
}
