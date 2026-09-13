using FakeInstaGUI.Models;
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

namespace FakeInstaGUI.UserControls
{
    /// <summary>
    /// PicturePost.xaml 的交互逻辑
    /// </summary>
    public partial class PicturePost : UserControl
    {
        public PicturePost(PicturePostModel pm)
        {
            InitializeComponent();
            PicOfPost.Source = pm.PostImage;
        }

        private void ContentControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (!pCtrl.PostLiked)
            {
                pCtrl.LikePost();

            }
            else
            {
                pCtrl.UnLikePost();
            }

        }
    }
}
