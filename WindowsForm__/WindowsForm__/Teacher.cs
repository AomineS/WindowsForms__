using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WindowsForm__;

namespace WindowsForm__
{
    public enum KeyWords { csharp, python, java, JS }
    class Teacher : Human
    {
        private int salary;
        private string department;
        private int numofseats;
        private KeyWords keywords;
        private int v1;
        private string text;
        private int v2;
        private Key key;

        public Teacher(string text, string text1) : base()
        {

        }
        public Teacher(string name, string surname, int age, Gender gender, Nation nation, Adress adress, string email, int salary, string department, int numofseats, KeyWords keywords) : base(name, surname,
                age, gender, nation, adress, email)
        {
            this.salary = salary;
            this.department = department;
            this.numofseats = numofseats;
            this.keywords = keywords;

        }

        public Teacher(string name, string surname, int age, Gender gender, Nation nation, Adress adress, string email, int v1, string text, int v2, Key key) : base(name, surname, age, gender, nation, adress, email)
        {
            this.v1 = v1;
            this.text = text;
            this.v2 = v2;
            this.key = key;
        }

        public override void printInfo()
        {
            string data = base.toStr() + "\n" +
               "Salary: " + this.salary.ToString() + "\n" +
               "Department: " + this.department + "\n" +
               "Number of set: " + this.numofseats.ToString() + "\n" +
                "Key: " + this.keywords.ToString() + "\n";
            Console.WriteLine(data);

        }
        public override string toStr()
        {
            string str;
            str = base.toStr();
            str += "Salary: " + this.salary.ToString() + "\n" +
               "Department: " + this.department + "\n" +
               "Number of set: " + this.numofseats.ToString() + "\n" +
                "Key: " + this.keywords.ToString() + "\n";
            return str;
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public int NumOfSeats
        {
            get { return numofseats; }
            set { numofseats = value; }
        }
        public KeyWords KeyWords
        {
            get { return keywords; }
            set { keywords = value; }
        }

    }

}