using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

namespace IntroToFS
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Console.WriteLine("Please enter the path to the directory");
            //string? path = Console.ReadLine();

            //if (string.IsNullOrEmpty(path))
            //{
            //    Console.WriteLine("You didnt enter any name");
            //    return;
            //}
            //DirectoryInfo directoryInfo = new DirectoryInfo(path);
            //if (directoryInfo.Exists)
            //{
            //    Console.WriteLine("Creation time " + directoryInfo.CreationTime);
            //    Console.WriteLine("Last access time " + directoryInfo.LastAccessTime);
            //    Console.WriteLine("Full name " + directoryInfo.FullName);
            //}
            //else
            //{
            //    Console.WriteLine("This directory does not exists");
            //}
            ////////////////////////////////////////////////////////////
            //string basePath = "newFolder";
            //Directory.CreateDirectory(basePath);

            //for (int i = 1; i <= 3; i++)
            //{
            //    File.WriteAllText(Path.Combine(basePath, $"file{i}.txt"), $"text{i}");
            //}
            ////////////////////////////////////////////////////////////////////////////////////

            //List<User> users = new List<User>();
            //users.Add(new User("Avi", "Cohen"));
            //users.Add(new User("David", "Levi"));
            //string json = JsonSerializer.Serialize(users);
            //List<User> deserializerUsers = JsonSerializer.Deserialize<List<User>>(json);
            //users.AddRange(deserializerUsers);

            //foreach (var item in users)
            //{
            //    Console.WriteLine(item.FirstName);

            //}
            ////////////////////////////////////////////////////////////////
            //string Path = "Folder";
            //Users(users,Path);
            /////////////////////////////////////////////////////////////////
            string jsonString = File.ReadAllText("students.json");
            Students students = JsonSerializer.Deserialize<Students>(jsonString);

            //FilesForStudents(students.students, "studentsFolder");
            //ShowStudentWithMostCourses(students.students);
            CheckIDCard(students.students);
            

            /////////////////////////////////////////////////////////////
            //for (int i = 0; i < 10; i++)
            //{
            //    using (StreamReader sr = new StreamReader("example.txt"))
            //    {
            //        string line;
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //////////////////////////////////////////////////////////////
            //using (StreamWriter sw = new StreamWriter("example.txt"))
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        sw.WriteLine($"line {i} this is test line");
            //    }
            //}
            //using (StreamReader sr = new StreamReader("example.txt"))
            //{
            //    Console.WriteLine(sr.ReadToEnd());
            //}

        }



        //public static void Users(List<User> users,string Path )
        //{
        //    Directory.CreateDirectory(Path);
        //    foreach (var user in users) {
        //        using (StreamWriter sw = new StreamWriter($"{Path}/{user.FirstName}.txt"))
        //        {
        //            sw.Write(user.FirstName + " " + user.LastName);

        //        }

        //    }
        //}
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////
        /// </summary>

        static void FilesForStudents(List<Students> students, string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            foreach (Students student in students)
            {
                string filePath = Path.Combine(path, $"{student.name}{student.id}.txt");
                File.WriteAllText(filePath, $"{student.name} is {student.age} years old");
            }

        }
        static void ShowDistinctCourses(List<Students> students)
        {
            Dictionary<string, int> uniqueCourses = new Dictionary<string, int>();
            foreach (Students student in students)
            {
                foreach (string course in student.courses)
                {
                    if (!uniqueCourses.ContainsKey(course))
                    {
                        uniqueCourses.Add(course, 1);

                    }
                    else
                        uniqueCourses[course]++;
                }
            }
            Console.WriteLine("The unique courses is:");
            foreach (string course in uniqueCourses.Keys)
            {
                Console.WriteLine(course);
            }
        }
        static void ShowStudentWithMostCourses(List<Students> students)
        {
            Students mostCoursesStudent = students[0];
            foreach (Students student in students)
            {
                if (student.courses.Count > mostCoursesStudent.courses.Count)
                {
                    mostCoursesStudent = student;
                }
            }

            Console.WriteLine($"The student with the most courses is {mostCoursesStudent.name}");
            Console.WriteLine($"This student study {mostCoursesStudent.courses.Count} courses");

        }
        static void CheckIDCard(List<Students> students)
        {
                HashSet<int> set = new HashSet<int>();
            bool result = false;
            foreach (Students student in students)
            {

                if (set.Contains(student.id))
                {
                    Console.WriteLine($"This {student.id} ID number is duplicate ");
                    result = true;
                }

                set.Add(student.id);
            }
            if (result != true)
            {
                Console.WriteLine($"There's no duplicate ID numbers  ");
            }
            
        }


        }
    }
