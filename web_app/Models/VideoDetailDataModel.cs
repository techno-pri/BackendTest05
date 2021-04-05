using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_app.Models
{
    public class VideoDetailDataModel
    {
        public string VideoId { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string HighestResolutionVideoUrl { get; set; }
    }
}