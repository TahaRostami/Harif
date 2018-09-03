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
using Tataiee.Harif.Infrastructures.GeneralEnums;

namespace Tataiee.Harif.WpfApplication
{
    /// <summary>
    /// Interaction logic for UcReductionStep2Settings.xaml
    /// </summary>
    public partial class UcProcessingSettings : UserControl
    {
        public UcProcessingSettings()
        {
            InitializeComponent();

            ReLoadSettings();


        }

        private void ReLoadSettings()
        {
            try
            {
                Properties.Settings.Default.Reload();

                rdbMale.IsChecked = Properties.Settings.Default.Gender == 'm' ? true : false;
                rdbFemale.IsChecked = rdbMale.IsChecked == true ? false : true;

                txtTermNumber.Text = Properties.Settings.Default.CurrentTermNumber.ToString();

                txtMaxUnits.Text = Properties.Settings.Default.MaxUnits.ToString();

                txtMinUnits.Text = Properties.Settings.Default.MinUnits.ToString();

                txtTimeout.Text = Properties.Settings.Default.TimeoutForReductionStep2ms.ToString();

                chkCapacityFiltering.IsChecked = Properties.Settings.Default.CapacityFiltering;

                chkExamCollideChecking.IsChecked = Properties.Settings.Default.ExamCollideChecking;

                txtMaxAlgoTimeProc.Text = Properties.Settings.Default.AlgorithmMaxProcessingTimeMS.ToString();

                txtMaxNumberOfSuggestedWeeklyProgram.Text = Properties.Settings.Default.MaxNumberOfSuggestedWeeklyProgram.ToString();

            }
            catch
            {
                lblMsg.Foreground = Brushes.Red;
                lblMsg.Content = "خطایی رخ داده است";
            }
        }

