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

# 8.密码框PasswordBox

## 还是上面的Controls项目，我们把CheckBox的代码注释了（后台代码也注释了，否则报错），然后添加一个StackPanel两个标签一个文本框一个密码框

![image-20260705184150072](./note2-wpf控件.assets/image-20260705184150072.png)

## 密码框有一个PasswordChar属性，你可以把它设置为你信号的字符，比如*

![image-20260705184313747](./note2-wpf控件.assets/image-20260705184313747.png)

## 注意，这个PasswordBox没有Content属性，没有Text属性，也没有Value属性，他的文本是通过Password属性来获取的，我们可以添加一个登录按钮，然后在按钮的点击事件里面获取密码框的密码属性，然后继续判断，这样子一个超级简单的登录小案例就做好了

![image-20260705190248420](./note2-wpf控件.assets/image-20260705190248420.png)

## 后台代码是这样子的

![image-20260705193340851](./note2-wpf控件.assets/image-20260705193340851.png)

### 效果

![image-20260705193435966](./note2-wpf控件.assets/image-20260705193435966.png)



![image-20260705193504454](./note2-wpf控件.assets/image-20260705193504454.png)

## 可以使用MaxLength属性设置密码的最大长度，但是它没有最小长度限制

![image-20260705193744338](./note2-wpf控件.assets/image-20260705193744338.png)

## 注意，密码框没有依赖属性，无法进行绑定也就是无法使用Binding，这是处于密码安全性的考量。



# 9.图像

## 还是controls项目，把密码框相关的代码注释了，然后我们来学习图像

#### 把一个图片作为资源的正确语法是如图

![image-20260705194755617](./note2-wpf控件.assets/image-20260705194755617.png)

## 我们创建一个图片控件，给他设置一个源图片

![image-20260705195445366](./note2-wpf控件.assets/image-20260705195445366.png)

## 我们给图片添加一个MouseUp事件处理函数（图片是没有Click事件的，MouseUp就相当于Click事件），并且，我们需要给Image元素起一个名字：ImgBox。然后我们进入后台文件，尝试用cs代码来覆盖这一幅图片

![image-20260705201458427](./note2-wpf控件.assets/image-20260705201458427.png)

![image-20260705202523936](./note2-wpf控件.assets/image-20260705202523936.png)

### 效果

![image-20260705202552414](./note2-wpf控件.assets/image-20260705202552414.png)

### 点击图片就会修改Image的source属性，会变为另外一张图片

![image-20260705202647396](./note2-wpf控件.assets/image-20260705202647396.png)

### 注意，xaml中图片的Source属性可以简写

![image-20260705202802500](./note2-wpf控件.assets/image-20260705202802500.png)



# 10.滑块-数据绑定和触发器

## 把图片控件的代码以及后台代码注释了，然后创建一个滑块控件

![image-20260712113900128](./note2-wpf控件.assets/image-20260712113900128.png)

## 此时运行程序，即使你设置了最大值，在界面上面都看不出来

![image-20260712113958089](./note2-wpf控件.assets/image-20260712113958089.png)



## 我们需要给滑块添加刻度，你可以指定宽度的位置和刻度的频率

![image-20260714092236185](./note2-wpf控件.assets/image-20260714092236185.png)

## 你还可以指定是否对齐到宽度，需要设置IsSnapToTickEnabled属性

![image-20260714092436664](./note2-wpf控件.assets/image-20260714092436664.png)

### 效果

![image-20260714092504246](./note2-wpf控件.assets/image-20260714092504246.png)



### 注意，设置了这个属性后，你无法平滑的移动滑块，只能够在宽度直接跳转

## 滑块还有一个重要属性value，你可以通过他来设置滑块的位置

![image-20260714092841946](./note2-wpf控件.assets/image-20260714092841946.png)

## 滑块的比较重要的事件是ValueChanged事件

![image-20260714100659671](./note2-wpf控件.assets/image-20260714100659671.png)

## 在后台代码这么写

![image-20260714101000870](./note2-wpf控件.assets/image-20260714101000870.png)

## 此时会有一个问题

![image-20260714101030109](./note2-wpf控件.assets/image-20260714101030109.png)

### 这是因为滑块在文本框创建之前就加载了

## 解决办法就是保证文本框不为空，只需要添加一个if判断

