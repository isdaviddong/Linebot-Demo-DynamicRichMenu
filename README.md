# Linebot-Demo-DynamicRichMenu

## Dynamic Rich Menu : 如何設計可以動態切換的Rich Menu

此範例展示如何動態切換Rich Menu，讓單一/特定用戶可以享有超過6格的多層選單
<img src='https://i.imgur.com/iyJJl1Y.png' />

### Live Demo 範例：
<img src='https://i.imgur.com/4A53agc.png' />

### 如何使用
1. 請使用 Visual Studio 2019, Clone from GitHub 
https://github.com/isdaviddong/Linebot-Demo-DynamicRichMenu.git
2. 開啟專案後，置換web.config中的ChannelAccessToken與AdminUserId 為你的Line bot資訊
3. 請先運行此專案，並執行 default.aspx 頁面上的 code，依照畫面指示的操作步驟，先建立 rich menu，才能夠使用WebHook的切換功能
   
![](https://i.imgur.com/OreYpGX.png)
4. 佈署此專案至 IIS 伺服器或 Azure WebSite 
or
4. 使用Ngrok模擬伺服器
5. 取得WebHook URL更新你的LINE Bot Messaging後台WebHook

完成後即可測試。


相關資源 
===
<br/>LineBotSDK：https://www.nuget.org/packages/LineBotSDK
<br/>相關課程：http://www.studyhost.tw/NewCourses/LineBot
<br/>線上課程：https://www.udemy.com/line-bot/
<br/>更多內容，請參考電子書：https://www.pubu.com.tw/ebook/103305
<br/>LINE Bot實體書籍：https://www.tenlong.com.tw/products/9789865020354


