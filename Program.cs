using AsteriskPatternExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id=1, Name="Sanju", Age=22});
            students.Add(new Student() { Id=2, Name="ABC", Age=23});
            students.Add(new Student() { Id=3, Name="DEF", Age=25});
            students.Add(new Student() { Id=4, Name="XXX", Age=25});
            students.Add(new Student() { Id=5, Name="PPPP", Age=24});
            students.Add(new Student() { Id=6, Name="Sanju", Age=29});
            students.Add(new Student() { Id=7, Name="DDDD", Age=30});
            students.Add(new Student() { Id=7, Name="DDDD", Age=30});
            students.Add(new Student() { Id=7, Name="DDDD", Age=30});
            students.Add(new Student() { Id=7, Name="DDDD", Age=30});
            students.Add(new Student() { Id=7, Name="DDDD", Age=30});
            students.Add(new Student() { Id=7, Name="DDDD", Age=30});
            students.Add(new Student() { Id=7, Name="DDDD", Age=30});
            students.Add(new Student() { Id=7, Name="DDDD", Age=30});
            students.Add(new Student() { Id=7, Name="DDDD", Age=30});
            students.Add(new Student() { Id=7, Name="DDDD", Age=30});
            students.Add(new Student() { Id=7, Name="DDDD", Age=30});

            foreach (var student in students)
            {
                Console.WriteLine("Id : " + student.Id+ ", Name : " + student.Name+ ", Age : " + student.Age);
            }

            Console.ReadLine();
        }
    }
}
