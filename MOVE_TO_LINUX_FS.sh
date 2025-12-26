#!/bin/bash
# 將 F* 項目從 Windows 文件系統移到 Linux 文件系統的腳本

set -e

echo "========================================="
echo "將 F* 項目移到 WSL Linux 文件系統"
echo "========================================="
echo ""

# 檢查是否在 Windows 文件系統上
if [[ "$(pwd)" == /mnt/* ]]; then
    CURRENT_PATH=$(pwd)
    echo "當前位置: $CURRENT_PATH (Windows 文件系統)"
    echo ""
    echo "建議移動到: ~/FStar (Linux 文件系統)"
    echo ""
    
    read -p "是否要複製項目到 ~/FStar? (y/n) " -n 1 -r
    echo ""
    if [[ $REPLY =~ ^[Yy]$ ]]; then
        echo ""
        echo "複製項目到 ~/FStar..."
        cd ~
        rm -rf ~/FStar  # 如果已存在則刪除
        cp -r "$CURRENT_PATH" ~/FStar
        cd ~/FStar
        
        echo "✓ 項目已複製到 ~/FStar"
        echo ""
        echo "下一步："
        echo "  1. cd ~/FStar"
        echo "  2. eval \$(opam config env)"
        echo "  3. make -j 4"
        echo "  4. make lib-fsharp"
        echo ""
        echo "或者現在就切換到新目錄？"
        read -p "切換到 ~/FStar? (y/n) " -n 1 -r
        echo ""
        if [[ $REPLY =~ ^[Yy]$ ]]; then
            cd ~/FStar
            exec bash  # 重新啟動 shell 在新目錄
        fi
    else
        echo "取消。請手動執行："
        echo "  cp -r /mnt/c/Games/FStar ~/FStar"
        echo "  cd ~/FStar"
    fi
else
    echo "您已經在 Linux 文件系統上了: $(pwd)"
    echo "符號鏈接應該可以正常工作。"
fi

