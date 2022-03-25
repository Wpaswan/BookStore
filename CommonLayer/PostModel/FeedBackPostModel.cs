using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.PostModel
{
    public class FeedBackPostModel
    {
        public int userId { get; set; }
        public int BookId { get; set; }
        public string FeedBackFromUserName { get; set; }
        public string Comments { get; set; }
        public int Ratings { get; set; }
    }
}
