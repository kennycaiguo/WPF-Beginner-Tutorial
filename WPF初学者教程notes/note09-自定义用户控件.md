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

## 案例

![image-20260829201315561](./note09-自定义用户控件.assets/image-20260829201315561.png)

![image-20260829201402543](./note09-自定义用户控件.assets/image-20260829201402543.png)

![image-20260829201458685](./note09-自定义用户控件.assets/image-20260829201458685.png)





# 3.创建第一个用户控件

## 1.新建一个项目，起名：InstaUserControlDemo

![image-20260905111123347](./note09-自定义用户控件.assets/image-20260905111123347.png)





## 2.给项目添加一个Icons文件夹，把一些图片放进来

![image-20260905115746856](./note09-自定义用户控件.assets/image-20260905115746856.png)



## 3.给项目添加一个用户控件，起名：PostControl.xaml,在Grid里面添加一个StackPanel面板，然后在它里面添加点赞，评论和发送图标，在StackPanel下面添加一个bookmark图标

![image-20260905122856174](./note09-自定义用户控件.assets/image-20260905122856174.png)

## 4.进入PostControl的后台文件，创建一个PostLiked属性，用来保存帖子是否被点赞

![image-20260905122509808](./note09-自定义用户控件.assets/image-20260905122509808.png)

## 5.然后我们创建一个方法来将一个帖子标记为已经点赞

![image-20260905124152668](./note09-自定义用户控件.assets/image-20260905124152668.png)

## 6.然后我们需要创建一个取消点赞的方法，实现类似的逻辑，只是图片不一样

![image-20260905124449823](./note09-自定义用户控件.assets/image-20260905124449823.png)



## 7.然后我们来实现Heart_MouseDown方法的代码，非常简单，当你点击一些这个图片，如果它之前没有被点赞，就执行点赞方法，如果它已经被点赞，就这些取消点赞的方法

![image-20260905124948044](./note09-自定义用户控件.assets/image-20260905124948044.png)

## 8.进入MainWindow.xaml,在里面调用我们的PostControl控件

![image-20260905125232168](./note09-自定义用户控件.assets/image-20260905125232168.png)

## 9.运行程序，界面如下，此时非常丑，但是没有关系我们只是想测试一下我们的代码逻辑是否工作正常

![image-20260905125350965](./note09-自定义用户控件.assets/image-20260905125350965.png)

## 10.点击爱心图片，发现它变红了，说明LikePost方法工作正常

![image-20260905125501748](./note09-自定义用户控件.assets/image-20260905125501748.png)

## 11.再点击一下爱心，它又把握白色，说明UnLikePost方法工作也正常

![image-20260905125604567](./note09-自定义用户控件.assets/image-20260905125604567.png)

## 12.当然我们可以把控件的高度改为40，此时效果如下

![image-20260905132028629](./note09-自定义用户控件.assets/image-20260905132028629.png)



# 4.MVC，不太好用，现在流行mvvm

## MVC架构图解

![image-20260905135527342](./note09-自定义用户控件.assets/image-20260905135527342.png)

## MVC核心组件与职责

### Model（模型）

**职责**：处理业务逻辑和数据操作（如数据库访问、计算规则）。
**示例**：

```
csharp复制public class UserModel {
    public int Id { get; set; }
    public string Name { get; set; }
    public UserModel GetUserById(int id) {
        return new UserModel { Id = id, Name = "张三" }; // 模拟数据获取
    }
}
```

### View（视图）

**职责**：展示数据（UI界面），接收用户输入，依赖Model但不含业务逻辑。
**Web示例（Razor视图）**：

```html
@model UserModel
<h1>用户详情</h1>
<p>ID：@Model.Id</p>
<p>姓名：@Model.Name</p>
```

### Controller（控制器）

**职责**：处理用户请求，协调Model和View（如调用Model方法、传递数据给View）。
**示例**：

```
public class UserController : Controller {
    public ActionResult Detail(int id) {
        var userModel = new UserModel();
        var user = userModel.GetUserById(id);
        return View(user); // 传递数据给View
    }
}
```

## MVC工作流程

1. **用户操作**（如点击按钮）触发请求。
2. **Controller接收请求**，调用Model处理数据。
3. **Model返回数据**给Controller。
4. **Controller传递数据给View**，View渲染并展示结果。

