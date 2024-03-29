﻿using HomeCinema.Data.Repositories;
using HomeCinema.Entities;
using System.Linq;

namespace HomeCinema.Data.Extensions
{
    public static class UserExtensions
    {
        public static User GetSingleByUsername(this IEntityBaseRepository<User> userRepository, string username)
        {
            return userRepository.GetAll().FirstOrDefault(x => x.Username == username);
        }
    }
}