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

namespace Assenstelsel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int firstTime = 0;
        double gridx = 0;
        double gridy = 0;
        

        public MainWindow()
        {
            InitializeComponent();
            LineX.Visibility = Visibility.Collapsed;
            LineY.Visibility = Visibility.Collapsed;
        }

        private void click(object sender, RoutedEventArgs e)
        {
            Point zero = Mouse.GetPosition(window);
            if (firstTime == 0)
            {
                firstTime = 1;
                gridy = zero.X;
                gridx = zero.Y;


                LineX.Margin = new Thickness(0, gridx, 0, 0);
                LineX.Visibility = Visibility.Visible;

                LineY.Margin = new Thickness(gridy, 0, 0, 0);
                LineY.Visibility = Visibility.Visible;
            }
            

            
            outputCEN.Content = "("+ gridy + "," + gridx + ")";
            outputSCR.Content = "(" + zero.X + "," + zero.Y + ")";
            zero.X = zero.X - gridy;
            zero.Y = gridx - zero.Y;
            outputWIS.Content = "(" + zero.X + "," + zero.Y + ")";
        }
    }
}
