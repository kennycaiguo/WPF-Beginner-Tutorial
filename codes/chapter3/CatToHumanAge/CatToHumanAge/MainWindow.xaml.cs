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

namespace CatToHumanAge
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

        private void tbAgeInp_KeyDown(object sender, KeyEventArgs e)
        {
            //不要按任何按键都触发这个事件，我们设置只有按下回车，才触发这个事件
            if (e.Key == Key.Enter) {
                try
                {
                    //int catage = Convert.ToInt32(tbAgeInp.Text);
                    float catage = float.Parse(tbAgeInp.Text);
                    string result = "";
                    //猫的年龄和人的年龄的换算关系,是一个复杂的对照表
                    if (catage > 0 && catage<=1) {
                        result = "0-15";
                    }else if (catage >= 2 && catage < 25)
                    {
                        result =((catage - 2) * 4 + 24).ToString();
                    }
                    else if (catage > 1 && catage < 25)
                    {
                        result = ((catage - 2) * 4 + 24).ToString();
                    } else
                    {
                        result = "Invalid cat age!!!";
                    }

                    tbAgeOpt.Text = result;
                }
                catch (Exception ex) {
                    MessageBox.Show("Please Enter a number,not string!!!");
                    tbAgeInp.Text = " ";
                    tbAgeInp.Focus();
                }
                

            }

        }
    }
}