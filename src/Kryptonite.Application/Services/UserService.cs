﻿using Kryptonite.Application.Interfaces;
using Kryptonite.Domain.Entities;
using Kryptonite.Domain.Interfaces;

namespace Kryptonite.Application.Services {
    public class UserService : IUserService {
        private readonly IUserRepository _userRepository;
       public UserService(IUserRepository userRepository) {
            _userRepository = userRepository;
        }
        public async Task<User> Login(string loginName, string loginPassword) {
            try {
                return await _userRepository.Login(loginName, loginPassword);
            }
            catch {
                throw;
            }
        }
    }
}
