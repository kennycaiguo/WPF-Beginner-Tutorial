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
    /// Page3.xaml 的交互逻辑
    /// </summary>
    public partial class Page3 : Page
    {
        //定义一个委托
        public delegate void OnNavBtnClick(object sender, RoutedEventArgs e);
        //定义一个事件,返回值是上面的委托的
        public event OnNavBtnClick NavBtnClick;

        public Page3()
        {
            InitializeComponent();
        }

        private void navBtn_Click(object sender, RoutedEventArgs e)
        {
            NavBtnClick(sender, e); //触发事件
        }
    }
}
