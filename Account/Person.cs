using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account {
    class Person {
        private string name;
        private Date dateOfBirth;
        private List<Account> myAccounts = new List<Account>();

        public Person(string name, int day, int month, int year) : this(name, new Date(day, month, year)) {
        }
        public Person(string name, Date birth) {
            this.name = name;
            this.dateOfBirth = birth;
        }

        public string GetName() {
            return name;
        }
        public void SetName(string name) {
            this.name = name;
            Console.WriteLine("Name changed.");
        }
        public string GetDateOfBirth() {
            return dateOfBirth.ToString();
        }
        public void SetDateOfBirth(int day, int month, int year) {
            this.dateOfBirth = new Date(day, month, year);
            Console.WriteLine("Date of birth changed.");
        }
        public void SetAccount(Account account) {
            myAccounts.Add(account);
        }
        public void WriteAccountsList() {
            Console.WriteLine($"Account owner: {GetName()}\nAccounts' balance:");
            for (int i = 0; i < myAccounts.Count; i++) {
                Console.WriteLine($"Account owner: {myAccounts[i].GetOwner().GetName()}, born: {myAccounts[i].GetOwner().GetDateOfBirth()}, Account {i + 1}: {myAccounts[i]}");
            }
        }
        public int ReturnAge() {
            DateTime birthday = Convert.ToDateTime(this.dateOfBirth.ToString());
            int pom = DateTime.Now.Year - dateOfBirth.GetYear();
            if (DateTime.Now.DayOfYear < birthday.DayOfYear) {
                pom = pom - 1;
            }
            return pom;
        }

        public override string ToString() {
            string pom = "";
            int i = 1;
            foreach (Account a in myAccounts) {
                pom = pom + $"\nAccount owner: {a.GetOwner().name}, born: {a.GetOwner().dateOfBirth}, Account {i}: {a}";
                i++;
            }
            return pom;
        }
    }
}
