using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;
using Tataiee.Harif.Infrastructures.OfferedCourses;
using Tataiee.Harif.Infrastructures.StudentHistory;
using Tataiee.Harif.WpfApplication.Models;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Models;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Utilities;
using Tataiee.Harif.Infrastructures.OfferesdCourses;

namespace Tataiee.Harif.WpfApplication
{
    /// <summary>
    /// Interaction logic for UcAdaptationTableCourses.xaml
    /// </summary>
    public partial class UcAdaptationTableCourses : UserControl
    {

        ObservableCollection<DataGridAdaptationTableGridRow> collection = new ObservableCollection<DataGridAdaptationTableGridRow>();

        public UcAdaptationTableCourses()
        {
            InitializeComponent();
            dataGridAdaptationTable.AutoGeneratingColumn += DataGridAdaptationTable_AutoGeneratingColumn;
            dataGridAdaptationTable.ItemsSource = collection;
        }

        private void DataGridAdaptationTable_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
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
                if (att.Name == "شناسه"
                 || att.Name == "عنوان درس"
                )
                {
                    e.Column.IsReadOnly = true;
                }
            }
        }

        public async Task RunAfterCreateAsync()
        {
            try
            {
                await Task.Run(() =>
                {
                    CourseInformation[] cfs = null;
                    if (!File.Exists(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CourseInformationSavedName))
                    {
                        CreateCourseInformationArrayAndFillItWithAppropriateData(out cfs);
                        FileServiceProvider.SerializeToXmlFile(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CourseInformationSavedName, cfs);
                    }
                    else
                    {
                        FileServiceProvider.DeserializeFromXmlFile(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CourseInformationSavedName, out cfs);
                    }
                    RiFillDataGrid(cfs);
                });
            }
            catch { }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CourseInformation[] cfs;

                if (File.Exists(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CourseInformationSavedName))
                {
                    FileServiceProvider.DeserializeFromXmlFile(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CourseInformationSavedName, out cfs);
                }
                else
                {
                    CreateCourseInformationArrayAndFillItWithAppropriateData(out cfs);
                }

                for (int i = 0; i < cfs.Length; i++)
                {
                    var current = cfs[i];

                    if (current.CorrespondingTitleInDesUni != collection[current.Id].TitleInDesUni)
                        current.CorrespondingTitleInDesUni = collection[current.Id].TitleInDesUni;

                    if (current.CodeInDesUni != collection[current.Id].CodeInDesUni)
                        current.CodeInDesUni = collection[current.Id].CodeInDesUni.ChangeFarsiNumberInStringToEnglishNumber();
                }

                FileServiceProvider.SerializeToXmlFile(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CourseInformationSavedName, cfs);

                Properties.Settings.Default.ReductionStep2MustBeLoad = false;
                Properties.Settings.Default.Save();

                MessageBox.Show("تغییرات با موفقیت اعمال شد");
            }
            catch { }
        }

        private void CreateCourseInformationArrayAndFillItWithAppropriateData(out CourseInformation[] cfs)
        {
            try
            {
                MainCurriculum curriculum = new MainCurriculum();
                cfs = new CourseInformation[curriculum.Courses.Count];
                for (int i = 0; i < cfs.Length; i++)
                {
                    var item = curriculum.Courses[i];
                    CourseInformation cf = new CourseInformation
                    {
                        Id = item.Id,
                        Title = item.Title,
                        CorrespondingTitleInDesUni = item.CorrespondingTitleInDesUni,
                        CodeInDesUni = item.CodeInDesUni,
                        IsPassed = item.IsPassed,
                        NumberOfFailed = item.NumberOfFailed,
                    };
                    cfs[i] = cf;
                }
            }
            catch
            {
                cfs = null;
            }
        }

        private void RiFillDataGrid(CourseInformation[] cfs)
        {
            try
            {
                foreach (var item in cfs)
                {
                    DataGridAdaptationTableGridRow gridRow = new DataGridAdaptationTableGridRow
                    {
                        Id = item.Id,
                        Title = item.Title,
                        TitleInDesUni = item.CorrespondingTitleInDesUni,
                        CodeInDesUni = item.CodeInDesUni,
                    };
                    Dispatcher.Invoke(() =>
                    {
                        collection.Add(gridRow);
                    });
                }
            }
            catch { }
        }

    }
}
