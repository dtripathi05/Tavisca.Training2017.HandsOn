using System.Text.RegularExpressions;


namespace Directory_Codejam
{
    public class Validation
    {
        public bool ValidatePhoneNumber(string phonenumber)
        {
            if (Regex.IsMatch(phonenumber, "^[0-9]{5,10}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-z]{2,3}$"))
                return true;
            else
                return false;
        }
        public bool ValidateDateOfBirth(string dateOfBirth)
        {
            if (Regex.IsMatch(dateOfBirth, @"^[0-3][0-9][01][0-9][12][0-9]{3}$"))
                return true;
            else
                return false;
        }
        public bool ValidateName(string name)
        {
            if (Regex.IsMatch(name, "^[a-zA-Z]"))
                return true;
            else
                return false;
        }
        public bool ValidateAddress(string Address)
        {
            if (true)
                return true;
            else
                return true;
        }
    }


}