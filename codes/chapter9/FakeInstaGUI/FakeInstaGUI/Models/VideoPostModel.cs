using FakeInstaGUI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeInstaGUI.Models
{
    public class VideoPostModel
    {
        public Uri _videoPlayerSource;

        public Uri VideoPlayerSource
        {
            get {
                if (_videoPlayerSource == null)
                    return MockDb.GetPostVideo(); //如果视频的地址为空，我们就从数据库获取
                else
                    return _videoPlayerSource; //否则就直接返回现有的视频地址
            }
            set { _videoPlayerSource = value; }
        }
    }
}
