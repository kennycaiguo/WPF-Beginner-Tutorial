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

namespace LinqDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public int[] Nums = { 5, 4, 3, 2, 1, 8, 7, 9, 6 };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void listDmo_Click(object sender, RoutedEventArgs e)
        {
            int[] scores = {90,71,82,93,75,83 };
            string res = "";
            IEnumerable<int> results = from score in scores where score > 80 orderby score descending select score;

            foreach (int r in results) 
            { 
                res += r+"\r\n";
            }
            MessageBox.Show(res);
        }

        private void listDmo2_Click(object sender, RoutedEventArgs e)
        {
            int[] scores = { 90, 71, 82, 93, 75, 83 };
            string res = "";
            IEnumerable<int> results = scores.Where(s => s>80).OrderBy(s => -s);

            foreach (int r in results)
            {
                res += r + "\r\n";
            }
            MessageBox.Show(res);
        }

        private void oddBtn_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<int> results = Nums.Where(s => s % 2 != 0).OrderBy(s => -s);

            int[] arrRes = results.ToArray(); //把查询结果转化为数组
            tbDisp.Text = string.Join(",", arrRes); //利用string对象的Join方法用一个逗号把数组连接成为一个字符串
        }

        private void evenBtn_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<int> results = Nums.Where(s => s % 2 == 0).OrderBy(s => -s);

            int[] arrRes = results.ToArray();
            tbDisp.Text = string.Join(",",arrRes);
        }

        private void revmBtn_Click(object sender, RoutedEventArgs e)
        {
            tbDisp.Text = string.Join(",",Nums);
        }

        private void btnAsc_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<int> results = Nums.OrderBy(s => s);

            int[] arrRes = results.ToArray();
            tbDisp.Text = string.Join(",", arrRes);
        }

        private void btnDsc_Click(object sender, RoutedEventArgs e)
        {
            //IEnumerable<int> results = Nums.OrderBy(s => -s); //排序只需要OrderBy就行了，不需要Where，-s表示降序排列
            IEnumerable<int> results = Nums.OrderByDescending(s => s); //降序排列也可以使用OrderByDescending，此时如果使用-s，它又会是升序排列

            int[] arrRes = results.ToArray();
            tbDisp.Text = string.Join(",", arrRes);
        }
    }
}
