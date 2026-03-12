namespace Bank_Application.NewFolder
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public BankAccount Account { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Account = new BankAccount
            {
                AccountNumber = "UA" + System.Guid.NewGuid().ToString().Substring(0, 8).ToUpper(),
                Balance = 100
            };
        }
    }
}