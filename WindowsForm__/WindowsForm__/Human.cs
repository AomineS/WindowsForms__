using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm__;

namespace WindowsForm__
{
    enum Nation { Ukranian, Germany, Polish, Italiano };
    enum Gender { Male, Female };
    class Human
    {
        protected string _name;
        protected string _surname;
        protected int _age;
        protected Gender _gender;
        protected Nation _nation;
        protected Adress _adress;
        protected string _email;

        public Human()
        {
            Console.WriteLine("Создание объекта Person");
            this._name = "Bohdan";
            this._surname = "Suprun";
            this._age = 18;
            this._gender = Gender.Male;
            this._nation = Nation.Ukranian;
            this._adress = new Adress("Ukraine", "Kherson", "Perekopskaya", 168);
            this._email = "xmidorima.shintaro@gmail.com";
        }
        public Human(string name, string surname, int age, Gender gender, Nation nation, Adress adress, string email)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
            this._gender = gender;
            this._nation = nation;
            this._adress = adress;
            this._email = email;
        }
        public static Human operator +(Human one, Human two)
        {
            Human result = new Human();
            result._age = one._age + two._age;
            return result;
        }
        public static bool operator >(Human one, Human two)
        {
            bool result = one._age > two._age;
            return result;
        }
        public static bool operator <(Human one, Human two)
        {
            bool result = one._age < two._age;
            return result;
        }
        public virtual void printInfo()
        {
            string data =
                "Name: " + this._name + "\n" +
                "Surname: " + this._surname + "\n" +
                "Age: " + this._age.ToString() + "\n" +
                "Gender: " + this._gender + "\n" +
                "Nation: " + this._nation.ToString() + "\n" +
                "Adress: " + this._adress.ToString() + "\n" +
                "Email: " + this._email + "\n";
            Console.WriteLine(data);
        }
        public virtual string toStr()
        {
            string str;
            str = "Name: " + this._name + "\n" +
                "Surname: " + this._surname + "\n" +
                "Age: " + this._age.ToString() + "\n" +
                "Gender: " + this._gender + "\n" +
                "Nation: " + this._nation.ToString() + "\n" +
                "Adress: " + this._adress.ToString() + "\n" +
                "Email: " + this._email + "\n";
            return str;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public Nation Nation
        {
            get { return _nation; }
            set { _nation = value; }
        }

        public Adress Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}
