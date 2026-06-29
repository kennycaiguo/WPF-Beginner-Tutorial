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



# 6.按钮



# 7.复选框



# 8.密码框



# 9.图像



# 10.滑块-数据绑定和触发器



# 11.日历



# 12.日历选择器



# 13.扩展器





