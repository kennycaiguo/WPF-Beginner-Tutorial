using FakeInstaGUI.UserControls;
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

namespace FakeInstaGUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd; //声明一个随机数变量
        public MainWindow()
        {
            rnd = new Random(); //用这个变量来接收一个新的随机数类对象
            InitializeComponent();
            MainStackPanel.Children.Add(new VideoPost(new Models.VideoPostModel()));
            MainStackPanel.Children.Add(new PicturePost(new Models.PicturePostModel()));
            MainStackPanel.Children.Add(new VideoPost(new Models.VideoPostModel()));
            MainStackPanel.Children.Add(new PicturePost(new Models.PicturePostModel()));
        }

        private void MainScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
           
            if (e.VerticalChange > 0)
            {
                int adjustment = 400;
                if(e.VerticalOffset + e.ViewportHeight +  adjustment >= e.ExtentHeight) //当我们滚动的足够远，就需要创建新的帖子
                {
                    for (int i = 0; i < 5; i++)
                    {
                        //用随机数来角色创建图片帖子还是视频帖子
                        if (rnd.Next(0, 100) % 5 == 0)
                        {   //如果是5的倍数，就创建视频帖子
                            MainStackPanel.Children.Add(new VideoPost(new Models.VideoPostModel()));
                        } else
                        {
                            //否则创建图片帖子
                            MainStackPanel.Children.Add(new PicturePost(new Models.PicturePostModel()));
                        }
                        
                    }
                }
            }
        }
    }
}
