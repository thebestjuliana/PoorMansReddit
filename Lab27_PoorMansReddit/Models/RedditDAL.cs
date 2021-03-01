using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Lab27_PoorMansReddit.Models
{
    public class RedditDAL
    {

        public SubReddit ConvertToSubReddit(string s)
        {
            
            string url = $"https://www.reddit.com/r/{s}/.json";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());
            string JSON = rd.ReadToEnd();
            string subredditData = JSON;
            SubReddit subreddit = JsonConvert.DeserializeObject<SubReddit>(subredditData);
            return subreddit;
        }
    }
}
