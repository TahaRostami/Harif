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
    /// Interaction logic for UcHomePage.xaml
    /// </summary>
    public partial class UcHomePage : UserControl
    {
        public UcHomePage()
        {
            InitializeComponent();
        }

        //email address
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText("tataiee1375@gmail.com");
        }

        //video
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.example.com");
        }

        //source code
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.example.com");
        }
    }
}
