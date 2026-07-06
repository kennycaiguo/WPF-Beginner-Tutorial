# 1.内容提要

## 我们新建一个wfpchapter2-controls项目，利用他来学习下面的这些控件

![image-20260628143042175](./note2-wpf控件.assets/image-20260628143042175.png)

# 2.xaml中的TextBlock

## 2.1打开上面的项目，最简单的TextBlock定义如下

![image-20260628144743308](./note2-wpf控件.assets/image-20260628144743308.png)

## 2.2可以给文本添加一下样式标签，比如bold和underline

![image-20260628150408537](./note2-wpf控件.assets/image-20260628150408537.png)

## 2.3还可以添加换行符LineBreak

![image-20260628150702543](./note2-wpf控件.assets/image-20260628150702543.png)

## 2.4还可以添加超链接，注意需要设置NavigateUri属性和RequestNavigate事件

![image-20260628152418860](./note2-wpf控件.assets/image-20260628152418860.png)



## 然后我们需要在后台cs文件中添加Hyperlink_RequestNavigate函数的事件处理代码

![image-20260628152809531](./note2-wpf控件.assets/image-20260628152809531.png)

## 2.5TextBlock的一些属性的使用，我们可以添加一段长文本，默认是没有自动换行的。

![image-20260628153851430](./note2-wpf控件.assets/image-20260628153851430.png)

## 我们可以给TextBlock设置TextWrapping属性来让他换行还有一个WrapWithOverflow选项不太好。用Wrap好一点

![image-20260628154122187](./note2-wpf控件.assets/image-20260628154122187.png)

### 还可以修改文本的前景色和背景色

![image-20260628154717786](./note2-wpf控件.assets/image-20260628154717786.png)

## 2.6如果你只需要修改某一些文本的颜色，你可以在文本里面使用Span标签

![image-20260628155100566](./note2-wpf控件.assets/image-20260628155100566.png)

# 3.xaml.cs中的TextBlock

## 3.1打开上面的项目，我们给第二个文本块起一个名字比如txtBlock

![image-20260628160151811](./note2-wpf控件.assets/image-20260628160151811.png)

## 3.2然后我们可以在cs代码里面获取这个文本块然后修改他的属性

![image-20260628160851357](./note2-wpf控件.assets/image-20260628160851357.png)

### 运行程序，你会发现，文本块2的内容和颜色都改变了

![image-20260628160949863](./note2-wpf控件.assets/image-20260628160949863.png)

##  3.3我们也可以把xaml里面的文本块代码注释了，然后在后台生成文本块

![image-20260628161138453](./note2-wpf控件.assets/image-20260628161138453.png)

![image-20260628162421758](./note2-wpf控件.assets/image-20260628162421758.png)

### 效果

![image-20260628162955900](./note2-wpf控件.assets/image-20260628162955900.png)

## 3.4这样子添加的文本无法改变样式，如果你需要添加可以设置样式的文本，你需要使用Run，语法有点奇怪，但是挺好用

![image-20260628163652833](./note2-wpf控件.assets/image-20260628163652833.png)

### 效果

![image-20260628163734308](./note2-wpf控件.assets/image-20260628163734308.png)

## 3.5为了方便我们的学习，我把它封装为一个函数

![image-20260628164214771](./note2-wpf控件.assets/image-20260628164214771.png)

# 4.Label控件

## 4.1还是上面的项目，我们把前面的代码注释了，然后提交一个Label控件，注意Label控件没有Text属性，它有Content属性，说明他是内容控件，我们先给项目添加一个Images文件夹，在里面放3张图片

![image-20260628164735290](./note2-wpf控件.assets/image-20260628164735290.png)

## 4.2然后我们在Label里面放置一个StackPanel控件，在里面放置3张图片，然后可以新建一个Label控件，由于Label控件的内容控件，它里面可以放置很多内容，可以使用2个嵌套的StackPanel

![image-20260628171214468](./note2-wpf控件.assets/image-20260628171214468.png)

### 运行程序，效果如下，可以看到，TextBlock里面只能够放文本，标签里面可以放任意控件

![image-20260628171232417](./note2-wpf控件.assets/image-20260628171232417.png)



### 可以看到，使用标签可以生成图文并茂的内容，此外，标签里面也可以使用内容模板



# 5.TextBox

## 1.继续使用controls项目，我们把标签的内容注释了，然后添加一个文本框,你可以设置他的很多属性，比如状态大小，间距等等，其中有一个AcceptsReturn属性，默认是False也就是说，默认文本框不支持多行文本，我们把它设置为True（在xaml中布尔值首字母大写），它就支持多行文本

![image-20260704101208368](./note2-wpf控件.assets/image-20260704101208368.png)

![image-20260704101335058](./note2-wpf控件.assets/image-20260704101335058.png)

