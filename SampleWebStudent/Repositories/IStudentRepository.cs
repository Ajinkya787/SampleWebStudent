using SampleWebStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleWebStudent.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllProducts();
        int AddProduct(Student stud);
        int ModifyProduct(Student stud);
        int DeleteProduct(int id);
    }
}
