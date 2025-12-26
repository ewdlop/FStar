#!/bin/bash
# 修復 WSL 中 Windows 文件系統上的符號鏈接問題

set -e

cd "$(dirname "$0")"

echo "修復 stage1 的符號鏈接..."
cd stage1/dune/fstar-guts

# 修復 fstarc.ml
if [ -f fstarc.ml ] && ! [ -L fstarc.ml ]; then
    echo "修復 fstarc.ml..."
    rm -f fstarc.ml
    ln -sf ../../fstarc.ml fstarc.ml
fi

# 修復 .mly 文件
if [ -f FStarC_Parser_Parse.mly ] && ! [ -L FStarC_Parser_Parse.mly ]; then
    echo "修復 FStarC_Parser_Parse.mly..."
    rm -f FStarC_Parser_Parse.mly
    ln -sf ../../../src/ml/FStarC_Parser_Parse.mly FStarC_Parser_Parse.mly
fi

if [ -f FStarC_Parser_WarnError.mly ] && ! [ -L FStarC_Parser_WarnError.mly ]; then
    echo "修復 FStarC_Parser_WarnError.mly..."
    rm -f FStarC_Parser_WarnError.mly
    ln -sf ../../../src/ml/FStarC_Parser_WarnError.mly FStarC_Parser_WarnError.mly
fi

# 修復 make_fstar_version.sh
if [ -f make_fstar_version.sh ] && ! [ -L make_fstar_version.sh ]; then
    echo "修復 make_fstar_version.sh..."
    rm -f make_fstar_version.sh
    ln -sf ../../../.scripts/make_fstar_version.sh make_fstar_version.sh
fi

cd ../../../
echo "修復 stage2 的符號鏈接..."
cd stage2/dune/fstar-guts

# 修復 fstarc.ml
if [ -f fstarc.ml ] && ! [ -L fstarc.ml ]; then
    echo "修復 fstarc.ml..."
    rm -f fstarc.ml
    ln -sf ../../fstarc.ml fstarc.ml
fi

# 修復 .mly 文件
if [ -f FStarC_Parser_Parse.mly ] && ! [ -L FStarC_Parser_Parse.mly ]; then
    echo "修復 FStarC_Parser_Parse.mly..."
    rm -f FStarC_Parser_Parse.mly
    ln -sf ../../../src/ml/FStarC_Parser_Parse.mly FStarC_Parser_Parse.mly
fi

if [ -f FStarC_Parser_WarnError.mly ] && ! [ -L FStarC_Parser_WarnError.mly ]; then
    echo "修復 FStarC_Parser_WarnError.mly..."
    rm -f FStarC_Parser_WarnError.mly
    ln -sf ../../../src/ml/FStarC_Parser_WarnError.mly FStarC_Parser_WarnError.mly
fi

# 修復 make_fstar_version.sh
if [ -f make_fstar_version.sh ] && ! [ -L make_fstar_version.sh ]; then
    echo "修復 make_fstar_version.sh..."
    rm -f make_fstar_version.sh
    ln -sf ../../../.scripts/make_fstar_version.sh make_fstar_version.sh
fi

cd ../../../
echo "符號鏈接修復完成！"