### 需要注意，设置了可以多行输入后，还需要设置 TextWrapping="Wrap"确保文本能够自动换行

![image-20260704101527653](./note2-wpf控件.assets/image-20260704101527653.png)



## 2.文本框有一个比较使用的功能就是拼写检查，它有3个选项

![image-20260704101938465](./note2-wpf控件.assets/image-20260704101938465.png)

## 3.我们只需要设置他的IsEnabled="True",就可以开启拼写检查，但是我们必须指定语言

![image-20260704102713545](./note2-wpf控件.assets/image-20260704102713545.png)

### 也许是.net8有问题，开启了也没有效果

## 4.还有其他属性，以及一些事件，我们以后还会学习到

![image-20260704112732673](./note2-wpf控件.assets/image-20260704112732673.png)



# 6.按钮

## 在wpf中，按钮是内容控件，它可以添加非常复杂的内容，也可以在里面添加面板，图片，其他控件等等，我们还可以给他添加点击事件处理函数

![image-20260705115321753](./note2-wpf控件.assets/image-20260705115321753.png)

## 我们在后台代码里面添加对Button_Click函数的处理代码，这里只是弹出一个消息框，说按钮被点击了

![image-20260705115446919](./note2-wpf控件.assets/image-20260705115446919.png)

### 效果

![image-20260705115520918](./note2-wpf控件.assets/image-20260705115520918.png)





## 按钮除了点击事件，还有很多事件，我们这里来学习一些MouseEnter和MouseLeave事件，他们组合起来使用，就可以实现类似于css的hover效果我们先在xamlm 添加这两个数据的处理函数

![image-20260705120900790](./note2-wpf控件.assets/image-20260705120900790.png)



## 然后我们在后台代码里面实现他们的功能

![image-20260705120945671](./note2-wpf控件.assets/image-20260705120945671.png)

### 效果

![image-20260705121025536](./note2-wpf控件.assets/image-20260705121025536.png)





![image-20260705121053227](./note2-wpf控件.assets/image-20260705121053227.png)

## 也可以给按钮添加提示文本

![image-20260705121350355](./note2-wpf控件.assets/image-20260705121350355.png)

### 效果

![image-20260705122734375](./note2-wpf控件.assets/image-20260705122734375.png)



# 7.复选框

## 还是controls项目，把按钮的代码注释了，添加一个StackPanel里面有2个Label标签和4个复选框,我们要实现的功能就是把用户选中的复选框的文本添加到配料表，如果取消选中，有需要从配料里面删除，界面如下

![image-20260705140047295](./note2-wpf控件.assets/image-20260705140047295.png)

## 后台代码如下，注意每一个复选框都有一个Checked和Unchecked事件，我们需要给这些事件添加处理代码

```
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace wfpchapter2_controls
{
    
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> toppings = new List<string>(); //集合成员变量
        public MainWindow()
        {
            InitializeComponent();
            ////txtBlock.Foreground=new SolidColorBrush(Colors.Black);
            //txtBlock.Foreground=Brushes.BlueViolet; //有现存可用的画刷
            //txtBlock.Text = "Hello from Code Behind!!!";
            //CreateTxtBlock();

        }

        private void CreateTxtBlock()
        {
            TextBlock block = new TextBlock();
            block.Text = "你好我好大家好，我是c#创建的TextBlock";
            block.Foreground = Brushes.BlueViolet;
            block.FontSize = 17;
            //设置文本自动换行
            block.TextWrapping = TextWrapping.Wrap;
            //往TextBlock里面添加内容
            block.Inlines.Add("\n好好学习，天天向上");
            block.Inlines.Add(new Run("\n这是用Run添加的文本")
            {
                Foreground = Brushes.DeepPink,
                FontSize = 24,
                FontWeight = FontWeights.Bold,
                TextDecorations = TextDecorations.Underline,
            });
            this.Content = block;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("按钮被点击了");
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = Brushes.AliceBlue;
            btn.FontWeight = FontWeights.Bold;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = Brushes.White;
            btn.FontWeight = FontWeights.Normal;
        }
        //处理复选框的选中和取消选中事件
        private void cbCheese_Checked(object sender, RoutedEventArgs e)
        {
            toppings.Add(cbCheese.Content.ToString());
            lbl_toppings.Content = string.Join(",", toppings);
        }

        private void cbCheese_Unchecked(object sender, RoutedEventArgs e)
        {
            toppings.Remove(cbCheese.Content.ToString());
            lbl_toppings.Content = string.Join(",", toppings);
        }

        private void cbTuna_Checked(object sender, RoutedEventArgs e)
        {
            toppings.Add(cbTuna.Content.ToString());
            lbl_toppings.Content = string.Join(",", toppings);
        }

        private void cbTuna_Unchecked(object sender, RoutedEventArgs e)
        {
            toppings.Remove(cbTuna.Content.ToString());
            lbl_toppings.Content = string.Join(",", toppings);
        }

        private void cbHam_Checked(object sender, RoutedEventArgs e)
        {
            toppings.Add(cbHam.Content.ToString());
            lbl_toppings.Content = string.Join(",", toppings);
        }

        private void cbHam_Unchecked(object sender, RoutedEventArgs e)
        {
            toppings.Remove(cbHam.Content.ToString());
            lbl_toppings.Content = string.Join(",", toppings);
        }

        private void cbPepp_Checked(object sender, RoutedEventArgs e)
        {
            toppings.Add(cbPepp.Content.ToString());
            lbl_toppings.Content = string.Join(",", toppings);
            MessageBox.Show("WoW,Que Rico!!!");
        }

        private void cbPepp_Unchecked(object sender, RoutedEventArgs e)
        {
            toppings.Remove(cbPepp.Content.ToString());
            lbl_toppings.Content = string.Join(",", toppings);
            MessageBox.Show("Se Necesita Una Cosa Mas Para Ser Rico");
        }
    }
    
}

```



