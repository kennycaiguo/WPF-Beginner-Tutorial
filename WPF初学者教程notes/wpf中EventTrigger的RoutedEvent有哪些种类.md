在 WPF 中，`EventTrigger` 的 `RoutedEvent`（路由事件）按**路由策略（Routing Strategy）\**可以分为\**三种种类**：**冒泡事件（Bubble）**、**隧道事件（Tunnel）\**和\**直接事件（Direct）**。

理论上，只要是向 WPF 事件系统注册的、支持类处理的 `RoutedEvent` 都可以被 `EventTrigger` 使用。

## 一、按路由策略分类的三种种类

- **冒泡事件 (Bubbling)**
  - **特点**：事件从实际触发它的源元素开始向上级父容器传播，直至根元素。
  - **常见例子**：`Button.Click`、`Mouse.MouseEnter`、`Mouse.MouseLeave` 等。
- **隧道事件 (Tunneling)**
  - **特点**：事件从元素树的根向下传导至实际的源元素。名称通常带有 `Preview` 前缀。
  - **常见例子**：`Mouse.PreviewMouseDown`、`Keyboard.PreviewKeyDown` 等。 
- **直接事件 (Direct)**
  - **特点**：不经过元素树的传播，只在事件源本身触发，类似于传统的 CLR 事件，但具备路由事件的特性。
  - **常见例子**：`FrameworkElement.Loaded`、`FrameworkElement.SizeChanged` 等。 

## 二、开发中最常用的高频事件列举

在编写样式（Style）或控制模板（ControlTemplate）中的 `EventTrigger` 时，以下是经常被指定的具体事件：

- **生命周期事件**
  - `FrameworkElement.Loaded`：元素加载完成时触发。
  - `FrameworkElement.Unloaded`：元素卸载时触发。 
- **鼠标交互事件**
  - `Mouse.MouseEnter` / `Mouse.MouseLeave`：鼠标进入或离开控件边界。
  - `Mouse.MouseDown` / `Mouse.MouseUp`：鼠标按下与释放。
- **焦点与状态事件**
  - `UIElement.GotFocus` / `UIElement.LostFocus`：获得或失去焦点时触发。