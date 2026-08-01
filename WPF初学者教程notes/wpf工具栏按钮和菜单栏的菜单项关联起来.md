WPF中将工具栏按钮和菜单栏菜单项关联起来的最佳实践是使用共同的 `RoutedCommand`（路由命令）或绑定到同一个 `ICommand` 视图模型属性。这样可以让它们共享相同的执行逻辑、可用状态（IsEnabled）以及快捷键。 [[1](https://developer.aliyun.com/article/260517)]

方法一：使用 RoutedCommand（原生路由命令）

在代码后台（C#）定义一个公共命令：

csharp

```
public static RoutedCommand MyCommand = new RoutedCommand();
```

 

在窗口的 `CommandBindings` 中添加命令实现：

csharp

```
// 在 Window 构造函数或初始化中
CommandBindings.Add(new CommandBinding(MyCommand, MyCommand_Executed, MyCommand_CanExecute));

private void MyCommand_Executed(object sender, ExecutedRoutedEventArgs e)
{
    // 执行点击后的逻辑
}

private void MyCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
{
    e.CanExecute = true; // 控制是否可用
}
```

 

在 XAML 中将菜单项和工具栏按钮同时指向该命令：

- **菜单项关联：** `<MenuItem Header="新建" Command="{x:Static local:MainWindow.MyCommand}" />`
- **工具栏按钮关联：** `<Button Content="新建" Command="{x:Static local:MainWindow.MyCommand}" />`

方法二：使用 MVVM 模式的 ICommand

如果使用的是 MVVM 架构，让菜单项和按钮绑定到 ViewModel 中的同一个命令属性即可：

- **ViewModel 定义：** `public ICommand SaveCommand { get; }`
- **菜单项关联：** `<MenuItem Header="保存" Command="{Binding SaveCommand}" />`
- **工具栏按钮关联：** `<Button Content="保存" Command="{Binding SaveCommand}" />`