### 效果

![image-20260705140403207](./note2-wpf控件.assets/image-20260705140403207.png)



![image-20260705140425076](./note2-wpf控件.assets/image-20260705140425076.png)



![image-20260705140446337](./note2-wpf控件.assets/image-20260705140446337.png)

![image-20260705140459899](./note2-wpf控件.assets/image-20260705140459899.png)

![image-20260705140518928](./note2-wpf控件.assets/image-20260705140518928.png)



![image-20260705140538257](./note2-wpf控件.assets/image-20260705140538257.png)

![image-20260705140552478](./note2-wpf控件.assets/image-20260705140552478.png)



![image-20260705140619235](./note2-wpf控件.assets/image-20260705140619235.png)



## 注意：CheckBox也是一个内容控件，可以在里面添加很多内容，也可以添加面板和图像，我们导入一些图片然后修改一下xaml代码

```
<Window x:Class="wfpchapter2_controls.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:wfpchapter2_controls"
        mc:Ignorable="d"
        Title="MainWindow" Height="300" Width="400">
    <StackPanel>
        <!--CheckBox-->
        <StackPanel Orientation="Horizontal">
            <Label>Pizza Toppings:</Label>
            <Label x:Name="lbl_toppings"></Label>
        </StackPanel>
        <CheckBox x:Name="cbCheese" Checked="cbCheese_Checked" Unchecked="cbCheese_Unchecked">
            <StackPanel Orientation="Horizontal">
                <Image Source="/Images/cheese-small.png" Width="16" />
                <TextBlock x:Name="tb_cheese"> Cheese</TextBlock>
            </StackPanel>
        </CheckBox>
        <CheckBox x:Name="cbTuna" Checked="cbTuna_Checked" Unchecked="cbTuna_Unchecked">
            <StackPanel Orientation="Horizontal">
                <Image Source="/Images/tuna-sm.png" Width="16" />
                <TextBlock x:Name="tb_tuna"> Tuna</TextBlock>
            </StackPanel>
        </CheckBox>
        <CheckBox x:Name="cbHam" Checked="cbHam_Checked" Unchecked="cbHam_Unchecked">
            <StackPanel Orientation="Horizontal">
                <Image Source="/Images/tuna-sm.png" Width="16" />
                <TextBlock x:Name="tb_ham"> Ham</TextBlock>
            </StackPanel>
        </CheckBox>
        <CheckBox x:Name="cbPepp" Checked="cbPepp_Checked" Unchecked="cbPepp_Unchecked">
            <StackPanel Orientation="Horizontal">
                <Image Source="/Images/tuna-sm.png" Width="16" />
                <TextBlock x:Name="tb_pepp"> Pepperoni</TextBlock>
            </StackPanel>
        </CheckBox>
    </StackPanel>
</Window>

```



## 然后后台代码需要适当修改，代码如下(注意，有效是以前的控件的代码，忽略即可)

