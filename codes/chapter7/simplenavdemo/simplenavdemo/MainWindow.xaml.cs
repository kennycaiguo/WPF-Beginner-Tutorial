using simplenavdemo.Pages;
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

namespace simplenavdemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public Page1 FirstPage;
        public Page2 SecondPage;
        public Page3 ThirdPage;
        public MainWindow()
        {
            InitializeComponent();
            FirstPage = new Page1();
            SecondPage = new Page2();
            ThirdPage = new Page3();
            MainFrame.Content = FirstPage; //设置默认页面
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
           MainFrame.Content = FirstPage;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = SecondPage; 
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.NavigationService.CanGoBack) 
            {
                MainFrame.NavigationService.GoBack();
            }
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.NavigationService.CanGoForward)
            {
                MainFrame.NavigationService.GoForward();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = ThirdPage;
        }
    }
}
