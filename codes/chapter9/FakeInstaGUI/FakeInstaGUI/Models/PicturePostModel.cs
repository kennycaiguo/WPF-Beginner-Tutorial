using FakeInstaGUI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace FakeInstaGUI.Models
{
    
    public class PicturePostModel
    {
         BitmapImage _postImage;
        public BitmapImage PostImage
        {
            get {
                if (_postImage == null)
                    return MockDb.GetPostPicture();
                else 
                    return _postImage;
            }
            set { 
                _postImage = value;
            }
        }
    }
}