```
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace wfpchapter2_controls
{
    
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> toppings = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            ////txtBlock.Foreground=new SolidColorBrush(Colors.Black);
            //txtBlock.Foreground=Brushes.BlueViolet; //有现存可用的画刷
            //txtBlock.Text = "Hello from Code Behind!!!";
            //CreateTxtBlock();

        }

        private void CreateTxtBlock()
        {
            TextBlock block = new TextBlock();
            block.Text = "你好我好大家好，我是c#创建的TextBlock";
            block.Foreground = Brushes.BlueViolet;
            block.FontSize = 17;
            //设置文本自动换行
            block.TextWrapping = TextWrapping.Wrap;
            //往TextBlock里面添加内容
            block.Inlines.Add("\n好好学习，天天向上");
            block.Inlines.Add(new Run("\n这是用Run添加的文本")
            {
                Foreground = Brushes.DeepPink,
                FontSize = 24,
                FontWeight = FontWeights.Bold,
                TextDecorations = TextDecorations.Underline,
            });
            this.Content = block;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("按钮被点击了");
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = Brushes.AliceBlue;
            btn.FontWeight = FontWeights.Bold;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = Brushes.White;
            btn.FontWeight = FontWeights.Normal;
        }

        private void cbCheese_Checked(object sender, RoutedEventArgs e)
        {
            toppings.Add(tb_cheese.Text);
            lbl_toppings.Content = string.Join(",", toppings);
        }

        private void cbCheese_Unchecked(object sender, RoutedEventArgs e)
        {
            toppings.Remove(tb_cheese.Text);
            lbl_toppings.Content = string.Join(",", toppings);
        }

        private void cbTuna_Checked(object sender, RoutedEventArgs e)
        {
            toppings.Add(tb_tuna.Text);
            lbl_toppings.Content = string.Join(",", toppings);
        }

        private void cbTuna_Unchecked(object sender, RoutedEventArgs e)
        {
            toppings.Remove(tb_tuna.Text);
            lbl_toppings.Content = string.Join(",", toppings);
        }

        private void cbHam_Checked(object sender, RoutedEventArgs e)
        {
            toppings.Add(tb_ham.Text);
            lbl_toppings.Content = string.Join(",", toppings);
        }

        private void cbHam_Unchecked(object sender, RoutedEventArgs e)
        {
            toppings.Remove(tb_ham.Text);
            lbl_toppings.Content = string.Join(",", toppings);
        }

        private void cbPepp_Checked(object sender, RoutedEventArgs e)
        {
            toppings.Add(tb_pepp.Text);
            lbl_toppings.Content = string.Join(",", toppings);
            MessageBox.Show("WoW,Que Rico!!!");
        }

        private void cbPepp_Unchecked(object sender, RoutedEventArgs e)
        {
            toppings.Remove(tb_pepp.Text);
            lbl_toppings.Content = string.Join(",", toppings);
            MessageBox.Show("Se Necesita Una Cosa Mas Para Ser Rico");
        }
    }
    
}

```



### 效果

![image-20260705150750800](./note2-wpf控件.assets/image-20260705150750800.png)





![image-20260705150813036](./note2-wpf控件.assets/image-20260705150813036.png)







![image-20260705150829847](./note2-wpf控件.assets/image-20260705150829847.png)



![image-20260705150857849](./note2-wpf控件.assets/image-20260705150857849.png)



## 注意，现在的CheckBox其实是可以有3种状态，是选中，未选中和未决定（或者说不全选，一般适用于一个项里面都有多个子项的情况）我们可以添加一个复选框，文本是all。然后把其余的复选框放入一个StackPanel里面方便定位，然后我们把新增的复选框的名称改为cbParent，然后开启他的3态属性并且给他一个选中事件处理函数叫做cbParentChackStateChanged，然后在复选框取消选中的事件中我们还是使用这个函数。xaml代码如下

```
<Window x:Class="wfpchapter2_controls.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:wfpchapter2_controls"
        mc:Ignorable="d"
        Title="MainWindow" Height="300" Width="400">
    <StackPanel>
        <!--CheckBox-->
        <StackPanel Orientation="Horizontal">
            <Label>Pizza Toppings:</Label>
            <Label x:Name="lbl_toppings"></Label>
        </StackPanel>
        <!--Parent CheckBox-->
        <CheckBox x:Name="cbParent" IsThreeState="True"
                  Checked="cbParentChackStateChanged"
                  Unchecked="cbParentChackStateChanged">All</CheckBox>
        <StackPanel Margin="15 5">
            <CheckBox x:Name="cbCheese" Checked="cbCheese_Checked" Unchecked="cbCheese_Unchecked">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/Images/cheese-small.png" Width="16" />
                    <TextBlock x:Name="tb_cheese"> Cheese</TextBlock>
                </StackPanel>
            </CheckBox>
            <CheckBox x:Name="cbTuna" Checked="cbTuna_Checked" Unchecked="cbTuna_Unchecked">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/Images/tuna-sm.png" Width="16" />
                    <TextBlock x:Name="tb_tuna"> Tuna</TextBlock>
                </StackPanel>
            </CheckBox>
            <CheckBox x:Name="cbHam" Checked="cbHam_Checked" Unchecked="cbHam_Unchecked">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/Images/tuna-sm.png" Width="16" />
                    <TextBlock x:Name="tb_ham"> Ham</TextBlock>
                </StackPanel>
            </CheckBox>
            <CheckBox x:Name="cbPepp" Checked="cbPepp_Checked" Unchecked="cbPepp_Unchecked">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/Images/tuna-sm.png" Width="16" />
                    <TextBlock x:Name="tb_pepp"> Pepperoni</TextBlock>
                </StackPanel>
            </CheckBox>
        </StackPanel>
    </StackPanel>
</Window>

```



