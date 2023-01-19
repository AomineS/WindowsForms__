using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsForm__
{
    class listTeacher
    {
        private List<Teacher> listTeachers;
        public listTeacher()
        {
            listTeachers = new List<Teacher>();
        }

        public void add(Teacher teacher)
        {
            listTeachers.Add(teacher);
        }
        public void show()
        {
            for (int n = 0; n < listTeachers.Count(); n++)
                listTeachers[n].printInfo();
        }
        public string show(int a)
        {
            string data = "";
            for (int n = 0; n < listTeachers.Count(); n++)
                data += listTeachers[n].toStr();
            return data;
        }
        public string save_txt()
        {
            string res = "";
            for (int n = 0; n < listTeachers.Count; n++)
            {
                res += listTeachers[n].toStr();
                res += "\n";
            }
            return res;
        }
        public void TextsWriter(string url)
        {
            StreamWriter sw = new StreamWriter(url);
            sw.WriteLine(save_txt());
            sw.Close();
        }
    }
}

