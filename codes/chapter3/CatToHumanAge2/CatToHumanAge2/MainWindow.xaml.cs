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

namespace CatToHumanAge2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TextBox tbInput = new TextBox();
        public TextBox tbOutput = new TextBox();
        public MainWindow()
        {
            InitializeComponent();
            this.Width = 250;
            this.Height = 100;
            StackPanel root = new StackPanel();
            StackPanel sp1 = new StackPanel();
            sp1.Orientation = Orientation.Horizontal;
            TextBlock tb1 = new TextBlock();
            tb1.Text = "Enter Cat Age:";
            sp1.Children.Add(tb1);
            tbInput.Width = 120;
            tbInput.Margin = new Thickness(15, 0, 0, 0);
            sp1.Children.Add(tbInput);
            sp1.Margin = new Thickness(10, 10, 0, 0);
            StackPanel sp2 = new StackPanel();
            sp2.Orientation = Orientation.Horizontal;
            TextBlock tb2 = new TextBlock();
            tb2.Text = "To Human Age:";
            sp2.Children.Add(tb2);
            tbOutput.Width = 120;
            tbOutput.Margin = new Thickness(7, 0, 0, 0);
            sp2.Children.Add(tbOutput);
            sp2.Margin = new Thickness(10, 10, 0, 0);
            root.Children.Add(sp1);
            root.Children.Add(sp2);

            this.AddChild(root);

            //给tbInput添加事件
            tbInput.KeyDown += tbInput_Keydown;
        }

        private void tbInput_Keydown(object sender, KeyEventArgs e)
        {
            //不要按任何按键都触发这个事件，我们设置只有按下回车，才触发这个事件
            if (e.Key == Key.Enter)
            {
                try
                {
                    //int catage = Convert.ToInt32(tbAgeInp.Text);
                    float catage = float.Parse(tbInput.Text);
                    string result = "";
                    //猫的年龄和人的年龄的换算关系,是一个复杂的对照表
                    if (catage > 0 && catage <= 1)
                    {
                        result = "0-15";
                    }
                    else if (catage >= 2 && catage < 25)
                    {
                        result = ((catage - 2) * 4 + 24).ToString();
                    }
                    else if (catage > 1 && catage < 25)
                    {
                        result = ((catage - 2) * 4 + 24).ToString();
                    }
                    else
                    {
                        result = "Invalid cat age!!!";
                    }

                    tbOutput.Text = result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter a number,not string!!!");
                    tbInput.Text = " ";
                    tbInput.Focus();
                }


            }

        }
    } 

}