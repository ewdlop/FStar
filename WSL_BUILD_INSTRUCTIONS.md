# 在 WSL 中構建 F* - 完整指南

## 重要：為什麼需要移到 Linux 文件系統

在 WSL 的 Windows 文件系統（`/mnt/c/`）上構建 F* 會遇到符號鏈接問題。
F* 的構建系統大量使用符號鏈接，這些在 Windows 文件系統上無法正常工作。

## 推薦解決方案：在 Linux 文件系統中構建

### 步驟 1: 將項目複製到 Linux 文件系統

```bash
# 在 WSL 中執行
cd ~
cp -r /mnt/c/Games/FStar ~/FStar
cd ~/FStar
```

### 步驟 2: 確保 OPAM 環境已設置

```bash
# 確保 OPAM 環境變量已加載
eval $(opam config env)

# 檢查必要工具
dune --version
ocamlc -version
```

### 步驟 3: 安裝 Z3

```bash
# 從 F* 根目錄執行
sudo .scripts/get_fstar_z3.sh /usr/local/bin

# 驗證
z3-4.8.5 --version
z3-4.13.3 --version
```

### 步驟 4: 構建 F* 和 F# 庫

```bash
# 構建 F*（這會構建 stage0, stage1, stage2）
make -j 4

# 構建 F# 標準庫
make lib-fsharp
```

### 步驟 5: 驗證構建

```bash
# 檢查構建結果
ls -l ~/FStar/bin/ulibfs.dll

# 檢查 F* 編譯器
~/FStar/bin/fstar.exe --version
```

## 如果必須在 Windows 文件系統上構建

如果您確實需要在 `/mnt/c/` 上構建，可以嘗試手動修復符號鏈接：

```bash
cd /mnt/c/Games/FStar

# 在 WSL 中，確保有管理員權限創建符號鏈接
# Windows 10 需要開發者模式或管理員權限

# 修復 stage1 的符號鏈接
cd stage1/dune/fstar-guts
rm -f fstarc.ml FStarC_Parser_Parse.mly FStarC_Parser_WarnError.mly make_fstar_version.sh

# 嘗試創建符號鏈接（在 WSL 中可能仍然失敗）
ln -sf ../../fstarc.ml fstarc.ml
ln -sf ../../../src/ml/FStarC_Parser_Parse.mly FStarC_Parser_Parse.mly
ln -sf ../../../src/ml/FStarC_Parser_WarnError.mly FStarC_Parser_WarnError.mly
ln -sf ../../../.scripts/make_fstar_version.sh make_fstar_version.sh

cd ../../../

# 對 stage2 做同樣的操作
cd stage2/dune/fstar-guts
rm -f fstarc.ml FStarC_Parser_Parse.mly FStarC_Parser_WarnError.mly make_fstar_version.sh
ln -sf ../../fstarc.ml fstarc.ml
ln -sf ../../../src/ml/FStarC_Parser_Parse.mly FStarC_Parser_Parse.mly
ln -sf ../../../src/ml/FStarC_Parser_WarnError.mly FStarC_Parser_WarnError.mly
ln -sf ../../../.scripts/make_fstar_version.sh make_fstar_version.sh
cd ../../../
```

**注意**：即使修復了符號鏈接，在 Windows 文件系統上構建仍可能遇到其他問題。

## 推薦：始終使用 Linux 文件系統構建

最好的做法是：
1. 將源代碼放在 Linux 文件系統（`~/FStar`）
2. 在 Linux 文件系統中構建
3. 構建完成後，可以將生成的二進制文件複製回 Windows 文件系統（如果需要）

這樣可以避免所有 Windows 文件系統的兼容性問題。

