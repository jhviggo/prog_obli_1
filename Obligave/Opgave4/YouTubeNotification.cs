namespace Obligave.Opgave4
{
    public class YouTubeNotification
    {
        public delegate void VideoPostedEventHandler(object sender, 
                        string newVideo);
        public event VideoPostedEventHandler VideoPostedHandler;

        private string video;
        public string Video
        {
            get { return video; }
            set
            {
                if (value != null && VideoPostedHandler != null)
                    VideoPostedHandler(this, value);

                video = value;
            }
        }
    }
}

