using Company.bis.Repositories;
using Company.bis.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Company.G3.dal.Models;

namespace Ass3.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepositories _departmentRepository;

        public DepartmentController(IDepartmentRepositories departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var departments = _departmentRepository.GetAll();
            return View(departments);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                var Count = _departmentRepository.Add(department);
                if (Count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(department);
        }
        public IActionResult Details(int? Id)
        {
            if (Id == null) return BadRequest();
            var department = _departmentRepository.GetById(Id.Value);
            if (department == null) return NotFound();
            return View(department);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var department = _departmentRepository.GetById(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }
        [HttpPost]
        public IActionResult Update(Department department)
        {
            if (ModelState.IsValid)
            {
                var result = _departmentRepository.Update(department);
                if (result > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(department);
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var department = _departmentRepository.GetById(id);
            if (department == null)
            {
                return NotFound();
            }

            _departmentRepository.Delete(department); // حذف القسم
            return RedirectToAction(nameof(Index)); // العودة إلى صفحة الأقسام بعد الحذف
        }

    }
}
