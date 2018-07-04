
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;


namespace FirstAplicationUsingWebAPI.Models
{
    public class Class
    {
        private List<Student> Students;
        private static Class instance;
        private Class() {
            try
            {
                Students = new List<Student>();
            }
            catch { }
        }
          
        public static Class Instance
        {
            get
            {
                if (instance == null)
                    instance = new Class();
                return instance;
            }
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        } 

        public void ExcludeAStudentById(int id)
        {
            
            var student = Students.Where(x=>x.Id==id).FirstOrDefault();
            if (student!=null)
            {
                Students.Remove(student);
            }
            else
            {
                throw new ArgumentNullException("This student doesn't exist!"); 
            }
           
        }

        public Student GetStudentById(int id)
        {
            var student = Students.Where(x => x.Id == id).FirstOrDefault();

            if (student!=null)
            {
                Students.Remove(student);
            }
            else
            {
                throw new ArgumentNullException("This student doesn't exist!");
            }

            return null;
        }

        public List<Student> GetStudents()
        {
            return Students;
        }
    }
}
