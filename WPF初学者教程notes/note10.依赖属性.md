# 1.依赖属性介绍

## 1》CLR属性

所谓的clr属性就是一个公共的有setter和getter或者只有getter，能够在里面操作一个私有字段的成员。如下图，_myProperty

是私有字段，MyProperty就是属性，属性必须是公有的。

![image-20260913114206057](./note10.依赖属性.assets/image-20260913114206057.png)

### 属性的MSDN定义

![image-20260913121026975](./note10.依赖属性.assets/image-20260913121026975.png)

### 属性的特点

![image-20260913121451875](./note10.依赖属性.assets/image-20260913121451875.png)

### 如何创建属性

![image-20260913121814298](./note10.依赖属性.assets/image-20260913121814298.png)

## 2.依赖属性

### 什么是依赖属性以及他的特点

![image-20260913124223654](./note10.依赖属性.assets/image-20260913124223654.png)

### 依赖属性的用途

![image-20260913124945190](./note10.依赖属性.assets/image-20260913124945190.png)

## 3》xaml中依赖属性的使用

![image-20260913125701497](./note10.依赖属性.assets/image-20260913125701497.png)

#### 效果对比

![image-20260913131022295](./note10.依赖属性.assets/image-20260913131022295.png)

#### 这个xaml代码的csharp等效代码

![image-20260913131342943](./note10.依赖属性.assets/image-20260913131342943.png)

## 4》在csharp中定义依赖属性的正确做法

![image-20260913171007607](./note10.依赖属性.assets/image-20260913171007607.png)

## 注意：

![image-20260913171655167](./note10.依赖属性.assets/image-20260913171655167.png)

## 小示例

![image-20260913172941062](./note10.依赖属性.assets/image-20260913172941062.png)

# 2.使用依赖属性

## 2.1新建一个项目起名：DependancyPropertyDemo

![image-20260919104635687](./note10.依赖属性.assets/image-20260919104635687.png)



## 2.2 我们把xaml中的Grid改为StackPanel，然后我们添加一个TextBlock元素并且给它添加样式触发器，可以实现当鼠标悬停在文本上面，文本变为深粉红色，移开鼠标，文本又变为原来的颜色。

![image-20260919115603900](./note10.依赖属性.assets/image-20260919115603900.png)

![image-20260919115635996](./note10.依赖属性.assets/image-20260919115635996.png)







![image-20260919115651578](./note10.依赖属性.assets/image-20260919115651578.png)



## 2.3在上面案例中，这个IsMouseOver属性就是一个依赖属性，触发器只有当它的值是True，才会执行特定的操作，比如，这里是把文本是颜色改为深分红色。

![image-20260919122607318](./note10.依赖属性.assets/image-20260919122607318.png)





# 3.创建我们自己的依赖属性并且使用

## 3.1 创建一个CustomDependancyPropertyDemo项目，把根元素改为StackPanel

![image-20260919133008418](./note10.依赖属性.assets/image-20260919133008418.png)

## 3.2.给项目添加一个UserControls文件夹，并且在里面创建一个MyUC用户控件

![image-20260919133220708](./note10.依赖属性.assets/image-20260919133220708.png)

## 3.3.进入MyUC控件的后台代码，用propdp快捷键创建一个依赖属性

![image-20260919133753321](./note10.依赖属性.assets/image-20260919133753321.png)

## 3.4.如果你需要修改名称，在代码生成后按tab键，就可以修改名称，我们把它改为Awesomeness

![image-20260919134112900](./note10.依赖属性.assets/image-20260919134112900.png)

## 3.4.为了能够在MainWindow.xaml文件里面使用这个用户控件，我们创建一个uc命名空间指向UserControls文件夹

![image-20260919134759859](./note10.依赖属性.assets/image-20260919134759859.png)

## 3.5.然后我们需要在用户控件的上面创建一个按钮，并且添加点击事件处理函数，我们想点击按钮来修改控件的Awesomeness的值，并且设置一个触发器，当Awesomeness的值达到我们设置的阈值，就会关闭用户控件的背景色。并且我们把Awesomeness的值绑定到Label控件的Content属性中使得它可见。

![image-20260919142501165](./note10.依赖属性.assets/image-20260919142501165.png)

## 3.6.为了使得触发器有效果，我们必须给MyUC控件设置宽高，否则没有效果

![image-20260919142722093](./note10.依赖属性.assets/image-20260919142722093.png)

## 3.7.然后我们需要在主窗口的后台代码中的按钮点击事件处理函数里面增加Awesomeness的值

![image-20260919142833228](./note10.依赖属性.assets/image-20260919142833228.png)

### 3.8 运行程序，效果如下

![image-20260919143300731](./note10.依赖属性.assets/image-20260919143300731.png)



# 扩展： 依赖属性参考文档1：

## https://www.cnblogs.com/gyweiUSTC/articles/2089209.html

![image-20260919143326084](./note10.依赖属性.assets/image-20260919143326084.png)

# 扩展： 依赖属性参考文档2：

## https://zhuanlan.zhihu.com/p/656341232
