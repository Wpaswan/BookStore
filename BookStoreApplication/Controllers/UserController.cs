using BussinessLayer.Interface;
using CommonLayer.PostModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BookStoreApplication.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        IUserBL userBL;

        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;

        }
        [HttpPost("register")]
        public async Task<ActionResult> RegisterUser(UserPostModel userPost)
        {
            try
            {

                await this.userBL.UserRegister(userPost);
                return this.Ok(new { success = true, message = $"Registration Successful for your given Mail-ID  {userPost.EmailId}" });
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpPost("Login/{EmailId}/{password}")]

        public IActionResult UserLogin(string EmailId, string password)
        {
            try
            {
                var login = this.userBL.login(EmailId, password);
                if (login!= null)
                {
                    return this.Ok(new { Success = true, message = "Login Successful", token = login });
                }
                else
                {
                    return this.Ok(new { Success = false, message = "Invalid User Please enter valid email and password." });
                }
            }
            catch (Exception ex)
            {
                return this.BadRequest(new { success = false, message = ex.Message });

            }
        }
        [HttpPost("ForgotPassword/{EmailId}")]
        public IActionResult ForgotPassword(string EmailId)
        {
            if (string.IsNullOrEmpty(EmailId))
            {
                return BadRequest("Email should not be null or empty");
            }
            try
            {
                var result = this.userBL.ForgotPassword(EmailId);
                if (result != null)
                {
                    return this.Ok(new { Success = true, message = "Token generated.Please check your email", token = result });
                }
                else
                {
                    return this.Ok(new { Success = false, message = "Invalid User Please enter valid email and password." });
                }
            }
            catch (Exception ex)
            {
                return this.BadRequest(new { success = false, message = ex.Message });

            }
        }
        [Authorize]
        [HttpPut("ResetPassword/{password}")]

        public ActionResult ResetPassword(string password)
        {
            try
            {
                var userEmail = User.FindFirst("EmailId").Value.ToString();
                if (userEmail != null)
                {
                    this.userBL.ResetPassword(userEmail, password);

                    return Ok(new { Success = true, message = "Password reset successfully" });
                }
                else
                {
                    return BadRequest(new { Success = false, message = "Password reset Unsuccesfully" });
                }
            }
            catch (Exception ex)
            {
                return this.BadRequest(new { success = false, message = ex.Message });

            }
        }



    }
}
