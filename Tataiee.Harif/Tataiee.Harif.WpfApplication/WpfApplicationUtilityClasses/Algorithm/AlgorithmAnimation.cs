using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Tataiee.Harif.WpfApplication.WpfApplicationUtilityClasses.Algorithm
{

    public class AnimateStatusObjectModel
    {
        public bool? Succ { get; set; }
    }
    internal static class AlgorithmAnimation
    {
        internal static async Task Animate(this UserControl uc, Canvas canvas, int animStatus, AnimateStatusObjectModel succ)
        {

            int algorithmMaxProcessingTime = Properties.Settings.Default.AlgorithmMaxProcessingTimeMS + 1000;

            canvas.Children.Clear();
            PackIcon icon = new PackIcon() { Kind = PackIconKind.Walk, Height = 36, Width = 36 };
            canvas.Children.Add(icon);

            icon.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
            icon.Arrange(new Rect(icon.DesiredSize));

            double iconH = icon.ActualHeight;
            double inocW = icon.ActualWidth;

            canvas.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
            canvas.Arrange(new Rect(canvas.DesiredSize));

            double canvasH = canvas.ActualHeight;
            double canvasW = canvas.ActualWidth;

            Canvas.SetTop(icon, canvasH - iconH);
            Canvas.SetLeft(icon, 0);

            int time = 0;
            await Task.Run(() =>
            {
                if (animStatus != 1 && animStatus != 0)//2 disable
                {
                    return;
                }

                int x = 0;
                while (true)
                {
                    if (succ.Succ.HasValue) break;

                    if (animStatus == 0 && canvasW - 40 <= x * 5)
                    {
                        x = 0;
                    }

                    uc.Dispatcher.Invoke(() =>
                    {
                        icon.Kind = PackIconKind.Run == icon.Kind ? PackIconKind.Walk : PackIconKind.Run;
                        Canvas.SetLeft(icon, 0 + x * 5);
                    });
                    x++;


                    System.Threading.Thread.Sleep(100);
                    time += 100;
                    if (time >= algorithmMaxProcessingTime)
                        break;
                }
            });

            if (animStatus != 1 && animStatus != 0)//2 disable
            {
                canvas.Children.Remove(icon);
                return;
            }
            else
            {
                Canvas.SetLeft(icon, canvasW / 2 - 30);
                if (succ.Succ.HasValue && succ.Succ.Value)
                {

                    icon.Kind = PackIconKind.CheckboxMarkedCircleOutline;
                }
                else
                {
                    icon.Kind = PackIconKind.EmoticonDead;
                }
            }

        }
    }
}
