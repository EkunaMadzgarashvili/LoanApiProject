using System.Net;
using FinalProject2.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject2.BankServices
{
    public class AccountantService
    {
        private static List<User> users = new List<User>();
        private static List<Loan> loans = new List<Loan>();
        private static List<Accountant> accountants = new List<Accountant>();
        private static Dictionary<User, Boolean> dict = new Dictionary<User, Boolean>();

        public AccountantService() { }


        public bool AddAccountant(Accountant newAccountant)
        {
            if (newAccountant == null || accountants.Contains(newAccountant))
            {
                return false;
            }
            if (newAccountant.Role == "user") { accountants.Add(newAccountant); }
            return true;
        }



        public void AccountantCheck(User user)
        {
            if (dict[user] == true) { user.isBlocked = false; dict[user] = false; }
            if (dict.Count > 100)
            {
                user.isBlocked = true;
            }
        }

    }
}