        private void btnSetting_Click(object sender, RoutedEventArgs e)
        {
            string exceptionMsgStr = string.Empty;

            try
            {
                int maxUnits;
                if (int.TryParse(txtMaxUnits.Text, out maxUnits))
                {
                    if (maxUnits >= 12 && maxUnits <= 24)
                        Properties.Settings.Default.MaxUnits = maxUnits;
                    else
                        exceptionMsgStr += System.Environment.NewLine + "حداکثر واحد باید عددی صحیح از 12 تا 24 واحد باشد";
                }
                else
                    exceptionMsgStr += System.Environment.NewLine + "حداکثر واحد باید عدد صحیح باشد";

                int minUnits;
                if (int.TryParse(txtMinUnits.Text, out minUnits))
                {
                    if (minUnits >= 12 && minUnits <= 24 && minUnits <= maxUnits)
                        Properties.Settings.Default.MinUnits = minUnits;
                    else
                    {
                        if (!(minUnits >= 12 && minUnits <= 24))
                            exceptionMsgStr += System.Environment.NewLine + "حداقل واحد باید عددی صحیح از 12 تا 24 واحد باشد";
                        if (minUnits > maxUnits)
                            exceptionMsgStr += System.Environment.NewLine + "حداقل واحد نمی تواند از حداکثر واحد بزرگتر باشد";
                    }
                }
                else
                    exceptionMsgStr += System.Environment.NewLine + "حداقل واحد باید عدد صحیح باشد";


                int termNumber;
                if (int.TryParse(txtTermNumber.Text, out termNumber))
                {
                    if (termNumber >= 1 && termNumber <= 12)
                        Properties.Settings.Default.CurrentTermNumber = termNumber;
                    else
                        exceptionMsgStr += System.Environment.NewLine + "شماره ترم می  تواند عددی از 1 تا 12 باشد";
                }
                else
                    exceptionMsgStr += System.Environment.NewLine + "شماره ترم باید عدد صحیح باشد";


                int timeout;
                if (int.TryParse(txtTimeout.Text, out timeout))
                {
                    if (timeout > 120 && timeout <= int.MaxValue)
                        Properties.Settings.Default.TimeoutForReductionStep2ms = timeout;
                    else
                        exceptionMsgStr += System.Environment.NewLine + "حداکثر زمان پردازش باید عددی بزرگتر مساوی 120 میلی ثانیه و در بازه اعداد صحیح باشد";
                }
                else
                    exceptionMsgStr += System.Environment.NewLine + "حداکثر زمان پردازش یک عدد صحیح بر حسب میلی ثانیه می باشد";

                int algoTime;
                if (int.TryParse(txtMaxAlgoTimeProc.Text, out algoTime))
                {
                    if (algoTime > timeout && algoTime <= 300000)//300000 ms = 5 min
                        Properties.Settings.Default.AlgorithmMaxProcessingTimeMS = algoTime;
                    else
                        exceptionMsgStr += System.Environment.NewLine + " زمان برای پرادزش الگوریتم باید از حداکثر زمان پردازش مجاز بودن اخذ الزامی دروس بیشتر و همچین در بازه مجاز باشد";
                }
                else
                    exceptionMsgStr += System.Environment.NewLine + "حداکثر زمان برای پرادزش الگوریتم یک عدد صحیح بر حسب میلی ثانیه می باشد";

                int maxNumberSuggestedWeeklyProgram;
                if (int.TryParse(txtMaxNumberOfSuggestedWeeklyProgram.Text, out maxNumberSuggestedWeeklyProgram))
                {
                    if (maxNumberSuggestedWeeklyProgram >= 1 && maxNumberSuggestedWeeklyProgram <= 50)
                        Properties.Settings.Default.MaxNumberOfSuggestedWeeklyProgram = maxNumberSuggestedWeeklyProgram;
                    else
                        exceptionMsgStr += System.Environment.NewLine + "حداکثر تعداد برنامه های پیشنهادی می تواند عددی صحیح از 1 تا 50 باشد";
                }
                else
                    exceptionMsgStr += System.Environment.NewLine + "حداکثر تعداد برنامه های پیشنهادی می تواند عددی صحیح از 1 تا 50 باشد";



                char gender = rdbMale.IsChecked == true ? 'm' : 'f';
                Properties.Settings.Default.Gender = gender;

                bool capacityFiltering = chkCapacityFiltering.IsChecked == true ? true : false;
                Properties.Settings.Default.CapacityFiltering = capacityFiltering;

                bool examCollideChecking = chkExamCollideChecking.IsChecked == true ? true : false;
                Properties.Settings.Default.ExamCollideChecking = examCollideChecking;

                if (exceptionMsgStr != string.Empty)
                    throw new Exception("TYPE_A");

                Properties.Settings.Default.ReductionStep2MustBeLoad = false;

                Properties.Settings.Default.Save();

                ReLoadSettings();
                lblMsg.Foreground = Brushes.DarkGreen;
                lblMsg.Content = "تغییرات با موفقیت اعمال شد";

            }
            catch (Exception ex)
            {
                ReLoadSettings();
                lblMsg.Foreground = Brushes.Red;
                if (ex.Message == "TYPE_A")
                {
                    lblMsg.Content = exceptionMsgStr;
                }
                else
                {
                    lblMsg.Content = "عدم موفقیت در اعمال تغییرات";
                }

            }


        }

        private void btnResetSetting_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Properties.Settings.Default.Gender = 'm';

                Properties.Settings.Default.CurrentTermNumber = 1;

                Properties.Settings.Default.MaxUnits = 24;

                Properties.Settings.Default.MinUnits = 12;

                Properties.Settings.Default.TimeoutForReductionStep2ms = 1000;

                Properties.Settings.Default.CapacityFiltering = false;

                Properties.Settings.Default.ExamCollideChecking = true;

                Properties.Settings.Default.AlgorithmMaxProcessingTimeMS = 5000;

                Properties.Settings.Default.MaxNumberOfSuggestedWeeklyProgram = 15;

                Properties.Settings.Default.ReductionStep2MustBeLoad = false;

                Properties.Settings.Default.Save();


                ReLoadSettings();
                lblMsg.Foreground = Brushes.DarkGreen;
                lblMsg.Content = "بازنشاندن مقادیر پیش فرض با موفقیت انجام شد";

            }
            catch
            {
                ReLoadSettings();
                lblMsg.Foreground = Brushes.Red;
                lblMsg.Content = "خطایی رخ داده است";
            }

        }
    }
}
