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

            //this.ResizeMode = ResizeMode.NoResize;
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

        #region ResizeWindows
        bool ResizeInProcess = false;
        private void Resize_Init(object sender, MouseButtonEventArgs e)
        {
          if (e.LeftButton == MouseButtonState.Pressed)
            {
                ResizeInProcess = true;

                Rectangle senderRectangle = sender as Rectangle;
                senderRectangle.CaptureMouse();
            }
        }

        private void Resize_End(object sender, MouseButtonEventArgs e)
        {
            Rectangle senderRect = sender as Rectangle;
            if (senderRect != null)
            {
                ResizeInProcess = false; ;
                senderRect.ReleaseMouseCapture();
            }
        }

        private void Resizing_Form(object sender, MouseEventArgs e)
        {
            if (ResizeInProcess)
            {
                Rectangle senderRectangle = (Rectangle)sender;
                if (senderRectangle != null)
                {
                    if (senderRectangle.Name == "bottomRightSizeGrip")
                    {
                        Point mousePosition = e.GetPosition(this);
                        senderRectangle.CaptureMouse();

                        double newHeight = Height - mousePosition.Y;

                        if (newHeight <= MaxHeight && newHeight > MinHeight)
                        {
                            Point absoluteMousePosition = PointToScreen(mousePosition);
                            Height = newHeight;
                            Top = absoluteMousePosition.Y;
                        }
                    }
                }
                
                
            }
        }
#endregion
        //min_Window
    }
}
