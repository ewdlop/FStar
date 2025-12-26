# 在 WSL 中構建 F*

## 步驟 1: 安裝 OCaml 和 OPAM

在 WSL 終端中執行：

```bash
# 1. 安裝 OPAM (OCaml 包管理器)
# 在 Ubuntu/Debian WSL 中：
sudo apt update
sudo apt install opam

# 或使用官方安裝腳本：
# sh <(curl -sL https://raw.githubusercontent.com/ocaml/opam/master/shell/install.sh)

# 2. 初始化 OPAM
opam init
# 如果提示，允許修改 ~/.bashrc 或 ~/.profile

# 3. 更新環境變量（如果 opam init 沒有自動添加）
eval $(opam config env)

# 4. 確保使用支持的 OCaml 版本 (4.14.X)
opam switch list
opam switch list-available | grep 4.14
opam switch create 4.14.0  # 或使用最新可用的 4.14.X 版本

# 5. 安裝必要的依賴
opam install --deps-only .
```

## 步驟 2: 安裝 Z3

F* 需要特定版本的 Z3：

```bash
# 從 F* 根目錄執行
sudo .scripts/get_fstar_z3.sh /usr/local/bin

# 驗證安裝
z3-4.8.5 --version
z3-4.13.3 --version
```

## 步驟 3: 構建 F*

從 F* 根目錄執行：

```bash
# 基本構建（使用 N 個並行作業，例如 4 或 6）
make -j 4

# 這會：
# 1. 構建 F* 編譯器
# 2. 驗證 F* 標準庫
```

## 步驟 4: 構建 F# 標準庫（用於 F# 提取）

如果您需要將 F* 代碼提取到 F#：

```bash
# 構建 F# 標準庫
make lib-fsharp

# 這會生成 bin/ulibfs.dll，可以在 F# 項目中使用
```

## 驗證構建

```bash
# 檢查 F* 是否正確構建
bin/fstar.exe --version

# 測試構建
make -C tests/micro-benchmarks
```

## 注意事項

- 首次構建可能需要較長時間（取決於您的機器性能）
- 如果遇到缺少依賴的錯誤，使用 `opam depext -i <包名>` 安裝系統級依賴
- 確保您在 WSL 中已經安裝了 `make` 和 `git` 等基本工具

