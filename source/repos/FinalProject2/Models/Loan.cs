namespace FinalProject2.Models
{
    public class Loan
    {
        public string LoanType { get; set; }

        public int Amount { get; set; }
        public string Currency { get; set; }
        public string Period { get; set; }
        public string Status { get; set; } = "Is in process";

    }
}
