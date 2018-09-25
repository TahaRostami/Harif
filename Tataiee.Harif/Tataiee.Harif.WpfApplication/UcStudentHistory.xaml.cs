using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Tataiee.Harif.Infrastructures.ReductionSteps;
using Tataiee.Harif.Infrastructures.StudentHistory;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Models;
using Tataiee.Harif.Infrastructures.OfferesdCourses;

namespace Tataiee.Harif.WpfApplication
{
    /// <summary>
    /// Interaction logic for UcStudentHistory.xaml
    /// </summary>
    public partial class UcStudentHistory : UserControl
    {

        ObservableCollection<StudentHistoryGridRow> collection = new ObservableCollection<StudentHistoryGridRow>();

        public UcStudentHistory()
        {
            InitializeComponent();
        }

        private void SetButtonBackgroundColor(Button button, WpfApplication.WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors color)
        {
            if (color == WpfApplication.WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.WHITE)
            {
                button.Background = Brushes.Transparent;
            }
            else if (color == WpfApplication.WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.GREEN)
            {
                BrushConverter bc = new BrushConverter();
                Brush brush = (Brush)bc.ConvertFrom("#8ee269");
                brush.Freeze();
                button.Background = brush;
            }
            else if (color == WpfApplication.WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.YELLOW)
            {
                BrushConverter bc = new BrushConverter();
                Brush brush = (Brush)bc.ConvertFrom("#f6e556");
                brush.Freeze();
                button.Background = brush;
            }
            else
            {
                throw new Exception();
            }
        }

        public async Task RunAfterCreateAsync()
        {
            try
            {
                await Task.Run(async () =>
                {
                    await Dispatcher.InvokeAsync(() =>
                    {
                        mainPanel.Children.Clear();
                    });


                    CourseInformation[] cfs;
                    FileServiceProvider.DeserializeFromXmlFile(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CourseInformationSavedName, out cfs);

                    for (int i = 0; i < cfs.Length; i++)
                    {
                        var item = cfs[i];
                        if (item.CodeInDesUni == "-") continue;
                        StudentHistoryGridRow shdr = new StudentHistoryGridRow
                        {
                            Id = item.Id,
                            CodeInDesUni = item.CodeInDesUni,
                            TitleInDesUni = item.CorrespondingTitleInDesUni,
                            StatusColor = item.IsPassed ? WpfApplication.WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.GREEN
                            : item.NumberOfFailed > 1 ? WpfApplication.WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.YELLOW
                            : WpfApplication.WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.WHITE,
                        };

                        Dispatcher.Invoke(() =>
                        {
                            collection.Add(shdr);
                        });

                    }

                    await Dispatcher.InvokeAsync(() =>
                    {

                        for (int i = 0; i < collection.Count; i++)
                        {
                            Badged badged = new Badged();
                            badged.Badge = collection[i].CodeInDesUni;
                            badged.Margin = new Thickness(15);
                            badged.Name = "bdg" + collection[i].Id;

                            Button button = new Button();
                            button.Content = new TextBlock()
                            {
                                Text = collection[i].TitleInDesUni,
                                TextAlignment = TextAlignment.Center,
                                TextWrapping = TextWrapping.Wrap
                            };
                            button.Name = "btn" + i.ToString();
                            button.Width = 250;
                            button.Height = Double.NaN;
                            button.Padding = new Thickness(8);

                            SetButtonBackgroundColor(button, collection[i].StatusColor);

                            button.Click += Button_Click;
                            badged.Content = button;

                            mainPanel.Children.Add(badged);
                        }

                    });


                });
            }
            catch { }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int collId = int.Parse(btn.Name.Substring(3));

            StudentHistoryGridRow shdr = collection[collId];

            if (shdr.StatusColor == WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.WHITE)
            {
                shdr.StatusColor = WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.GREEN;
            }
            else if (shdr.StatusColor == WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.YELLOW)
            {
                shdr.StatusColor = WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.WHITE;
            }
            else if (shdr.StatusColor == WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.GREEN)
            {
                shdr.StatusColor = WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.YELLOW;
            }
            else
            {
                throw new Exception();
            }

            SetButtonBackgroundColor(btn, shdr.StatusColor);

        }

        private async void btnOk_Click(object sender, RoutedEventArgs e)
        {
            btnOk.IsEnabled = false;
            await Task.Run(() => {

                CourseInformation[] cfs;
                try
                {
                    FileServiceProvider.DeserializeFromXmlFile(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CourseInformationSavedName, out cfs);

                    for (int i = 0; i < collection.Count; i++)
                    {
                        var c = cfs[collection[i].Id];
                        if (collection[i].StatusColor == WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.WHITE)
                        {
                            c.IsPassed = false;
                            c.NumberOfFailed = 0;
                        }
                        else if (collection[i].StatusColor == WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.GREEN)
                        {
                            c.IsPassed = true;
                        }
                        else if (collection[i].StatusColor == WpfApplicationUtilityClasses.Enums.StudentHistoryGridRowColors.YELLOW)
                        {
                            c.IsPassed = false;
                            c.NumberOfFailed = 2;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }

                    FileServiceProvider.SerializeToXmlFile(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CourseInformationSavedName, cfs);

                    Properties.Settings.Default.ReductionStep2MustBeLoad = false;
                    Properties.Settings.Default.Save();

                    Dispatcher.Invoke(() => {
                        MessageBox.Show("تغییرات با موفقیت اعمال شد");
                    });
                    
                }
                catch
                {
                    Dispatcher.Invoke(() => {
                        MessageBox.Show("عدم موفقیت");
                    });                   
                }
            });
            btnOk.IsEnabled = true;

        }
    }
}
