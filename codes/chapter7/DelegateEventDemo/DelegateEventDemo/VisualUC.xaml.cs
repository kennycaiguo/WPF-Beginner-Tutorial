using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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

namespace DelegateEventDemo
{
    /// <summary>
    /// VisualUC.xaml 的交互逻辑
    /// </summary>
    public partial class VisualUC : UserControl
    {
        //定义到达最小门槛委托
        public delegate void OnMinThresholdReached(object sender,RoutedEventArgs e);
        //定义到达最小门槛事件
        public event OnMinThresholdReached MinThresholdReached;
        //定义到达最大门槛委托
        public delegate void OnMaxThresholdReached(object sender,RoutedEventArgs e);
        //定义到达最大门槛事件
        public event OnMaxThresholdReached MaxThresholdReached;



        public VisualUC()
        {
            InitializeComponent();
        }

        private void btnAdd10_Click(object sender, RoutedEventArgs e)
        {
            tbVal.Text = (Int32.Parse(tbVal.Text)+10).ToString();

        }

        private void btnSub10_Click(object sender, RoutedEventArgs e)
        {
            tbVal.Text = (Int32.Parse(tbVal.Text) - 10).ToString();
        }

        private void tbVal_TextChanged(object sender, TextChangedEventArgs e)
        {
            //int value = Int32.Parse(tbVal.Text);
            //if (value >= 100)
            //{
            //    MessageBox.Show("Reached The Maximum Value");
            //    tbVal.Text = "100";
            //} 
            //if (value < 0)
            //{
            //    MessageBox.Show("Reached The Minimum Value");
            //    tbVal.Text = "0";
            //}

            if (Int32.Parse(tbVal.Text) < 0)
            {
                tbVal.Text = "0";
                MinThresholdReached(sender, e);
            }
            if (Int32.Parse(tbVal.Text) > 100)
            {
                tbVal.Text = "100";
                MaxThresholdReached(sender, e);
            }

        }
    }
}
