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
using System.Windows.Shapes;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Enums;

namespace Tataiee.Harif.WpfApplication
{
    /// <summary>
    /// Interaction logic for LastAlgorithmOutputShowerWindow.xaml
    /// </summary>
    public partial class LastAlgorithmOutputShowerWindow : Window
    {
        public LastAlgorithmOutputShowerWindow()
        {
            InitializeComponent();
            try
            {
                UcWeeklyProgramReportManager ucWeeklyProgramReportManager = new UcWeeklyProgramReportManager()
                {
                    SelectionMode = UcWeeklyProgramReportManagerSelectionMode.AUTOMATIC_SELECT_FIRST_ITEM_IN_LIST,
                    SaveDirectoryMode = UcWeeklyProgramManagerSaveDirectoryMode.SAVE_IN_SOURCE_AND_SECOND_DIRECTORY,
                };
                gridMain.Children.Clear();
                gridMain.Children.Add(ucWeeklyProgramReportManager);
                gridMain.HorizontalAlignment = HorizontalAlignment.Stretch;
                gridMain.VerticalAlignment = VerticalAlignment.Top;
                ucWeeklyProgramReportManager.Margin = new Thickness(0, 20, 20, 0);
                ucWeeklyProgramReportManager.SourceDirectory = DirectoryManager.LastAlgorithmExeOutputs;
                ucWeeklyProgramReportManager.SecondSavedDirectory = Properties.Settings.Default.WeeklyProgramSavedDirectory;
            }
            catch { }
        }
    }
}
