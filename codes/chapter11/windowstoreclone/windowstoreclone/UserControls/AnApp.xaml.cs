using MiscUtil;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

namespace windowstoreclone.UserControls
{
    /// <summary>
    /// AnApp.xaml 的交互逻辑
    /// </summary>
    public partial class AnApp : UserControl
    {
        public string AppName;
        public ImageSource AppImageSource;
        public AnApp()
        {
            InitializeComponent();
            //获取文件的链接列表
            List<string> filePaths = Directory.GetFiles(Environment.CurrentDirectory + @"\..\..\Images","*.png").ToList<string>();
            //随机选取一个路径创建一个FileInfo对象
            FileInfo rndFile = new FileInfo(filePaths[StaticRandom.Next(filePaths.Count)]);
            //为我们的ProductImage元素设置源图片
            ProductImage.Source = new BitmapImage(new Uri(rndFile.FullName,UriKind.RelativeOrAbsolute));
            //修改AppNameText文本块的文本为当前图片的文件名
            //AppNameText.Text = rndFile.Name;
            AppNameText.Text = (new CultureInfo("en-US", false).TextInfo).ToTitleCase(rndFile.FullName.Split('\\').Last().Split('-').Last().Split('.').First());
            //保存应用程序名称和源图片的路径
            AppName = AppNameText.Text.ToString();
            AppImageSource = ProductImage.Source;
        }

        private void ProductImage_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

    }
}
