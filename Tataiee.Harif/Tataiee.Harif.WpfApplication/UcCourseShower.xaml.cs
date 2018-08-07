using MaterialDesignThemes.Wpf;
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

namespace Tataiee.Harif.WpfApplication
{
    /// <summary>
    /// Interaction logic for UcCourseShower.xaml
    /// </summary>
    public partial class UcCourseShower : UserControl
    {

        PackIcon icon1= new PackIcon() { Kind = PackIconKind.AccountOutline };
        PackIcon icon2= new PackIcon() { Kind = PackIconKind.AccountMultiplePlusOutline };
        public UcCourseShower()
        {
            InitializeComponent();
            btnMust.Content = btnMust.Content == icon1 ? icon2 : icon1;
            btnMust.SetValue(ButtonProgressAssist.IsIndeterminateProperty, false);
            btnMust.SetValue(ButtonProgressAssist.IsIndicatorVisibleProperty, false);
        }

        private void btnMust_Click(object sender, RoutedEventArgs e)
        {
            btnMust.Content = btnMust.Content == icon1 ? icon2 : icon1;
            btnMust.SetValue(ButtonProgressAssist.IsIndeterminateProperty, true);
            btnMust.SetValue(ButtonProgressAssist.IsIndicatorVisibleProperty, true);
        }
    }
}
