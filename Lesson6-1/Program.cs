
namespace Lesson6
{


    public class BankAccount
    {
        public BankAccount()
        {
            AddAccountNumber();

        }

        public BankAccount(int accountBalanceUser)
        {
            AddAccountNumber();
            _accountBalance = accountBalanceUser;


        }

        public BankAccount(AccountType clientAccountTypeUser)
        {
            AddAccountNumber();
            _clientAccountType = clientAccountTypeUser;

        }

        public BankAccount(AccountType clientAccountTypeUser, int accountBalanceUser)
        {
            AddAccountNumber();
            _accountBalance = accountBalanceUser;
            _clientAccountType = clientAccountTypeUser;
        }

        public enum AccountType
        {
            MainAccount = 1,
            DollarAccount = 2,
            EuroAccount = 3,
            AccountInYuan = 4,
            SavingsAccount = 5,
            InvestmentAccount = 6,
            CreditAccount = 7,
            MortgageAccount = 8
        }

        private static uint _accountNumber = 10000000;
        public uint AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }

        }

        private int _accountBalance = 100000;
        public int AccountBalance
        {
            get
            {
                return _accountBalance;
            }
            set
            {
                _accountBalance = value;
            }

        }

        private AccountType _clientAccountType;
        public AccountType ClientAccountType
        {
            get
            {
                return _clientAccountType;
            }
            set
            {
                _clientAccountType = value;
            }

        }


        public static void AddAccountNumber()
        {
            _accountNumber += 1;

        }

        public int PutBalance(int balanceUser)
        {
            _accountBalance += balanceUser;
            return _accountBalance;
        }

        public int WithdrawBalance(int balanceUser)
        {
            if (_accountBalance >= balanceUser)
            {
                _accountBalance -= balanceUser;
                return _accountBalance;
            }
            else
            {
                Console.WriteLine("Вы превысили лимит, введите другую сумму");
                return _accountBalance;
            }

        }
        public static bool operator == (BankAccount bankAccount1, BankAccount bankAccount2)
        {
            
            if ((bankAccount1.ClientAccountType == bankAccount2.ClientAccountType) && 
                (bankAccount1.AccountBalance == bankAccount2.AccountBalance) 
                && (bankAccount1.AccountNumber == bankAccount2.AccountNumber))
                return true;
            else
                return false;
        }

        public static bool operator !=(BankAccount bankAccount1, BankAccount bankAccount2)
        {

            if ((bankAccount1.ClientAccountType != bankAccount2.ClientAccountType) ||
                (bankAccount1.AccountBalance != bankAccount2.AccountBalance)
                || (bankAccount1.AccountNumber != bankAccount2.AccountNumber))
                return true;
            else
                return false;
        }

        public override int GetHashCode ()
        {   

            return HashCode.Combine(AccountBalance, AccountNumber, ClientAccountType);
        }


        public  bool Equals(BankAccount bankAccount1)
        {
            if ((bankAccount1.ClientAccountType == ClientAccountType) &&
               (bankAccount1.AccountBalance == AccountBalance)
               && (bankAccount1.AccountNumber == AccountNumber))
                return true;
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            if (obj is BankAccount)
            {

                return true;

            }
            return false;
        }
        public override string ToString()
        {
            return "BankAccount: " + "Тип счета:  " + ClientAccountType + "  Номер счета:  " + AccountNumber + "  Баланс:  " + AccountBalance;
        }



    }




    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(BankAccount.AccountType.CreditAccount, 12345);

            var accountTest = new BankAccount(BankAccount.AccountType.AccountInYuan, 125);
            var accountTest1 = new BankAccount(BankAccount.AccountType.CreditAccount, 12345);

            Console.WriteLine(account.GetHashCode());
            Console.WriteLine(account.Equals(6));
            Console.WriteLine(account.Equals(accountTest));
            Console.WriteLine(account.Equals(accountTest1));
            Console.WriteLine(account == accountTest);
            Console.WriteLine(account == accountTest1);
            Console.WriteLine(account != accountTest);
            Console.WriteLine(account != accountTest1);
            Console.WriteLine(account.ToString());


        }
    }

}


