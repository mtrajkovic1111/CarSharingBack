using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) 
            : base(userRepository)
        {
            _userRepository = userRepository;
        }

        //public void ChangeUserPassword(int userId, string password)
        //{
        //    _userRepository.ChangeUserPassword(userId, password);
        //}

        public bool DoesUserHaveCarsForRenting(User user)
        {
            return _userRepository.DoesUserHaveCarsForRenting(user);
        }

        public User FindUserByEmail(string email)
        {
            return _userRepository.FindUserByEmail(email);
        }

        //public User FindUserByPasswordAndUserId(string password, int userId)
        //{
        //    return _userRepository.FindUserByPasswordAndUserId(password, userId);
        //}

        public User FindUserByUsername(string username)
        {
            return _userRepository.FindUserByUsername(username);
        }

        public int GetNumberOfCarsForRenting(User user)
        {
            return _userRepository.GetNumberOfCarsForRenting(user);
        }

        public int? GetUserRate(User user)
        {
            return _userRepository.GetUserRate(user);
        }

        public bool isUser18(User user)
        {
            return _userRepository.isUser18(user);
        }

        public int TotalNumberOfusers()
        {
            return _userRepository.TotalNumberOfusers();
        }

        public void ChangeUserProfilePicture(int userId, byte[] userProfilePicture)
        {
            _userRepository.ChangeUserProfilePicture(userId, userProfilePicture);
        }


    }
}
