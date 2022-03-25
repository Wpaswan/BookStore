using CommonLayer.PostModel;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Interface
{
    public interface IFeedBackBL
    {
        string AddFeedBack(FeedBackPostModel feedBackPost);

        List<FeedBackModel> GetAllFeedBacks(int BookId);
    }
   
}
