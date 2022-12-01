using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManageStudent manageStudent = new ManageStudent();

            while (true)
            {
                Console.WriteLine("PROGRAM MANAGE STUDENT");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Add Student                                   **");
                Console.WriteLine("**  2. Edit Student by Id                            **");
                Console.WriteLine("**  3. Delete student by Id                          **");
                Console.WriteLine("**  4. Sort students by GPA                          **");
                Console.WriteLine("**  5. Sort students by name                         **");
                Console.WriteLine("**  6. Show students                                 **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("1. Them sinh vien.");
                        manageStudent.AddStudent();
                        Console.WriteLine("Them sinh vien thanh cong!");
                        break;
                    case 2:
                        if (manageStudent.NumberOfStudent() > 0)
                        {
                            int id;
                            Console.WriteLine("2. Edit Student by Id ");
                            Console.Write("Nhap ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            manageStudent.UpdateStudent(id);
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong!");
                        }
                        break;
                    case 3:
                        if (manageStudent.NumberOfStudent() > 0)
                        {
                            int id;
                            Console.WriteLine("3. Delete students by Id");
                            Console.Write("Nhap ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            if (manageStudent.DeleteById(id))
                            {
                                Console.WriteLine("Sinh vien co id = {0} da bi xoa.", id);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong!");
                        }
                        break;

                    case 4:
                        if (manageStudent.NumberOfStudent() > 0)
                        {
                            Console.WriteLine("4. Sort students by GPA");
                            manageStudent.SortByGPA();
                            manageStudent.ShowStudent(manageStudent.getListStudent());
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong!");
                        }
                        break;
                    case 5:
                        if (manageStudent.NumberOfStudent() > 0)
                        {
                            Console.WriteLine("5. Sort students by Name");
                            manageStudent.SortByName();
                            manageStudent.ShowStudent(manageStudent.getListStudent());
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong!");
                        }
                        break;
                    case 6:
                        if (manageStudent.NumberOfStudent() > 0)
                        {
                            Console.WriteLine("6. Show students");
                            manageStudent.ShowStudent(manageStudent.getListStudent());
                        }
                        else
                        {
                            Console.WriteLine("Danh sach sinh vien trong!");
                        }
                        break;
                    case 0:
                        Console.WriteLine("You exit program!");
                        return;
                    default:
                        Console.WriteLine("Khong co chuc nang nay!");
                        Console.WriteLine("Hay chon chuc nang trong hop menu.");
                        break;
                }
            }
        }
    }
}
