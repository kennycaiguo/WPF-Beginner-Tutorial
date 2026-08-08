using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace no_odp_databinding
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //创建一个整数类型的可观察集合
        public ObservableCollection<int> AvailableNumbers { get; set; }
        public MainWindow()
        {
            AvailableNumbers = new ObservableCollection<int>();
            int counter = 0;
            for (int i = 0; i < 10; i++) { 
                AvailableNumbers.Add(counter++); //注意，这里需要使用Add方法而不是Append方法，否则没有数据
            }
            //DataContext = this;
            InitializeComponent();
            //MessageBox.Show(AvailableNumbers.Count.ToString());
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AvailableNumbers.Add((int)AvailableNumbers.Count); //注意：ObservableCollection添加数据用Add方法
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            AvailableNumbers.RemoveAt(AvailableNumbers.Count-1); //每一次点击删除按钮，就删除第一个
        }
    }
}
