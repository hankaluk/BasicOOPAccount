using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account {
    class Account {
        private int balance;
        private Person owner;

        public Account(Person owner, int balance) {
            this.owner = owner;
            this.balance = balance;
            owner.SetAccount(this);
        }
        public Account(string name, int day, int month, int year, int balance) : this(new Person(name, day, month, year), balance) {
        }
        public Person GetOwner() {
            return owner;
        }

        public void WriteInfo() {
            Console.WriteLine("The account information:");
            Console.WriteLine($"Owner: {owner.GetName()}\nBorn: {owner.GetDateOfBirth()}\nTotal balance: {balance}");
        }

        public void InsertInto(int amount) {
            try {
                if ((balance + amount) < 0) {
                    throw new ArgumentOutOfRangeException("Your account does not have sufficient funds! Repeat your request.");
                }
                balance += amount;
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine(e.Message);
            }
        }

        public void WriteBalance() {
            Console.WriteLine($"Current balance of your account is {balance}.");
        }

        public void TransferTo(Account account, int amount) {
            try {
                if (this == account) {
                    throw new ArgumentOutOfRangeException("It is NOT ALLOWED to transfer money to the same account.");
                }
                if (amount < 0) {
                    throw new ArgumentOutOfRangeException("It is NOT ALLOWED to draft from other people's accounts.");
                }
                if ((this.balance - amount) < 0) {
                    throw new ArgumentOutOfRangeException("Your account does not have sufficient funds for the transfer.");
                }
                this.balance -= amount;
                account.balance += amount;
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine(e.Message);
            }
        }
        public override string ToString() {
            return $"{balance}";
        }



    }
}
