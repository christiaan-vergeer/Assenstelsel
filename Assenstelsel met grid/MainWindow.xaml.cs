﻿using System;
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

namespace Assenstelsel_met_grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int firstTime = 0;
        double gridx = 0;
        double gridy = 0;
        byte Redfill = 0;
        byte Greenfill = 0;
        byte Bluefill = 225;
        byte Redborder = 225;
        byte Greenborder = 0;
        byte Blueborder = 0;


        public MainWindow()
        {
            InitializeComponent();
            LineX.Visibility = Visibility.Collapsed;
            LineY.Visibility = Visibility.Collapsed;
            cp.SelectedColor = Colors.Blue;
            cp2.SelectedColor = Colors.Red;
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



                
                for (int i = -1200; i < 1250; i = i + 10)
                {

                    PathFigure line = new PathFigure();
                    line.StartPoint = new Point(gridy + i, 0);
                    LineSegment lineSeg = new LineSegment();
                    lineSeg.Point = new Point(gridy + i, 1200);
                    PathSegmentCollection path = new PathSegmentCollection();
                    path.Add(lineSeg);
                    line.Segments = path;
                    PathFigureCollection collection = new PathFigureCollection();
                    collection.Add(line);
                    PathGeometry geo = new PathGeometry();
                    geo.Figures = collection;
                    Path arcPath = new Path();
                    arcPath.Stroke = new SolidColorBrush(Colors.Gray);
                    arcPath.StrokeThickness = 1;
                    arcPath.Data = geo;
                    //arcPath.Fill = new SolidColorBrush(Colors.Yellow);
                    window.Children.Add(arcPath);
                }
                for (int i = -1200; i < 1250; i = i + 10)
                {
                    PathFigure line = new PathFigure();
                    line.StartPoint = new Point(0, gridx + i);
                    LineSegment lineSeg = new LineSegment();
                    lineSeg.Point = new Point(1200, gridx + i);
                    PathSegmentCollection path = new PathSegmentCollection();
                    path.Add(lineSeg);
                    line.Segments = path;
                    PathFigureCollection collection = new PathFigureCollection();
                    collection.Add(line);
                    PathGeometry geo = new PathGeometry();
                    geo.Figures = collection;
                    Path arcPath = new Path();
                    arcPath.Stroke = new SolidColorBrush(Colors.Gray);
                    arcPath.StrokeThickness = 1;
                    arcPath.Data = geo;
                    //arcPath.Fill = new SolidColorBrush(Colors.Yellow);
                    window.Children.Add(arcPath);
                }

                for (int i = -1200; i < 1250; i = i + 100)
                {
                    PathFigure line = new PathFigure();
                    line.StartPoint = new Point(gridy + i, 0);
                    LineSegment lineSeg = new LineSegment();
                    lineSeg.Point = new Point(gridy + i, 1200);
                    PathSegmentCollection path = new PathSegmentCollection();
                    path.Add(lineSeg);
                    line.Segments = path;
                    PathFigureCollection collection = new PathFigureCollection();
                    collection.Add(line);
                    PathGeometry geo = new PathGeometry();
                    geo.Figures = collection;
                    Path arcPath = new Path();
                    arcPath.Stroke = new SolidColorBrush(Colors.Red);
                    arcPath.StrokeThickness = 3;
                    arcPath.Data = geo;
                    //arcPath.Fill = new SolidColorBrush(Colors.Yellow);
                    window.Children.Add(arcPath);
                }
                for (int i = -1200; i < 1250; i = i + 100)
                {
                    PathFigure line = new PathFigure();
                    line.StartPoint = new Point(0, gridx + i);
                    LineSegment lineSeg = new LineSegment();
                    lineSeg.Point = new Point(1200, gridx + i);
                    PathSegmentCollection path = new PathSegmentCollection();
                    path.Add(lineSeg);
                    line.Segments = path;
                    PathFigureCollection collection = new PathFigureCollection();
                    collection.Add(line);
                    PathGeometry geo = new PathGeometry();
                    geo.Figures = collection;
                    Path arcPath = new Path();
                    arcPath.Stroke = new SolidColorBrush(Colors.Red);
                    arcPath.StrokeThickness = 3;
                    arcPath.Data = geo;
                    //arcPath.Fill = new SolidColorBrush(Colors.Yellow);
                    window.Children.Add(arcPath);
                }

                for (int i = -1200; i < 1250; i = i + 100)
                {
                    TextBlock box = new TextBlock();
                    box.Text = ((i / 10)*-1).ToString();
                    Margin = new Thickness(gridy+5, gridx + i, 0, 0);
                    box.Margin = Margin;
                    box.FontSize = 20;
                    box.Foreground = Brushes.Green;
                    box.FontWeight = FontWeights.Bold;
                    window.Children.Add(box);
                }
                for (int i = -1200; i < 1250; i = i + 100)
                {
                    TextBlock box = new TextBlock();
                    box.Text = (i / 10).ToString();
                    Margin = new Thickness(gridy + i + 5, gridx, 0, 0);
                    box.Margin = Margin;
                    box.FontSize = 20;
                    box.Foreground = Brushes.Green;
                    box.FontWeight = FontWeights.Bold;
                    window.Children.Add(box);
                }
                window.Background = Brushes.Wheat;
            }
            else
            {
                Ellipse dot = new Ellipse();
                dot.Height = dotthick.Value;
                dot.Width = dotthick.Value;
                if (borderthick.Value * 2 > dotthick.Value * (dotthick.Value / 100 * 10)) { borderthick.Value = (dotthick.Value * (dotthick.Value / 100 * 10)) / 2; }
                dot.StrokeThickness = borderthick.Value;
                SolidColorBrush fillBrush = new SolidColorBrush(Color.FromRgb(Redfill,Greenfill,Bluefill));
                SolidColorBrush borderBrush = new SolidColorBrush(Color.FromRgb(Redborder,Greenborder,Blueborder));
                dot.Fill = fillBrush;    
                dot.Stroke = borderBrush; 
                dot.Margin = new Thickness((zero.X * 2) - 1184, (zero.Y * 2) - 660, 0, 0);
                window.Children.Add(dot);
            }

            //outputCEN.Content = "(" + gridy + "," + gridx + ")";
            outputSCR.Content = "(" + zero.X + "," + zero.Y + ")";
            zero.X = Math.Round((zero.X - gridy)/10);
            zero.Y = Math.Round((gridx - zero.Y)/10);
            outputWIS.Content = "(" + zero.X + "," + zero.Y + ")";
        }

        private void cpSelectFill(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (cp.SelectedColor.HasValue)
            {
                Color C = cp.SelectedColor.Value;
                Redfill = C.R;
                Greenfill = C.G;
                Bluefill = C.B;
            }

        }

        private void cpSelectBorder(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (cp2.SelectedColor.HasValue)
            {
                Color C = cp2.SelectedColor.Value;
                Redborder = C.R;
                Greenborder = C.G;
                Blueborder = C.B;
            }

        }

        private void rest_Click(object sender, RoutedEventArgs e)
        {
            if(firstTime == 1)
            {
                firstTime = 0;
                LineX.Visibility = Visibility.Collapsed;
                LineY.Visibility = Visibility.Collapsed;
                window.Children.Clear();
                window.Background = Brushes.White;
            }
            
        }

        private void afsluiten(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        //this is the grid one
    }
}