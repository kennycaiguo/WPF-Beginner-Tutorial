using System;
using System.Speech.Synthesis;
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

namespace text_to_speech
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private SpeechSynthesizer synthesizer;
        public MainWindow()
        {
            InitializeComponent();
            synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100; //设置音量,0-100超出范围程序会崩溃
            synthesizer.Rate = 0; //语速，取值范围是-10 到10之间


        }

        private void btnSp_Click(object sender, RoutedEventArgs e)
        {
            if (tbMain.Text == string.Empty) 
            {
                MessageBox.Show("Please Enter Text!!!");
                tbMain.Focus();
            }
            synthesizer.Speak(tbMain.Text);
        }
    }
}
