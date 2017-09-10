using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// member 的摘要说明
/// 会员实体类
/// </summary>
public class Member
{
    private int id;// 会员编号

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private string account;// 会员名

    public string Account
    {
        get { return account; }
        set { account = value; }
    }
    private string password;// 密码

    public string Password
    {
        get { return password; }
        set { password = value; }
    }
    private string nickname;// 昵称

    public string Nickname
    {
        get { return nickname; }
        set { nickname = value; }
    }
    private string realname;// 真实姓名

    public string Realname
    {
        get { return realname; }
        set { realname = value; }
    }
    private string gender;// 性别

    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }
    private string email;// 电子邮件

    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    private string birthday;// 生日

    public string Birthday
    {
        get { return birthday; }
        set { birthday = value; }
    }
    private int del;// 删除标记

    public int Del
    {
        get { return del; }
        set { del = value; }
    }

	public Member()
	{
	}

    public Member(int id,string account,string password,string nickname,string realname,string gender,string email,string birthday,int del)
    {
        this.id = id;
        this.account = account;
        this.password = password;
        this.nickname = nickname;
        this.realname = realname;
        this.gender = gender;
        this.email = email;
        this.birthday = birthday;
        this.del = del;
    }
}