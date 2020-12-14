using System;

namespace Refactoring
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string SecuritySocialNumber { get; set; }

        public string GetAreaCode()
        {
            if (!string.IsNullOrEmpty(this.PhoneNumber) && this.PhoneNumber.Length > 0 && this.PhoneNumber.StartsWith("+") && this.PhoneNumber.IndexOf("-") >= 0)
            {
                var parts = this.PhoneNumber.Split('-');
                return parts[0];
            }
            else
            {
                throw new Exception("No correct phone number.");
            }
        }

        public string GetBirthYear()
        {
            if (!string.IsNullOrEmpty(this.SecuritySocialNumber) && this.SecuritySocialNumber.Length == 13)
            {
                return this.SecuritySocialNumber.Substring(1, 2);
            }
            else
            {
                throw new Exception("No Social Security Number");
            }
        }

    }
}
