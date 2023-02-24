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

namespace WpfApp1
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //myLbl.Content = "Selected";
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
          //  myLbl.Content = "Not Selected";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioBtn = sender as RadioButton;
            radioBtn.Content += " Selected";
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            var radioBtn = sender as RadioButton;
            var data = radioBtn.Content.ToString().Split(' ');
            radioBtn.Content = data[0];
        }
        public int Counter { get; set; } = 0;
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            ++Counter;
            //btn.Content = Counter.ToString();
        }

        private void repeat_btn_Click(object sender, RoutedEventArgs e)
        {
            ++Counter;
           // repeat_btn.Content = Counter.ToString();
        }
        public bool HasClicked { get; set; }=false;
        private void toggle_btn_Click(object sender, RoutedEventArgs e)
        {
            HasClicked = !HasClicked;
            //toggle_btn.Content = HasClicked ? "Clicked" : "Not Clicked";
        }
    }
}
