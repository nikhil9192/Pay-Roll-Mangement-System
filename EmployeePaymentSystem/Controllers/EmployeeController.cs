using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeDAL;
using EmployeePaymentSystem.Models;

namespace EmployeePaymentSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();

        public ActionResult Index()
        {
            var empLsit = context.Employees;
            var convertToViewEmployee = empLsit.Select(employee => new UserView
            {
                Id = employee.Id,
                Email = employee.Email,
                UserName = employee.UserName,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                PhoneNumber = employee.PhoneNumber,

            });
            return View(convertToViewEmployee);
        }


    }

}