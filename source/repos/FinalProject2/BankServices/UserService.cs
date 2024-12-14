using System.Net;
using FinalProject2.Models;
using Microsoft.AspNetCore.Mvc;
namespace FinalProject2.BankServices
{
    public class UserService
    {
        private static List<User> users = new List<User>();
        private static List<Loan> loans = new List<Loan>();
        private static List<Accountant> accountants = new List<Accountant>();
        private static Dictionary<User, Boolean> dict = new Dictionary<User, Boolean>();
        public UserService() { }
        public bool Authorization(User newUser)
        {
            if (newUser == null || users.Contains(newUser))
            {
                return false;
            }
            if (newUser.Role == "user") { users.Add(newUser); dict.Add(newUser, false); }
            return true;
        }

        public bool ChangeLoanInformation(User user)
        {
            if (!users.Contains(user) && dict[user] == false) { return false;  }
            return true;
        }
    }
}