![image-20260714101236856](./note2-wpf控件.assets/image-20260714101236856.png)

## 当然，要实现同样的效果，也可以只使用xaml来完成，只需要使用实现绑定

![image-20260714105455009](./note2-wpf控件.assets/image-20260714105455009.png)

## 效果

![image-20260714105523818](./note2-wpf控件.assets/image-20260714105523818.png)

![image-20260714105601145](./note2-wpf控件.assets/image-20260714105601145.png)



# 11.日历

## 注释调滑块的代码，然后我们来创建一个日历控件

![image-20260717200914819](./note2-wpf控件.assets/image-20260717200914819.png)

## 如果你需要拉伸日历，可以把它放到一个ViewBox里面

![image-20260718111649690](./note2-wpf控件.assets/image-20260718111649690.png)

### 当然ViewBox的拉伸模式还可以选择uniform，有时候这个选项更好

![image-20260718112014123](./note2-wpf控件.assets/image-20260718112014123.png)

## 那么如何获取我们选择的日期？我们需要先给日历控件添加一个名称，然后我们可以添加一个Label和一个TextBlock控件，然后给日历控件的SelectedDatesChanged事件添加处理代码

![image-20260718112939910](./note2-wpf控件.assets/image-20260718112939910.png)

![image-20260718113040359](./note2-wpf控件.assets/image-20260718113040359.png)

## 效果

![image-20260718113405171](./note2-wpf控件.assets/image-20260718113405171.png)



![image-20260718113440072](./note2-wpf控件.assets/image-20260718113440072.png)

## 可以通过DisplayMode来实战日历控件的显示模式有10年，月和年3种选项

![image-20260718113754649](./note2-wpf控件.assets/image-20260718113754649.png)

## 日历控件可以设置排除日期，设置后这个范围内的日期不可选择

![image-20260718114032699](./note2-wpf控件.assets/image-20260718114032699.png)

![image-20260718114236062](./note2-wpf控件.assets/image-20260718114236062.png)

# 12.日历选择器

## 还是这个项目，我们把日历控件的代码注释了，然后创建一个日期挑选器DataPicker

![image-20260718114647114](./note2-wpf控件.assets/image-20260718114647114.png)

## 运行程序，效果如下，你可以选择一个日期，此时日期选择器的文本框就会显示这个日期

![image-20260718114854728](./note2-wpf控件.assets/image-20260718114854728.png)



## 你也可以在日期选择器的文本框里面输入一个日期，日期选择器也会选中这个日期，比如我们输入2026/6/16，回车，然后打开日期选择器，效果如下

![image-20260718115109780](./note2-wpf控件.assets/image-20260718115109780.png)



## 我们可以设置日期选择器的默认选择日期，使用SelectedDate属性来设置，注意，格式是月/日/年，否则报错

![image-20260718115500280](./note2-wpf控件.assets/image-20260718115500280.png)



## 可以设置日期的格式，有Long和short，默认值是short

![image-20260718115648134](./note2-wpf控件.assets/image-20260718115648134.png)

## Long格式可以显示日期和星期几

![image-20260718115809480](./note2-wpf控件.assets/image-20260718115809480.png)

## 日期选择器有一个SelectedDateChanged事件

![image-20260718120353139](./note2-wpf控件.assets/image-20260718120353139.png)

## 然后我们可以添加一些代码

![image-20260718120329513](./note2-wpf控件.assets/image-20260718120329513.png)

## 效果

![image-20260718120459251](./note2-wpf控件.assets/image-20260718120459251.png)

## 和日历控件一样，日期选择器也可以排除某些日期，使得他们不能够被选中

![image-20260718152538113](./note2-wpf控件.assets/image-20260718152538113.png)

# 13.展开器expander

## 把日期选择器的代码注释了，然后创建一个展开器Expander

![image-20260718153014568](./note2-wpf控件.assets/image-20260718153014568.png)

## 然后我们可以在展开器里面添加一些东西,比如一幅图片，一个日期选择器，一个文本块和一个按钮

![image-20260718160605020](./note2-wpf控件.assets/image-20260718160605020.png)

## 可以给展开器添加标题文本，只需要设置Header属性的值即可

![image-20260718161150163](./note2-wpf控件.assets/image-20260718161150163.png)

## 运行程序，效果如下