## 我们需要做一些代码重构，把每一个复选框的Checked和Unchecked事件的处理函数改为同一个处理函数，优化后的xaml代码如下

```
<Window x:Class="wfpchapter2_controls.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:wfpchapter2_controls"
        mc:Ignorable="d"
        Title="MainWindow" Height="300" Width="400">
    <StackPanel>
        <!--TextBlock-->
        <!--<TextBlock>Hello <Bold>From </Bold> <Underline>TextBlock</Underline>,
            <LineBreak/> Hello World<LineBreak/>
            Visit <Hyperlink NavigateUri="https://www.google.com"
                             RequestNavigate="Hyperlink_RequestNavigate">Google.com</Hyperlink>
        </TextBlock>
        <TextBlock x:Name="txtBlock" TextWrapping="Wrap" Foreground="DeepPink" Background="Beige">
            Photoshop由托马斯·诺尔和约翰·诺尔在1988年首次发布。自那时起，它成为位图编辑的行业标准。该软件的名称经常被通俗地用作动词，
            如<Span Foreground="Aquamarine" Background="White">“P图”，“正在 PS”和“PS 比赛”</Span>，尽管 Adobe 不鼓励这样使用。它可以编辑和合成多个图层中的位图，支持图层遮罩、图像合成且包含 RGB、CMYK、CIELAB、专色通道和双色调等多种颜色模型。该软件使用自己的 .PSD 和 .PSB 文件格式来支持上述功能。不过除位图以外，它编辑或渲染文本、矢量图形（尤其是剪辑路径）、3D 图形和视频的能力有限。它的功能可以通过 Photoshop 插件、独立于该软件开发和分发的程序来扩展，这些程序在其内部运行以增强或是提供全新的功能。
        </TextBlock>-->
        <!--Label-->
        <!--<Label Width="300" Height="120">
            <StackPanel>
                <StackPanel Orientation="Horizontal" Margin="0 10 0 0">
                    <Image Source="/Images/1.jpg" Width="60" Height="50" />
                    <Image Source="/Images/2.png" Width="60" Height="50" />
                    <Image Source="/Images/3.jpg" Width="60" Height="50" />
                </StackPanel>
                <Button Margin="0 10 0 0">我是标签内容里面的按钮</Button>
                <TextBox>我是标签内容里面的文本框</TextBox>
            </StackPanel>
           
        </Label>-->
        <!--TextBox-->
        <!--<TextBox 
                 FontSize="18"
                 Margin="5" AcceptsReturn="True"
                 TextWrapping="Wrap"
                 Language="en-US"
                 SpellCheck.IsEnabled="True"
                 />-->
        <!--Button-->
        <!--<Button Width="200" Height="80" Click="Button_Click"
                MouseEnter="Button_MouseEnter"
                MouseLeave="Button_MouseLeave"
                ToolTip="Hello Button ho ho ho...">
               Hello
            --><!--<StackPanel>
                <Image Source="/Images/1.jpg" Width="200" Height="50"  Stretch="Fill"/>
                <Image Source="/Images/2.png" Width="200" Height="50" Stretch="UniformToFill" />
                <Image Source="/Images/3.jpg" Width="200" Height="50" Stretch="Fill"/>
            </StackPanel>--><!--
        </Button>-->
        <!--CheckBox-->
        <StackPanel Orientation="Horizontal">
            <Label>Pizza Toppings:</Label>
            <Label x:Name="lbl_toppings"></Label>
        </StackPanel>
        <!--Parent CheckBox-->
        <CheckBox x:Name="cbParent" IsThreeState="True"
                  Checked="cbParentChackStateChanged"
                  Unchecked="cbParentChackStateChanged">All</CheckBox>
        <StackPanel Margin="15 5">
            <CheckBox x:Name="cbCheese" Checked="cbCheese_CheckedChanged" Unchecked="cbCheese_CheckedChanged">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/Images/cheese-small.png" Width="16" />
                    <TextBlock x:Name="tb_cheese"> Cheese</TextBlock>
                </StackPanel>
            </CheckBox>
            <CheckBox x:Name="cbTuna" Checked="cbTuna_CheckedChanged" Unchecked="cbTuna_CheckedChanged">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/Images/tuna-sm.png" Width="16" />
                    <TextBlock x:Name="tb_tuna"> Tuna</TextBlock>
                </StackPanel>
            </CheckBox>
            <CheckBox x:Name="cbHam" Checked="cbHam_CheckedChanged" Unchecked="cbHam_CheckedChanged">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/Images/tuna-sm.png" Width="16" />
                    <TextBlock x:Name="tb_ham"> Ham</TextBlock>
                </StackPanel>
            </CheckBox>
            <CheckBox x:Name="cbPepp" Checked="cbPepp_CheckedChanged" Unchecked="cbPepp_CheckedChanged">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/Images/tuna-sm.png" Width="16" />
                    <TextBlock x:Name="tb_pepp"> Pepperoni</TextBlock>
                </StackPanel>
            </CheckBox>
        </StackPanel>
    </StackPanel>
</Window>

```



