#!/bin/bash
# 在 WSL 中修復符號鏈接的腳本
# 如果符號鏈接無法創建，會輸出錯誤信息並建議移到 Linux 文件系統

set -e

cd "$(dirname "$0")"

echo "嘗試修復符號鏈接..."
echo "注意：在 Windows 文件系統 (/mnt/c/) 上，符號鏈接可能無法正常工作"
echo "如果失敗，建議將項目移到 Linux 文件系統: cp -r /mnt/c/Games/FStar ~/FStar"
echo ""

# 檢查是否在 Windows 文件系統上
if [[ "$(pwd)" == /mnt/* ]]; then
    echo "警告：您在 Windows 文件系統 (/mnt/c/) 上"
    echo "建議：將項目複製到 Linux 文件系統以獲得更好的兼容性"
    echo ""
fi

# 修復 stage1
echo "修復 stage1..."
cd stage1/dune/fstar-guts

# 刪除錯誤的文件
rm -f fstarc.ml FStarC_Parser_Parse.mly FStarC_Parser_WarnError.mly make_fstar_version.sh

# 創建符號鏈接
if ln -sf ../../fstarc.ml fstarc.ml 2>/dev/null; then
    echo "✓ 創建 fstarc.ml 符號鏈接"
else
    echo "✗ 無法創建 fstarc.ml 符號鏈接（可能需要管理員權限）"
fi

if ln -sf ../../../src/ml/FStarC_Parser_Parse.mly FStarC_Parser_Parse.mly 2>/dev/null; then
    echo "✓ 創建 FStarC_Parser_Parse.mly 符號鏈接"
else
    echo "✗ 無法創建 FStarC_Parser_Parse.mly 符號鏈接"
fi

if ln -sf ../../../src/ml/FStarC_Parser_WarnError.mly FStarC_Parser_WarnError.mly 2>/dev/null; then
    echo "✓ 創建 FStarC_Parser_WarnError.mly 符號鏈接"
else
    echo "✗ 無法創建 FStarC_Parser_WarnError.mly 符號鏈接"
fi

if ln -sf ../../../.scripts/make_fstar_version.sh make_fstar_version.sh 2>/dev/null; then
    echo "✓ 創建 make_fstar_version.sh 符號鏈接"
else
    echo "✗ 無法創建 make_fstar_version.sh 符號鏈接"
fi

cd ../../../
echo ""

# 修復 stage2
echo "修復 stage2..."
cd stage2/dune/fstar-guts

# 刪除錯誤的文件
rm -f fstarc.ml FStarC_Parser_Parse.mly FStarC_Parser_WarnError.mly make_fstar_version.sh

# 創建符號鏈接
if ln -sf ../../fstarc.ml fstarc.ml 2>/dev/null; then
    echo "✓ 創建 fstarc.ml 符號鏈接"
else
    echo "✗ 無法創建 fstarc.ml 符號鏈接"
fi

if ln -sf ../../../src/ml/FStarC_Parser_Parse.mly FStarC_Parser_Parse.mly 2>/dev/null; then
    echo "✓ 創建 FStarC_Parser_Parse.mly 符號鏈接"
else
    echo "✗ 無法創建 FStarC_Parser_Parse.mly 符號鏈接"
fi

if ln -sf ../../../src/ml/FStarC_Parser_WarnError.mly FStarC_Parser_WarnError.mly 2>/dev/null; then
    echo "✓ 創建 FStarC_Parser_WarnError.mly 符號鏈接"
else
    echo "✗ 無法創建 FStarC_Parser_WarnError.mly 符號鏈接"
fi

if ln -sf ../../../.scripts/make_fstar_version.sh make_fstar_version.sh 2>/dev/null; then
    echo "✓ 創建 make_fstar_version.sh 符號鏈接"
else
    echo "✗ 無法創建 make_fstar_version.sh 符號鏈接"
fi

cd ../../../
echo ""

# 驗證符號鏈接
echo "驗證符號鏈接..."
if [ -L stage1/dune/fstar-guts/fstarc.ml ] && [ -e stage1/dune/fstar-guts/fstarc.ml ]; then
    echo "✓ stage1 符號鏈接看起來正常"
else
    echo "✗ stage1 符號鏈接可能有問題"
    echo "  建議：將項目移到 Linux 文件系統："
    echo "    cp -r /mnt/c/Games/FStar ~/FStar"
    echo "    cd ~/FStar"
    echo "    make lib-fsharp"
fi

if [ -L stage2/dune/fstar-guts/fstarc.ml ] && [ -e stage2/dune/fstar-guts/fstarc.ml ]; then
    echo "✓ stage2 符號鏈接看起來正常"
else
    echo "✗ stage2 符號鏈接可能有問題"
fi

echo ""
echo "如果符號鏈接無法正常工作，請將項目移到 WSL 的 Linux 文件系統："
echo "  cp -r /mnt/c/Games/FStar ~/FStar"
echo "  cd ~/FStar"
echo "  make lib-fsharp"

