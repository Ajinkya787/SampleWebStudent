using SampleWebStudent.Entities;
using SampleWebStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleWebStudent.Repositories
{
    public class StudentRepositoy : IStudentRepository
    {
        RepositoriesContext context;
        public StudentRepositoy(RepositoriesContext context) //DI
        {
            this.context = context;
        }

        public object student { get; private set; }

        public int AddProduct(Student Stud)
        {
            context.Add(student);
            context.SaveChanges(); // update the data in DB
            return 1;
        }
        public int DeleteProduct(int id)
        {
            var Stud = context.Products.Where(p => p.Id == id).SingleOrDefault();
            if (Stud != null)
            {
                context.Products.Remove(Stud);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

            public int UpdateProduct(Student Stud)  
            {
                var student = context.Student.Where(p => p.Id == prod.Id).SingleOrDefault();
                if (student != null)
                {
                    student.Name = Stud.Name;
                    student.Id = Stud.Id;
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
        }

        public IEnumerable<Student> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public int ModifyProduct(Student prod)
        {
            throw new NotImplementedException();
        }

        public int ModifyStudent(Student stud)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Student> IStudentRepository.GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
    }
