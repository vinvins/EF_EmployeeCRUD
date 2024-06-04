using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeCRUD_EF_cF.Models;

namespace EmployeeCRUD_EF_cF.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeDbcontextModel Context = new EmployeeDbcontextModel();
        public ActionResult Index()
        {          
            IEnumerable<Employee> emp = Context.employees.ToList();
            return View(emp);
        }

        public ActionResult Create(int ID=0)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {           
            Context.employees.Add(employee);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int ID)
        {
   
            List<Employee> emp = Context.employees.ToList();
            int EmpIDVal= emp.FindIndex(x => x.ID == ID);
            Employee empl= emp[EmpIDVal];
            return View(empl);
        }

        public ActionResult Details(int ID)
        {
         
            List<Employee> emp = Context.employees.ToList();
            int EmpIDVal = emp.FindIndex(x => x.ID == ID);
            Employee empl = emp[EmpIDVal];
            return View(empl);
        }

        public ActionResult Delete(int ID)
        {
       
            List<Employee> emp = Context.employees.ToList();
            int EmpIDVal = emp.FindIndex(x => x.ID == ID);
            Employee empl = emp[EmpIDVal];
            return View(empl);
        }

        [HttpPost]
        public ActionResult Edit(Employee employeeVal)
        {
            Employee empl = Context.employees.Where(
           x => x.ID == employeeVal.ID).SingleOrDefault();
            if(empl != null)
            {
                Context.Entry(empl).CurrentValues.SetValues(employeeVal);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

   
        [HttpPost]
        public ActionResult Delete(Employee employee)
        {
            List<Employee> emp = Context.employees.ToList();         
            Context.employees.Remove(emp.Find(x => x.ID == employee.ID));
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}