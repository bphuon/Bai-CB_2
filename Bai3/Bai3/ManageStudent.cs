using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class ManageStudent
    {
        private List<Student> ListStudent = null;
        public ManageStudent()
        {
            ListStudent = new List<Student>();
        }
        private int GenerateID()
        {
            int max = 1;
            if (ListStudent != null&& ListStudent.Count>0)
            {
                max = ListStudent[0].Id;
                foreach (Student sv in ListStudent)
                {
                    if (max<sv.Id)
                    {
                        max =sv.Id;
                    }
                }
                max++;
            }
            return max;
        }
        public int NumberOfStudent()
        {
            int count = 0;
            if(ListStudent != null)
            {
                count = ListStudent.Count;
            }
            return count;
        }
        public void AddStudent()
        {
            Student sv = new Student();
            sv.Id = GenerateID();
            Console.WriteLine("Enter your student's Name:");
            sv.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your student's Age:");
            sv.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your student's Address:");
            sv.Address= Convert.ToString(Console.ReadLine());

            ListStudent.Add(sv);
        }

        public void EditStudent(int Id)
        {
            Student sv = FindByID(Id);
            if (sv != null)
            {
                Console.WriteLine("Nhap ten sinh vien");
                string name = Convert.ToString(Console.ReadLine());
                if (name!=null && name.Length>0)
                {
                    sv.Name = name;
                }
                Console.WriteLine("Nhap tuoi cua sinh vien:");
                string age=Convert.ToString(Console.ReadLine());
                if (age!=null&& age.Length>0)
                {
                    sv.Age = Convert.ToInt32(age);
                }
            }
            else
            {
                Console.WriteLine("Sinh vien co Id={0} khong ton tai.",Id);
            }
        }

        private Student FindByID(object iD)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int Id)
        {
            bool IsDelete = false;
            Student sv = FindByID(Id);
            if(sv!=null)
            {
                IsDelete = ListStudent.Remove(sv);
            }
            return IsDelete;
        }
        public void SortByGPA()
        {
            ListStudent.Sort(delegate (Student sv1, Student sv2) { return sv1.GPA.CompareTo(sv2.GPA); });
        }

        public void SortByName()
        {
            ListStudent.Sort(delegate (Student sv1, Student sv2) { return sv1.Name.CompareTo(sv2.Name); });
        }

        public void ShowStudent(List<Student>ListSV)
        {
            Console.WriteLine("{0,-5}{1,-20}{3,5}{7,10}", "Id", "Name", "Age", "GPA");
            if (ListSV != null && ListSV.Count > 0)
            {
                foreach (Student sv in ListSV)
                {
                    Console.WriteLine("{0,-5}{1,-20}{3,5}{7,10}", sv.Id, sv.Name, sv.Age, sv.GPA);
                }
            }
            Console.WriteLine();
        }
        public List<Student>getListStudent()
        {
            return ListStudent;
        }

        internal void UpdateStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
