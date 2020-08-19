using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account {
    class Date {
        private int day;
        private int month;
        private int year;
        public Date(int day, int month, int year) {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public override string ToString() {
            return $"{day:D2}/{month:D2}/{year:D2}";
        }
        public int GetYear() {
            return year;
        }
        public int GetMonth() {
            return month;
        }
        public int GetDay() {
            return day;
        }
    }
}
