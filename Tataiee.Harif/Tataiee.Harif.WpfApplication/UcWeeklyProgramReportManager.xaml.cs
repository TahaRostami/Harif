using System;
using System.Collections.Generic;
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
using Tataiee.Harif.Infrastructures.OfferedCourses;
using Tataiee.Harif.Infrastructures.OfferedCourses.Models;
using Tataiee.Harif.Infrastructures.Algorithm.Models;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Enums;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Models;
using Tataiee.Harif.Infrastructures.OfferesdCourses;

namespace Tataiee.Harif.WpfApplication
{
    /// <summary>
    /// Interaction logic for UcWeeklyProgramReportManager.xaml
    /// </summary>
    public partial class UcWeeklyProgramReportManager : UserControl
    {
        public UcWeeklyProgramReportManagerSelectionMode SelectionMode { get; set; } = UcWeeklyProgramReportManagerSelectionMode.AUTOMATIC_SELECT_FIRST_ITEM_IN_LIST;
        public UcWeeklyProgramManagerSaveDirectoryMode SaveDirectoryMode { get; set; } = UcWeeklyProgramManagerSaveDirectoryMode.SAVE_JUST_IN_SOURCE_DIRECTORY;

        private UcWeeklyProgram ucWeeklyProgram;

        private OfferedWeeklyProgram program;

        private UcWeeklyProgramReportManagerListBoxObjectModel selectedModel;

        private string[] files;

        private string sourceDirectory;
        public string SourceDirectory
        {
            get => sourceDirectory;
            set
            {
                if (sourceDirectory != value)
                {
                    sourceDirectory = value;
                    OnSourceDirectoryChanged();
                }
            }
        }

        public string SecondSavedDirectory { get; set; }

        private void OnSourceDirectoryChanged()
        {
            try
            {
                lstBoxWeeklyProgramsNavigation.Items.Clear();
                if (Directory.Exists(sourceDirectory))
                {
                    var sortedFiles = new DirectoryInfo(SourceDirectory).GetFiles()
                                                   .OrderBy(f => f.LastWriteTime)
                                                   .ToList();

                    string[] files = new string[sortedFiles.Count];

                    for (int i = 0; i < sortedFiles.Count; i++)
                    {
                        files[i] = sortedFiles[i].FullName;
                    }
                    
                    if (files == null || files.Length == 0) return;

                    this.files = files;
                    foreach (var f in files)
                    {
                        int x1 = f.LastIndexOf('\\');
                        int x2 = f.LastIndexOf(".xml");
                        string fileName = f.Substring(x1 + 1, x2 - x1 - 1);

                        UcWeeklyProgramReportManagerListBoxObjectModel model = new UcWeeklyProgramReportManagerListBoxObjectModel();
                        model.DisplayName = fileName;
                        model.FileName = f;

                        lstBoxWeeklyProgramsNavigation.Items.Add(model);
                    }

                    if (SelectionMode == UcWeeklyProgramReportManagerSelectionMode.AUTOMATIC_SELECT_FIRST_ITEM_IN_LIST)
                    {
                        if (lstBoxWeeklyProgramsNavigation.Items.Count > 0)
                            lstBoxWeeklyProgramsNavigation.SelectedItem = lstBoxWeeklyProgramsNavigation.Items[0];
                    }


                }
                else
                {
                    // ...
                }
            }
            catch { }

        }

        public UcWeeklyProgramReportManager()
        {
            InitializeComponent();
            ucWeeklyProgram = new UcWeeklyProgram(Properties.Settings.Default.WeeklyProgram_StartHour, Properties.Settings.Default.WeeklyProgram_Length, WpfApplication.WpfApplicationUtilityClasses.Enums.ReportFeaturs.ALL_FEATURES);
            panelContent.Children.Clear();
            panelContent.Children.Add(ucWeeklyProgram);
        }

        private void btnSaveCurrentWeeklyProgram_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                program.Description = txtDescription.Text;
                program.NumberOfUnits = int.Parse(txtUnits.Text);
                program.Score = double.Parse(txtScore.Text);
                program.TermNumber = int.Parse(txtTermNumber.Text);
                program.UserScore = ratingBarUserScore.Value;
                if (SaveDirectoryMode == UcWeeklyProgramManagerSaveDirectoryMode.SAVE_JUST_IN_SOURCE_DIRECTORY)
                    FileServiceProvider.SerializeToXmlFile(selectedModel.FileName, program);
                else if (SaveDirectoryMode == UcWeeklyProgramManagerSaveDirectoryMode.SAVE_JUST_IN_SECOND_DIRECTORY)
                    FileServiceProvider.SerializeToXmlFile(SecondSavedDirectory + selectedModel.DisplayName + ".xml", program);
                else if (SaveDirectoryMode == UcWeeklyProgramManagerSaveDirectoryMode.SAVE_IN_SOURCE_AND_SECOND_DIRECTORY)
                {
                    FileServiceProvider.SerializeToXmlFile(selectedModel.FileName, program);
                    FileServiceProvider.SerializeToXmlFile(SecondSavedDirectory + selectedModel.DisplayName + ".xml", program);
                }
                else
                    throw new Exception();                
            }
            catch
            {

            }
        }

        private void lstBoxWeeklyProgramsNavigation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                UcWeeklyProgramReportManagerListBoxObjectModel model = lstBoxWeeklyProgramsNavigation.SelectedItem as UcWeeklyProgramReportManagerListBoxObjectModel;
                selectedModel = model;

                FileServiceProvider.DeserializeFromXmlFile(selectedModel.FileName, out program);
                txtDescription.Text = program.Description;
                txtUnits.Text = program.NumberOfUnits.ToString();
                txtScore.Text = program.Score.ToString();
                txtTermNumber.Text = program.TermNumber.ToString();
                ratingBarUserScore.Value = program.UserScore;

                ucWeeklyProgram.Print(program.DataSource,
                    Properties.Settings.Default.WeeklyProgram_MinuteWidth, Properties.Settings.Default.WeeklyProgram_BorderThickness
                    , Properties.Settings.Default.WeeklyProgram_Padding, Properties.Settings.Default.WeeklyProgram_FontSize,
                    Properties.Settings.Default.WeeklyProgram_MinHeight, Properties.Settings.Default.WeeklyProgram_DataGridCourseInfoWidth);
            }
            catch { }
        }

        private void btnDeleteCurrentWeeklyProgram_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var res = MessageBox.Show("آیا می خواهید حذف کنید ؟", "حذف", MessageBoxButton.OKCancel);
                if (res == MessageBoxResult.OK)
                {
                    int x = lstBoxWeeklyProgramsNavigation.SelectedIndex;
                    if (lstBoxWeeklyProgramsNavigation.Items.Count <= 1)
                    {
                        x = -1;
                    }
                    else if (x + 1 < lstBoxWeeklyProgramsNavigation.Items.Count - 1)
                    {
                        x = x + 1;
                    }
                    else if (x - 1 >= 0)
                    {
                        x = x - 1;
                    }
                    File.Delete(selectedModel.FileName);
                    lstBoxWeeklyProgramsNavigation.Items.Remove(selectedModel);
                    if (x != -1)
                    {
                        lstBoxWeeklyProgramsNavigation.SelectedIndex = x;
                    }
                }

            }
            catch
            {

            }
        }

    }
}
