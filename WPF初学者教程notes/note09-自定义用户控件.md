# 1.本章介绍

## 在本章中，我们将会创建一个类似于Instagram，Facebook的可以无限滚动加载的应用程序界面。由此来了解MVC架构，已经创建一些可重复使用的用户控件。



# 2.用户控件简介

## 什么是用户控件

![image-20260829193324704](./note09-自定义用户控件.assets/image-20260829193324704.png)

## 如何创建用户控件

![image-20260829193414016](./note09-自定义用户控件.assets/image-20260829193414016.png)

## 用户控件命名空间

![image-20260829195539259](./note09-自定义用户控件.assets/image-20260829195539259.png)

<img src="./note09-自定义用户控件.assets/image-20260829195637969.png" alt="image-20260829195637969" style="zoom:70%;" />



![image-20260829195847826](./note09-自定义用户控件.assets/image-20260829195847826.png)

## 用户控件和窗口和Page有什么不同

WPF 中的 **窗口（Window）**、**页面（Page）** 和 **用户控件（UserControl）** 是构建用户界面的三种核心容器/组件，它们在宿主关系、导航能力和生命周期上存在本质区别。 

| 比较维度           | 窗口 (Window)                        | 页面 (Page)                        | 用户控件 (UserControl)                 |
| ------------------ | ------------------------------------ | ---------------------------------- | -------------------------------------- |
| **本质定位**       | 顶级顶级容器（独立原生窗口）         | 可导航的视图组件                   | 可重用的复合 UI 组件                   |
| **独立运行**       | 可独立弹出、拥有自己的操作系统边框   | 必须宿主于 `Window` 或 `Frame` 中  | 必须嵌入到 `Window` 或 `Page` 中使用   |
| **生命周期与控制** | 支持 `Show()` / `Hide()` / `Close()` | 通过 `NavigationService` 进行跳转  | 随父容器的加载与卸载而变化             |
| **尺寸与边框**     | 拥有完整的标题栏、最大最小化及边框   | 通常不设自身固定大小，自适应容器   | 表现如同普通控件，无独立窗口外壳       |
| **核心适用场景**   | 应用程序主界面或独立弹出对话框       | 类似浏览器形式的页签、步骤导向导航 | 模块化封装、复杂表单或重复利用的局部UI |

### 窗口可以包含页面和用户控件，页面里面也可以包含用户控件。但是用户控件里面不可以包含窗口，也不能包含页面，页面里面也不能包含窗口，因为窗口是顶级控件，不能嵌入到其他控件中，正确的包含关系是窗口包含框架，框架包含页面，页面里面包含用户控件，当然窗口也可以直接包含用户控件。

## 注意： 在应该用户控件里面可以包含一个或者多个其他用户控件。这样做是有意义的。可以构建更加强大的用户控件。



# 3.创建第一个用户控件



# 4.MVC



# 5.创建PostLikedBy用户控件



# 6.重构和使用父控件



# 7.添加视频模型并创建视频帖子



# 8.添加无限滚动和新元素创建



# 9.为我们的Instagram滚动器生成随机图像结尾



# 扩展1：WPF的用户控件和自定义控件

## 一、[用户控件](https://zhida.zhihu.com/search?content_id=237801220&content_type=Article&match_order=1&q=用户控件&zd_token=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJ6aGlkYV9zZXJ2ZXIiLCJleHAiOjE3ODgyMjU1MzAsInEiOiLnlKjmiLfmjqfku7YiLCJ6aGlkYV9zb3VyY2UiOiJlbnRpdHkiLCJjb250ZW50X2lkIjoyMzc4MDEyMjAsImNvbnRlbnRfdHlwZSI6IkFydGljbGUiLCJtYXRjaF9vcmRlciI6MSwiemRfdG9rZW4iOm51bGx9.z4Y_eOPZOYUpWKgBDcGEEC3ht4573PYf46o12SHIwog&zhida_source=entity)（User Control）：

### **1.定义：**

