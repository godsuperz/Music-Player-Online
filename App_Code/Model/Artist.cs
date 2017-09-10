using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Artist 的摘要说明
/// 歌手实体类
/// </summary>
public class Artist
{
    private int id; // 歌手编号
    private string name;// 歌手名称
    private string alias;// 别名
    private string category;// 歌手类别，男歌手，女歌手，组合
    private string gender;// 性别

    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }
    private string education;// 学历

    public string Education
    {
        get { return education; }
        set { education = value; }
    }
    private string school;// 毕业学校

    public string School
    {
        get { return school; }
        set { school = value; }
    }
    private string birthplace;// 籍贯

    public string Birthplace
    {
        get { return birthplace; }
        set { birthplace = value; }
    }
    private string zodiac;// 生肖

    public string Zodiac
    {
        get { return zodiac; }
        set { zodiac = value; }
    }
    private string bloodtype;//血型，A,B,0，AB

    public string Bloodtype
    {
        get { return bloodtype; }
        set { bloodtype = value; }
    }
    private string birthday;// 生日

    public string Birthday
    {
        get { return birthday; }
        set { birthday = value; }
    }
    private double height;// 身高(cm)

    public double Height
    {
        get { return height; }
        set { height = value; }
    }
    private double weight;// 体重(kg)

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }
    private string image1;// 歌手原图

    public string Image1
    {
        get { return image1; }
        set { image1 = value; }
    }
    private string image2;// 歌手缩略图

    public string Image2
    {
        get { return image2; }
        set { image2 = value; }
    }
    private string description;// 描述

    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    private int del;// 删除标记，0表示未删除，1表示删除

    public int Del
    {
        get { return del; }
        set { del = value; }
    }

	public Artist()
	{
	}

    public Artist(int id,string name,string alias,string category,string gender,string education,string school,string birthplace,string zodiac,string bloodtype,string birthday,double height,double weight,string image1,string image2,string description,int del)
    {
        this.id = id;
        this.name = name;
        this.alias = alias;
        this.category = category;
        this.gender = gender;
        this.education = education;
        this.school = school;
        this.birthplace = birthplace;
        this.zodiac = zodiac;
        this.bloodtype = bloodtype;
        this.birthday = birthday;
        this.height = height;
        this.weight = weight;
        this.image1 = image1;
        this.image2 = image2;
        this.description = description;
        this.del = del;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Alias
    {
        get { return alias; }
        set { alias = value; }
    }

    public string Category
    {
        get { return category; }
        set { category = value; }
    }
}