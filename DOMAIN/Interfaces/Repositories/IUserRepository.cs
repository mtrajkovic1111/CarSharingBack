using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Interfaces.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User FindUserByUsername(string username);
        User FindUserByEmail(string email);
        //User FindUserByPasswordAndUserId(string password, int userId);
        int? GetUserRate(User user);
       // void ChangeUserPassword(int userId, string password);
        bool DoesUserHaveCarsForRenting(User user);
        int GetNumberOfCarsForRenting(User user);
        bool isUser18(User user);
        int TotalNumberOfusers();

        void ChangeUserProfilePicture(int userId, byte[] userProfilePicture);
    }
}
