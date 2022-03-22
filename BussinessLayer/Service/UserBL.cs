using BussinessLayer.Interface;
using CommonLayer.PostModel;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Service
{
    public class UserBL:IUserBL
    {
        IUserRL userRL;

        public UserBL(IUserRL userRL)
        {
            this.userRL = userRL;
        }

        public async Task UserRegister(UserPostModel userPost)
        {
            try
            {
                await userRL.UserRegister(userPost);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string login(string EmailId, string password)
        {
            try
            {
                return userRL.login(EmailId, password);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool ForgotPassword(string EmailId)
        {
            try
            {
                return userRL.ForgotPassword(EmailId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool ResetPassword(string EmailId, string password)
        {
            try
            {
                return userRL.ResetPassword(EmailId, password);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
