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
            this.Title = "Welcome to WPF";
            (this.Height, this.Width) = (1000, 1000);
            this.WindowStyle = WindowStyle.ThreeDBorderWindow;
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

        private void frMain_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}