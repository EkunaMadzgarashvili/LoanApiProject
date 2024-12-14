using System.Net;
using FinalProject2.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject2.BankServices
{
    public class LoanService
    {
        private static List<User> users = new List<User>();
        private static List<Loan> loans = new List<Loan>();
        private static List<Accountant> accountants = new List<Accountant>();
        private static Dictionary<User, Boolean> dict = new Dictionary<User, Boolean>();

        public LoanService() { }

        public bool GetLoan(User user)
        {
            if (user == null || user.isBlocked == true) { return false; }
            dict[user] = true;
            return true;

        }

        public bool GetInfomation(User user)
        {
            if (!users.Contains(user)) { return false; }
            return true;
        }

        public void GetLoanProperties(Loan loan)
        {
            loans.Add(loan);
        }
    }
}
