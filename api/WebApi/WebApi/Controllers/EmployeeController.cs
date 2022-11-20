using Microsoft.AspNetCore.Mvc;
using WebApi.DataBase;
using WebApi.Model;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {

        private EmployeeContext _employeeContext;

        public EmployeeController(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var emp = _employeeContext.Employees.ToList();
            return emp;
        }
    }
}
