using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrontClient_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    //点击登录
    protected void loginbtn_Click(object sender, EventArgs e)
    {
        //string account=username.Text;
        //string pwd=password.Text;
        //if (account == "admin" && pwd == "admin")
        //{
        //}
        //else
        //{
        //    loginalertlabel.Text = "用户名或密码不正确！";
        //}
        //// 是否记住密码
        //if (storePwd1.Checked==true) 
        //{
        //    storePwd(account, pwd);
        //}
    }
    // 点击搜索
    protected void searchbtn_Click(object sender, EventArgs e)
    {
        if(searchBox.Text!=null&&searchBox.Text!="")
        {
            // 搜索歌曲 1.按歌曲搜索2.按专辑搜索3.按歌手搜索
            
        }
    }

    // 点击显示登录窗口
    protected void readyloginbtn_Click(object sender, EventArgs e)
    {
        loginpanel.Visible = true;
    }
}
