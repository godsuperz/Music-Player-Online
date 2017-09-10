using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Album 的摘要说明
/// 专辑实体类
/// </summary>
public class Album
{
    private int id; // 专辑编号
    private string name; // 专辑名称

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string publishdate; // 出版日期

    public string Publishdate
    {
        get { return publishdate; }
        set { publishdate = value; }
    }
    private string image1; // 原图 ，用户上传

    public string Image1
    {
        get { return image1; }
        set { image1 = value; }
    }
    private string image2; // 缩略图，系统生成

    public string Image2
    {
        get { return image2; }
        set { image2 = value; }
    }
    private string company; // 唱片公司

    public string Company
    {
        get { return company; }
        set { company = value; }
    }
    private int artistid; // 歌手编号

    public int Artistid
    {
        get { return artistid; }
        set { artistid = value; }
    }
    private string description;  // 描述

    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    private int del; // 删除标记，0表示未删除，1表示删除

    public int Del
    {
        get { return del; }
        set { del = value; }
    }

	public Album()
	{
	}

    public Album(int id,string name,string publishdate,string image1,string image2,string company,int artistid,string description,int del)
    {
        this.id = id;
        this.name = name;
        this.publishdate = publishdate;
        this.image1 = image1;
        this.image2 = image2;
        this.company = company;
        this.artistid = artistid;
        this.description = description;
        this.del = del;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
}