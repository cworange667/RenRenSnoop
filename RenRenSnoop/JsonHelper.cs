using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace RenRenSnoop
{
    public class JsonHelper
    {
        static public UserInfoResponse FromJsonToUserInfo(string strJson)
        {
            if (strJson == "error")
                return null;
            return FromJson(strJson, typeof(UserInfoResponse)) as UserInfoResponse;
        }
        static public StatusListInfoResponse FromJsonToStatusListInfo(string strJson)
        {
            if (strJson == "error")
                return null;
            return FromJson(strJson, typeof(StatusListInfoResponse)) as StatusListInfoResponse;
        }

        static public AlbumListInfoResponse FromJsonToAlbumListInfo(string strJson)
        {
            if (strJson == "error")
                return null;
            return FromJson(strJson, typeof(AlbumListInfoResponse)) as AlbumListInfoResponse;
        }

        static public PhotoListInfoResponse FromJsonToPhotoListInfo(string strJson)
        {
            if (strJson == "error")
                return null;
            return FromJson(strJson, typeof(PhotoListInfoResponse)) as PhotoListInfoResponse;
        }
        static public FriendListInfoResponse FromJsonToFriendListInfo(string strJson)
        {
            if (strJson == "error")
                return null;
            return FromJson(strJson, typeof(FriendListInfoResponse)) as FriendListInfoResponse;
        }

        static private object FromJson(string strJson, Type type)
        {
            DataContractJsonSerializer ds = new DataContractJsonSerializer(type);
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(strJson));
            return ds.ReadObject(ms);
        }
    }
}
