namespace MailingAddess
{
    public class Display
    {
        public string MailingAddress(string UserName, string City, string Street, string pin, string houseNumber)
        {
            return (UserName + "\n" + houseNumber + "  " + Street + "\n" + City + "\nPIN=" + pin);
        }

    }
}
