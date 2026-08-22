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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace csharp_animatin_demo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AniGrid_Loaded(object sender, RoutedEventArgs e)
        {
            //创建动画对象并且设置它的起始位置和终止完整以及时长
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0.0d;
            anim.To = 1.0d;
            anim.Duration = TimeSpan.FromSeconds(3.0d);
            //调用Grid的BeginAnimation方法来开始动画
            AniGrid.BeginAnimation(Grid.OpacityProperty,anim); //第一个参数表示修改哪个属性的值，第二个参数表示使用那个动画对象

            //小测试，创建另外一个动画,修改Grid的颜色需要先设置背景属性的颜色画刷
            //然后我们其实是修改这个画刷的颜色
            ColorAnimation anim2 = new ColorAnimation();
            //anim2.From = Colors.Pink;
            anim2.To = Colors.Purple;
            anim2.Duration = TimeSpan.FromSeconds(3.0d);
            AniGrid.Background = new SolidColorBrush(Colors.White);
            AniGrid.Background.BeginAnimation(SolidColorBrush.ColorProperty, anim2);
        }

        private void AniGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            ColorAnimation anim2 = new ColorAnimation();
            //anim2.From = Colors.Pink;
            anim2.To = Colors.DeepPink;
            anim2.Duration = TimeSpan.FromSeconds(3.0d);
            AniGrid.Background = new SolidColorBrush(Colors.White);
            AniGrid.Background.BeginAnimation(SolidColorBrush.ColorProperty, anim2);
        }

        private void AniGrid_MouseLeave(object sender, MouseEventArgs e)
        {
            ColorAnimation anim2 = new ColorAnimation();
            anim2.To = Colors.Purple;
            anim2.Duration = TimeSpan.FromSeconds(3.0d);
            AniGrid.Background = new SolidColorBrush(Colors.White);
            AniGrid.Background.BeginAnimation(SolidColorBrush.ColorProperty, anim2);
        }
    }
}
