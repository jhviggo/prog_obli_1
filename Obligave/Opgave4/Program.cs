using System;

namespace Obligave.Opgave4
{
    class ProgramOpgave4
    {
        public static void Run()
        {

            YouTubeNotification p = new YouTubeNotification();
            p.VideoPostedHandler += p_VideoNotification;

            p.Video = "TechLinked";
            p.Video = "Markiplier plays games";

            p.VideoPostedHandler -= p_VideoNotification;

            p.Video = "I am inevitable";

        }

        static void p_VideoNotification(object sender, 
            string newVideo)
        {
            if (newVideo != null)
                Console.WriteLine("New video posted: " + newVideo);
        }
    }
}