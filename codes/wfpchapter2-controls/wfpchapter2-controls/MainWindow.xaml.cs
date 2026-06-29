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
    }
    
}
