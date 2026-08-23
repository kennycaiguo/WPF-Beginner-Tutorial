# 1.介绍

## 这一章是一个混合章节，我们将学习动画，命令和linq等等技术

# 2.动画1，用xaml制作动画

## 学习内容

![image-20260822142250897](./note08-动画-命令-linq.assets/image-20260822142250897.png)

## 项目演练

## 1.新建一个项目，起名：xamlanimationdemo

![image-20260822142501248](./note08-动画-命令-linq.assets/image-20260822142501248.png)

## 2.然后我们给Grid元素添加触发器集，然后添加一个事件触发器，在里面添加一个BeginStoryBoard标签，在并且里面添加一个StoryBoard标签然后在里面添加一个DoubleAnimation动画

![image-20260822143759596](./note08-动画-命令-linq.assets/image-20260822143759596.png)

## 3.然后我们在Grid里面添加一幅图片

![image-20260822143848078](./note08-动画-命令-linq.assets/image-20260822143848078.png)



## 4.RoutedEvent有一些选项，

![image-20260822154139888](./note08-动画-命令-linq.assets/image-20260822154139888.png)

## 5.比如我们可以把这里的RoutedEvent改为"MouseEnter"

![image-20260822154251281](./note08-动画-命令-linq.assets/image-20260822154251281.png)

### 效果，当我们把鼠标移到图片里面，图片会先消失然后再慢慢出现，持续我们设置的时间



# 3.动画2，用c#制作动画

## 下一节我们尝试用csharp代码来实现动画，

## 1.新建一个wpf项目，起名：csharp-animatin-demo

![image-20260822154710525](./note08-动画-命令-linq.assets/image-20260822154710525.png)





## 2.创建一个StackPanel，把Grid放到它的里面，然后给Grid创建一个标签，并且给Grid起名AniGrid还要给它的Loaded事件添加处理函数，然后在Grid下面创建一个TextBlock这个元素不设置动画效果，只是用来做对比

![image-20260822155443188](./note08-动画-命令-linq.assets/image-20260822155443188.png)

## 3.我们需要做的就是在Grid的Loaded事件处理函数里面实现动画效果，代码如下

![image-20260822163222346](./note08-动画-命令-linq.assets/image-20260822163222346.png)

### 效果

![image-20260822163255554](./note08-动画-命令-linq.assets/image-20260822163255554.png)

![image-20260822163309726](./note08-动画-命令-linq.assets/image-20260822163309726.png)

## 4.我们也可以创建于一个用于修改Grid背景的动画，此时需要ColorAnimation，并且需要2个步骤，第一个就是给Grid创建一个背景对象，填充一个颜色，比如白色，然后我们对这个背景对象使用BeginAnimation方法来改变背景对象的颜色

![image-20260822173739676](./note08-动画-命令-linq.assets/image-20260822173739676.png)

### 效果

![Snipaste_2026-08-22_17-39-30](./note08-动画-命令-linq.assets/Snipaste_2026-08-22_17-39-30.png)

![image-20260822174004023](./note08-动画-命令-linq.assets/image-20260822174004023.png)

## 5.我们还可以在MouseEnter事件里面使用动画

![image-20260822174519769](./note08-动画-命令-linq.assets/image-20260822174519769.png)



![image-20260822174651311](./note08-动画-命令-linq.assets/image-20260822174651311.png)

### 效果

![image-20260822174729934](./note08-动画-命令-linq.assets/image-20260822174729934.png)

# 4.命令1-设置关闭命令



# 5.linq简介



# 6.筛选奇数和偶数



# 7.linq2，使用linq对列表排序



# 8.语音合成器



