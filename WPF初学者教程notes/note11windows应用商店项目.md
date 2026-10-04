# 1.项目简介

略

# 2.设置并显示应用1

## 1.新建一个项目，起名：windowstoreclone

![image-20260926094336729](./note11windows应用商店项目.assets/image-20260926094336729.png)



## 2.给项目条件应该Images文件夹，在里面放在70张左右的图片

![image-20261003104326290](./note11windows应用商店项目.assets/image-20261003104326290.png)

![image-20260927120921491](./note11windows应用商店项目.assets/image-20260927120921491.png)

#### 注意：这些文件的名称都是由数字编号的。方便管理



### 注意：这里有应该图片的下载链接： https://www.flaticon.com/packs/home-screen-apps-21

## 3.然后我们需要通过nuget工具安装miscutil包，打开nuget包管理工具，点击浏览选项卡，在搜索框中输入miscutil，会出现一大堆的包

![image-20261003112831773](./note11windows应用商店项目.assets/image-20261003112831773.png)

## 4.我们选择第一个，然后点击安装即可

![image-20261003113226866](./note11windows应用商店项目.assets/image-20261003113226866.png)

![image-20261003113310292](./note11windows应用商店项目.assets/image-20261003113310292.png)



## 5.安装成功后会在引用里面看到这个包并且在项目里面生成一个package.config文件

![image-20261003113532656](./note11windows应用商店项目.assets/image-20261003113532656.png)



## 6.给项目添加一个UserControls文件夹，用来存放我们的用户控件

![image-20261003114358989](./note11windows应用商店项目.assets/image-20261003114358989.png)





## 7.然后在这个文件夹里面新建一个用户控件，起名AnApp

![image-20261003114630107](./note11windows应用商店项目.assets/image-20261003114630107.png)



## 8.进入这个用户控件的xaml文件也就是界面设计文件，把grid元素分为2行，然后添加一个图片，放在第一行然后再添加一个Grid元素，把它划分为2行2列然后在里面的Grid里面添加2个TextBlock

![image-20261003130229367](./note11windows应用商店项目.assets/image-20261003130229367.png)

## 9.我们需要删除控件的设计宽度和设计高度，改为使用实际的宽高，并且添加一点边距

![image-20261003131057638](./note11windows应用商店项目.assets/image-20261003131057638.png)

## 10.回到MainWindow.xaml,需要先添加一个命名空间映射到UserControls文件夹，然后我们就可以使用里面的用户控件

![image-20261003131226182](./note11windows应用商店项目.assets/image-20261003131226182.png)

## 11.回到AnApp控件中，给Image元素添加源图片

![image-20261003131416292](./note11windows应用商店项目.assets/image-20261003131416292.png)

### 下一节课，我们会设置源图片为随机抽取的图片

# 3.设置并显示应用2，使用随机图片

## 1.进入AnApp.xaml.cs,在AnApp的构造函数中添加设置随机图片的功能

![image-20261003144242855](./note11windows应用商店项目.assets/image-20261003144242855.png)

### 此时每一次运行应用程序，都会显示不同的图片

![image-20261003144525211](./note11windows应用商店项目.assets/image-20261003144525211.png)



![image-20261003144548255](./note11windows应用商店项目.assets/image-20261003144548255.png)

![image-20261003144614147](./note11windows应用商店项目.assets/image-20261003144614147.png)

## 2.然后我们需要把Zoom Rooms文本替换为图片的基本文件名的文本部分，也就是不要前面的数字和后面的.png，然后我们需要定义2给成员变量，并且用他们来存储图片路径等待的信息

![image-20261003151302140](./note11windows应用商店项目.assets/image-20261003151302140.png)



# 4.在ScrollView中显示多个项目1-通过点击滚动

## 这一节我们将扩展邮箱上面的程序，让他在界面显示一个app列表，如图

![image-20261003153841887](./note11windows应用商店项目.assets/image-20261003153841887.png)

## 4.1 给项目添加一个新的用户控件，起名：AppsViewer

![image-20261003154118817](./note11windows应用商店项目.assets/image-20261003154118817.png)

## 4.2.然后我们进入这个控件的界面文件，把它的设计宽度改为1200，并且添加15像素的边距

![image-20261003154413629](./note11windows应用商店项目.assets/image-20261003154413629.png)





## 4.3我们把Grid分为一行四列，其中由2列的高度的50px宽度另外中间依赖的宽度为除了其他列以外的所有空间和一列为剩余空间的0.02

![image-20261003160818780](./note11windows应用商店项目.assets/image-20261003160818780.png)

## 4.4.然后我们可以先添加一个按钮，宽度为40，高度也是40，有4个像素的边距，文本是<

![image-20261003162352260](./note11windows应用商店项目.assets/image-20261003162352260.png)

## 4.5.然后我们添加一个ScrollViewer，代码有点复杂，需要先设置一个资源

![image-20261003165000884](./note11windows应用商店项目.assets/image-20261003165000884.png)



## 4.6进入AppsViewer.xaml.cs文件，先添加一个成员变量，是一个应用程序AnApp列表，并且是构造函数里面给这个成员变量创建一个List< Anapp>列表实例

![image-20261003170230593](./note11windows应用商店项目.assets/image-20261003170230593.png)

## 4.7.回到MainWindow.xaml,此时我们应该使用AppViewer控件而不是AnApp控件

![image-20261003170735152](./note11windows应用商店项目.assets/image-20261003170735152.png)

## 4.8运行程序，可以看到我们的应用程序

![image-20261003170807676](./note11windows应用商店项目.assets/image-20261003170807676.png)

## 4.9然后还得AppsViwer.xaml中，我们需要添加右侧的按钮

![image-20261003171241202](./note11windows应用商店项目.assets/image-20261003171241202.png)

### 运行程序，效果如下

![image-20261003171334206](./note11windows应用商店项目.assets/image-20261003171334206.png)









# 5.在ScrollView中显示多个项目2-通过点击滚动



# 6.TopApps用户控件



# 7.ProductivityTopApps用户控件



# 8.创建页面并将我们的用户控件添加到其中



# 9.在后台代码和xaml中创建动画



# 10.添加更多选项卡



# 11.修复滚动问题



# 12.构建应用的详情页面的部分内容



# 13.创建应用详情页面



# 14.导航工作原理



# 15.在商店中导航1



# 16.在商店中导航2



# 17.在应用详情中创建概览选项卡



# 18.创建系统要求选项卡



# 19.创建评论选项卡



# 20.相关选项卡



# 21.优化生产力热门应用的外观并且使其可以点击



# 22.优化主热门应用的外观并且使其可以点击



# 23.添加热门应用页面和环绕面板



# 24.添加汉堡菜单



# 25.处理搜索字段点击事件



# 26.准备汉堡菜单应用



# 27.准备汉堡菜单应用列表



# 28.创建会把菜单标题



# 29.完成汉堡菜单



# 30.实现MahApps



# 31.使用MahApps进行样式设计



# 32.使用MahApps汉堡菜单和ObjectDataProvider1



# 33.使用MahApps汉堡菜单和ObjectDataProvider2



# 34.下载页面返回按钮



# 35.附加内容，为你的MahApps添加主题选择器













