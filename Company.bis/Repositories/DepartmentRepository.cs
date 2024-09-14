using Company.bis.Interfaces;
using Company.G3.dal.Data.Contexts;
using Company.G3.dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.bis.Repositories
{
    public class DepartmentRepository : IDepartmentRepositories
    {
        private readonly AppDbContext _context;

        public DepartmentRepository(AppDbContext context )
        {
            _context = context;
        }

        public int Add(Department entity)
        {
            _context.Departments.Add(entity);
            return _context.SaveChanges();
        }

        public int Delete(Department entity)
        {
            _context.Departments.Remove(entity);
            return _context.SaveChanges();
        }

        public IEnumerable<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public Department GetById(int id)
        {
            return _context.Departments.FirstOrDefault(d => d.Id == id);
        }

        public int Update(Department entity)
        {
            _context.Departments.Update(entity);
            return _context.SaveChanges();
        }
    }
}
