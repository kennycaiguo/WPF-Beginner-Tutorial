using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfSimpleFileDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //获取特殊文件夹
            //ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //直接指定路径
            //ofd.InitialDirectory = @"d:\";
            //获取当源码前文件夹，需要先获取exe文件所在的路径，然后往上退3次
            ofd.InitialDirectory =System.IO.Path.GetFullPath(Environment.CurrentDirectory + @"/../../..");
            ofd.Filter = "Text File(*.txt)|*.txt|所有文件(*.*)|*.*|Xaml File(*.xaml)|*.xaml|CSharp File(*.cs)|*.cs";
            if (ofd.ShowDialog() == true) {
                string filename = ofd.FileName;
                if (filename != string.Empty)
                {
                    this.Title = filename;
                    tb.Text = File.ReadAllText(filename);
                }
                
            }
            else
            {
                MessageBox.Show("User Aborted..."); //用户打开了文件夹对话框，但是没有选择文件
            }

        }

        private void MenuSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();  
            sfd.InitialDirectory = System.IO.Path.GetFullPath(Environment.CurrentDirectory + @"/../../..");
            sfd.Filter = "Text File(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (tb.Text != string.Empty)
            {
                if (sfd.ShowDialog() == true)
                {
                    string filename = sfd.FileName;
                    File.WriteAllText(filename, tb.Text);
                    this.Title = filename;
                }
                else
                {
                    MessageBox.Show("User Aborted..."); //用户打开了文件夹对话框，但是没有选择文件
                }
            }
            else
            {
                //没有内容不要弹出对话框，弹出消息框提示用户输入内容
                MessageBox.Show("No Content,Please Enter Content First...");
                tb.Focus();
            }
        }
    }
}