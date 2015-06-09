using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenRenSnoop
{
    public class AlbumListInfoResponse
    {
        public AlbumInfo[] response;
    }
    public class AlbumInfo
    {
        //id	Long	相册的ID
        //type	AlbumType	相册的类型
        //cover	Image[]	相册的封面
        //name	String	相册的名字
        //description	String	相册的描述
        //createTime	String	相册的创建时间
        //lastModifyTime	String	相册的最后更新时间，最后上传照片至这个相册的时间
        //location	String	相册拍摄的地点
        //photoCount	Integer	相册中的照片数
        //accessControl	AccessControl	相册的访问控制
        public string id { get; set; }
        public string type { get; set; }
        public Image[] cover { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string createTime { get; set; }
        public string lastModifyTime { get; set; }
        public string location { get; set; }
        public string photoCount { get; set; }
        public string accessControl { get; set; }

        //public enum AlbumType
        //{
        //    //PORTRAIT	枚举	头像相册
        //    //APP	枚举	APP相册
        //    //GENERAL	枚举	普通相册
        //    //PUBLISHER_SINGLE	枚举	快速上传相册
        //    //OTHER	枚举	其他相册
        //    //BLOG	枚举	日志相册
        //    //ALL_APP	枚举	应用相册
        //    //VOICE	枚举	语音相册
        //    //HEADPHOTO	枚举	大头贴相册
        //    //ACTIVE	枚举	活动相册
        //    //MMS	枚举	手机相册
        //    PORTRAIT, APP	, GENERAL, PUBLISHER_SINGLE, OTHER, BLOG, ALL_APP, VOICE, HEADPHOTO, ACTIVE	, MMS
        //}

        public class Image
        {
            public string size { get; set; }
            public string url { get; set; }
        }
    }
}