**特点**：View和Controller双向交互，Controller直接控制View更新。

## MVC的变体与对比

### MVP（Model-View-Presenter）

- **改进点**：解耦View和Model，通过Presenter中间层处理逻辑。
- **适用场景**：WinForm/WPF桌面应用，测试性优于MVC。
- **缺点**：Presenter可能臃肿（需手动更新View接口）。

### MVVM（Model-View-ViewModel）

- **核心**：数据绑定（如WPF的`INotifyPropertyChanged`），消除手动更新代码。
- **适用场景**：现代C#界面框架（WPF/MAUI/Blazor），解耦和可维护性最优。

**对比表**：

| 特性         | MVC                    | MVP                   | MVVM                   |
| :----------- | :--------------------- | :-------------------- | :--------------------- |
| **解耦方式** | View-Controller耦合    | View-Presenter接口    | View-ViewModel数据绑定 |
| **交互方式** | Controller直接更新View | Presenter调用View接口 | 数据绑定自动更新       |
| **测试性**   | 中等                   | 较高                  | 最高                   |
| **适用框架** | ASP.NET MVC            | WinForm（早期）       | WPF/MAUI/Blazor        |

## 最佳实践与注意事项

1. **职责分离**
   - Model不依赖View或Controller，确保业务逻辑可复用。
   - Controller仅处理请求协调，避免包含复杂逻辑（可抽离到Service层）。
2. **依赖注入（DI）**
   - 使用`IServiceCollection`注册服务（如`services.AddScoped<IUserService, UserService>()`），降低耦合度。
3. **异步处理**
   - 在Controller中使用`async/await`提升性能（如`public async Task<ActionResult> DetailAsync(int id)`）。
4. **避免过度分层**
   - 小型项目可简化设计（如合并Service层与Model）。

## 总结

- **MVC**：适合简单Web应用（如ASP.NET MVC），开发速度快但View-Controller耦合略高。
- **MVP**：适合早期桌面应用，通过Presenter解耦View和Model。
- **MVVM**：现代C#界面开发首选（如WPF），数据驱动设计，解耦和可维护性最优。

**选择原则**：

- 简单Web项目用MVC；
- 现代桌面/跨平台应用用MVVM；
- MVP仅作为过渡或老项目维护场景使用。

通过合理应用MVC模式，可显著提升代码的可读性、可测试性和可扩展性。



# 5.创建PostLikedBy用户控件

## 项目演练，还是上面的项目，我们来实现统计功能

![image-20260905161344987](./note09-自定义用户控件.assets/image-20260905161344987.png)



## 1.给项目新建一个新的用户控件起名：PostLikedBy

![image-20260905161636502](./note09-自定义用户控件.assets/image-20260905161636502.png)



## 2.把Grid元素改为StackPanel，然后用TextBlock来显示对应的事件，由于我们这里没有使用数据库，暂时是硬编码，等到我们使用数据库，这些数据都需要从数据库里面获取

![image-20260905165001340](./note09-自定义用户控件.assets/image-20260905165001340.png)

## 3.然后我们需要把这个控件添加到主窗口，并且放在上一节课的控件的下面

![image-20260905165110492](./note09-自定义用户控件.assets/image-20260905165110492.png)



# 6.重构和使用父控件

## 1.还是上面的项目，我们给项目创建一个UserControls文件夹，把我们的用户控件统统移动到里面

![image-20260905170229070](./note09-自定义用户控件.assets/image-20260905170229070.png)



## 2.然后我们给UserControls文件夹添加一个PicturePost用户控件

![image-20260905170449842](./note09-自定义用户控件.assets/image-20260905170449842.png)



## 3.然后我们把前面两个用户控件都添加到PicturePost用户控件里面作为它的子控件，然后把MainWindow里面的那两个控件引用删除。然后我们需要先创建一个命名空间映射uc，指向UserControls文件夹，然后就可以引用PicturePost用户控件了

![image-20260905171548578](./note09-自定义用户控件.assets/image-20260905171548578.png)

## 4.那么，问题来了，在PicturePost用户控件里面如何引用PostControl控件和PostLikedBy控件？原来也是通过local标签来使用，注意，需要设置高度

