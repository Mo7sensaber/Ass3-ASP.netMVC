using Company.G3.dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.bis.Interfaces
{
    public interface IDepartmentRepositories
    {
        IEnumerable<Department> GetAll();
        Department GetById(int id);
        int Add(Department entity);
        int Update(Department entity);
        int Delete (Department entity);
    }
}
