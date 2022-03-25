using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Entity
{
    public class FeedBackModel
    {
        public int FeedbackId { get; set; }
        public int userId { get; set; }
        public int BookId { get; set; }
        public string FeedBackFromUserName { get; set; }
        public string Comments { get; set; }
        public int Ratings { get; set; }


    }
}
