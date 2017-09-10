using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Admin 的摘要说明
/// 管理员实体类
/// </summary>
public class Admin
{
    private int _id; // 用户表编号，主键
    private string _account; // 账号名
    private string _password; // 密码
    private string _nickname; // 昵称
    private string _permissions; // 权限
    private int _del; // 删除标记

    public Admin()
    {
 
    }

    public Admin(int id, string account, string password, string nickname, string permissions, int del)
    {
        this._id = id;
        this._account = account;
        this._password = password;
        this._nickname = nickname;
        this._permissions = permissions;
        this._del = del;
    }

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }


    public string Account
    {
        get { return _account; }
        set { _account = value; }
    }


    public string Password
    {
        get { return _password; }
        set { _password = value; }
    }


    public string Nickname
    {
        get { return _nickname; }
        set { _nickname = value; }
    }


    public string Permissions
    {
        get { return _permissions; }
        set { _permissions = value; }
    }


    public int Del
    {
        get { return _del; }
        set { _del = value; }
    }
}