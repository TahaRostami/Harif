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

namespace Tataiee.Harif.WpfApplication
{
    /// <summary>
    /// Interaction logic for MainSettings.xaml
    /// </summary>
    public partial class UcMainSettings : UserControl
    {
        public UcMainSettings()
        {
            InitializeComponent();
            ReLoadDataAndBindThemToControls();
        }

        private void ReLoadDataAndBindThemToControls()
        {
            try
            {


                Properties.Settings.Default.Reload();

                txtWpStartHour.Text = Properties.Settings.Default.WeeklyProgram_StartHour.ToString();
                txtWpFinishHour.Text = (Properties.Settings.Default.WeeklyProgram_StartHour + Properties.Settings.Default.WeeklyProgram_Length).ToString();
                txtWpMinuteWidth.Text = Properties.Settings.Default.WeeklyProgram_MinuteWidth.ToString();
                txtWpBorderThickness.Text = Properties.Settings.Default.WeeklyProgram_BorderThickness.ToString();
                txtPadding.Text = Properties.Settings.Default.WeeklyProgram_Padding.ToString();
                txtFontSize.Text = Properties.Settings.Default.WeeklyProgram_FontSize.ToString();
                txtMinHeight.Text = Properties.Settings.Default.WeeklyProgram_MinHeight.ToString();
                txtDataGridCourseInfoWidth.Text = Properties.Settings.Default.WeeklyProgram_DataGridCourseInfoWidth.ToString();

                chkAdaptTblVis.IsChecked = Properties.Settings.Default.AdaptTableVisibility;
                chkCreditDeterminerVis.IsChecked = Properties.Settings.Default.CreditDeterminerVisibility;
                chkHomePageVis.IsChecked = Properties.Settings.Default.HomePageVisibility;
                chkOfferedCourseManagerVis.IsChecked = Properties.Settings.Default.OfferedCourseManagerVisibility;
                chkReductionStep2SettingVis.IsChecked = Properties.Settings.Default.ReductionStep2SettingVisibility;
                chkStudHistoryVis.IsChecked = Properties.Settings.Default.StudHistoryVisibility;


                txtWpSaveDirectory.Text = Properties.Settings.Default.WeeklyProgramSavedDirectory;

                if (Properties.Settings.Default.AlgorithmAnimationEffectStatus == 0)
                {
                    rdbAlgorithmStandardEffect.IsChecked = true;
                }
                else if (Properties.Settings.Default.AlgorithmAnimationEffectStatus == 1)
                {
                    rdbAlgorithmNonStandardEffect.IsChecked = true;
                }
                else if (Properties.Settings.Default.AlgorithmAnimationEffectStatus == 2)
                {
                    rdbAlgorithmEffectDisabled.IsChecked = true;
                }
                else
                    throw new Exception();

                cmbStartPage.SelectedIndex = Properties.Settings.Default.StartPage;
            }
            catch { }
        }



        private void btnSaveSettingWeeklyProgram_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(txtWpStartHour.Text) >= 5)
                    Properties.Settings.Default.WeeklyProgram_StartHour = int.Parse(txtWpStartHour.Text);
                if (int.Parse(txtWpFinishHour.Text) <= 23 && int.Parse(txtWpFinishHour.Text) > int.Parse(txtWpStartHour.Text))
                    Properties.Settings.Default.WeeklyProgram_Length = int.Parse(txtWpFinishHour.Text) - int.Parse(txtWpStartHour.Text);
                if (double.Parse(txtWpMinuteWidth.Text) > 0)
                    Properties.Settings.Default.WeeklyProgram_MinuteWidth = double.Parse(txtWpMinuteWidth.Text);
                if (double.Parse(txtWpBorderThickness.Text) > 0)
                    Properties.Settings.Default.WeeklyProgram_BorderThickness = double.Parse(txtWpBorderThickness.Text);
                if (double.Parse(txtPadding.Text) > 0)
                    Properties.Settings.Default.WeeklyProgram_Padding = double.Parse(txtPadding.Text);
                if (double.Parse(txtFontSize.Text) > 0)
                    Properties.Settings.Default.WeeklyProgram_FontSize = double.Parse(txtFontSize.Text);
                if (double.Parse(txtMinHeight.Text) > 0)
                    Properties.Settings.Default.WeeklyProgram_MinHeight = double.Parse(txtMinHeight.Text);
                if (double.Parse(txtDataGridCourseInfoWidth.Text) > 0)
                    Properties.Settings.Default.WeeklyProgram_DataGridCourseInfoWidth = double.Parse(txtDataGridCourseInfoWidth.Text);

                Properties.Settings.Default.Save();

                ReLoadDataAndBindThemToControls();

