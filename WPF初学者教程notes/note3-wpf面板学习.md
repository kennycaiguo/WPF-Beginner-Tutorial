# 1.面板介绍

面板就是容器，可以在里面放置ui控件或者其他面板



# 2.网格

## 为了方便我们的学习，我们新建一个WpfPanelsDemo项目，在这里学习各种面板

![image-20260726110538516](./note3-wpf面板学习.assets/image-20260726110538516.png)

## 2.1网格1

### 我们看到，当我们创建一个新的wpf项目，在窗口里面默认的面板就是Grid

![image-20260726110742023](./note3-wpf面板学习.assets/image-20260726110742023.png)

## 我们可以使用Grid.RowDefinitions设置网格元素的行数，通过Grid.ColumnDefinitions设置网格的列数，比如我们把它设置为2列



## 设置网格的列宽有n种方式，

### 第一种就是显式指定比如Width="200",

![image-20260726113540855](./note3-wpf面板学习.assets/image-20260726113540855.png)

### 第二种就是使用 n*,也就是按比例分配

![image-20260726113732044](./note3-wpf面板学习.assets/image-20260726113732044.png)

### 第三种，固定列宽+auto

![image-20260726114000361](./note3-wpf面板学习.assets/image-20260726114000361.png)

### 第四种，固定列宽+*

![image-20260726113941893](./note3-wpf面板学习.assets/image-20260726113941893.png)

### 第五种，auto+*

![image-20260726114030059](./note3-wpf面板学习.assets/image-20260726114030059.png)

#### ...总之，可以根据你的需要来配置，有一点需要注意，你设置所有列的列宽后，他们的总宽度不要超过父元素的宽度。

## 行的设置也是一样的道理，但是行只能够设置高度，而不是宽度，我们这里来设置2行

![image-20260726122410952](./note3-wpf面板学习.assets/image-20260726122410952.png)



## 2.2 网格2，跨行跨列的设置

### 把上面的网格改为3行4列，并且清空所有控件

![image-20260726123648510](./note3-wpf面板学习.assets/image-20260726123648510.png)

### 如果一个元素需要跨越多列，可以给他设置Grid.ColumnSpan属性，如果它还需要跨越多行，就可以设置Grid.RowSpan

![image-20260726124209081](./note3-wpf面板学习.assets/image-20260726124209081.png)

### 注意，网格其实非常灵活，我们可以随意构建我们需要的界面



# 3.堆叠面板StackPanel

## 把上面的代码注释了，我们来创建一个StackPanel

![image-20260726125856171](./note3-wpf面板学习.assets/image-20260726125856171.png)

## StackPanel的堆叠方向默认是垂直堆叠的，我们也可以把它设置为水平堆叠，需要修改Orientation="Horizontal"

![image-20260726130147280](./note3-wpf面板学习.assets/image-20260726130147280.png)

## StackPanel里面也可以嵌套StackPanel，比如我们把上面的堆叠面板的堆叠方向改为垂直，然后添加一个嵌套的StackPanel

![image-20260726132302025](./note3-wpf面板学习.assets/image-20260726132302025.png)

## 我们发现水平堆叠的StackPanel，他的元素没有居中显示，如果我们需要他们水平居中显示，可以设置StackPanel的水平对齐属性

![image-20260726132450446](./note3-wpf面板学习.assets/image-20260726132450446.png)

## 注意：stackpanel总是认为他里面的控件需要无限大的空间，一不小心就会出现宽度超出父元素的界面的情况。

## 当StackPanel的堆叠方向为垂直的时候，每一个控件的高度只是占用了它里面的子元素的高度，比如这里按钮的文本高度。同理，当StackPanel的堆叠方向为水平堆叠的时候，每一个控件的宽度只是占用了它里面的子元素的宽度，比如这里按钮的文本宽度，这意味着，你调整按钮的文本的字体大小，按钮的高度或者宽度就会发生相应的变化，也是说在堆叠面板中，子元素会获得他们想要的所有空间，有时候这并不是我们需要的。这是需要注意的另外一个地方。

![image-20260726135738401](./note3-wpf面板学习.assets/image-20260726135738401.png)

## 垂直堆叠的时候，默认元素的宽度是等于父元素的宽度的，此时如果我们给按钮设置了水平居中，按钮就会水平居中，此时宽度使用按钮文本的宽度

![image-20260726140942997](./note3-wpf面板学习.assets/image-20260726140942997.png)

