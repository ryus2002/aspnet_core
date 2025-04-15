using Microsoft.AspNetCore.Mvc;  // 引入 MVC 控制器相關功能
using MyFirstWebApp.Models;      // 引入自定義模型
using System.Collections.Generic; // 引入集合類
using System.Linq;               // 引入 LINQ 查詢功能
namespace MyFirstWebApp.Controllers
{
    /// <summary>
    /// 待辦事項控制器 - 處理所有與待辦事項相關的請求
    /// </summary>
    public class TodoController : Controller
    {
        // 使用靜態列表模擬數據庫存儲
        // 注意：在實際應用中，應該使用數據庫而不是靜態列表，因為靜態列表在應用重啟後會丟失數據
        private static List<TodoItem> _todoItems = new List<TodoItem>
        {
            // 預設添加三個待辦事項作為示例數據
            new TodoItem { Id = 1, Title = "學習 ASP.NET Core", Description = "完成基礎教程", IsDone = false },
            new TodoItem { Id = 2, Title = "創建第一個 Web 應用", Description = "實現待辦事項功能", IsDone = false },
            new TodoItem { Id = 3, Title = "部署應用", Description = "將應用部署到雲端", IsDone = false }
        };

        /// <summary>
        /// 顯示所有待辦事項列表
        /// 對應 URL: /Todo/Index 或 /Todo
        /// HTTP 方法: GET
        /// </summary>
        /// <returns>包含所有待辦事項的視圖</returns>
        public IActionResult Index()
        {
            // 將待辦事項列表傳遞給視圖進行顯示
            return View(_todoItems);
        }

        /// <summary>
        /// 顯示創建新待辦事項的表單
        /// 對應 URL: /Todo/Create
        /// HTTP 方法: GET
        /// </summary>
        /// <returns>創建待辦事項的表單視圖</returns>
        public IActionResult Create()
        {
            // 返回空表單視圖，等待用戶輸入
            return View();
        }

        /// <summary>
        /// 處理創建新待辦事項的表單提交
        /// 對應 URL: /Todo/Create
        /// HTTP 方法: POST
        /// </summary>
        /// <param name="todoItem">從表單提交的待辦事項數據</param>
        /// <returns>成功則重定向到列表頁，失敗則返回表單視圖並顯示錯誤</returns>
        [HttpPost]  // 指定此方法只響應 HTTP POST 請求
        [ValidateAntiForgeryToken]  // 防止跨站請求偽造攻擊(CSRF)
        public IActionResult Create(TodoItem todoItem)
        {
            // 檢查模型驗證是否通過（例如必填字段是否填寫）
            if (ModelState.IsValid)
            {
                // 設置新待辦事項的 ID
                // 在實際數據庫應用中，這通常由數據庫自動生成
                todoItem.Id = _todoItems.Count > 0 ? _todoItems.Max(t => t.Id) + 1 : 1;
                
                // 將新待辦事項添加到列表中
                _todoItems.Add(todoItem);
                
                // 重定向到待辦事項列表頁
                return RedirectToAction(nameof(Index));
            }
            
            // 如果模型驗證失敗，返回表單視圖並顯示錯誤
            return View(todoItem);
        }

        /// <summary>
        /// 顯示待辦事項的詳細信息
        /// 對應 URL: /Todo/Details/{id}
        /// HTTP 方法: GET
        /// </summary>
        /// <param name="id">待辦事項的唯一標識符</param>
        /// <returns>待辦事項詳情視圖，或 404 錯誤（如果找不到）</returns>
        public IActionResult Details(int id)
        {
            // 根據 ID 查找待辦事項
            var todoItem = _todoItems.FirstOrDefault(t => t.Id == id);
            
            // 如果找不到待辦事項，返回 404 錯誤
            if (todoItem == null)
            {
                return NotFound();  // 返回 HTTP 404 狀態碼
            }
            
            // 將待辦事項傳遞給詳情視圖進行顯示
            return View(todoItem);
        }

        /// <summary>
        /// 切換待辦事項的完成狀態（已完成/未完成）
        /// 對應 URL: /Todo/Toggle/{id}
        /// HTTP 方法: GET
        /// </summary>
        /// <param name="id">待辦事項的唯一標識符</param>
        /// <returns>重定向到列表頁，或 404 錯誤（如果找不到）</returns>
        public IActionResult Toggle(int id)
        {
            // 根據 ID 查找待辦事項
            var todoItem = _todoItems.FirstOrDefault(t => t.Id == id);
            
            // 如果找不到待辦事項，返回 404 錯誤
            if (todoItem == null)
            {
                return NotFound();  // 返回 HTTP 404 狀態碼
            }
            
            // 切換完成狀態（如果是已完成則改為未完成，反之亦然）
            todoItem.IsDone = !todoItem.IsDone;
            
            // 重定向到待辦事項列表頁
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// 刪除指定的待辦事項
        /// 對應 URL: /Todo/Delete/{id}
        /// HTTP 方法: GET
        /// 注意：在實際應用中，刪除操作通常應該使用 POST 或 DELETE 方法，而不是 GET
        /// </summary>
        /// <param name="id">待辦事項的唯一標識符</param>
        /// <returns>重定向到列表頁，或 404 錯誤（如果找不到）</returns>
        public IActionResult Delete(int id)
        {
            // 根據 ID 查找待辦事項
            var todoItem = _todoItems.FirstOrDefault(t => t.Id == id);
            
            // 如果找不到待辦事項，返回 404 錯誤
            if (todoItem == null)
            {
                return NotFound();  // 返回 HTTP 404 狀態碼
            }
            
            // 從列表中刪除待辦事項
            _todoItems.Remove(todoItem);
            
            // 重定向到待辦事項列表頁
            return RedirectToAction(nameof(Index));
        }
    }
}
