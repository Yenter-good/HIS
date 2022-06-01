using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;

namespace HIS.Utility
{
    public static class HTTPHelper
    {
        public enum ContentType
        {
            [Description("application/json")]
            Json,
            [Description("application/xml")]
            Xml,
            [Description("text/html")]
            HTML,
            [Description("application/x-www-form-urlencoded")]
            Normal
        }

        public static string HttpPost(string Url, string postDataStr)
        {
            return HttpPost(Url, postDataStr, ContentType.Normal);
        }

        public static string HttpPost(string Url, string postDataStr, ContentType contentType)
        {
            var request = (HttpWebRequest)WebRequest.Create(Url);

            var data = Encoding.UTF8.GetBytes(postDataStr);

            request.Method = "POST";
            request.Timeout = 2000;
            request.ContentType = contentType.GetDescription();
            request.ContentLength = data.Length;
            request.Proxy = null;
            try
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return responseString;
            }
            catch (WebException e)
            {
                try
                {
                    if (e.Status == WebExceptionStatus.ProtocolError)
                    {
                        HttpWebResponse response = (HttpWebResponse)e.Response;
                        using (Stream d = response.GetResponseStream())
                        {
                            using (StreamReader reader = new StreamReader(d))
                            {
                                string text = reader.ReadToEnd();
                                return text;
                            }
                        }
                    }
                }
                catch
                {
                }
                return "";
            }
        }
        public static string HttpPost(string Url, string postDataStr, ContentType contentType, Dictionary<string, string> heads)
        {
            var request = (HttpWebRequest)WebRequest.Create(Url);
            var data = Encoding.UTF8.GetBytes(postDataStr);

            request.Method = "POST";
            request.Timeout = 2000;
            request.ContentType = contentType.GetDescription();
            request.ContentLength = data.Length;
            foreach (var item in heads)
                request.Headers.Add(item.Key, item.Value);
            try
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return responseString;
            }
            catch (WebException e)
            {
                try
                {
                    if (e.Status == WebExceptionStatus.ProtocolError)
                    {
                        HttpWebResponse response = (HttpWebResponse)e.Response;
                        using (Stream d = response.GetResponseStream())
                        {
                            using (StreamReader reader = new StreamReader(d))
                            {
                                string text = reader.ReadToEnd();
                                return text;
                            }
                        }
                    }
                }
                catch
                {
                }
                return "";
            }
        }
        public static string HttpGet(string Url, Dictionary<string, string> param)
        {
            List<string> data = new List<string>();
            foreach (var item in param)
                data.Add(item.Key + "=" + item.Value);

            string url = data.Count == 0 ? Url : Url + "?" + string.Join("&", data);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }

        public static Bitmap HttpGet(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            Image img = Image.FromStream(myResponseStream);
            myResponseStream.Close();
            return img as Bitmap;
        }
    }
}