## 然后我们需要在后台代码里面实现这些函数，代码如下

```
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace wfpchapter2_controls
{
    
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> toppings = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            ////txtBlock.Foreground=new SolidColorBrush(Colors.Black);
            //txtBlock.Foreground=Brushes.BlueViolet; //有现存可用的画刷
            //txtBlock.Text = "Hello from Code Behind!!!";
            //CreateTxtBlock();

        }

        private void CreateTxtBlock()
        {
            TextBlock block = new TextBlock();
            block.Text = "你好我好大家好，我是c#创建的TextBlock";
            block.Foreground = Brushes.BlueViolet;
            block.FontSize = 17;
            //设置文本自动换行
            block.TextWrapping = TextWrapping.Wrap;
            //往TextBlock里面添加内容
            block.Inlines.Add("\n好好学习，天天向上");
            block.Inlines.Add(new Run("\n这是用Run添加的文本")
            {
                Foreground = Brushes.DeepPink,
                FontSize = 24,
                FontWeight = FontWeights.Bold,
                TextDecorations = TextDecorations.Underline,
            });
            this.Content = block;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("按钮被点击了");
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = Brushes.AliceBlue;
            btn.FontWeight = FontWeights.Bold;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = Brushes.White;
            btn.FontWeight = FontWeights.Normal;
        }

        private void cbCheese_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (cbCheese.IsChecked == true) {
                toppings.Add(tb_cheese.Text);
               
            }else if(cbCheese.IsChecked == false)
            {
                toppings.Remove(tb_cheese.Text);
            }
            lbl_toppings.Content = string.Join(",", toppings);
        }

       

        private void cbTuna_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if(cbTuna.IsChecked == true)
              toppings.Add(tb_tuna.Text);
            else if(cbTuna.IsChecked == false)
              toppings.Remove(tb_tuna.Text);
            lbl_toppings.Content = string.Join(",", toppings);
        }


        private void cbHam_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (cbHam.IsChecked == true)
                toppings.Add(tb_ham.Text);
            else if (cbHam.IsChecked == false)
                toppings.Remove(tb_ham.Text);
            lbl_toppings.Content = string.Join(",", toppings);
        }

     
        private void cbPepp_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if(cbPepp.IsChecked == true)
                toppings.Add(tb_pepp.Text);
            else if (cbPepp.IsChecked == false)
                toppings.Remove(tb_pepp.Text);
            lbl_toppings.Content = string.Join(",", toppings);
        }

        //private void cbPepp_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    toppings.Remove(tb_pepp.Text);
        //    lbl_toppings.Content = string.Join(",", toppings);
        //    //MessageBox.Show("Se Necesita Una Cosa Mas Para Ser Rico");
        //}
        private void cbParentChackStateChanged(object sender, RoutedEventArgs e) 
        {

        }
    }
    
}

```

### 为了更加方便我们的编程，我们其实可以创建一个cbToppingsCheckChanged函数给这四种topping的复选框都使用这个函数，我们再来重构一些xaml,代码如下

