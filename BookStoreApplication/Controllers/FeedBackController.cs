using BussinessLayer.Interface;
using CommonLayer.PostModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookStoreApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedBackController : ControllerBase
    {
        IFeedBackBL feedBackBL;
        public FeedBackController(IFeedBackBL feedBackBL)
        {
            this.feedBackBL = feedBackBL;

        }
        [Authorize]
        [HttpPost("feedBack")]
        public IActionResult AddFeedBack(FeedBackPostModel feedBackPost)
        {
            try
            {
                var userEmail = User.FindFirst("EmailId").Value.ToString();
                if (userEmail != null)
                {
                    var result = this.feedBackBL.AddFeedBack(feedBackPost);
                    if (result.Equals("FeedBack added Successfully"))
                    {
                        return this.Ok(new { success = true, message = $"FeedBack added Successfully" });
                    }
                    else
                    {
                        return this.BadRequest(new { Status = false, Message = result });
                    }
                }
                else
                {
                    return BadRequest(new { Success = false, message = "Unable to add Feedback!!!" });
                }
               

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        [Authorize]
        [HttpGet("getallFeedBacks/{BookId}")]
        public IActionResult GetAllFeedBacks(int BookId)
        {
            try
            {
                var userEmail = User.FindFirst("EmailId").Value.ToString();
                if (userEmail != null)
                {
                    var result = this.feedBackBL.GetAllFeedBacks(BookId);
                    if (result != null)
                    {
                        return this.Ok(new { success = true, message = $"All FeedBacks from User Displayed Successfully ", response = result });
                    }
                    else
                    {
                        return this.BadRequest(new { Status = false, Message = $"FeedBack for this Book is not exist" });
                    }
                }
                else
                {
                    return BadRequest(new { Success = false, message = "Password reset Unsuccesfully" });
                }
               

            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}