![image-20260718161225379](./note2-wpf控件.assets/image-20260718161225379.png)



![image-20260718161249442](./note2-wpf控件.assets/image-20260718161249442.png)

![image-20260718161315394](./note2-wpf控件.assets/image-20260718161315394.png)



## 注意：Header也可以作为一个并且来使用，里面可以放置任何内容

![image-20260718162230890](./note2-wpf控件.assets/image-20260718162230890.png)

## Expander有一个Expanded和一个Collapsed事件，当展开器被展开，就会触发Expanded事件，当展开器被折叠，触发Collapsed事件

![image-20260718163049810](./note2-wpf控件.assets/image-20260718163049810.png)

## 对应的后台代码如下

![image-20260718163133317](./note2-wpf控件.assets/image-20260718163133317.png)

## 效果

![image-20260718163204080](./note2-wpf控件.assets/image-20260718163204080.png)

![image-20260718163225267](./note2-wpf控件.assets/image-20260718163225267.png)



![image-20260718163245648](./note2-wpf控件.assets/image-20260718163245648.png)



![image-20260718163310266](./note2-wpf控件.assets/image-20260718163310266.png)

# 注意：wpf大坑

## wpf在滑块的valueChanged事件处理函数出现System.NullReferenceException:“未将对象引用设置到对象的实例。”

在 WPF 中，滑块（`Slider`）的 `ValueChanged` 事件触发非常频繁（甚至在 UI 初始化加载时就会触发）。出现 `System.NullReferenceException` 错误，通常是因为事件处理函数中调用了未初始化的对象、空控件或空变量。 [[1](https://blog.csdn.net/Monkey_King_GL/article/details/125972092), [2](https://www.cnblogs.com/daran/p/14302650.html), [3](https://blog.csdn.net/wangjinyang_123/article/details/41411597)]

以下是导致该问题的最常见原因及对应的排查与解决办法：

1. 常见原因

- **后台代码访问了尚未初始化的 UI 控件**：如果在 XAML 中，`Slider` 的定义在其他目标控件（如 `TextBlock`、`Label`）之前，或者在 `InitializeComponent()` 之前触发了事件，访问目标控件时会因未实例化而报错。
- **未进行空值（Null）判断**：事件处理函数中直接调用了可能为 `null` 的对象属性或方法（例如未初始化的自定义类、数据库连接对象等）。
- **数据绑定触发异常**：`Slider` 的值改变时常用来更新某个对象，如果绑定的目标对象实例未创建，赋值时就会引发异常。
- **事件处理程序获取了错误的发送者**：事件处理时将 `sender` 强制转换为特定类型时失败，或者获取的数据上下文（`DataContext`）为 `null`。 [[1](https://comate.baidu.com/zh/page/qzblza2iu69), [2](https://www.cnblogs.com/liuzijin/p/17884122.html), [3](https://blog.csdn.net/Monkey_King_GL/article/details/125972092), [4](https://blog.csdn.net/wangjinyang_123/article/details/41411597), [5](https://www.cnblogs.com/daran/p/14302650.html)]
- 核心排查与解决步骤

第一步：调试定位（最快的方法）

1. 在抛出异常的 `ValueChanged` 事件处理函数第一行设置**断点**。
2. 运行程序，当触发滑动条改变时进入断点。
3. 使用“单步执行”（F10/F11）往下走，观察哪一行代码使程序崩溃，并将鼠标悬停在变量上查看哪个对象显示为 `null`。

第二步：添加防御性代码

在代码中使用条件运算符 `?.` 或者判空语句来防止异常崩溃：

csharp

```wpf
private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
{
    // 1. 确保控件已经初始化完成（防范窗口加载时的误触发）
    if (!this.IsLoaded) return;

    // 2. 使用安全转换和空值判断
    if (sender is Slider slider && myTargetTextBox != null)
    {
        // 确保你要赋值的目标对象不为空
        myTargetTextBox.Text = slider.Value.ToString();
    }
}
```

## 注意：wpf控件的定义是由顺序的，先定义的控件不能够操作后定义的控件，会发生null异常，因为在先定义的控件的里面，后面的控件还可以完成初始化，此时使用后面的控件就会引发空异常，当然你非要操作，也可以，必须先用if语句判断这个对象是否为空，如果不为空才操作它就不会有问题