```
<Window x:Class="wfpchapter2_controls.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:wfpchapter2_controls"
        mc:Ignorable="d"
        Title="MainWindow" Height="300" Width="400">
    <StackPanel>
        <!--TextBlock-->
        <!--<TextBlock>Hello <Bold>From </Bold> <Underline>TextBlock</Underline>,
            <LineBreak/> Hello World<LineBreak/>
            Visit <Hyperlink NavigateUri="https://www.google.com"
                             RequestNavigate="Hyperlink_RequestNavigate">Google.com</Hyperlink>
        </TextBlock>
        <TextBlock x:Name="txtBlock" TextWrapping="Wrap" Foreground="DeepPink" Background="Beige">
            Photoshop由托马斯·诺尔和约翰·诺尔在1988年首次发布。自那时起，它成为位图编辑的行业标准。该软件的名称经常被通俗地用作动词，
            如<Span Foreground="Aquamarine" Background="White">“P图”，“正在 PS”和“PS 比赛”</Span>，尽管 Adobe 不鼓励这样使用。它可以编辑和合成多个图层中的位图，支持图层遮罩、图像合成且包含 RGB、CMYK、CIELAB、专色通道和双色调等多种颜色模型。该软件使用自己的 .PSD 和 .PSB 文件格式来支持上述功能。不过除位图以外，它编辑或渲染文本、矢量图形（尤其是剪辑路径）、3D 图形和视频的能力有限。它的功能可以通过 Photoshop 插件、独立于该软件开发和分发的程序来扩展，这些程序在其内部运行以增强或是提供全新的功能。
        </TextBlock>-->
        <!--Label-->
        <!--<Label Width="300" Height="120">
            <StackPanel>
                <StackPanel Orientation="Horizontal" Margin="0 10 0 0">
                    <Image Source="/Images/1.jpg" Width="60" Height="50" />
                    <Image Source="/Images/2.png" Width="60" Height="50" />
                    <Image Source="/Images/3.jpg" Width="60" Height="50" />
                </StackPanel>
                <Button Margin="0 10 0 0">我是标签内容里面的按钮</Button>
                <TextBox>我是标签内容里面的文本框</TextBox>
            </StackPanel>
           
        </Label>-->
        <!--TextBox-->
        <!--<TextBox 
                 FontSize="18"
                 Margin="5" AcceptsReturn="True"
                 TextWrapping="Wrap"
                 Language="en-US"
                 SpellCheck.IsEnabled="True"
                 />-->
        <!--Button-->
        <!--<Button Width="200" Height="80" Click="Button_Click"
                MouseEnter="Button_MouseEnter"
                MouseLeave="Button_MouseLeave"
                ToolTip="Hello Button ho ho ho...">
               Hello
            --><!--<StackPanel>
                <Image Source="/Images/1.jpg" Width="200" Height="50"  Stretch="Fill"/>
                <Image Source="/Images/2.png" Width="200" Height="50" Stretch="UniformToFill" />
                <Image Source="/Images/3.jpg" Width="200" Height="50" Stretch="Fill"/>
            </StackPanel>--><!--
        </Button>-->
        <!--CheckBox-->
        <StackPanel Orientation="Horizontal">
            <Label>Pizza Toppings:</Label>
            <Label x:Name="lbl_toppings"></Label>
        </StackPanel>
        <!--Parent CheckBox-->
        <CheckBox x:Name="cbParent" IsThreeState="True"
                  Checked="cbParentChackStateChanged"
                  Unchecked="cbParentChackStateChanged">All</CheckBox>
        <StackPanel Margin="15 5">
            <CheckBox x:Name="cbCheese" Checked="cbToppingsCheckChanged" Unchecked="cbToppingsCheckChanged">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/Images/cheese-small.png" Width="16" />
                    <TextBlock x:Name="tb_cheese"> Cheese</TextBlock>
                </StackPanel>
            </CheckBox>
            <CheckBox x:Name="cbTuna" Checked="cbToppingsCheckChanged" Unchecked="cbToppingsCheckChanged">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/Images/tuna-sm.png" Width="16" />
                    <TextBlock x:Name="tb_tuna"> Tuna</TextBlock>
                </StackPanel>
            </CheckBox>
            <CheckBox x:Name="cbHam" Checked="cbToppingsCheckChanged" Unchecked="cbToppingsCheckChanged">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/Images/tuna-sm.png" Width="16" />
                    <TextBlock x:Name="tb_ham"> Ham</TextBlock>
                </StackPanel>
            </CheckBox>
            <CheckBox x:Name="cbPepp" Checked="cbToppingsCheckChanged" Unchecked="cbToppingsCheckChanged">
                <StackPanel Orientation="Horizontal">
                    <Image Source="/Images/tuna-sm.png" Width="16" />
                    <TextBlock x:Name="tb_pepp"> Pepperoni</TextBlock>
                </StackPanel>
            </CheckBox>
        </StackPanel>
    </StackPanel>
</Window>

```



## 然后我们回到后台代码，来完成这两个函数的编写

