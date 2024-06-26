﻿using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace UserRegistrationService
{
    public class UserRegistration
    {
        public List<User> Users { get; set; }
        public UserRegistration()
        {
            Users = new List<User>();
        }

        public void RegisterNewUser(string username, string password, string email)
        {
            if (ValidateUserName(username) == true && ValidatePassword(password) == true && ValidateEmail(email) == true) 
            { 
                var u = new User();
                u.UserName = username;
                u.Password = password;
                u.Email = email;
                Users.Add(u);
                Console.WriteLine($"{username} was added succesfully!");
            }
        }
        public bool ValidateUserName(string username)
        {
            if (CheckIfUserNameDoesNotAlreadyExists(username) == true)
            {
                if (username.Length >= 5 && username.Length <= 20 && username.All(char.IsLetterOrDigit))
                    return true;
            }
            return false;
        }

        public bool CheckIfUserNameDoesNotAlreadyExists(string username)
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].UserName.ToLower() == username.ToLower())
                    return false;
            }
            return true;
        }

        public bool ValidatePassword(string password)
        {
            if (password.Length >= 8 && !password.All(char.IsLetterOrDigit))
                return true;
            return false;
        }
        public bool ValidateEmail(string email)
        {
            // Regular expression pattern for basic email validation
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Check if email matches the pattern
            if (Regex.IsMatch(email, pattern) == true)
                return true;
            return false;
        }
    }
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
