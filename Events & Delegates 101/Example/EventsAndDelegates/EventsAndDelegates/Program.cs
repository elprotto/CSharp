using EventsAndDelegates.Encoders;
using EventsAndDelegates.Models;
using EventsAndDelegates.NotificationService;
using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video Title" };
            var videoEncoder = new VideoEncoder(); // Publisher
            var mailService = new MailService(); // Subscriber
            var txtNotificationService = new TxtNotificationService(); // Subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += txtNotificationService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}
