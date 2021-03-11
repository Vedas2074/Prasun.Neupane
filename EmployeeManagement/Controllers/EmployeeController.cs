using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {

        var employees = Person.GetEmployee();
        return View(employees);
    }

    public ActionResult Detail(string firstName)
    {
        var employees = Person.GetEmployee();
        var employee = employees.FirstOrDefault(x => x.FirstName == firstName);
        return View(employee);
    }
}







