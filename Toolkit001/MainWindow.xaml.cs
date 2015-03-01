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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.DataGrid; 

namespace Toolkit001
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


        private void ButtonSpinner_Spin(object sender, Xceed.Wpf.Toolkit.SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void btnDrawPie_Click(object sender, RoutedEventArgs e)
        {
            Pie myPie = new Pie();
            myPie.Fill = new SolidColorBrush(Colors.CadetBlue);
            myPie.Height = 100;
            myPie.Width = 100;
            myPie.StartAngle = 0;
            myPie.EndAngle = 90;

            Pie myPie2 = new Pie();
            myPie2.Fill = new SolidColorBrush(Colors.PeachPuff);
            myPie2.Height = 100;
            myPie2.Width = 100;
            myPie2.StartAngle = 90;
            myPie2.EndAngle = 250;

            Pie myPie3 = new Pie();
            myPie3.Fill = new SolidColorBrush(Colors.PaleGreen);
            myPie3.Height = 100;
            myPie3.Width = 100;
            myPie3.StartAngle = 250;
            myPie3.EndAngle = 360;



            pieGrid.Children.Add(myPie);
            pieGrid.Children.Add(myPie2);
            pieGrid.Children.Add(myPie3);
        }
    }
}