## 垂直堆叠的时候，默认对齐方式是拉伸

![image-20260726141124568](./note3-wpf面板学习.assets/image-20260726141124568.png)

### 比如我们创建一个新按钮，不设置对齐方式，效果如下

![image-20260726141454054](./note3-wpf面板学习.assets/image-20260726141454054.png)

## 水平方向堆叠也是类似的道理，只不过此时需要调整的是VerticalAlignment，有Top，Bottom，Center和Stretch

![image-20260726141840604](./note3-wpf面板学习.assets/image-20260726141840604.png)

## 堆叠面板有时候如果有获得控件，需要结合滚动视图控件来使用

![image-20260726142328908](./note3-wpf面板学习.assets/image-20260726142328908.png)

# 4.环绕面板（也叫做换行面板）WrapPanel

## 把堆叠面板的内容注释了，我们创建一个WrapPanel，它默认的堆叠方式是一个接着一个，

![image-20260726142908875](./note3-wpf面板学习.assets/image-20260726142908875.png)

## 宽度放不下就会堆叠到下一行，以此类推

![image-20260726143105246](./note3-wpf面板学习.assets/image-20260726143105246.png)

## 如果你把一行中的一个元素的高度设置为100，那么这一行的所有元素的高度都是100

![image-20260726143319547](./note3-wpf面板学习.assets/image-20260726143319547.png)

## 如果运行程序，效果如下

![image-20260726143450885](./note3-wpf面板学习.assets/image-20260726143450885.png)

## 如果此时你把窗口的宽度拉宽，你会发现只要宽度放得下，下面的控件会往上移动而且高度和前面的控件一样

![image-20260726143629453](./note3-wpf面板学习.assets/image-20260726143629453.png)

## 如果此时你缩小窗口的宽度，放不下的控件会移动到下一行

![image-20260726143802882](./note3-wpf面板学习.assets/image-20260726143802882.png)

## WrapPanel元素可以设置元素的排列方向的。例如，设置他的方向为垂直方向

![image-20260726144049557](./note3-wpf面板学习.assets/image-20260726144049557.png)



# 5.停靠面板DockPanel

## 把WrapPanel的代码注释了，我们创建一个DockPanel

![image-20260726144432683](./note3-wpf面板学习.assets/image-20260726144432683.png)

## 把Window的宽高都调整为500

![image-20260726144656253](./note3-wpf面板学习.assets/image-20260726144656253.png)

## 我们给停靠面板添加一个按钮，它会占据所有位置

![image-20260726144839786](./note3-wpf面板学习.assets/image-20260726144839786.png)

## 然后我们再添加一个按钮，此时的界面效果有点奇怪，他的原理是第一个按钮由于没有设置宽度，默认使用按钮文本的宽度，剩余的都给了第二个按钮

![image-20260726145044610](./note3-wpf面板学习.assets/image-20260726145044610.png)

## 你可以给按钮添加一个附加属性：DockPanel.Dock,有4个选项

![image-20260726145302127](./note3-wpf面板学习.assets/image-20260726145302127.png)



## 比如，我们把它停靠在下面

![image-20260726145349249](./note3-wpf面板学习.assets/image-20260726145349249.png)

## 需要注意，如果DockPanel的一个方向上面只有一个元素，他会在这个方向上面填充整个宽度比如按钮2，如果你把它的停靠方向改为Right，其实是没有效果的，因为从水平方向看，就只有一个元素，

![image-20260726145643154](./note3-wpf面板学习.assets/image-20260726145643154.png)

## 为了方便观察，我们再添加3个按钮

![image-20260726150104310](./note3-wpf面板学习.assets/image-20260726150104310.png)

## 可以看到，最后一个按钮会居中，因为所有的边缘都给其他按钮占据了，而且按钮5会占据所有的剩余空间，当然不一定非得是按钮，可以是其他元素，比如图片等等

## 如果在同一个方向上面有多个元素，它会挤压中间区域的大小

![image-20260726151614495](./note3-wpf面板学习.assets/image-20260726151614495.png)

## DockPanel默认情况下是最后一个元素填充他的剩余空间，我们可以把它设置为False，属性名称叫做LastChildFill,此时它就会有一些多余的空间没有被占用

![image-20260726151907164](./note3-wpf面板学习.assets/image-20260726151907164.png)

## 注意，即使你把这个属性设置为False，如果这个子元素他的大小就需要这么多空间，它也会占用这些空间。

