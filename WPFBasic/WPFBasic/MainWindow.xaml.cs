using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFBasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Show Page01
        private void BtnToPage01_Click(object sender, RoutedEventArgs routedEventArgs)
        {
            frMain.Content = new Page1();
        }

        //Show Page02
        private void BtnToPage02_Click(object sender, RoutedEventArgs rutedEventArgs)
        {
            frMain.Content = new Page2();
        }
    }
}