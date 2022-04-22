using SampleWebStudent.Models;
using SampleWebStudent.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleWebStudent.Services
{
    public class ProductServices : IStudentRepository
    {
        private readonly IStudentRepository _iProductRepo;
        public ProductServices(IStudentRepository iProductRepo)
        {
            _iProductRepo = iProductRepo;
        }
        public int AddProduct(Student prod)
        {
            return _iProductRepo.AddProduct(prod);
        }
        public int DeleteProduct(int id)
        {
            return _iProductRepo.DeleteProduct(id);
        }
        public IEnumerable<Student> GetAllProducts()
        {
            return _iProductRepo.GetAllProducts();
        }
        public int ModifyProduct(Student prod)
        {
            return _iProductRepo.ModifyProduct(prod);
        }
    }
} 