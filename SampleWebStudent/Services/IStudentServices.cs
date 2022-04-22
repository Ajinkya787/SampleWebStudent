using SampleWebStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleWebStudent.Services
{
    public interface IProductServices
    {
        IEnumerable<Student> GetAllProducts();
        int AddProduct(Student prod); 
        int ModifyProduct(Student prod);
        int DeleteProduct(int id);
    }
}
