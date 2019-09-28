using APPLICATION.Interfaces;
using DOMAIN.Entities;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICATION.AppServices
{
    public class UserAppService : AppServiceBase<User>, IUserAppService
    {
        private readonly IUserService _UserService;
        public UserAppService(IUserService userService) : base(userService)
        {
            _UserService = userService;
        }

        //public void ChangeUserPassword(int userId, string password)
        //{
        //    _UserService.ChangeUserPassword(userId, password);
        //}

        public bool DoesUserHaveCarsForRenting(User user)
        {
            return _UserService.DoesUserHaveCarsForRenting(user);
        }

        public User FindUserByEmail(string email)
        {
            return _UserService.FindUserByEmail(email);
        }

        //public User FindUserByPasswordAndUserId(string password, int userId)
        //{
        //    return _UserService.FindUserByPasswordAndUserId(password, userId);
        //}

        public User FindUserByUsername(string username)
        {
            return _UserService.FindUserByUsername(username);
        }

        public int GetNumberOfCarsForRenting(User user)
        {
            return _UserService.GetNumberOfCarsForRenting(user);
        }

        public int? GetUserRate(User user)
        {
            return _UserService.GetUserRate(user);
        }

        public bool isUser18(User user)
        {
            return _UserService.isUser18(user);
        }

        public int TotalNumberOfusers()
        {
            return _UserService.TotalNumberOfusers();
        }
    

        public void ChangeUserProfilePicture(int userId, byte[] userProfilePicture)
        {
            _UserService.ChangeUserProfilePicture(userId, userProfilePicture);
        }

    }
}
