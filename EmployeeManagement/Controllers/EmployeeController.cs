using System.Linq;
using EmployeeManagement.Data;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        var db = new EMSContext();
        var employees = db.Employees.Select(x => x.Gender == 'm');
        return View(employees);
    }
    public ActionResult Detail([FromQuery] int id)
    {
        var employees = Person.GetEmployee();
        var employee = employees.FirstOrDefault(x => x.Id == id);
        return View(employee);
    }
    
    public ActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public ActionResult<string> Add(Person person)
    {
        return "Record saved";
    }

}