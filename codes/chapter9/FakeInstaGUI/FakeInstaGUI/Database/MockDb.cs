using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace FakeInstaGUI.Database
{
    public class MockDb
    {
        //public static Uri GetPostVideo()
        //{
        //    return new Uri(Environment.CurrentDirectory + @"\..\..\Videos\dancingg.mp4",UriKind.RelativeOrAbsolute);
        //}
        public static Uri GetPostVideo()
        {
            //随机生成视频的Uri对象然后返回给视频元素的source
            List<string> vidPaths = Directory.GetFiles(Environment.CurrentDirectory + @"\..\..\Videos", "*.mp4").ToList();
            Random random = new Random(DateTime.Now.Millisecond);

            return new Uri(vidPaths[random.Next(vidPaths.Count)], UriKind.RelativeOrAbsolute);
        }

        public static BitmapImage GetPostPicture()
        {
            //我们用来做帖子的图片都是jpg格式的。
            List<string> picPaths = Directory.GetFiles(Environment.CurrentDirectory + @"\..\..\Icons","*.jpg").ToList();
            Random random = new Random(DateTime.Now.Millisecond);
            FileInfo rndFile = new FileInfo(picPaths[random.Next(picPaths.Count)]);//在图片链接列表里面随机获取一个路径
            return new BitmapImage(new Uri(rndFile.FullName,UriKind.RelativeOrAbsolute));
        }
    }
}
