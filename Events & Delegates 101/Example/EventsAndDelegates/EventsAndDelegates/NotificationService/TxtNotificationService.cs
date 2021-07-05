using EventsAndDelegates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates.NotificationService
{
    public class TxtNotificationService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("TxtNotificationService: Sending an text notification..." + args.Video.Title);
            Thread.Sleep(2000);
        }
    }
}
