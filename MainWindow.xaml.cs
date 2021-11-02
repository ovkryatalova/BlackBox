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

namespace BlackBox
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
        private string TextChanger(string text)
        {
            string res = "0";
            foreach (var item in text)
            {
                if (char.IsDigit(item) || item ==',')
                    res += item;
            }
            return res;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {

            double x1_1 = Convert.ToDouble(TextChanger(TBx1_1.Text));
            double y1_1 = Convert.ToDouble(TextChanger(TBy1_1.Text));
            double z1_1 = Convert.ToDouble(TextChanger(TBz1_1.Text));
            double x2_1 = Convert.ToDouble(TextChanger(TBx2_1.Text));
            double y2_1 = Convert.ToDouble(TextChanger(TBy2_1.Text));
            double z2_1 = Convert.ToDouble(TextChanger(TBz2_1.Text));
            double x1_2 = Convert.ToDouble(TextChanger(TBx1_2.Text));
            double y1_2 = Convert.ToDouble(TextChanger(TBy1_2.Text));
            double z1_2 = Convert.ToDouble(TextChanger(TBz1_2.Text));
            double x2_2 = Convert.ToDouble(TextChanger(TBx2_2.Text));
            double y2_2 = Convert.ToDouble(TextChanger(TBy2_2.Text));
            double z2_2 = Convert.ToDouble(TextChanger(TBz2_2.Text));

            double l1 = x2_1 - x1_1;
            double m1 = y2_1 - y1_1;
            double n1 = z2_1 - z1_1;
            double l2 = x2_2 - x1_2;
            double m2 = y2_2 - y1_2;
            double n2 = z2_2 - z1_2;

            if (y1_1 == y2_1 && z1_1==z2_1)
            {
                LParallel_1.Content =  "Прямая параллельна оси х";
            }
            if (x1_1 == x2_1 && z1_1 == z2_1)
            {
                LParallel_1.Content = "Прямая параллельна оси y";
            }
            if (x1_1 == x2_1 && y1_1 == y2_1)
            {
                LParallel_1.Content = "Прямая параллельна оси z";
            }
            if (y1_2 == y2_2 && z1_2 == z2_2)
            {
                LParallel_2.Content = "Прямая параллельна оси х";
            }
            if (x1_2 == x2_2 && z1_2 == z2_2)
            {
                LParallel_2.Content =  "Прямая параллельна оси y";
            }
            if (x1_2 == x2_2 && y1_2 == y2_2)
            {
                LParallel_2.Content =  "Прямая параллельна оси z";
            }
            if (((x1_2-x1_1)*(m1*n2-n1*m2)+(y1_2 - y1_1)*(l1*n2-n1*l2) +(z1_2 - z1_1)*(l1*m2- m1*l2) ) == 0)
            {
                LFlat.Content = "Прямые лежат в одной плоскости";
            }
            else
            {
                LFlat.Content = "Прямые не лежат в одной плоскости";
            }

            double a1 = y2_1 - y1_1;
            double b1 = x2_1 - x1_1;
            double c1 = -x1_1 * y2_1 + y1_1 * x2_1;
            double a2 = y2_2 - y1_2;
            double b2 = x2_2 - x1_2;
            double c2 = -x1_2 * y2_2 + y1_2 * x2_2;
            if ((a1*b2-a2*b1)==0)
            {
                LParallel.Content = "Две прямые параллельны";
                LDot.Content = "Нет точек пересечения";
            }
            else LParallel.Content = "Две прямые НЕ параллельны";
            if (a1*b2==b1*a2 && a1*c2==a2*c1&&b1*c2==c1*b2)
            {
                LSame.Content = "Две прямые совпадают";
                LDot.Content ="Бесконечное количество точек пересечения";
            }
            else
            {
                LSame.Content = "Прямые не совпадают";
               Point p;
                p.X = (b1 * c2 - b2 * c1) / (a1 * b2 - a2 * b1);
                p.Y = (a2 * c1 - a1 * c2) / (a1 * b2 - a2 * b1);
                LDot.Content = "Прямые пересекаются в точке p (" + Convert.ToString(p.X) + "," + Convert.ToString(p.Y) + ")";
            }
            if ((a1*a2 + b1*b2)==0)
            {
                LPerp.Content = "Прямые перпендикулярны";
            }
            else
            {
                LPerp.Content = "Прямые не перпендикулярны";
            }
        }

        private void BTri_Click(object sender, RoutedEventArgs e)
        {
            new TriangleWindow().Show();
        }
    }
}
