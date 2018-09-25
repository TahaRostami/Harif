using System;
using System.Collections.Generic;
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
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Enums;

namespace Tataiee.Harif.WpfApplication
{
    /// <summary>
    /// Interaction logic for UcWeeklyProgramReportManagerWithDirectorySelection.xaml
    /// </summary>
    public partial class UcWeeklyProgramReportManagerWithDirectorySelection : UserControl
    {
        UcWeeklyProgramReportManager ucWeeklyProgramReportManager;
        public UcWeeklyProgramReportManagerWithDirectorySelection()
        {
            InitializeComponent();
            ucWeeklyProgramReportManager = new UcWeeklyProgramReportManager()
            {
                SelectionMode = UcWeeklyProgramReportManagerSelectionMode.AUTOMATIC_SELECT_FIRST_ITEM_IN_LIST,
            };
            panelContent.Children.Add(ucWeeklyProgramReportManager);
            panelContent.HorizontalAlignment = HorizontalAlignment.Stretch;
            panelContent.VerticalAlignment = VerticalAlignment.Top;
            ucWeeklyProgramReportManager.Margin = new Thickness(0, 10, 20, 20);

            Button_Click(btn1, null);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ucWeeklyProgramReportManager.SaveDirectoryMode = UcWeeklyProgramManagerSaveDirectoryMode.SAVE_IN_SOURCE_AND_SECOND_DIRECTORY;
                ucWeeklyProgramReportManager.SecondSavedDirectory = Properties.Settings.Default.WeeklyProgramSavedDirectory;
                ucWeeklyProgramReportManager.SourceDirectory = DirectoryManager.LastAlgorithmExeOutputs;
            }
            catch { }
            btn1.SetResourceReference(Button.BackgroundProperty, "PrimaryHueMidBrush");
            btn2.Background = Brushes.Transparent;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                ucWeeklyProgramReportManager.SaveDirectoryMode = UcWeeklyProgramManagerSaveDirectoryMode.SAVE_JUST_IN_SOURCE_DIRECTORY;
                ucWeeklyProgramReportManager.SecondSavedDirectory = Properties.Settings.Default.WeeklyProgramSavedDirectory;
                ucWeeklyProgramReportManager.SourceDirectory = Properties.Settings.Default.WeeklyProgramSavedDirectory;
            }
            catch { }
            btn1.Background = Brushes.Transparent;
            btn2.SetResourceReference(Button.BackgroundProperty, "PrimaryHueMidBrush");
        }


    }
}
