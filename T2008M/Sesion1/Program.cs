using System.Collections;
using System.Collections.Generic;

namespace T2008M.Sesion1
{
    public class Program
    {
        public static void  Main(string[] args)
        {
            Student s = new Student();
            s.name = "Quang Anh";
            Student.sName = "T2008M";
            ArrayList arrayList = new ArrayList();
            arrayList.Add("aa");
            arrayList.Add(1);
            List<Student> students = new List<Student>();
            students.Add(s);
            List<int> ints = new List<int>();
            ints.Add(4);
            ints.Add(1);
        }
    }
}