- - 用户控件是由一组现有的 WPF 控件组成，并在一个 [XAML](https://zhida.zhihu.com/search?content_id=237801220&content_type=Article&match_order=1&q=XAML&zd_token=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJ6aGlkYV9zZXJ2ZXIiLCJleHAiOjE3ODgyMjU1MzAsInEiOiJYQU1MIiwiemhpZGFfc291cmNlIjoiZW50aXR5IiwiY29udGVudF9pZCI6MjM3ODAxMjIwLCJjb250ZW50X3R5cGUiOiJBcnRpY2xlIiwibWF0Y2hfb3JkZXIiOjEsInpkX3Rva2VuIjpudWxsfQ.ASkFXUWbFsnno3cKUnHlsbkoAcY4lHZox3AeYrNMh1I&zhida_source=entity) 文件中定义的可重用的控件。它可以包含多个控件，布局和行为，形成一个独立的、可在应用程序中多次使用的模块。

### **2. 组成：**

- - 用户控件的主体是 XAML 文件，其中包含了一组控件的定义和布局。此外，用户控件通常还包含一个关联的代码文件，用于处理与用户控件相关的逻辑。

### **3. 重用性：**

- - 用户控件的设计目的是提高代码的重用性。你可以在不同的窗体或页面中多次使用同一个用户控件，使得界面元素的组合和布局能够在应用程序中重复利用。

### **4.** 创建一个用户控件

创建用户控件是通过组合现有的控件、定义布局、以及可能添加一些代码来实现的。以下是创建一个简单用户控件的步骤：

**步骤 1：创建一个新的 WPF 项目**

1. 在 [Visual Studio](https://zhida.zhihu.com/search?content_id=237801220&content_type=Article&match_order=1&q=Visual+Studio&zd_token=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJ6aGlkYV9zZXJ2ZXIiLCJleHAiOjE3ODgyMjU1MzAsInEiOiJWaXN1YWwgU3R1ZGlvIiwiemhpZGFfc291cmNlIjoiZW50aXR5IiwiY29udGVudF9pZCI6MjM3ODAxMjIwLCJjb250ZW50X3R5cGUiOiJBcnRpY2xlIiwibWF0Y2hfb3JkZXIiOjEsInpkX3Rva2VuIjpudWxsfQ.E04g_duXESHg0pGynPUcVor4AzheHWZCpyrYfdScrvc&zhida_source=entity) 中选择 "文件" -> "新建" -> "项目"。
2. 选择 "WPF 应用程序" 作为项目类型。

**步骤 2：添加一个用户控件**

1. 在项目中，右键单击项目名称，选择 "添加" -> "新建项"。
2. 选择 "WPF 用户控件 (WPF UserControl)"，并为用户控件命名，例如 `MyUserControl.xaml`。

**步骤 3：定义用户控件的 XAML 布局**

打开 `MyUserControl.xaml` 文件，定义用户控件的 XAML 布局。例如：

```text
xamlCopy code
<UserControl x:Class="YourNamespace.MyUserControl"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
             mc:Ignorable="d"
             d:DesignHeight="300" d:DesignWidth="300">
    <Grid>
        <TextBlock Text="Hello from MyUserControl" HorizontalAlignment="Center" VerticalAlignment="Center"/>
    </Grid>
</UserControl> 
```

**步骤 4：使用用户控件**

在你的主窗口或其他页面中使用刚刚创建的用户控件。

```text
xamlCopy code
<Window x:Class="YourNamespace.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:YourNamespace"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <local:MyUserControl/>
    </Grid>
</Window> 
```

在这个例子中，`MyUserControl` 被放置在主窗口的 Grid 中。你可以在 `MyUserControl.xaml` 中定义任意的布局、控件、样式和行为，就像在任何其他 XAML 文件中一样。

用户控件是一种很好的组织和重用界面元素的方式，特别是当你需要在多个地方使用相似的 UI 片段时。

## 二、[自定义控件](https://zhida.zhihu.com/search?content_id=237801220&content_type=Article&match_order=1&q=自定义控件&zd_token=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJ6aGlkYV9zZXJ2ZXIiLCJleHAiOjE3ODgyMjU1MzAsInEiOiLoh6rlrprkuYnmjqfku7YiLCJ6aGlkYV9zb3VyY2UiOiJlbnRpdHkiLCJjb250ZW50X2lkIjoyMzc4MDEyMjAsImNvbnRlbnRfdHlwZSI6IkFydGljbGUiLCJtYXRjaF9vcmRlciI6MSwiemRfdG9rZW4iOm51bGx9.zCARrHiAD94dJrsrsrrdG72qRd2-oZ0-bQ6EFGukYuo&zhida_source=entity)（Custom Control）：

### **1. 定义：**

- - 自定义控件是通过继承现有的 WPF 控件类，并添加自定义的行为和外观，创建全新的控件。自定义控件通常需要在代码中添加一些新的逻辑，以满足特定的需求。

### **2. 组成：**

- - 自定义控件的主体是由代码和 XAML 文件组成的。代码文件包含了新的控件类的定义和行为，而 XAML 文件则定义了控件的外观和模板。

### **3. 重用性：**

- - 自定义控件的设计目的是创建一种具有独特行为和外观的控件，以满足应用程序的特定需求。它可以被重用，但通常设计用于特定的应用程序场景。

### **4.** 创建一个自定义控件

创建自定义控件涉及两个主要方面：定义控件的外观（通过 XAML 模板）和定义控件的行为（通过代码）。以下是创建一个简单自定义按钮控件的步骤：

**步骤 1：创建一个新的 [WPF 控件库](https://zhida.zhihu.com/search?content_id=237801220&content_type=Article&match_order=1&q=WPF+控件库&zd_token=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJ6aGlkYV9zZXJ2ZXIiLCJleHAiOjE3ODgyMjU1MzAsInEiOiJXUEYg5o6n5Lu25bqTIiwiemhpZGFfc291cmNlIjoiZW50aXR5IiwiY29udGVudF9pZCI6MjM3ODAxMjIwLCJjb250ZW50X3R5cGUiOiJBcnRpY2xlIiwibWF0Y2hfb3JkZXIiOjEsInpkX3Rva2VuIjpudWxsfQ.mX98Sflvzhx-tUa-k3H-0JqHE7BPZFOGr58u8G0Iruw&zhida_source=entity)项目**

1. 在 Visual Studio 中选择 "文件" -> "新建" -> "项目"。
2. 选择 "WPF 控件库" 作为项目类型。

**步骤 2：定义 XAML 模板**

1. 在项目中，打开 `Themes\Generic.xaml` 文件，这是用于存放控件模板的地方。
2. 在 `Generic.xaml` 中添加一个新的样式定义，定义你的控件外观。例如，创建一个简单的按钮样式：

```text
<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <Style TargetType="{x:Type local:MyButton}">
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="{x:Type local:MyButton}">
                    <Button Content="{TemplateBinding Content}"
                            Command="{TemplateBinding Command}"
                            Width="100"
                            Height="50"/>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>

</ResourceDictionary>
```

**请注意，local:MyButton 中的 MyButton 是你自定义控件的类名，确保你已经在项目中创建了这个类。**

**步骤 3：定义控件类**

1. 在项目中创建一个新的类，例如 `MyButton.cs`。
2. 在类中继承 `Button` 类，并注册一个 `DependencyProperty` 以便能够通过 XAML 设置属性。

```text
using System.Windows;
using System.Windows.Controls;

namespace YourNamespace
{
    public class MyButton : Button
    {
        public static readonly DependencyProperty MyCustomProperty =
            DependencyProperty.Register("MyCustom", typeof(string), typeof(MyButton));

        public string MyCustom
        {
            get { return (string)GetValue(MyCustomProperty); }
            set { SetValue(MyCustomProperty, value); }
        }
    }
}
```

**步骤 4：使用自定义控件**

1. 在你的 WPF 应用程序中引用创建的 WPF 控件库项目。
2. 在 XAML 中使用你的自定义按钮：

```text
<Window x:Class="YourNamespace.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:YourNamespace"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">

    <Grid>
        <local:MyButton Content="Click me" MyCustom="Custom property value"/>
    </Grid>

</Window>
```

这样，你就成功创建了一个简单的自定义按钮控件，并在应用程序中使用它。你可以根据需要添加更多的样式、属性和行为。

**总结：**

- 用户控件主要用于创建可重用的 UI 模块，通过组合现有的控件，提高代码的重用性。
- 自定义控件主要用于创建具有独特行为和外观的全新控件，通过继承现有的控件类并添加特定逻辑，满足特定的应用程序需求。



# 扩展2，微软官方的自定义控件文档

## https://learn.microsoft.com/zh-cn/dotnet/desktop/wpf/controls/control-authoring-overview



# 扩展3：掘金WPF中用户控件和自定义控件

## https://juejin.cn/post/7197692526520713277



