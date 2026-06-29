WPF 有5种 **画刷** 和1种自定义画刷，都是继承自基类 **Brush**

![img](https://pica.zhimg.com/v2-b864825b6728459c8c70da2d4b59d97e_1440w.jpg)



| 常用属性 | 描述                          |
| -------- | ----------------------------- |
| Opacity  | 透明度（取值区间在 0-1 之间） |
| Color    | 填充颜色                      |

### **1** 实心画刷**（**SolidColorBrush**）**

实心画刷：填充 **单一** 颜色

例子：

```html
    <Grid>
        <Rectangle Width="100" Height="100" >
            <Rectangle.Fill>
                <SolidColorBrush Color="LightGreen" Opacity="0.555"/>
            </Rectangle.Fill>
        </Rectangle>
    </Grid>
```

或者：

```html
    <Grid>
        <Rectangle Width="100" Height="100" Fill="LightGreen" Opacity="0.5555"/>
    </Grid>
```

> 两种写法都一样，矩形的Fill属性为画刷Brush类型，Fill 为附加属性，可以直接对其赋值。

![img](https://pic2.zhimg.com/v2-e54b7c19af10833a3b6413dc61c61a77_1440w.jpg)

------

### **2** 梯度画刷**（**GradientBrush**）**

梯度画刷：填充 **渐变** 颜色

**4.2.1 LinearGradientBrush（线性梯度画刷）**

直线型渐变色填充

| 常用属性   | 描述                                       |
| ---------- | ------------------------------------------ |
| StartPoint | 起始位置坐标（取值区间 0~1）               |
| EndPoint   | 结束位置坐标（取值区间 0~1）               |
| Offset     | 渐变向量中渐变停止点的位置（取值区间 0~1） |

例子：

```html
    <Canvas>
        <Rectangle Canvas.Top="0" Height="100" Width="492">
            <Rectangle.Fill>  //起始坐标涉及到角度问题，相当于是X,Y的夹角，
                <LinearGradientBrush StartPoint="0,0" EndPoint="1,0"> //X为1时，为横向渐变
                    <GradientStop Color="Yellow"  Offset="0"/> //Offset为渐变点，两个渐变点的大小决定了颜色变化方向，颜色总是从小往大变化
                    <GradientStop Color="Green"   Offset="1"/>
                </LinearGradientBrush>
            </Rectangle.Fill>
        </Rectangle>
        <Rectangle Canvas.Bottom="0" Height="100" Width="492">
            <Rectangle.Fill>
                <LinearGradientBrush StartPoint="0,0" EndPoint="0,1"> //Y为1时，为纵向渐变
                    <GradientStop Color="Blue"     Offset="1"/> //如果Offset值相同，那么按照代码顺序取两者中位置靠前的颜色
                    <GradientStop Color="purple"  Offset="0"/>
                </LinearGradientBrush>
            </Rectangle.Fill>
        </Rectangle>
    </Canvas>
```

![img](https://pic4.zhimg.com/v2-716a463a6afe0bb85c4a7733ff4307d7_1440w.jpg)

![img](https://pic4.zhimg.com/v2-228e6bdcb7fec1a46f53174812074ab1_1440w.jpg)

------

**4.2.2 RadialgradientBrush(圆形梯度画刷)**

圆形渐变色填充

| 常用属性             | 描述                                    |
| -------------------- | --------------------------------------- |
| Point GradientOrigin | 渐变开始的二维焦点的坐标（取值区间0~1） |
| Point Center         | 渐变的最外面圆的中心坐标（取值区间0~1） |
| double RadiusX       | 渐变的最外面圆的水平半径（按比例）      |
| double RadiusY       | 渐变的最外面圆的垂直半径（按比例）      |

例子：

```html
    <Grid>
        <Rectangle Height="200" Width="200">
            <Rectangle.Fill>
                <RadialGradientBrush GradientOrigin="0.5,0.5" Center="0.5,0.5" RadiusX="0.5" RadiusY="0.5">
                    <RadialGradientBrush.GradientStops>
                        <GradientStop Color="White"      Offset="0"/>
                        <GradientStop Color="Yellow"    Offset="0.25"/>
                        <GradientStop Color="Orange"  Offset="0.75"/>
                        <GradientStop Color="Red"        Offset="1"/>
                    </RadialGradientBrush.GradientStops>
                </RadialGradientBrush>
            </Rectangle.Fill>
        </Rectangle>
    </Grid>
```

![img](https://pic4.zhimg.com/v2-f10123dfea4eeaedab551e54960cbe23_1440w.jpg)

------

### **3** 图像画刷**（**ImageBrush**）**

使用图像进行填充

| 常用属性                | 描述                                       |
| ----------------------- | ------------------------------------------ |
| ImageSource ImageSource | 图像来源地址，可以是本地地址也能是网络地址 |
| TileMode TileMode       | 枚举类，填充绘画区域类型                   |
| Stretch Stretch         | 枚举类，内容拉伸类型                       |

```html
    <Grid>
        <Rectangle Height="200" Width="200">
            <Rectangle.Fill>
                <ImageBrush ImageSource="./Image/liulanqi.png"/>
            </Rectangle.Fill>
        </Rectangle>
    </Grid>
```

![img](https://pic1.zhimg.com/v2-d76492a2dc1c666d4d90d52c7699b694_1440w.jpg)

例子：

```html
    <Grid>
        <Rectangle  Height="180" Width="400">
            <Rectangle.Fill> //网络地址（下面的图片是我之前资料发的网络地址）
                <ImageBrush ImageSource="https://pic2.zhimg.com/80/v2-9a6d05baf8187dc44643ce7689287d7d_720w.jpg"/>
            </Rectangle.Fill>
        </Rectangle>
    </Grid>
```

![img](https://pic4.zhimg.com/v2-65fa763e0574379e32fc42b7c719ceb5_1440w.jpg)

------

### **4** 控件画刷**（**VisualBrush**）**

使用控件进行填充

| 常用属性          | 描述                     |
| ----------------- | ------------------------ |
| TileMode TileMode | 枚举类，填充绘画区域类型 |
| Stretch Stretch   | 枚举类，内容拉伸类型     |

例子：

```html
    <Window.Resources>
        <VisualBrush x:Key="test" TileMode="Tile" Stretch="Fill">
            <VisualBrush.Visual>
                <StackPanel>
                    <Rectangle Height="50" Width="50" Fill="Gold"/>
                    <Rectangle Height="50" Width="50" Fill="LightBlue"/>
                    <Rectangle Height="50" Width="50" Fill="LightGray"/>
                    <Rectangle Height="50" Width="50" Fill="Pink"/>
                </StackPanel>
            </VisualBrush.Visual>
        </VisualBrush>
    </Window.Resources>
    <Grid>
        <Border Height="200" Width="400" Background="{StaticResource test}"/>
    </Grid>
```

![img](https://picx.zhimg.com/v2-0d10c2f05cda112bdbba96c42473a847_1440w.jpg)



例子：

```html
    <Grid>
        <Rectangle Height="200" Width="400">
            <Rectangle.Fill>
                <VisualBrush>
                    <VisualBrush.Visual>
                        <StackPanel>
                            <TextBlock Foreground="White" Text="text"/>
                            <TextBlock Foreground="White" Text="text2"/>
                        </StackPanel>
                    </VisualBrush.Visual>
                </VisualBrush>
            </Rectangle.Fill>
        </Rectangle>
    </Grid>
```

![img](https://pic1.zhimg.com/v2-a5dd1aac1d3dcb7965596859104aa496_1440w.jpg)

------

### **5** 自定义画刷**（**DrawingBrush**）**

可以自定义形状，填充，边框

| 常用属性          | 描述         |
| ----------------- | ------------ |
| Brush Brush       | 设置填充画刷 |
| Pen Pen           | 设置填充画笔 |
| Geometry Geometry | 设置填充形状 |

```html
    <Window.Resources>
        <DrawingBrush x:Key="test">
            <DrawingBrush.Drawing>
                <DrawingGroup>
                    <DrawingGroup.Children>
                        <GeometryDrawing>
                            <!-- 绘制矩形 -->
                            <GeometryDrawing.Geometry>
                                <RectangleGeometry RadiusX="0.2" RadiusY="0.5"
                                                   Rect="0.02,0.02,0.96,0.96"/>
                            </GeometryDrawing.Geometry>
                            <!-- 矩形填充 -->
                            <GeometryDrawing.Brush>
                                <LinearGradientBrush StartPoint="0,0" EndPoint="0,1">
                                    <GradientStop Color="Yellow" Offset="0"/>
                                    <GradientStop Color="Red"   Offset="1"/>
                                </LinearGradientBrush>
                            </GeometryDrawing.Brush>
                            <!-- 矩形边框 -->
                            <GeometryDrawing.Pen>
                                <Pen Thickness="0.02">
                                    <Pen.Brush>
                                        <LinearGradientBrush StartPoint="0,0" EndPoint="0,1">
                                            <GradientStop Color="AliceBlue" Offset="0"/>
                                            <GradientStop Color="Black"     Offset="1"/>
                                        </LinearGradientBrush>
                                    </Pen.Brush>
                                </Pen>
                            </GeometryDrawing.Pen>
                        </GeometryDrawing>
                    </DrawingGroup.Children>
                </DrawingGroup>
            </DrawingBrush.Drawing>
        </DrawingBrush>
    </Window.Resources>
    <Grid>
        <Button Background="{StaticResource ResourceKey=test}"
                Name="button1" FontSize="40" Content="Button"
                Foreground="White" Height="113" Width="292"/>
    </Grid>
```

![img](https://pic1.zhimg.com/v2-a7c8fa68ab515ba8a6f677e8737d1760_1440w.jpg)

## 参考文档：https://www.cnblogs.com/huangxincheng/archive/2012/07/14/2591941.html