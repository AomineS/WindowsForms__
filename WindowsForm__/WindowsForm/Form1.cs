using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm__
{
    public partial class Form1 : Form
    {
        private int i = 0;
        private Dictionary<int, Human> HumanDict = new Dictionary<int, Human>();
        private listHuman listHuman = new listHuman();
        private Dictionary<int, Student> StudentDict = new Dictionary<int, Student>();
        private listStudent listStudent = new listStudent();
        private Dictionary<int, Teacher> TeacherDict = new Dictionary<int, Teacher>();
        private listTeacher listTeacher = new listTeacher();
        public Form1()
        {
            InitializeComponent();
        }
        private Gender chooseGender()
        {
            RadioButton male = (RadioButton)Gender1;
            RadioButton female = (RadioButton)Gender2;
            if (male.Checked) { return Gender.Male; }
            if (female.Checked) { return Gender.Female; }
            return 0;
        }
        private Gender chooseSGender()
        {
            RadioButton male = (RadioButton)Gender3;
            RadioButton female = (RadioButton)Gender4;
            if (male.Checked) { return Gender.Male; }
            if (female.Checked) { return Gender.Female; }
            return 0;
        }
        private Gender chooseTGender()
        {
            RadioButton male = (RadioButton)Gender5;
            RadioButton female = (RadioButton)Gender6;
            if (male.Checked) { return Gender.Male; }
            if (female.Checked) { return Gender.Female; }
            return 0;
        }
        private Nation chooseNation()
        {
            if (NationBox.SelectedIndex == 0) { return Nation.Ukranian; }
            if (NationBox.SelectedIndex == 1) { return Nation.Germany; }
            if (NationBox.SelectedIndex == 2) { return Nation.Polish; }
            if (NationBox.SelectedIndex == 3) { return Nation.Italiano; }
            return 0;
        }
        private Nation chooseSNation()
        {
            if (NationSBox.SelectedIndex == 0) { return Nation.Ukranian; }
            if (NationSBox.SelectedIndex == 1) { return Nation.Germany; }
            if (NationSBox.SelectedIndex == 2) { return Nation.Polish; }
            if (NationSBox.SelectedIndex == 3) { return Nation.Italiano; }
            return 0;
        }
        private Nation chooseTNation()
        {
            if (NationTBox.SelectedIndex == 0) { return Nation.Ukranian; }
            if (NationTBox.SelectedIndex == 1) { return Nation.Germany; }
            if (NationTBox.SelectedIndex == 2) { return Nation.Polish; }
            if (NationTBox.SelectedIndex == 3) { return Nation.Italiano; }
            return 0;
        }
        private Key chooseKeyS()
        {
            if (KeySBox.SelectedIndex == 0) { return Key.csharp; }
            if (KeySBox.SelectedIndex == 1) { return Key.python; }
            if (KeySBox.SelectedIndex == 2) { return Key.java; }
            if (KeySBox.SelectedIndex == 3) { return Key.JS; }
            return 0;
        }
        private Key chooseKeyT()
        {
            if (KeyTBox.SelectedIndex == 0) { return Key.csharp; }
            if (KeyTBox.SelectedIndex == 1) { return Key.python; }
            if (KeyTBox.SelectedIndex == 2) { return Key.java; }
            if (KeyTBox.SelectedIndex == 3) { return Key.JS; }
            return 0;
        }

        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            TeacherDict.Add(i, new Teacher(NameTeacher.Text, SurnameTeacher.Text,
                    int.Parse(AgeTeacher.Text),  chooseTGender(),
                    chooseTNation(), new Adress(CountryTeacher.Text, CityTeacher.Text,
                    StreetTeacher.Text, int.Parse(HouseTeacher.Text)), GmailTeacher.Text,
                    int.Parse(SalaryTeacher.Text), DepartmentTeacher.Text,
                    int.Parse(NumberTeacher.Text), chooseKeyT()));
            listTeacher.add(TeacherDict[i]);
            listTeacher.TextsWriter("Teachers.txt");
            i++;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            StudentDict.Add(i, new Student(NameStudent.Text, SurnameStudent.Text,
                    int.Parse(AgeStudent.Text), chooseSGender(),
                    chooseSNation(), new Adress(CountryStudent.Text, CityStudent.Text,
                    StreetStudent.Text, int.Parse(HouseStudent.Text)), GmailStudent.Text,
                    int.Parse(GroupStudent.Text), int.Parse(MoneyStudent.Text), chooseKeyS()));
            listStudent.add(StudentDict[i]);
            listStudent.TextsWriter("Students.txt");
            i++;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HumanDict.Add(i, new Human(NameHuman.Text, SurnameHuman.Text, int.Parse(AgeTeacher.Text),
                    chooseGender(), chooseNation(), new Adress(CountryHuman.Text,
                    CityHuman.Text, StreetHuman.Text, int.Parse(HouseHuman.Text)),
                    GmailHuman.Text));
            listHuman.add(HumanDict[i]);
            listHuman.TextsWriter("Humans.txt");
            i++;
        }
    }
}