                MessageBox.Show("درخواست شما با موفقیت انجام شد");
            }
            catch
            {
                ReLoadDataAndBindThemToControls();
                MessageBox.Show("خطا");
            }
        }

        private void btnResetSettingWeeklyProgram_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Properties.Settings.Default.WeeklyProgram_StartHour = 7;

                Properties.Settings.Default.WeeklyProgram_Length = 15;

                Properties.Settings.Default.WeeklyProgram_MinuteWidth = 1.1;

                Properties.Settings.Default.WeeklyProgram_BorderThickness = 1;

                Properties.Settings.Default.WeeklyProgram_Padding = 5;

                Properties.Settings.Default.WeeklyProgram_FontSize = 13;

                Properties.Settings.Default.WeeklyProgram_MinHeight = 70;

                Properties.Settings.Default.WeeklyProgram_DataGridCourseInfoWidth = 800;

                Properties.Settings.Default.Save();

                ReLoadDataAndBindThemToControls();

                MessageBox.Show("درخواست شما با موفقیت انجام شد");
            }
            catch
            {
                ReLoadDataAndBindThemToControls();
                MessageBox.Show("خطا");
            }

        }

        private void btnSaveSettingVisMenus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.StartPage == 0 && chkHomePageVis.IsChecked.Value == false) throw new Exception();
                else if (Properties.Settings.Default.StartPage == 1 && chkStudHistoryVis.IsChecked.Value == false) throw new Exception();
                else if (Properties.Settings.Default.StartPage == 2 && chkOfferedCourseManagerVis.IsChecked.Value == false) throw new Exception();
                else if (Properties.Settings.Default.StartPage == 3 && chkReductionStep2SettingVis.IsChecked.Value == false) throw new Exception();           


                Properties.Settings.Default.HomePageVisibility = chkHomePageVis.IsChecked.Value;

                Properties.Settings.Default.CreditDeterminerVisibility = chkCreditDeterminerVis.IsChecked.Value;

                Properties.Settings.Default.AdaptTableVisibility = chkAdaptTblVis.IsChecked.Value;

                Properties.Settings.Default.StudHistoryVisibility = chkStudHistoryVis.IsChecked.Value;

                Properties.Settings.Default.OfferedCourseManagerVisibility = chkOfferedCourseManagerVis.IsChecked.Value;

                Properties.Settings.Default.ReductionStep2SettingVisibility = chkReductionStep2SettingVis.IsChecked.Value;

                Properties.Settings.Default.Save();

                ReLoadDataAndBindThemToControls();

                MessageBox.Show("درخواست شما با موفقیت انجام شد برای اطمینان از اعمال تغییرات یکبار برنامه را بسته دوباره باز کنید");
            }
            catch
            {
                ReLoadDataAndBindThemToControls();
                MessageBox.Show("خطا");
            }
        }

        private void btnResetSettingVisMenus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Properties.Settings.Default.HomePageVisibility) throw new Exception();                

                Properties.Settings.Default.HomePageVisibility = true;

                Properties.Settings.Default.CreditDeterminerVisibility = true;

                Properties.Settings.Default.AdaptTableVisibility = true;

                Properties.Settings.Default.StudHistoryVisibility = true;

                Properties.Settings.Default.OfferedCourseManagerVisibility = true;

                Properties.Settings.Default.ReductionStep2SettingVisibility = true;

                Properties.Settings.Default.Save();

                ReLoadDataAndBindThemToControls();

                MessageBox.Show("درخواست شما با موفقیت انجام شد برای اطمینان از اعمال تغییرات یکبار برنامه را بسته دوباره باز کنید");
            }
            catch
            {
                ReLoadDataAndBindThemToControls();
                MessageBox.Show("خطا");
            }
        }

        private void btnSaveSettingOthers_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (rdbAlgorithmStandardEffect.IsChecked == true)
                {
                    
                    Properties.Settings.Default.AlgorithmAnimationEffectStatus = 0;
                }
                else if (rdbAlgorithmNonStandardEffect.IsChecked == true)
                {                    
                    Properties.Settings.Default.AlgorithmAnimationEffectStatus = 1;
                }
                else if (rdbAlgorithmEffectDisabled.IsChecked == true)
                {
                    Properties.Settings.Default.AlgorithmAnimationEffectStatus=2;
                }
                else
                    throw new Exception();                

                Properties.Settings.Default.WeeklyProgramSavedDirectory = txtWpSaveDirectory.Text;

                if (cmbStartPage.SelectedIndex >= 0)
                {
                    if (cmbStartPage.SelectedIndex == 0)
                    {
                        if (!Properties.Settings.Default.HomePageVisibility) throw new Exception();
                    }
                    else if (cmbStartPage.SelectedIndex == 1)
                    {
                        if (!Properties.Settings.Default.StudHistoryVisibility) throw new Exception();
                    }
                    else if (cmbStartPage.SelectedIndex == 2)
                    {
                        if (!Properties.Settings.Default.OfferedCourseManagerVisibility) throw new Exception();
                    }
                    else if (cmbStartPage.SelectedIndex == 3)
                    {
                        if (!Properties.Settings.Default.ReductionStep2SettingVisibility) throw new Exception();
                    }
                    else if (cmbStartPage.SelectedIndex == 4)
                    {
                        
                    }
                    else if (cmbStartPage.SelectedIndex == 5)
                    {
                        
                    }
                    Properties.Settings.Default.StartPage = cmbStartPage.SelectedIndex;
                }
                   
                else
                    throw new Exception();

                Properties.Settings.Default.Save();

                ReLoadDataAndBindThemToControls();

                MessageBox.Show("درخواست شما با موفقیت انجام شد برای اطمینان از اعمال تغییرات یکبار برنامه را بسته دوباره باز کنید");
            }
            catch
            {
                ReLoadDataAndBindThemToControls();
                MessageBox.Show("خطا");
            }
        }

        private void btnResetSettingOthers_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Properties.Settings.Default.AlgorithmAnimationEffectStatus = 0;
                Properties.Settings.Default.WeeklyProgramSavedDirectory = "Data\\Reports\\AlgorithmReports\\SavedAlgorithmExeOutputs\\";
                Properties.Settings.Default.StartPage = 0;//home page

                Properties.Settings.Default.Save();

                ReLoadDataAndBindThemToControls();

                MessageBox.Show("درخواست شما با موفقیت انجام شد برای اطمینان از اعمال تغییرات یکبار برنامه را بسته دوباره باز کنید");
            }
            catch
            {
                ReLoadDataAndBindThemToControls();
                MessageBox.Show("خطا");
            }
        }
    }
}
