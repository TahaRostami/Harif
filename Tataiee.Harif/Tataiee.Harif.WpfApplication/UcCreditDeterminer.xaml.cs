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
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;
using Tataiee.Harif.Infrastructures.StudentHistory;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses;
using Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.UiMiddlewares;
using Tataiee.Harif.Infrastructures.OfferesdCourses;

namespace Tataiee.Harif.WpfApplication
{
    /// <summary>
    /// Interaction logic for UcCreditDeterminer.xaml
    /// </summary>
    public partial class UcCreditDeterminer : UserControl
    {

        readonly string stateLevel1 = CurriculumWpfClientMiddleware.ListLevel1Name();
        readonly string stateLevel2 = CurriculumWpfClientMiddleware.ListLevel2Name();

        public UcCreditDeterminer()
        {
            InitializeComponent();
            btnPrev_Click(null, null);
        }

       

        private void LoadData(string titleBar, Tuple<string, int>[] arr, RoutedEventHandler method, Visibility btnNextVisibility, Visibility btnPrevVisibility)
        {
            try
            {
                CreditDeterminer creditDeterminer = null;
                if (File.Exists(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CreditDeterminerSavedName))
                {
                    FileServiceProvider.DeserializeFromXmlFile(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CreditDeterminerSavedName, out creditDeterminer);
                }
                else
                {
                    creditDeterminer = new CreditDeterminer
                    {
                        Level1 = CurriculumWpfClientMiddleware.DefaultLevel1Value,
                        Level2 = CurriculumWpfClientMiddleware.DefaultLevel2Value,
                    };
                    FileServiceProvider.SerializeToXmlFile(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CreditDeterminerSavedName, creditDeterminer);
                }

                wrapPanelList.Children.Clear();
                txtblockTitleBar.Text = titleBar;

                for (int i = 0; i < arr.Length; i++)
                {
                    Badged badged = new Badged();
                    badged.Badge = (i + 1).ToString();
                    badged.Margin = new Thickness(15);
                    badged.Name = "bdg" + arr[i].Item2;

                    Button button = new Button();
                    button.Content = arr[i].Item1;
                    button.Name = "btn" + arr[i].Item2;

                    if (creditDeterminer.Level1 == arr[i].Item2 || creditDeterminer.Level2 == arr[i].Item2)
                    {
                        button.SetResourceReference(Button.BackgroundProperty, "PrimaryHueMidBrush");
                    }
                    else
                    {
                        button.Background = Brushes.Transparent;
                    }


                    button.Click += method;
                    badged.Content = button;

                    wrapPanelList.Children.Add(badged);
                }

                btnNext.Visibility = btnNextVisibility;
                btnPrev.Visibility = btnPrevVisibility;
            }
            catch { }

        }

        private void UpdateCreditDeterminerFile(Button sender)
        {
            try
            {
                if (File.Exists(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CreditDeterminerSavedName))
                {
                    CreditDeterminer creditDeterminer;
                    FileServiceProvider.DeserializeFromXmlFile(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CreditDeterminerSavedName, out creditDeterminer);

                    if (stateLevel1 == txtblockTitleBar.Text)
                    {
                        int x = int.Parse(sender.Name.Substring(3));

                        if (creditDeterminer.Level1 != x)
                        {
                            creditDeterminer.Level1 = x;

                            creditDeterminer.Level2 = CurriculumWpfClientMiddleware.DefaultLevel2Value;
                        }
                    }
                    else if (stateLevel2 == txtblockTitleBar.Text)
                    {
                        creditDeterminer.Level2 = int.Parse(sender.Name.Substring(3));
                    }
                    else
                        throw new Exception();

                    FileServiceProvider.SerializeToXmlFile(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CreditDeterminerSavedName, creditDeterminer);

                    Properties.Settings.Default.ReductionStep2MustBeLoad = false;
                    Properties.Settings.Default.Save();

                }
            }
            catch { }
        }
        
        private void UpdateCreditDeterminerUI(Button sender)
        {
            try
            {
                for (int i = 0; i < wrapPanelList.Children.Count; i++)
                {
                    var child1 = wrapPanelList.Children[i];
                    if (child1 is Badged)
                    {
                        var bdg = (Badged)child1;
                        Button cBtn = (Button)bdg.Content;
                        if (cBtn.Background != Brushes.Transparent)
                            cBtn.Background = Brushes.Transparent;
                    }
                    sender.SetResourceReference(Button.BackgroundProperty, "PrimaryHueMidBrush");
                }
            }
            catch { }
        }

        private void Level1Button_Click(object sender, RoutedEventArgs e)
        {
            UpdateCreditDeterminerFile((Button)sender);
            UpdateCreditDeterminerUI((Button)sender);
        }

        private void Level2Button_Click(object sender, RoutedEventArgs e)
        {
            UpdateCreditDeterminerFile((Button)sender);
            UpdateCreditDeterminerUI((Button)sender);
        }


        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreditDeterminer creditDeterminer;
                FileServiceProvider.DeserializeFromXmlFile(DirectoryManager.EssentialInforamtion1Directory + DirectoryManager.CreditDeterminerSavedName, out creditDeterminer);
                LoadData(stateLevel2, ServiceProviderForWpfClientCurriculums.ValidateAndReturnListLevel2(creditDeterminer.Level1), Level2Button_Click, Visibility.Collapsed, Visibility.Visible);
            }
            catch { }
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            LoadData(stateLevel1, ServiceProviderForWpfClientCurriculums.ListLevel1(), Level1Button_Click, Visibility.Visible, Visibility.Collapsed);
        }
    }
}
