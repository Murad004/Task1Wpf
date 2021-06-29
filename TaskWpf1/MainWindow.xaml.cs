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


namespace TaskWpf1
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
        Random random = new Random();

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)random.Next(1, 256), (byte)random.Next(1, 256), (byte)random.Next(1, 256)));
            if (sender is Button bt)
            {
                bt.Background = brush;
                MessageBox.Show($"I am {bt.Content}");
            }
        }

        private void Button1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button bt)
            {
                this.Title = bt.Content.ToString();
                mygrid.Children.Remove(bt);
                mygrid.Children.Remove(bt);
            }
        }
    }
}
