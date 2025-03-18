namespace exercises.app
{
    public class Atm
    {
        public Atm(string fullName, long cardNumber, int pin, int balance)
        {
            FullName = fullName;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
            GreetMessage = $"Hello {fullName}, You have successfully logged in to your card.";
        }
        public string FullName { get; set; }
        public long CardNumber { get; set; }
        private int Pin { get; set; }
        private int Balance { get; set; }
        public string GreetMessage { get; set; }

        public bool CheckPin(int enteredPin)
        {
            return enteredPin == Pin;
        }

        public int GetBalance()
        {
            return Balance;
        }

        public void Withdraw(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }
    }
}