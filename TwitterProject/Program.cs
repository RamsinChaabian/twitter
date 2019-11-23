using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;


namespace TwitterProject
{
    class Program
    {
        private static readonly string cusotmerKey = "";
        private static readonly string customerKeySecret = "";
        private static readonly string accessToken = "";
        private static readonly string accessTokenSecret = "";

        private static TwitterService service = new TwitterService(cusotmerKey, customerKeySecret, accessToken, accessTokenSecret);
        static void  Main(string[] args)
        {
            var directMessages =  service.ListDirectMessagesReceived(new ListDirectMessagesReceivedOptions { Count = 10 });

            Console.ReadKey();
        }
    }
}
