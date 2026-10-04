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

namespace windowstoreclone.UserControls
{
    /// <summary>
    /// AppsViewer.xaml 的交互逻辑
    /// </summary>
    public partial class AppsViewer : UserControl
    {
        List<AnApp> PresentedApps;

        public AppsViewer()
        {
            InitializeComponent();
            //创建一个列表并且赋值给
            PresentedApps = new List<AnApp>();
            AppList.ItemsSource = PresentedApps;
            //创建9个条目
            for (int i = 0; i < 9; i++)
            {
                AnApp app = new AnApp();
                PresentedApps.Add(app);
            }
        }

        private void LeftBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RightBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
