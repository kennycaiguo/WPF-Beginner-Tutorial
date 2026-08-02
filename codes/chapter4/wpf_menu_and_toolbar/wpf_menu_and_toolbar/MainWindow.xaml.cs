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

namespace wpf_menu_and_toolbar
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

        private void Menu_New_Project_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New Project MenuItem Clicked...");
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length > 0) {
                tb.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("No Text To Clear!!!");
            }
            
        }

        private void CbFont_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox? cb = (ComboBox)sender;
            ComboBoxItem? cbItem = cb.SelectedItem as ComboBoxItem;
            string newSizeStr = (string)cbItem!.Content; //cbItem后面的!是断言这个变量有值，如果变量的值为空，程序会崩溃
            int newSize;
            if (Int32.TryParse(newSizeStr, out newSize))
            {
                if (tb != null)
                {
                    tb.FontSize = newSize;
                }
            }
        }

      

        //private void MenuItalic_Click(object sender, RoutedEventArgs e)
        //{
        //    tb.FontStyle = FontStyles.Italic;
        //}

        private void MenuBold_Checked(object sender, RoutedEventArgs e)
        {
            tb.FontWeight = FontWeights.Bold; //设置粗体
        }

        private void MenuBold_Unchecked(object sender, RoutedEventArgs e)
        {
            tb.FontWeight = FontWeights.Normal;
        }

        private void MenuItalic_Checked(object sender, RoutedEventArgs e)
        {
            tb.FontStyle = FontStyles.Italic;
        }

        private void MenuItalic_Unchecked(object sender, RoutedEventArgs e)
        {
            tb.FontStyle = FontStyles.Normal;
        }
    }
}