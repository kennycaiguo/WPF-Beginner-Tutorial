**为 ObservableCollection 对象添加数据，应该使用 Add 方法**。C# 的 `ObservableCollection` 原生并没有 `Append` 方法（`Append` 是 LINQ 提供的查询操作符，返回一个新的序列，不会修改原集合）。

方法对比

- **Add 方法**：
  - 修改原集合。
  - 在末尾添加元素。
  - 触发通知事件更新 UI。
- **Append 方法**：
  - 不修改原集合。
  - 属于 LINQ 延迟查询。
  - 返回新序列。

正确用法

- `collection.Add(item);`