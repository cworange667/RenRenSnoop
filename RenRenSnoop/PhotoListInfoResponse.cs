using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenRenSnoop
{
    public class PhotoListInfoResponse
    {
        public PhotoInfo[] response;
    }
    public class PhotoInfo
    {
        //id	Long	照片的ID
        //albumId	Long	照片所属相册的ID
        //ownerId	Long	照片所有者的ID
        //description	String	照片的描述
        //images	Image[]	照片对应的各种类型图片
        //createTime	String	照片的创建时间
        //viewCount	Integer	照片被浏览的次数
        //commentCount	Integer	照片被回复的次数
        public string id { get; set; }
        public string albumId { get; set; }
        public string ownerId { get; set; }
        public string description { get; set; }
        public Image[] images { get; set; }
        public string createTime { get; set; }
        public string viewCount { get; set; }
        public string commentCount { get; set; }
        public class Image
        {
            public string size { get; set; }
            public string url { get; set; }
        }
    }
}
