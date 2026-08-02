using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace wfpchapter2_controls
{
    
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> toppings = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            ////txtBlock.Foreground=new SolidColorBrush(Colors.Black);
            //txtBlock.Foreground=Brushes.BlueViolet; //有现存可用的画刷
            //txtBlock.Text = "Hello from Code Behind!!!";
            //CreateTxtBlock();
           
        }

        private void CreateTxtBlock()
        {
            TextBlock block = new TextBlock();
            block.Text = "你好我好大家好，我是c#创建的TextBlock";
            block.Foreground = Brushes.BlueViolet;
            block.FontSize = 17;
            //设置文本自动换行
            block.TextWrapping = TextWrapping.Wrap;
            //往TextBlock里面添加内容
            block.Inlines.Add("\n好好学习，天天向上");
            block.Inlines.Add(new Run("\n这是用Run添加的文本")
            {
                Foreground = Brushes.DeepPink,
                FontSize = 24,
                FontWeight = FontWeights.Bold,
                TextDecorations = TextDecorations.Underline,
            });
            this.Content = block;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("按钮被点击了");
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = Brushes.AliceBlue;
            btn.FontWeight = FontWeights.Bold;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = Brushes.White;
            btn.FontWeight = FontWeights.Normal;
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am  expanded,now you are going to see everything");
        }

        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am collapsing,this will hide everything");
        }

        //private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    DatePicker dp = (DatePicker)sender;
        //    this.Title = dp.SelectedDate.ToString();
        //}

        //private void MyCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    DateTxt.Text = MyCalendar.SelectedDate.ToString();
        //}



        //private void my_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    //if (txtBox != null)
        //    //{
        //    //    if (my_Slider.Value > 0)
        //    //    {
        //    //        txtBox.FontSize = my_Slider.Value;
        //    //    }

        //    //    txtBox.Text = my_Slider.Value.ToString();
        //    //}


        //}

        //图片控件
        //private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    ImgBox.Source = new BitmapImage(
        //        new Uri(@"/Images/3.jpg",UriKind.Relative));
        //}

        //密码框案例的模拟登录功能
        //private void btnLogin_Click(object sender, RoutedEventArgs e)
        //{
        //    //获取PasswordBox的内容，需要获取他的Password属性
        //    // MessageBox.Show(passBox.Password.ToString());
        //    if (userName.Text == "Boss" && passBox.Password == "12345")
        //    {
        //        MessageBox.Show("登录成功");
        //    }
        //    else
        //    {
        //        MessageBox.Show("用户名或者密码错误！！");
        //    }
        //}

        //private void cbCheese_CheckedChanged(object sender, RoutedEventArgs e)
        //{
        //    if (cbCheese.IsChecked == true) {
        //        toppings.Add(tb_cheese.Text);

        //    }else if(cbCheese.IsChecked == false)
        //    {
        //        toppings.Remove(tb_cheese.Text);
        //    }
        //    lbl_toppings.Content = string.Join(",", toppings);
        //}



        //private void cbTuna_CheckedChanged(object sender, RoutedEventArgs e)
        //{
        //    if(cbTuna.IsChecked == true)
        //      toppings.Add(tb_tuna.Text);
        //    else if(cbTuna.IsChecked == false)
        //      toppings.Remove(tb_tuna.Text);
        //    lbl_toppings.Content = string.Join(",", toppings);
        //}


        //private void cbHam_CheckedChanged(object sender, RoutedEventArgs e)
        //{
        //    if (cbHam.IsChecked == true)
        //        toppings.Add(tb_ham.Text);
        //    else if (cbHam.IsChecked == false)
        //        toppings.Remove(tb_ham.Text);
        //    lbl_toppings.Content = string.Join(",", toppings);
        //}


        //private void cbPepp_CheckedChanged(object sender, RoutedEventArgs e)
        //{
        //    if(cbPepp.IsChecked == true)
        //        toppings.Add(tb_pepp.Text);
        //    else if (cbPepp.IsChecked == false)
        //        toppings.Remove(tb_pepp.Text);
        //    lbl_toppings.Content = string.Join(",", toppings);
        //}

        //private void cbToppingsCheckChanged(object sender, RoutedEventArgs e) 
        //{
        //    cbParent.IsChecked = null; //既不是true也不是false的状态是一个黑色方块
        //    if (cbCheese.IsChecked == true)
        //    {
        //        if(!toppings.Contains(tb_cheese.Text))
        //            toppings.Add(tb_cheese.Text);

        //    }
        //    else if (cbCheese.IsChecked == false)
        //    {
        //        toppings.Remove(tb_cheese.Text);
        //    }

        //    if (cbTuna.IsChecked == true)
        //    {
        //        if (!toppings.Contains(tb_tuna.Text))
        //            toppings.Add(tb_tuna.Text);
        //    }  
        //    else if (cbTuna.IsChecked == false)
        //        toppings.Remove(tb_tuna.Text);

        //    if (cbHam.IsChecked == true)
        //    {
        //       if (!toppings.Contains(tb_ham.Text))
        //            toppings.Add(tb_ham.Text);
        //    }    
        //    else if (cbHam.IsChecked == false)
        //        toppings.Remove(tb_ham.Text);

        //    if (cbPepp.IsChecked == true)
        //    {
        //        if (!toppings.Contains(tb_pepp.Text))
        //            toppings.Add(tb_pepp.Text);
        //    }

        //    else if (cbPepp.IsChecked == false)
        //        toppings.Remove(tb_pepp.Text);
        //    lbl_toppings.Content = string.Join(",", toppings);
        //    //如果所有是自复选框都被选中，父亲复选框也需要变为选中状态
        //    if(cbCheese.IsChecked == true && cbHam.IsChecked==true && cbTuna.IsChecked==true && cbPepp.IsChecked==true)
        //    {
        //        cbParent.IsChecked = true;
        //    }
        //    //如果所有是自复选框都被取消选中，父亲复选框也需要变为取消选中状态
        //    if (cbCheese.IsChecked == false && cbHam.IsChecked == false && cbTuna.IsChecked == false && cbPepp.IsChecked == false)
        //    {
        //        cbParent.IsChecked = false;
        //    }
        //}
        //private void cbParentChackStateChanged(object sender, RoutedEventArgs e) 
        //{
        //    //获取父亲复选框的状态，然后赋值给所有自复选框,这样子，只要勾选了父亲复选框。所有自复选框都会勾选上，
        //    //只要取消勾选父亲复选框，所有的自复选框都会取消选中
        //    bool newVal = (cbParent.IsChecked == true);
        //    cbCheese.IsChecked = newVal;
        //    cbHam.IsChecked = newVal;
        //    cbTuna.IsChecked = newVal;
        //    cbPepp.IsChecked = newVal;
        //}
    }
    
}
