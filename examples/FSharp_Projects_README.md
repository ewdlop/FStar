# F# 項目編譯指南

本目錄包含了一個統一的 F# 庫項目文件（`Examples.fsproj`），可以用來將所有 F* 示例編譯為 F# 代碼。

## 項目結構

`Examples.fsproj` 包含了以下示例：

### Algorithms（算法）
- BinarySearch - 二分搜索
- InsertionSort - 插入排序
- MergeSort - 歸併排序
- QuickSort - 快速排序（List、Array、Seq 版本）
- GenericSort - 通用排序
- Huffman - 霍夫曼編碼
- 以及其他算法示例

### Data Structures（數據結構）
- BinarySearchTree - 二叉搜索樹
- BinaryTrees - 二叉樹
- BinomialQueue - 二項式堆
- LeftistHeap - 左偏堆
- Lens - 透鏡
- RBTree - 紅黑樹
- Vector - 向量
- 以及其他數據結構示例

### Hello Examples
- Hello - 簡單的 Hello World 示例

## 使用方法

### 前提條件

1. 確保已構建 F* 的 F# 庫：
   ```bash
   make lib-fsharp
   ```
   或
   ```bash
   make all
   ```

2. 確保 `bin/ulibfs.dll` 存在

### 編譯項目

從 examples 目錄運行：

```bash
cd examples
dotnet build Examples.fsproj
```

或者從根目錄：

```bash
dotnet build examples/Examples.fsproj
```

### 為其他示例創建項目

如果需要為其他 F* 文件創建 .fsproj，可以參考現有的模板：

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <OutputType>Library</OutputType>
    <NoWarn>$(NoWarn);62</NoWarn>
  </PropertyGroup>
  <PropertyGroup>
    <FSTAR_HOME>..\..\..</FSTAR_HOME>
    <FSTAR_FLAGS>--ext optimize_let_vc</FSTAR_FLAGS>
  </PropertyGroup>
  <Import Project="$(FSTAR_HOME)\examples\fsharp.extraction.targets" />
  <ItemGroup>
    <!-- 添加依賴的 .fst 文件 -->
    <Compile Include="..\Dependency.fst" Link="Dependency.fst" />
    <!-- 添加主文件 -->
    <Compile Include="..\YourModule.fst" Link="YourModule.fst" />
  </ItemGroup>
  <ItemGroup>
    <PackageReference Update="FSharp.Core" Version="4.3.4" />
    <PackageReference Include="FSharp.Compatibility.OCaml" Version="0.1.14" />
    <PackageReference Include="Microsoft.NETFramework.ReferenceAssemblies" PrivateAssets="All" Version="1.0.0-preview.2" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="ulibfs">
      <HintPath>$(FSTAR_HOME)\bin\ulibfs.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
```

## 注意事項

- 如果 F* 模組有依賴關係，需要在 `<ItemGroup>` 中包含所有依賴的 .fst 文件
- 文件順序很重要：依賴的文件應該在依賴它的文件之前
- 生成的 F# 文件會自動放在 `obj/Debug/net6.0/extracted/` 目錄中
- 模組名中的點（`.`）會被替換為底線（`_`），例如 `FStar.IO` → `FStar_IO`

