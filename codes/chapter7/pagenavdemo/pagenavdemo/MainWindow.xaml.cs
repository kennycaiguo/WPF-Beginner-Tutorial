using pagenavdemo.Pages;
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

namespace pagenavdemo
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
            SecondPage.ToPage1BtnClick += btn1_Click;
            SecondPage.ToPage3BtnClick += btn3_Click;

            ThirdPage = new Page3();
            //ThirdPage.NavBtnClick += Page3NavBtnClick;  //需要把我们在这里定义的事件处理函数用+=赋值给Page3的后台代码里面设置的事件对象
            //当然，如果这里以及有能够处理这个事件的函数，我们就直接进行赋值即可
            ThirdPage.NavBtnClick += btn1_Click;
            MainFrame.Content = FirstPage; //设置默认页面
        }

        private void Page3NavBtnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = FirstPage;
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
