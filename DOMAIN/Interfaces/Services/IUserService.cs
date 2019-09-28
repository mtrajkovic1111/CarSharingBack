using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Interfaces.Services
{
    public interface IUserService : IServiceBase<User>
    {
        User FindUserByUsername(string username);
        User FindUserByEmail(string email);
       // User FindUserByPasswordAndUserId(string password, int userId);
        int? GetUserRate(User user);
       // void ChangeUserPassword(int userId, string password);
        bool DoesUserHaveCarsForRenting(User user);
        int GetNumberOfCarsForRenting(User user);
        int TotalNumberOfusers();
        
        bool isUser18(User user);
        void ChangeUserProfilePicture(int userId, byte[] userProfilePicture);

    }
}
