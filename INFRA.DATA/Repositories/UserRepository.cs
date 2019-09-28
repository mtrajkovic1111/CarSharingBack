using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using INFRA.DATA.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IUnitOfWork<Context> unitOfWork) : base(unitOfWork)
        {
        }

        //public void ChangeUserPassword(int userId, string password)
        //{
        //    var dbUser = context.Users.Find(userId);
        //    dbUser.Password = password;
        //}

        public bool DoesUserHaveCarsForRenting(User user)
        {
            return context.Users.Any(u => u.Cars == user.Cars);
        }

        public User FindUserByEmail(string email)
        {
            return context.Users.Where(m => m.Email == email).FirstOrDefault();
        }

        //public User FindUserByPasswordAndUserId(string password, int userId)
        //{
        //    User userFromDb = context.Users.Where(u => u.Id == userId && u.Password == password).FirstOrDefault();
        //    return userFromDb;
        //}

        public User FindUserByUsername(string username)
        {
            User user = context.Users.Where(u => u.Username == username).FirstOrDefault();
            return user;
        }

        public int GetNumberOfCarsForRenting(User user)
        {
            var numberOfCars = context.Users.Where(u => u.Cars == user.Cars).Count(); //?????
            return numberOfCars;

        }

        public int? GetUserRate(User user)
        {
            var userRate = context.Users.Find(user.Id);
            return userRate.Rate;
        }

        public bool isUser18(User user)
        {
            return context.Users.Any(u => u.DateOfBirth.Year - user.DateOfBirth.Year  >= 18);


        }

        public int TotalNumberOfusers()
        {
            return context.Users.Count();
        }

   

        public void ChangeUserProfilePicture(int userId, byte[] userProfilePicture)
        {
            var dbUser = context.Users.Find(userId);
            dbUser.ProfilePicture = userProfilePicture;
        }


    }
}

