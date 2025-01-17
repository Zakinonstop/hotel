using System;
using System.Collections.Generic;
using Hotel.Model.Repository;
using Hotel.Model.Entry;

namespace Hotel.Controller
{
    public class UserController
    {
        private UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool VerifyLogin(string email, string password)
        {
            var users = _userRepository.ReadByEmail(email);
            if (users.Count == 1) 
            {
                var user = users[0];
                return user.Password == password; 
            }
            return false; 
        }
    }
}
