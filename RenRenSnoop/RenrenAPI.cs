using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenRenSnoop
{
    static public class RenrenAPI
    {
        static public void StatusPut(string accessToken, string content)
        {
            WeiboParaeter[] weiboPar = new WeiboParaeter[]
            {
                new WeiboParaeter{ Name="access_token", Value=accessToken},
                new WeiboParaeter{ Name = "content", Value = content},
             };
            Utility.Request("https://api.renren.com/v2/status/put", Utility.RequestMethod.Post, weiboPar);
        }
        static public UserInfoResponse UserGet(string accessToken, string userId)
        {
            WeiboParaeter[] weiboPar = new WeiboParaeter[]
            {
                new WeiboParaeter{ Name="access_token", Value=accessToken},
                new WeiboParaeter{ Name = "userId", Value = userId},
             };
            string result = Utility.Request("https://api.renren.com/v2/user/get", Utility.RequestMethod.Get, weiboPar);
            return JsonHelper.FromJsonToUserInfo(result);
        }
        static public StatusListInfoResponse StatusList(string accessToken, string ownerId, string pageSize, string pageNumber)
        {
            WeiboParaeter[] weiboPar = new WeiboParaeter[]
            {
                new WeiboParaeter{ Name="access_token", Value=accessToken},
                new WeiboParaeter{ Name = "ownerId", Value = ownerId},
                new WeiboParaeter{ Name = "pageSize", Value = pageSize},
                new WeiboParaeter{ Name = "pageNumber", Value = pageNumber},
                
             };
            string result = Utility.Request("https://api.renren.com/v2/status/list", Utility.RequestMethod.Get, weiboPar);

            return JsonHelper.FromJsonToStatusListInfo(result);
        }

        static public AlbumListInfoResponse AlbumList(string accessToken, string ownerId, string pageSize, string pageNumber)
        {
            WeiboParaeter[] weiboPar = new WeiboParaeter[]
            {
                new WeiboParaeter{ Name="access_token", Value=accessToken},
                new WeiboParaeter{ Name = "ownerId", Value = ownerId},
                new WeiboParaeter{ Name = "pageSize", Value = pageSize},
                new WeiboParaeter{ Name = "pageNumber", Value = pageNumber},
                
             };
            string result = Utility.Request("https://api.renren.com/v2/album/list", Utility.RequestMethod.Get, weiboPar);

            return JsonHelper.FromJsonToAlbumListInfo(result);
        }

        static public PhotoListInfoResponse PhotoList(string accessToken, string albumId, string ownerId, string pageSize, string pageNumber)
        {
            WeiboParaeter[] weiboPar = new WeiboParaeter[]
            {
                new WeiboParaeter{ Name="access_token", Value=accessToken},
                new WeiboParaeter{ Name = "albumId", Value = albumId},
                new WeiboParaeter{ Name = "ownerId", Value = ownerId},
                new WeiboParaeter{ Name = "pageSize", Value = pageSize},
                new WeiboParaeter{ Name = "pageNumber", Value = pageNumber},
                
             };
            string result = Utility.Request("https://api.renren.com/v2/photo/list", Utility.RequestMethod.Get, weiboPar);

            return JsonHelper.FromJsonToPhotoListInfo(result);
        }
        static public FriendListInfoResponse FriendList(string accessToken, string userId, string pageSize, string pageNumber)
        {
            WeiboParaeter[] weiboPar = new WeiboParaeter[]
            {
                new WeiboParaeter{ Name="access_token", Value=accessToken},
                new WeiboParaeter{ Name = "userId", Value = userId},
                new WeiboParaeter{ Name = "pageSize", Value = pageSize},
                new WeiboParaeter{ Name = "pageNumber", Value = pageNumber},
                
             };
            string result = Utility.Request("https://api.renren.com/v2/friend/list", Utility.RequestMethod.Get, weiboPar);

            return JsonHelper.FromJsonToFriendListInfo(result);;
        }
    }
}
