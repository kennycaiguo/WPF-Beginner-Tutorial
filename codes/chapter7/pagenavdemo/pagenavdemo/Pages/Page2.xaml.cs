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

namespace pagenavdemo.Pages
{
    /// <summary>
    /// Page2.xaml 的交互逻辑
    /// </summary>
    public partial class Page2 : Page
    {
        //toPage1按钮的委托事件
        public delegate void OnToPage1BtnClick(object sender, RoutedEventArgs e);
        public event OnToPage1BtnClick ToPage1BtnClick;
        //toPage2按钮的委托事件
        public delegate void OnToPage3BtnClick(object sender, RoutedEventArgs e);
        public event OnToPage3BtnClick ToPage3BtnClick;
        public Page2()
        {
            InitializeComponent();
        }

        private void toPage1_Click(object sender, RoutedEventArgs e)
        {
            ToPage1BtnClick(sender, e);
        }

        private void toPage3_Click(object sender, RoutedEventArgs e)
        {
            ToPage3BtnClick(sender, e);
        }
    }
}