## 你也可以设置控件的大小，然后它就会占用你设置的大小的空间

![image-20260726152313441](./note3-wpf面板学习.assets/image-20260726152313441.png)

## 设置了高度后，即使你把宽度设置得很小，这个元素依然占据这么高的一整行

![image-20260726152513841](./note3-wpf面板学习.assets/image-20260726152513841.png)





# 6.画布Canvas

## 把DockPanel的代码注释了，创建一个Canvas元素

![image-20260726152928792](./note3-wpf面板学习.assets/image-20260726152928792.png)

## 我们在Canvas里面添加2个按钮，你会发现，你只看见一个，因为我们重叠在一起了。可见，在Canvas里面，元素默认不会占据整个空间，它只占据需要的空间，并且默认都是放在左上角的。所以有多个元素都没有指定位置的话，他们就会重叠在一起

![image-20260726153059498](./note3-wpf面板学习.assets/image-20260726153059498.png)

## 我们可以在控件里面配置距离Canvas的上下左右属性的多少个像素来定位元素

![image-20260726153601658](./note3-wpf面板学习.assets/image-20260726153601658.png)

## 定位可以组合使用，比如我们创建一个矩形把它放在Canvas的右下角，需要需要设置他到画布底部的距离和到画布右边的距离

![image-20260726154150752](./note3-wpf面板学习.assets/image-20260726154150752.png)

## 注意，在wpf中元素也是分层绘制的，你可以使用Panel.ZIndex来调整层级

![image-20260726154740160](./note3-wpf面板学习.assets/image-20260726154740160.png)

## 此外，Canvas有一个Opacity属性，可以设置它里面的元素的不透明度

![image-20260726155032510](./note3-wpf面板学习.assets/image-20260726155032510.png)



# 7.计算猫的年龄1

## 我们把前面学习的知识应用一下创建一个计算猫的年龄对应的人类年龄的案例：CatToHumanAge，界面非常简单

![image-20260726163313249](./note3-wpf面板学习.assets/image-20260726163313249.png)

## 我们需要给第一个文本框添加一个KeyDown事件，

![image-20260726163410772](./note3-wpf面板学习.assets/image-20260726163410772.png)

## 然后在后台实现我们的逻辑，后台代码如下

MainWindow.xaml.cs

```
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
```

## 运行效果

![image-20260726163630309](./note3-wpf面板学习.assets/image-20260726163630309.png)



![image-20260726163719077](./note3-wpf面板学习.assets/image-20260726163719077.png)

![image-20260726163745618](./note3-wpf面板学习.assets/image-20260726163745618.png)



![image-20260726163805689](./note3-wpf面板学习.assets/image-20260726163805689.png)

![image-20260726163825736](./note3-wpf面板学习.assets/image-20260726163825736.png)

# 8.计算猫的年龄2

## 其实是同一个项目，只是这里不使用xaml，使用纯csharp代码，创建一个CatToHumanAge2项目，注意，因为这里是使用纯c#代码来编程，xaml文件里面除了Window元素，什么都不能有，否则会抛异常

![image-20260726185047520](./note3-wpf面板学习.assets/image-20260726185047520.png)

## 用纯c#代码写的程序还是比较复杂，代码如下，需要创建2个文本框成员变量tbInput和tbOutput，然后在窗口的构造函数里面创建界面元素并且添加事件委托，再实现这个委托方法。MainWindow.xaml.cs的完整代码如下

```
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
```



### 运行程序，一切工作正常

![image-20260726190529505](./note3-wpf面板学习.assets/image-20260726190529505.png)

![image-20260726190550441](./note3-wpf面板学习.assets/image-20260726190550441.png)



![image-20260726190606927](./note3-wpf面板学习.assets/image-20260726190606927.png)

## 注意：年龄我们需要使用浮点数，因为它有可能不够1岁，老师使用整数是不对的，这样子你生日0.6就会进入catch里面的代码弹出错误消息框。所以学习需要动脑筋，不能一味照抄

## 下面是老师的部分代码，可以学习一些我不知道的语法

![image-20260726192423795](./note3-wpf面板学习.assets/image-20260726192423795.png)

![image-20260726191900853](./note3-wpf面板学习.assets/image-20260726191900853.png)

### 注意，除非有特殊情况，一般不用纯csharp代码来实现UI控件，效率太低也很复杂。