![image-20260905171950743](./note09-自定义用户控件.assets/image-20260905171950743.png)

## 5.然后我们个堆叠面板添加一个图片，为了能够使得图片支持双击，需要把图片放到一个ContentControl容器里面，这是因为图片没有鼠标双击事件，而内容控件有鼠标双击事件，注意，这里的图片有点大，我们需要把它的高度设置小一点，否则看不到下面两个控件(注意，老师的有些写法已经过时，在vs2022里面不工作。)

![image-20260905173752820](./note09-自定义用户控件.assets/image-20260905173752820.png)

## 6.也可以不限制图片的高度，然后我们回到MainWindow.xaml中，修改主窗口的高度为800，宽度为450px

![image-20260905174231714](./note09-自定义用户控件.assets/image-20260905174231714.png)

## 7.运行程序，效果如下

<img src="./note09-自定义用户控件.assets/image-20260905174340396.png" alt="image-20260905174340396" style="zoom:50%;" />





## 8.然后我们给内容控件的鼠标双击事件处理程序添加处理代码，我们在这里实现的功能是如果没有点赞，双击图片会触发点赞操作，如果点赞了，双击图片会触发取消点赞操作

![image-20260905182556097](./note09-自定义用户控件.assets/image-20260905182556097.png)

## 9.运行程序效果如下

![image-20260905182727455](./note09-自定义用户控件.assets/image-20260905182727455.png)

![image-20260905182823688](./note09-自定义用户控件.assets/image-20260905182823688.png)

### 当然也可以点击爱心触发点赞，双击图片取消点赞或者双击图片触发点赞，点击爱心触发取消点赞。。。

## 10.然后我们给项目添加一个Models文件夹，然后在Models文件夹里面创建一个类，起名：PicturePostModel

![image-20260905183227445](./note09-自定义用户控件.assets/image-20260905183227445.png)



## 11.我们给这个类添加一个属性，是BitmapImage类的变量。

![image-20260905183505068](./note09-自定义用户控件.assets/image-20260905183505068.png)



# 7.添加视频模型并创建视频帖子

## 这里有一个网站可以下载小视频：https://www.pexels.com/search/videos/little-girl/

## 此外，还可以在pinterest网站查找视频，然后点击分享-复制链接，粘贴到这个网站就可以解析下载： https://www.savepin.onl/

## 1.还是上面的项目，我们给项目新建一个Videos文件夹，把一个跳舞的开通视频粘贴过来

![image-20260905203013284](./note09-自定义用户控件.assets/image-20260905203013284.png)



## 2.然后我们回到MainWindow.xaml中，把创建控件的代码删除，然后给StackPanel添加一个名称：MainStackPanel

![image-20260912092621799](./note09-自定义用户控件.assets/image-20260912092621799.png)

## 3.然后，我们给项目创建一个VideoPost用户控件

![image-20260912093054418](./note09-自定义用户控件.assets/image-20260912093054418.png)



## 4不知道什么原因，wpf找不到控件，所以我重新创建了一个FakeInstaGUI项目，把前面的代码添加进来，然后我们来编辑我们的VideoPost控件，我们先把PicturePost控件的内容粘贴过来。然后再来修改

![image-20260912104308992](./note09-自定义用户控件.assets/image-20260912104308992.png)

## 5.把Image标签改为MediaElement标签

![image-20260912105224510](./note09-自定义用户控件.assets/image-20260912105224510.png)



## 6.我们给项目创建一个Database文件夹，在里面添加一下模拟从数据库获取数据的代码，下面的步骤会用到，我们在里面新建一个MockDb类。代码如下

![image-20260912111006958](./note09-自定义用户控件.assets/image-20260912111006958.png)

### 注意，这是一个静态方法

## 7.由于我们使用的是mvc架构，我们需要给视频帖子创建一个模型，我们在Models文件夹里面创建一个VideoPostModel类

![image-20260912111403780](./note09-自定义用户控件.assets/image-20260912111403780.png)

## 8.回到VideoPost控件的后台代码，我们需要重写VideoPost类的构造函数

![image-20260912112154412](./note09-自定义用户控件.assets/image-20260912112154412.png)

