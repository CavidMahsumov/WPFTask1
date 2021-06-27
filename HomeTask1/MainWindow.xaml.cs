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

namespace HomeTask1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();

        }
        private void BtnClick(object sender,EventArgs e)
        {
            Color randomColor = Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256));

            var btn = sender as Button;
            SolidColorBrush brush = new SolidColorBrush(randomColor);
            btn.Background = brush;
            MessageBox.Show($"I am {btn.Content} button");

        }

        private void RightClickBtn(object sender, MouseButtonEventArgs e )
        {
            
            var btn = sender as Button;
            Stack1.Children.Remove(btn);
            Stack2.Children.Remove(btn);
            this.Title = (string)btn.Content;

        }

        
        
    }
}
