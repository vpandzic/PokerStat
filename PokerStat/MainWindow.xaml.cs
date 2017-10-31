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

namespace PokerStat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            //PROMJENA
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {

            this.ResizeMode = ResizeMode.NoResize;
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }


        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.ResizeMode = ResizeMode.CanResize;
            //NOP
          /*  if(this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }*/
        }


        private void min_Window(object sender, RoutedEventArgs e) => this.WindowState = WindowState.Minimized;
        private void close_Window(object sender, RoutedEventArgs e) => this.Close();

        private void max_Window(object sender, RoutedEventArgs e) => this.WindowState = (this.WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;


        //min_Window
    }
}
