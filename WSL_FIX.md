# WSL 中 ftruncate() 錯誤的解決方案

這個錯誤發生在 `trim`（清理）階段，是 WSL 在 Windows 文件系統上的已知限制。
構建本身通常已經成功，只是清理步驟失敗。

## 解決方案 1：檢查構建是否成功（推薦）

```bash
# 檢查 fstar.exe 是否已成功構建
ls -l stage0/out/bin/fstar.exe

# 如果文件存在，構建已成功！
# 您可以繼續使用，忽略 trim 錯誤
```

## 解決方案 2：修改 Makefile 允許 trim 失敗

編輯 `stage0/Makefile`，將第 98 行改為允許失敗：

```makefile
trim: .force
	$(call msg, "DUNE CLEAN")
	-dune clean $(FSTAR_DUNE_OPTIONS) --root=dune || true
```

（在命令前添加 `-` 使 make 忽略錯誤）

## 解決方案 3：跳過 trim 步驟直接構建

```bash
# 直接構建 stage0，跳過 trim
cd stage0
make minimal

# 然後繼續其他構建步驟
cd ..
make -j 4  # 但這仍會觸發 trim...

# 更好的方法：修改主 Makefile
```

## 解決方案 4：將項目移到 WSL 的 Linux 文件系統（最佳性能）

```bash
# 在 WSL 中複製項目到 Linux 文件系統
cp -r /mnt/c/Games/FStar ~/FStar
cd ~/FStar

# 然後在 Linux 文件系統中構建
make -j 4
```

這樣可以避免所有 WSL/Windows 文件系統兼容性問題。

