# ShoppingWebSite

## 特點
### 購物網站基本操作
#### 未註冊訪客
- 產品列表
- 註冊
- 登入
#### 註冊會員
- 產品列表
- 購物車
- 訂單
- 登出
- 歡迎該使用者

## 使用技術
### 前端
- Model : 利用 Entity Framework 從資料庫建立 Model。其中註冊裡的欄位為必填
- View : 使用 HTML Helper 和 C# 完成 MVC 中 View 的版面配置（Layout）
- Controller：
  - **HomeController**：使用 C# 撰寫註冊/登入功能。若有資料傳遞，則使用 HTTP POST 方法，因為這樣更安全。
  - **MemberController**：使用 C# 撰寫購物車相關操作。若有資料傳遞，同樣使用 HTTP POST 方法。
### 後端
- 使用LINQ語法完成基本CRUD, HomeController / MemberController 皆有使用

## 其他須注意點
- 若生成 view 時出現 "viewentityframework 6.4.4' 與 'entityframework.zh-hant 6.2.0 條件約束 entityframework (= 6.2.0)" 不相容的問題
  需在 NuGet 套件中將 "entityframework.zh-hant 6.2.0" 移除。
- 若使用了 Authorize 屬性，請確保在 Web.Config 中的 `<system.web>` 內添加以下配置：
    ```xml
    <authentication mode="Forms">
      <forms loginUrl="~/Home/Login"/> <!-- 導向的路徑 -->
    </authentication>
    ```
    這樣未通過驗證的使用者將會被導向到 `~/Home/Login`。

## 參考
-[該篇](https://ithelp.ithome.com.tw/articles/10287423) 
