using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenRenSnoop
{
    public class OAuth
    {
        private string _appKey;
        private string _appSecret;
        private string _callBackUrl;
        private string _accessToken;
        private string _id;
        public UserInfoResponse userInfo;

        public OAuth(string appKey, string appSecret, string callBackUrl)
        {
            _appKey = appKey;
            _appSecret = appSecret;
            _callBackUrl = callBackUrl;
        }

        public bool SetAccessToken(string accessToken)
        {
            _accessToken = accessToken;
            if (string.IsNullOrEmpty(_accessToken))
                return false;
            else
                return true;
        }

        public bool SetAccessTokenByAuthorizationCode(string code)
        {
            if (!String.IsNullOrEmpty(code))
            {
                WeiboParaeter[] weiboPar = new WeiboParaeter[]
                {
                    new WeiboParaeter{ Name="client_id", Value=_appKey },
                    new WeiboParaeter{ Name = "client_secret", Value = _appSecret},
                    new WeiboParaeter{ Name = "grant_type", Value= "authorization_code"},
                    new WeiboParaeter{ Name="code", Value = code},
                    new WeiboParaeter{ Name="redirect_uri",Value = _callBackUrl},
                };
                string result = Utility.Request("https://graph.renren.com/oauth/token", Utility.RequestMethod.Post, weiboPar);
                if (result != "error")
                {
                    _accessToken = result.Substring(result.IndexOf("access_token") + 15, 70);
                    _id = result.Substring(result.IndexOf("\"id\":") + 5, 9);
                }
            }
            if (string.IsNullOrEmpty(_accessToken))
                return false;
            else
                return true;
        }

        public string ReadAccessToken()
        {
            return _accessToken;
        }

        public void StatusPut(string content)
        {
            RenrenAPI.StatusPut(_accessToken, content);
        }

        public void UserGet()
        {
            userInfo = RenrenAPI.UserGet(_accessToken, _id);
        }

        public UserInfoResponse OtherUserGet(string targetID)
        {
            return RenrenAPI.UserGet(_accessToken, targetID);
        }

        public StatusListInfoResponse TargetUserStatusList(string ownerId, string pageSize, string pageNumber)
        {
            return RenrenAPI.StatusList(_accessToken, ownerId, pageSize, pageNumber);
        }

        public AlbumListInfoResponse TargetUserAlbumList(string ownerId, string pageSize, string pageNumber)
        {
            return RenrenAPI.AlbumList(_accessToken, ownerId, pageSize, pageNumber);
        }
        public PhotoListInfoResponse TargetUserPhotoList(string albumId, string ownerId, string pageSize, string pageNumber)
        {
            return RenrenAPI.PhotoList(_accessToken, albumId, ownerId, pageSize, pageNumber);
        }
        public FriendListInfoResponse UserFriendList(string userId, string pageSize, string pageNumber)
        {
            return RenrenAPI.FriendList(_accessToken, userId, pageSize, pageNumber);
        }
    }
}
