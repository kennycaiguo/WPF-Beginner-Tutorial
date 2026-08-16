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
using static DelegateEventDemo.VisualUC;

namespace DelegateEventDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            valueCtrl.MinThresholdReached += ValueCtrl_MinThresholdReached;
            valueCtrl.MaxThresholdReached += ValueCtrl_MaxThresholdReached;
        }

        private void ValueCtrl_MaxThresholdReached(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reached The Maximun Value"); ;
        }

        private void ValueCtrl_MinThresholdReached(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reached The Minimun Value");
        }
    }
}