```
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace wfpchapter2_controls
{
    
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> toppings = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            ////txtBlock.Foreground=new SolidColorBrush(Colors.Black);
            //txtBlock.Foreground=Brushes.BlueViolet; //有现存可用的画刷
            //txtBlock.Text = "Hello from Code Behind!!!";
            //CreateTxtBlock();

        }

        private void CreateTxtBlock()
        {
            TextBlock block = new TextBlock();
            block.Text = "你好我好大家好，我是c#创建的TextBlock";
            block.Foreground = Brushes.BlueViolet;
            block.FontSize = 17;
            //设置文本自动换行
            block.TextWrapping = TextWrapping.Wrap;
            //往TextBlock里面添加内容
            block.Inlines.Add("\n好好学习，天天向上");
            block.Inlines.Add(new Run("\n这是用Run添加的文本")
            {
                Foreground = Brushes.DeepPink,
                FontSize = 24,
                FontWeight = FontWeights.Bold,
                TextDecorations = TextDecorations.Underline,
            });
            this.Content = block;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("按钮被点击了");
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = Brushes.AliceBlue;
            btn.FontWeight = FontWeights.Bold;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = Brushes.White;
            btn.FontWeight = FontWeights.Normal;
        }

        //private void cbCheese_CheckedChanged(object sender, RoutedEventArgs e)
        //{
        //    if (cbCheese.IsChecked == true) {
        //        toppings.Add(tb_cheese.Text);
               
        //    }else if(cbCheese.IsChecked == false)
        //    {
        //        toppings.Remove(tb_cheese.Text);
        //    }
        //    lbl_toppings.Content = string.Join(",", toppings);
        //}

       

        //private void cbTuna_CheckedChanged(object sender, RoutedEventArgs e)
        //{
        //    if(cbTuna.IsChecked == true)
        //      toppings.Add(tb_tuna.Text);
        //    else if(cbTuna.IsChecked == false)
        //      toppings.Remove(tb_tuna.Text);
        //    lbl_toppings.Content = string.Join(",", toppings);
        //}


        //private void cbHam_CheckedChanged(object sender, RoutedEventArgs e)
        //{
        //    if (cbHam.IsChecked == true)
        //        toppings.Add(tb_ham.Text);
        //    else if (cbHam.IsChecked == false)
        //        toppings.Remove(tb_ham.Text);
        //    lbl_toppings.Content = string.Join(",", toppings);
        //}

     
        //private void cbPepp_CheckedChanged(object sender, RoutedEventArgs e)
        //{
        //    if(cbPepp.IsChecked == true)
        //        toppings.Add(tb_pepp.Text);
        //    else if (cbPepp.IsChecked == false)
        //        toppings.Remove(tb_pepp.Text);
        //    lbl_toppings.Content = string.Join(",", toppings);
        //}

        private void cbToppingsCheckChanged(object sender, RoutedEventArgs e) 
        {
            cbParent.IsChecked = null; //既不是true也不是false的状态是一个黑色方块
            if (cbCheese.IsChecked == true)
            {
                if(!toppings.Contains(tb_cheese.Text))
                    toppings.Add(tb_cheese.Text);

            }
            else if (cbCheese.IsChecked == false)
            {
                toppings.Remove(tb_cheese.Text);
            }

            if (cbTuna.IsChecked == true)
            {
                if (!toppings.Contains(tb_tuna.Text))
                    toppings.Add(tb_tuna.Text);
            }  
            else if (cbTuna.IsChecked == false)
                toppings.Remove(tb_tuna.Text);

            if (cbHam.IsChecked == true)
            {
               if (!toppings.Contains(tb_ham.Text))
                    toppings.Add(tb_ham.Text);
            }    
            else if (cbHam.IsChecked == false)
                toppings.Remove(tb_ham.Text);
            
            if (cbPepp.IsChecked == true)
            {
                if (!toppings.Contains(tb_pepp.Text))
                    toppings.Add(tb_pepp.Text);
            }
                
            else if (cbPepp.IsChecked == false)
                toppings.Remove(tb_pepp.Text);
            lbl_toppings.Content = string.Join(",", toppings);
            //如果所有是自复选框都被选中，父亲复选框也需要变为选中状态
            if(cbCheese.IsChecked == true && cbHam.IsChecked==true && cbTuna.IsChecked==true && cbPepp.IsChecked==true)
            {
                cbParent.IsChecked = true;
            }
            //如果所有是自复选框都被取消选中，父亲复选框也需要变为取消选中状态
            if (cbCheese.IsChecked == false && cbHam.IsChecked == false && cbTuna.IsChecked == false && cbPepp.IsChecked == false)
            {
                cbParent.IsChecked = false;
            }
        }
        private void cbParentChackStateChanged(object sender, RoutedEventArgs e) 
        {
            //获取父亲复选框的状态，然后赋值给所有自复选框,这样子，只要勾选了父亲复选框。所有自复选框都会勾选上，
            //只要取消勾选父亲复选框，所有的自复选框都会取消选中
            bool newVal = (cbParent.IsChecked == true);
            cbCheese.IsChecked = newVal;
            cbHam.IsChecked = newVal;
            cbTuna.IsChecked = newVal;
            cbPepp.IsChecked = newVal;
        }
    }
    
}

```



### 效果

![image-20260705182139604](./note2-wpf控件.assets/image-20260705182139604.png)





![image-20260705182201364](./note2-wpf控件.assets/image-20260705182201364.png)



![image-20260705182230201](./note2-wpf控件.assets/image-20260705182230201.png)

![image-20260705182248483](./note2-wpf控件.assets/image-20260705182248483.png)

# 8.密码框



# 9.图像



# 10.滑块-数据绑定和触发器



# 11.日历



# 12.日历选择器



# 13.扩展器





