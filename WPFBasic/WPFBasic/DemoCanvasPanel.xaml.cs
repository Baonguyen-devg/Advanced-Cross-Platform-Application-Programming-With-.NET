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
using System.Windows.Shapes;

namespace WPFBasic
{
    /// <summary>
    /// Interaction logic for DemoCanvasPanel.xaml
    /// </summary>
    public partial class DemoCanvasPanel : Window
    {
        public DemoCanvasPanel()
        {
            InitializeComponent();
        }

        private void ButtonDisplay_Click(object sender, RoutedEventArgs e)
        {
          /*  string carInformation = $"Car name: {TextBoxCarName.Text}\n" +
                $"Color: {TextBoxColor.Text} \nBrand: {TextBoxBrand.Text}";*/
           // MessageBox.Show(carInformation, "Car Details");
        }
    }
}
