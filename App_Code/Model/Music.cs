using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Music 的摘要说明
/// 歌曲实体类
/// </summary>
public class Music
{
    private int id;// 歌曲编号

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private string name;// 歌曲名称

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string publishdate;// 出版日期

    public string Publishdate
    {
        get { return publishdate; }
        set { publishdate = value; }
    }
    private string musicurl;// 歌曲文件路径

    public string Musicurl
    {
        get { return musicurl; }
        set { musicurl = value; }
    }
    private string musictext;// 歌词文件路径

    public string Musictext
    {
        get { return musictext; }
        set { musictext = value; }
    }
    private int albumid;// 专辑编号，与专辑表编号弱关联

    public int Albumid
    {
        get { return albumid; }
        set { albumid = value; }
    }
    private int artistid;// 歌手编号，与歌手表编号弱关联

    public int Artistid
    {
        get { return artistid; }
        set { artistid = value; }
    }
    private string zone;// 地区名称，华语/欧美/日韩/

    public string Zone
    {
        get { return zone; }
        set { zone = value; }
    }
    private int del;// 删除标记，0表示未删除，1表示删除

    public int Del
    {
        get { return del; }
        set { del = value; }
    }

	public Music()
	{
	}

    public Music(int id,string name,string publishdate,string musicurl,string musictext,int albumid,int artistid,string zone,int del)
    {
        this.id = id;
        this.name = name;
        this.publishdate = publishdate;
        this.musicurl = musicurl;
        this.musictext = musictext;
        this.albumid = albumid;
        this.artistid = artistid;
        this.zone = zone;
        this.del = del;
    }
}