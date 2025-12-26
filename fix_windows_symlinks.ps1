# PowerShell 腳本：修復 Windows 文件系統上的符號鏈接
# 注意：需要管理員權限或開發者模式

$ErrorActionPreference = "Stop"

Write-Host "嘗試修復符號鏈接..." -ForegroundColor Yellow
Write-Host "注意：如果失敗，請將項目移到 WSL 的 Linux 文件系統 (~/FStar)" -ForegroundColor Yellow

$basePath = $PSScriptRoot

# 修復 stage1
$stage1Path = Join-Path $basePath "stage1\dune\fstar-guts"
Write-Host "修復 stage1..." -ForegroundColor Cyan

# fstarc.ml 應該指向目錄
$fstarcLink = Join-Path $stage1Path "fstarc.ml"
$fstarcTarget = Join-Path $basePath "stage1\fstarc.ml"
if (Test-Path $fstarcLink) {
    Remove-Item $fstarcLink -Force
}
New-Item -ItemType SymbolicLink -Path $fstarcLink -Target $fstarcTarget -ErrorAction SilentlyContinue

# .mly 文件
$mlyFiles = @(
    @{Source = "FStarC_Parser_Parse.mly"; Target = Join-Path $basePath "src\ml\FStarC_Parser_Parse.mly"},
    @{Source = "FStarC_Parser_WarnError.mly"; Target = Join-Path $basePath "src\ml\FStarC_Parser_WarnError.mly"}
)

foreach ($file in $mlyFiles) {
    $linkPath = Join-Path $stage1Path $file.Source
    if (Test-Path $linkPath) {
        Remove-Item $linkPath -Force
    }
    New-Item -ItemType SymbolicLink -Path $linkPath -Target $file.Target -ErrorAction SilentlyContinue
}

# make_fstar_version.sh
$scriptLink = Join-Path $stage1Path "make_fstar_version.sh"
$scriptTarget = Join-Path $basePath ".scripts\make_fstar_version.sh"
if (Test-Path $scriptLink) {
    Remove-Item $scriptLink -Force
}
New-Item -ItemType SymbolicLink -Path $scriptLink -Target $scriptTarget -ErrorAction SilentlyContinue

# 修復 stage2（同樣的操作）
$stage2Path = Join-Path $basePath "stage2\dune\fstar-guts"
Write-Host "修復 stage2..." -ForegroundColor Cyan

$fstarcLink2 = Join-Path $stage2Path "fstarc.ml"
$fstarcTarget2 = Join-Path $basePath "stage2\fstarc.ml"
if (Test-Path $fstarcLink2) {
    Remove-Item $fstarcLink2 -Force
}
New-Item -ItemType SymbolicLink -Path $fstarcLink2 -Target $fstarcTarget2 -ErrorAction SilentlyContinue

foreach ($file in $mlyFiles) {
    $linkPath = Join-Path $stage2Path $file.Source
    if (Test-Path $linkPath) {
        Remove-Item $linkPath -Force
    }
    New-Item -ItemType SymbolicLink -Path $linkPath -Target $file.Target -ErrorAction SilentlyContinue
}

$scriptLink2 = Join-Path $stage2Path "make_fstar_version.sh"
if (Test-Path $scriptLink2) {
    Remove-Item $scriptLink2 -Force
}
New-Item -ItemType SymbolicLink -Path $scriptLink2 -Target $scriptTarget -ErrorAction SilentlyContinue

Write-Host "完成！" -ForegroundColor Green
Write-Host "如果符號鏈接創建失敗，請以管理員身份運行此腳本，或將項目移到 WSL 的 Linux 文件系統" -ForegroundColor Yellow

