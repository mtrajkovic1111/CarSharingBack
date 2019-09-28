using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICATION.Interfaces
{
    public interface IUserAppService : IAppServiceBase<User>
    {
        User FindUserByUsername(string username);
        User FindUserByEmail(string email);
       // User FindUserByPasswordAndUserId(string password, int userId);
        int? GetUserRate(User user);
       // void ChangeUserPassword(int userId, string password);
        bool DoesUserHaveCarsForRenting(User user);
        int GetNumberOfCarsForRenting(User user);
        bool isUser18(User user);
        int TotalNumberOfusers();
        
        void ChangeUserProfilePicture(int userId, byte[] userProfilePicture);
    }
}
