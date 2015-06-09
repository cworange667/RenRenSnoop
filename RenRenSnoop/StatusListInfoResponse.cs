using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenRenSnoop
{
    public class StatusListInfoResponse
    {
        public StatusInfo[] response;
    }

    public class StatusInfo
    {
        //id	Long	状态的ID
        //ownerId	Long	状态所有者的用户ID
        //content	String	状态的内容，未处理过ubb的状态原文本
        //createTime	String	状态发布的时间
        //shareCount	Integer	状态被转发的次数
        //commentCount	Integer	状态被回复的次数
        //sharedStatusId	Long	被分享状态的状态ID（分享的状态才会有）
        //sharedUserId	Long	被分享的根状态的用户ID（分享的状态才会有）
        public string id { get; set; }
        public string ownerId { get; set; }
        public string content { get; set; }
        public string createTime { get; set; }
        public string shareCount { get; set; }
        public string commentCount { get; set; }
        public string sharedStatusId { get; set; }
        public string sharedUserId { get; set; }
    }
}
