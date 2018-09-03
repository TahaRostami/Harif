using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.WeeklyProgram
{
    public class WeeklyProgramServiceProvider
    {
        public static Border AddNewBorderedTextBlockToCanvas(Canvas originCanvas, string text, double top, double left, double width,
                                            double rightBorderThickness, double topBorderThickness, double leftBorderThickness, double bottomBorderThickness, double padding = 5,
                                            double fontsize = 13)
        {
            //Canvas FlowDir r to l


            Border border = new Border();
            border.BorderThickness = new Thickness(rightBorderThickness, topBorderThickness, leftBorderThickness, bottomBorderThickness);
            border.BorderBrush = Brushes.Black;


            Canvas.SetTop(border, top);
            Canvas.SetLeft(border, left);

            TextBlock txtBlock = new TextBlock();
            txtBlock.Padding = new Thickness(padding);


            txtBlock.FontSize = fontsize;
            txtBlock.Text = text;
            txtBlock.TextWrapping = TextWrapping.Wrap;
            txtBlock.HorizontalAlignment = HorizontalAlignment.Center;
            txtBlock.VerticalAlignment = VerticalAlignment.Center;
            txtBlock.Width = width - rightBorderThickness - leftBorderThickness;

            border.Child = txtBlock;

            originCanvas.Children.Add(border);

            return border;
        }

        public static Line AddNewHorizontalLineToCanvas(Canvas originCanvas, double thickness, double y, double width)
        {
            Line line = new Line();
            Thickness thickness1 = new Thickness(thickness);
            line.Margin = thickness1;
            line.Visibility = System.Windows.Visibility.Visible;
            line.StrokeThickness = 1;
            line.Stroke = System.Windows.Media.Brushes.Black;
            line.X1 = 0;
            line.X2 = width;
            line.Y1 = 0;
            line.Y2 = 0;

            Canvas.SetTop(line, y);
            Canvas.SetLeft(line, 0);
            originCanvas.Children.Add(line);

            return line;
        }

        public static Line AddNewVerticalLineToCanvas(Canvas originCanvas, double thickness, double x, double height)
        {
            Line line = new Line();
            Thickness thickness1 = new Thickness(thickness);
            line.Margin = thickness1;
            line.Visibility = System.Windows.Visibility.Visible;
            line.StrokeThickness = 1;
            line.Stroke = System.Windows.Media.Brushes.Black;
            line.X1 = 0;
            line.X2 = 0;
            line.Y1 = 0;
            line.Y2 = height;

            Canvas.SetTop(line, 0);
            Canvas.SetLeft(line, x);
            originCanvas.Children.Add(line);

            return line;
        }
    }
}
