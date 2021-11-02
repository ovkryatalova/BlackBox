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
using System.Windows.Shapes;

namespace BlackBox
{
    /// <summary>
    /// Логика взаимодействия для TriangleWindow.xaml
    /// </summary>
    public partial class TriangleWindow : Window
    {
        public TriangleWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;

            double.TryParse(TBa.Text, out a);
            double.TryParse(TBb.Text, out b);
            double.TryParse(TBc.Text, out c);
            /*if (TBa.Text != "" && TBb.Text != "" && TBc.Text != "")
            {
                a = Convert.ToDouble(TBa.Text.Trim(new char[] { ' ', '*' }));
                b = Convert.ToDouble(TBb.Text.Trim(new char[] { ' ', '*' }));
                c = Convert.ToDouble(TBc.Text.Trim(new char[] { ' ', '*' }));
            }*/
            string side = "разносторонним";
            string angle = "";
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && a == c && b == c)
                {
                    side = "равносторонним";
                }
                else
                {
                    if (a == b || a == c || b == c)
                    {
                        side = "равнобедренным";
                    }
                }
                if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                {
                    angle = " прямоугольным";
                }
                LType.Content = "Треугольник является " + side + angle;
            }
            else
                LType.Content = "Треугольник не существует";
        }
    }
}
