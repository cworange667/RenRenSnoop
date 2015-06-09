using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace RenRenSnoop
{
    static public class Utility
    {
        public enum RequestMethod
        {
            Get,
            Post
        }
        static public String BuildQueryString(params WeiboParaeter[] parameter)
        {
            List<String> list = new List<String>();
            foreach (WeiboParaeter item in parameter)
            {
                String value = String.Format("{0}", item.Value);
                if (!String.IsNullOrEmpty(value))
                {
                    list.Add(String.Format("{0}={1}", Uri.EscapeDataString(item.Name),
                        Uri.EscapeDataString(value)));
                }
            }
            return String.Join("&", list.ToArray());
        }

        static public String BuildQueryString(Dictionary<String, String> kvp)
        {
            List<String> list = new List<String>();
            foreach (var item in kvp)
            {
                String value = String.Format("{0}", item.Value);
                if (!String.IsNullOrEmpty(value))
                {
                    list.Add(String.Format("{0}={1}", Uri.EscapeDataString(item.Key),
                        Uri.EscapeDataString(value)));
                }
            }
            String a = String.Join("&", list.ToArray());
            return String.Join("&", list.ToArray());
        }
        static public String Request(String url, RequestMethod method, params WeiboParaeter[] parameter)
        {
            String result = String.Empty;
            UriBuilder uri = new UriBuilder(url);
            uri.Query = Utility.BuildQueryString(parameter);
            HttpWebRequest http = HttpWebRequest.Create(uri.Uri) as HttpWebRequest;
            http.ServicePoint.Expect100Continue = false;
            http.UserAgent = "Mozilla/4.0 (compatible; MSIE 9.0; Windows NT 6.0)";
            switch (method)
            {
                case RequestMethod.Get:
                    http.Method = "GET";
                    break;
                case RequestMethod.Post:
                    http.Method = "POST";
                    http.ContentType = "application/x-www-form-urlencoded";
                    using (StreamWriter sw = new StreamWriter(http.GetRequestStream()))
                        try
                        {
                            sw.Write(uri);
                        }
                        catch (System.Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    break;
            }
            try
            {
                using (HttpWebResponse response = http.GetResponse() as HttpWebResponse)
                {
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        result = sr.ReadToEnd();
                    }
                }
            }
            catch (System.Net.WebException exc)
            {
                if (exc.Response != null)
                {
                    using (StreamReader sr = new StreamReader(exc.Response.GetResponseStream()))
                    {
                        String message = sr.ReadToEnd();
          //              throw new Exception(message);
                        return "error";
                    }
                }
            }
            return result;
        }
    }
}

