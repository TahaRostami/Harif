using MaterialDesignThemes.Wpf;
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
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses;
using Tataiee.Harif.Infrastructures.OfferesdCourses;

namespace Tataiee.Harif.WpfApplication
{
    /// <summary>
    /// Interaction logic for UcOfferedCoursesManager.xaml
    /// </summary>
    public partial class UcOfferedCoursesManager : UserControl
    {

        List<string> files = new List<string>();

        public UcOfferedCoursesManager()
        {
            InitializeComponent();
        }

        private void stackPanelDragAndDrop_Drop(object sender, DragEventArgs e)
        {
            try
            {
                SetBackgroundColor(null);
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] fls = (string[])e.Data.GetData(DataFormats.FileDrop);

                    this.files.Clear();
                    for (int i = 0; i < fls.Length; i++)
                    {
                        files.Add(fls[i]);
                    }

                }
            }
            catch { }
        }

        private async void btnGenerateGoalVersionXmlFile_Click(object sender, RoutedEventArgs e)
        {
            string red = "#f0513c";
            string green = "#5c9444";

            //specify appropriate color for user notification 
            string color = red;

            try
            {
                //if 'files' does not have any items , no need to start the proccess
                if (files.Count == 0)
                {
                    throw new Exception();
                }

                //disable button before the start of the process to prevent user from the requesting again.
                btnGenerateGoalVersionXmlFile.IsEnabled = false;

                await Task.Run(() =>
                {
                    //create an empty list 'lst' that represents goal version object that must be generated and then saved.
                    List<GoalVersionOfferedCoursesRow> lst = new List<GoalVersionOfferedCoursesRow>();

                    if (!Directory.Exists(DirectoryManager.GoalVersionOfferedCoursesRowDirectory))
                    {
                        Directory.CreateDirectory(DirectoryManager.GoalVersionOfferedCoursesRowDirectory);
                    }

                    //for every selected files (droped files) insert items where item's id does not exist in the 'lst'.
                    files.ForEach(f =>
                    {
                        //create object model from the specific file 'f' to insert it's items.
                        var glst = FileServiceProvider.ConvertFromOfferedCoursesBasicFormToGoalVersionXmlFormat(f, DirectoryManager.GoalVersionOfferedCoursesRowDirectory + DirectoryManager.GoalVersionOfferedCoursesRowSavedName, false);

                        #region Add Distinct

                        //add 'glst' items in the 'lst' list where its 'id' does not exist in the 'lst'.

                        for (int i = 0; i < glst.Count; i++)
                        {
                            var p = glst[i];
                            bool find = false;
                            for (int j = 0; j < lst.Count; j++)
                            {
                                var q = lst[j];
                                if (p.Id == q.Id)
                                {
                                    find = true;
                                    break;
                                }
                            }
                            if (!find)
                            {
                                lst.Add(p);
                            }
                        }

                        #endregion

                    });

                    //save goal version generated in appropriate directory with the specific name.
                    FileServiceProvider.SerializeToXmlFile(DirectoryManager.GoalVersionOfferedCoursesRowDirectory + DirectoryManager.GoalVersionOfferedCoursesRowSavedName, lst);

                    Properties.Settings.Default.ReductionStep2MustBeLoad = false;
                    Properties.Settings.Default.Save();

                    //specify appropriate color for user notification
                    color = green;
                });
            }
            catch
            {
                //set null to notify user that 'files' does not have any items.
                color = null;
            }
            finally
            {
                //set the background color to notify user about result of the proccess that completed.
                SetBackgroundColor(color);

                //remove all of the 'files' items for the next 'drag and drop'.
                files.Clear();

                //enable button after the proccess finished.
                btnGenerateGoalVersionXmlFile.IsEnabled = true;

            }

        }

        private void SetBackgroundColor(string color)
        {
            if (color != null)
            {
                BrushConverter bc = new BrushConverter();
                Brush brush = (Brush)bc.ConvertFrom(color);
                brush.Freeze();
                img1.Foreground = brush;
                txt1.Foreground = brush;
            }
            else
            {
                img1.SetResourceReference(PackIcon.ForegroundProperty, "PrimaryHueDarkBrush");
                txt1.SetResourceReference(TextBlock.ForegroundProperty, "PrimaryHueDarkBrush");
            }
        }

        private void LinkButton_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists(DirectoryManager.GoalVersionOfferedCoursesRowDirectory))
                System.Diagnostics.Process.Start(DirectoryManager.GoalVersionOfferedCoursesRowDirectory);
        }

    }
}
