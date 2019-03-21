using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_DynamicRichMenu
{
    public partial class _default : System.Web.UI.Page
    {
         string channelAccessToken = System.Configuration.ConfigurationManager.AppSettings["ChannelAccessToken"].ToString();
        string AdminUserId = System.Configuration.ConfigurationManager.AppSettings["AdminUserId"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //動態建立選單
            var menu = new isRock.LineBot.RichMenu.RichMenuItem()
            { name = "快捷選單1", selected = true, chatBarText = "快捷選單1" };
            menu.size.width = 2500; menu.size.height = 1686;

            var area = new isRock.LineBot.RichMenu.Area();
            area.bounds.x = 1666;
            area.bounds.y = 843;
            area.bounds.width = 833;
            area.bounds.height = 843;
            area.action = new isRock.LineBot.MessageAction() { label = "/下一頁", text = "/下一頁" };

            menu.areas.Add(area);
            var item = isRock.LineBot.Utility.CreateRichMenu(menu, new Uri("https://i.imgur.com/HLv4R2T.jpg"), channelAccessToken);
            Response.Write("<br/>第1組richMenuId : " + item.richMenuId);
            ViewState["menuid"] = item.richMenuId;

            var menu2 = new isRock.LineBot.RichMenu.RichMenuItem()
            { name = "快捷選單2", selected = true, chatBarText = "快捷選單2" };
            menu.size.width = 2500; menu.size.height = 1686;

            var area2 = new isRock.LineBot.RichMenu.Area();
            area2.bounds.x = 0;
            area2.bounds.y = 0;
            area2.bounds.width = 833;
            area2.bounds.height = 843;
            area2.action = new isRock.LineBot.MessageAction() { label = "/上一頁", text = "/上一頁" };

            menu2.areas.Add(area2);
            var item2 = isRock.LineBot.Utility.CreateRichMenu(menu2, new Uri("https://imgur.com/ukgGq2v.jpg"), channelAccessToken);
            Response.Write("<br/>第2組richMenuId : " + item2.richMenuId);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var MenuId = ViewState["menuid"].ToString();
            //設定預設選單
            isRock.LineBot.Utility.SetDefaultRichMenu(MenuId, channelAccessToken);
            Response.Write("done, now you can check your bot's menu.");
        }

        protected void Button_DEL_Click(object sender, EventArgs e)
        {
            //取消預設選單
            isRock.LineBot.Utility.CancelDefaultRichMenu(channelAccessToken);
            //抓取所有選單
            var menus = isRock.LineBot.Utility.GetRichMenuList(channelAccessToken);
            //顯示數量
            Response.Write("Menu Count : "+menus.richmenus.Count());
            //刪除每一個
            foreach (var item in menus.richmenus)
            {
                isRock.LineBot.Utility.DeleteRichMenu(item.richMenuId, channelAccessToken);
                Response.Write("<br/> deleted : "+item.richMenuId);
            }
        }
    }
}