# 修復 WSL 中符號鏈接問題

在 WSL 的 Windows 文件系統（/mnt/c/）上，符號鏈接無法正常工作。
有幾個文件應該是指向其他目錄的符號鏈接，但在 Windows 文件系統上無法正常工作。

## 解決方案：在 WSL 中運行修復命令

在 WSL 終端中執行：

```bash
cd /mnt/c/Games/FStar

# 刪除錯誤的文件並創建正確的符號鏈接
cd stage1/dune/fstar-guts

# 修復 fstarc.ml - 應該是符號鏈接到 ../../fstarc.ml/
rm -f fstarc.ml
ln -sf ../../fstarc.ml fstarc.ml

# 修復 .mly 文件 - 應該是符號鏈接到源文件
rm -f FStarC_Parser_Parse.mly FStarC_Parser_WarnError.mly
ln -sf ../../../src/ml/FStarC_Parser_Parse.mly FStarC_Parser_Parse.mly
ln -sf ../../../src/ml/FStarC_Parser_WarnError.mly FStarC_Parser_WarnError.mly

# 檢查 make_fstar_version.sh 是否正確
ls -la make_fstar_version.sh

cd ../../../

# 對 stage2 做同樣的修復
cd stage2/dune/fstar-guts
rm -f fstarc.ml
ln -sf ../../fstarc.ml fstarc.ml
rm -f FStarC_Parser_Parse.mly FStarC_Parser_WarnError.mly
ln -sf ../../../src/ml/FStarC_Parser_Parse.mly FStarC_Parser_Parse.mly
ln -sf ../../../src/ml/FStarC_Parser_WarnError.mly FStarC_Parser_WarnError.mly
cd ../../../
```

## 更好的長期解決方案

最好的做法是將整個項目複製到 WSL 的 Linux 文件系統：

```bash
# 複製到 Linux 文件系統
cp -r /mnt/c/Games/FStar ~/FStar
cd ~/FStar

# 在那裡構建，符號鏈接會正常工作
make lib-fsharp
```

這樣可以避免所有 Windows 文件系統的兼容性問題。

