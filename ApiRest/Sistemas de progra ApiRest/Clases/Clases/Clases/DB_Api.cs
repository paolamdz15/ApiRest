﻿using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web;

    public class DB_Api
    {
        public dynamic Get(string url)
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            myWebRequest.Credentials = CredentialCache.DefaultCredentials;
            myWebRequest.Proxy = null;
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            Stream myStream = myHttpWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myStream);
            
            string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());
            dynamic data = JsonConvert.DeserializeObject(Datos);
            return data;
        }
    }

