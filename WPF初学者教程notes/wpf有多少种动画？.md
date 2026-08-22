# wpf的动画种类

在WPF（Windows Presentation Foundation）中，动画按**实现方式与作用机制**主要分为**3大类**，而根据不同的目标数据类型又衍生出了**数十个具体的类**。所有的WPF动画都继承自基类 `Timeline`，位于 `System.Windows.Media.Animation` 命名空间下。

## 一、 WPF动画的三大核心类型

- **From/To/By 动画（基本线性/基础动画）**：在起始值（From）、结束值（To）或偏移量（By）之间进行平滑的线性或缓动过渡。

- **关键帧动画（Key-Frame Animations）**：允许在指定的多个时间点（KeyTime）设置不同的目标值（Value），支持离散、线性、样条三次平滑插值，能做出极其复杂的变向和变速效果。

- **路径动画（Path Animations）**：让对象或坐标沿着一条几何路径（PathGeometry）进行移动或旋转。

   

## 二、 按目标数据类型分类的常用具体动画类

因为WPF动画本质是在一段时间内修改某个**依赖属性的值**，所以针对不同的数据类型有专属的动画类：

### 1. 基础 From/To/By 动画

- **DoubleAnimation**：操作 `Double` 类型属性（如 `Width`、`Height`、`Opacity`、`Angle`）。

- **ColorAnimation**：操作 `Color` 类型属性（如背景色、前景色渐变）。

- **PointAnimation**：操作 `Point` 类型坐标点属性。

- **ThicknessAnimation**：操作边距或厚度属性（如 `Margin`、`Padding`）。

- **RectAnimation**：操作矩形区域属性。

- **SizeAnimation**：操作尺寸大小属性。

- **CharAnimation / BooleanAnimation**：分别用于字符和布尔值的离散切换。

   

### 2.关键帧动画 (`*AnimationUsingKeyFrames`)

每种数据类型都对应一个关键帧版本，用来做多阶段组合动画

- **DoubleAnimationUsingKeyFrames**

- **ColorAnimationUsingKeyFrames**

- **PointAnimationUsingKeyFrames**

- **ThicknessAnimationUsingKeyFrames**

   

### 3.路径动画 (`*AnimationUsingPath`)

让元素沿着矢量路径运动：

- **DoubleAnimationUsingPath**：沿路径改变双精度值（通常用于控制进度或偏移）。
- **PointAnimationUsingPath**：沿路径改变坐标点（实现对象轨迹移动）。
- **MatrixAnimationUsingPath**：沿路径改变矩阵变换（实现位置与角度的连续复合运动）