## 9.然后我们回到MainWindow.xaml.cs在，在这里使用csharp代码来显示我们的控件

![image-20260912113041841](./note09-自定义用户控件.assets/image-20260912113041841.png)

## 9.2 其实我们需要修改一下VideoPost控件里面的视频元素的高度，设置为380

![image-20260912134220029](./note09-自定义用户控件.assets/image-20260912134220029.png)

## 10.回到VideoPost.xaml中，给视频元素所在的内容控件的双击事件函数添加事件处理代码，前提是需要给PostControl子控件起个名字，如pCtrl

![image-20260912113532205](./note09-自定义用户控件.assets/image-20260912113532205.png)

## 11.运行程序，效果如下，视频会自动播放

![image-20260912123851990](./note09-自定义用户控件.assets/image-20260912123851990.png)

## 12.双击视频会点赞，

![image-20260912124006660](./note09-自定义用户控件.assets/image-20260912124006660.png)

## 13.再双击视频，又会取消点赞

![image-20260912134330207](./note09-自定义用户控件.assets/image-20260912134330207.png)



# 8.添加无限滚动和新元素创建

## 1.上一节课我们实现了最基本的内容，就是显示控件，但是此时应用程序还没有滚动加载功能，我们这一节课来实现一下，进入MainWindow.xaml文件中，把StackPanel放在一个ScrollViewer中，并且ScrollViewer取名：MainScrollViewer，然后把它的垂直滚动条隐藏并且沟通添加一个ScrollChanged事件处理函数

![image-20260912135515235](./note09-自定义用户控件.assets/image-20260912135515235.png)



## 2.然后我们给这个事件处理函数添加事件处理代码，首先我们需要夺添加2个控件到堆叠面板中，使得它有内容来滚动

![image-20260912140004402](./note09-自定义用户控件.assets/image-20260912140004402.png)

## 3.然后进入滚动事件处理函数，添加下面的代码，但是这个代码暂时不太完美，只是保证能够实现功能，我们以后会与优化

![image-20260912154318360](./note09-自定义用户控件.assets/image-20260912154318360.png)

### 运行程序，此时你往下滑动鼠标滚轮，就会不断有帖子网上滚动。当然暂时还是同一幅图片





# 9.为我们的Instagram滚动器生成随机图像结尾

## 1.这一节课我们来完成我们的仿Instagram程序，我们首先实现的功能就是当用户往下滚动鼠标滚轮，我们需要使用随机抽取图片来创建帖子，不要老是使用同一幅图片，我们需要在PostPictureModel里面模拟从数据库获取图片链接的功能。我们首先需要修改一下PicturePost类的构造函数

![image-20260912160612356](./note09-自定义用户控件.assets/image-20260912160612356.png)

## 2.然后我们需要在MockDb里面添加模拟从数据库里面获取图片的代码

![image-20260912174100648](./note09-自定义用户控件.assets/image-20260912174100648.png)



## 3.回到PicturePostModel中，我们需要创建一个私有字段_postImage,然后在PostImage属性的getter中获取这个值在wetter中设置这个值

![image-20260912174856100](./note09-自定义用户控件.assets/image-20260912174856100.png)

## 4.然后我们需要回到MainWindow.axml.cs中，把代码修改一下

![image-20260912175322264](./note09-自定义用户控件.assets/image-20260912175322264.png)

## 5.运行程序，此时我们滚动鼠标滚轮，就能够随机获取图片来生成帖子了。

![image-20260912175629825](./note09-自定义用户控件.assets/image-20260912175629825.png)



## 6.其实我们还可以扩展运行VideoPostModel,让他也能够随机生成视频帖子

![image-20260912180958508](./note09-自定义用户控件.assets/image-20260912180958508.png)

## 7.运行程序，分析视频可以随机选取了

![image-20260912181052082](./note09-自定义用户控件.assets/image-20260912181052082.png)



![image-20260912181120562](./note09-自定义用户控件.assets/image-20260912181120562.png)

## 7.我们还可以在主窗口的后台文件里面也使用随机数来决定创建帖子的时候是创建图片帖子还是视频帖子

![image-20260912191832322](./note09-自定义用户控件.assets/image-20260912191832322.png)





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



