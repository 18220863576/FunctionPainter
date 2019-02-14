using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FunctionPainter
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //BitmapImage imageTemp = new BitmapImage(new Uri("\\zuobiao.png", UriKind.Relative));
            //Photo.Source = imageTemp;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            float valueK=0,valueB=0;
            if (float.TryParse(k.Text, System.Globalization.NumberStyles.Float, System.Globalization.NumberFormatInfo.InvariantInfo, out valueK) && float.TryParse(b.Text, System.Globalization.NumberStyles.Float, System.Globalization.NumberFormatInfo.InvariantInfo, out valueB) && valueK != 0)
            {
                line.X1 = 50;
                line.Y1 = (10.0 * valueK - valueB) * 35 + 400;
                line.X2 = 750;
                line.Y2 = (-10.0 * valueK - valueB) * 35 + 400;
            }
            else
            {
                MessageBox.Show("函数参数错误，请检查输入无误后再次绘制", "警告", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }
    }
}
