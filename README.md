# MyFirstWebApp - ASP.NET Core MVC 待辦事項應用

這是一個使用 ASP.NET Core MVC 框架開發的簡單待辦事項管理應用程序。該應用程序允許用戶創建、查看、更新和刪除待辦事項，是學習 ASP.NET Core Web 開發的良好起點。

![待辦事項應用截圖](https://via.placeholder.com/800x450.png?text=MyFirstWebApp+Screenshot)

## 功能特點

- ✅ 顯示待辦事項列表
- ✅ 創建新的待辦事項
- ✅ 查看待辦事項詳情
- ✅ 標記待辦事項為已完成/未完成
- ✅ 刪除待辦事項
- ✅ 響應式設計，適配各種設備

## 技術棧

- **後端框架**: ASP.NET Core 7.0
- **前端框架**: Bootstrap 5
- **模板引擎**: Razor
- **架構模式**: MVC (Model-View-Controller)
- **數據存儲**: 內存中集合 (模擬數據庫)

## 系統需求

- .NET SDK 7.0 或更高版本
- 任何現代瀏覽器 (Chrome, Firefox, Edge, Safari)
- 操作系統: Windows, macOS, 或 Linux

## 安裝指南

### 先決條件

1. 安裝 [.NET SDK 7.0](https://dotnet.microsoft.com/download/dotnet/7.0) 或更高版本
2. 安裝 [Visual Studio Code](https://code.visualstudio.com/) (推薦) 或其他 IDE

### 克隆倉庫

```bash
git clone https://github.com/ryus2002/aspnet_core.git
cd aspnet_core
```

### 運行應用程序

```bash
cd MyFirstWebApp
dotnet run
```

應用程序將在 `https://localhost:5001` 和 `http://localhost:5000` 啟動 (端口可能會有所不同)。

## 使用指南

### 查看待辦事項列表

訪問應用程序主頁或點擊導航菜單中的「待辦事項」選項，即可查看所有待辦事項。

### 創建新待辦事項

1. 在待辦事項列表頁面，點擊「創建新待辦事項」按鈕
2. 填寫表單，包括標題、描述和完成狀態
3. 點擊「創建」按鈕保存

### 查看待辦事項詳情

在待辦事項列表中，點擊「詳情」按鈕查看特定待辦事項的完整信息。

### 標記為已完成/未完成

在待辦事項列表或詳情頁面，點擊「標記為已完成」或「標記為未完成」按鈕可切換待辦事項的完成狀態。

### 刪除待辦事項

在待辦事項列表中，點擊「刪除」按鈕可移除不需要的待辦事項。

## 項目結構

```
MyFirstWebApp/
├── Controllers/            # 控制器類
│   ├── HomeController.cs   # 首頁控制器
│   └── TodoController.cs   # 待辦事項控制器
├── Models/                 # 數據模型
│   ├── ErrorViewModel.cs   # 錯誤視圖模型
│   └── TodoItem.cs         # 待辦事項模型
├── Views/                  # 視圖文件
│   ├── Home/               # 首頁視圖
│   ├── Todo/               # 待辦事項視圖
│   └── Shared/             # 共享視圖組件
├── wwwroot/                # 靜態資源
│   ├── css/                # 樣式表
│   ├── js/                 # JavaScript 文件
│   └── lib/                # 第三方庫
├── Program.cs              # 應用程序入口點
└── appsettings.json        # 應用程序配置
```

## 未來計劃

- [ ] 添加數據庫支持 (使用 Entity Framework Core)
- [ ] 實現用戶認證和授權
- [ ] 添加搜索和過濾功能
- [ ] 添加截止日期和提醒功能
- [ ] 改進用戶界面和用戶體驗

## 貢獻指南

1. Fork 這個倉庫
2. 創建您的功能分支 (`git checkout -b feature/amazing-feature`)
3. 提交您的更改 (`git commit -m 'Add some amazing feature'`)
4. 推送到分支 (`git push origin feature/amazing-feature`)
5. 打開一個 Pull Request

## 許可證

本項目採用 MIT 許可證 - 查看 [LICENSE](LICENSE) 文件了解詳情。

## 聯繫方式

如有任何問題或建議，請通過以下方式聯繫我：

- GitHub: [ryus2002](https://github.com/ryus2002)
- Email: [您的郵箱地址]

## 致謝

- [ASP.NET Core](https://docs.microsoft.com/aspnet/core) - Web 框架
- [Bootstrap](https://getbootstrap.com/) - CSS 框架
- [jQuery](https://jquery.com/) - JavaScript 庫